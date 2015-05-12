using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Router.Models;
using MVC_Router.ViewModels;
using System.Web.Security;

namespace MVC_Router.Controllers
{
    public class MemberController : Controller
    {
        // 資料庫資源
        private NorthwindDBEntities db = new NorthwindDBEntities();

        // GET: Member
        public ActionResult Index()
        {
            return View();
        }

        // 登入頁面
        public ActionResult Login()
        {
            return View();
        }

        // 登入驗證
        [HttpPost]
        public ActionResult Login(MemberViewModel member)
        {
            bool result = false;
            string pass5 = "";
            if (!String.IsNullOrEmpty(member.LoginID))
            {
                pass5 = getMd5Hash(member.Password);
                result = db.Employees.Where(p => p.LoginID == member.LoginID).Select(p => p.Password.Contains(pass5)).FirstOrDefault();
            }

            // 如果驗證成功，就加入驗證票，並導向Index
            if (result)
            {
                // userData 放入 FirstName,LastName

                var loginMember = db.Employees.Where(p => p.LoginID == member.LoginID && p.Password == pass5).FirstOrDefault();
                string userData = loginMember.FirstName + "," + loginMember.LastName;

                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,
                    member.LoginID, DateTime.Now, DateTime.Now.AddMinutes(30),
                    true, userData, FormsAuthentication.FormsCookiePath);
                string encryTicket = FormsAuthentication.Encrypt(ticket);
                var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryTicket);
                // Client 加入 Cookie
                Response.Cookies.Add(cookie);
                return RedirectToAction("Index");                
            }
            else
            {
                // 登入失敗，導回登入頁面
                return View(member);
            }
        }

        // 註冊頁面
        public ActionResult Register()
        {
            return View(new MemberViewModel());
        }

        // 註冊資料頁面，註冊成功導向Index
        [HttpPost]
        public ActionResult Register(MemberViewModel member)
        {
            Employees employee = new Employees()
            {
                FirstName = member.FirstName,
                LastName = member.LastName,
                LoginID = member.LoginID,
                Password = getMd5Hash(member.Password)
            };
            db.Employees.Add(employee);
            db.SaveChanges();
            return RedirectToAction("Login");            
        }



        // 記得要釋放資料庫資源
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        #region 自訂方法
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="txtInput">輸入字串</param>
        /// <param name="salt">是否加鹽</param>
        /// <returns>MD5編碼後的字串</returns>
        public static String getMd5Hash(String txtInput, String salt = "")
        {
            if (!String.IsNullOrEmpty(salt)) txtInput += salt;
            System.Security.Cryptography.MD5 md5Hasher = System.Security.Cryptography.MD5.Create();
            Byte[] MD5data = md5Hasher.ComputeHash(System.Text.Encoding.Default.GetBytes(txtInput));

            System.Text.StringBuilder sBuilder = new System.Text.StringBuilder();
            for (int i = 0; i < MD5data.Length; i++)
            {
                sBuilder.Append(MD5data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        #endregion
    }
}