//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Automapper.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Permission_RoleUserMapping
    {
        public int URoleID { get; set; }
        public int RoleID { get; set; }
        public int UserID { get; set; }
        public short Status { get; set; }
        public Nullable<int> EntryBy { get; set; }
        public Nullable<System.DateTime> EntryDatetime { get; set; }
    
        public virtual Permission_Roles Permission_Roles { get; set; }
    }
}
