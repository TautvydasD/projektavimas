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
    using System.Web.Mvc;

    public partial class Repair
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Status { get; set; }
        public string DeviceID { get; set; }
        public int fk_Order_Id { get; set; }
        public int fk_Worker_Id { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Worker Worker { get; set; }

        //public RepairState state { get; set; }
    }
}
