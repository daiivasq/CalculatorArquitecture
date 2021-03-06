//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CS.WebApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.UserProfile = new HashSet<UserProfile>();
        }
    
        public System.Guid Id { get; set; }
        public int Seq { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public Nullable<System.DateTime> EmailConfirmedDate { get; set; }
        public bool Enabled { get; set; }
        public string DisplayName { get; set; }
        public Nullable<System.DateTime> LastAccessDate { get; set; }
        public string PictureUrl { get; set; }
        public System.Guid RoleId { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual Role Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserProfile> UserProfile { get; set; }
    }
}
