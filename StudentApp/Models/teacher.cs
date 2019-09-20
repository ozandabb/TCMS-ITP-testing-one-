//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class teacher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public teacher()
        {
            this.tutes = new HashSet<tute>();
        }

        public int t_id { get; set; }

        [Required]
        public string full_name { get; set; }

        [Required]
        public string school { get; set; }

        [Required]
        public string division { get; set; }

        [Required]
        public string t_address { get; set; }

        [Required]
        [StringLength(10, ErrorMessage ="Phone number can not exceed 10 digits")]
        public string contact_number { get; set; }

        [Required]
        public string email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tute> tutes { get; set; }
    }
}