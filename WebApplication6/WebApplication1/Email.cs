//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Email
    {
        public Email()
        {
            this.Contacts = new HashSet<Contact>();
        }
    
        public int emailid { get; set; }
        public string email1 { get; set; }
        public Nullable<int> ContactID { get; set; }
    
        public virtual Contact Contact { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}