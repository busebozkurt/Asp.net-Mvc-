//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NishClub
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Orders
    {
        public int OrderID { get; set; }
        public int MemberID { get; set; }
        public string Prefix { get; set; }
        public Nullable<System.DateTime> Credate { get; set; }
        public Nullable<bool> ISACTIVE { get; set; }
    }
}