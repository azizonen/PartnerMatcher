//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace yad2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Category
    {
        public Category()
        {
            this.Adds = new HashSet<Add>();
            this.Groups = new HashSet<Group>();
        }
    
        public string Type { get; set; }
    
        public virtual ICollection<Add> Adds { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
    }
}
