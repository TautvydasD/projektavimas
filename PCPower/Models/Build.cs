//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PCPower.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Build
    {
        public int Id { get; set; }
        public int fk_Computer_Id { get; set; }
        public int fk_Part_Id { get; set; }
    
        public virtual Computer Computer { get; set; }
        public virtual Part Part { get; set; }
    }
}
