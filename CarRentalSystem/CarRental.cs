//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRentalSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class CarRental
    {
        public int ID { get; set; }
        public string Customer_Name { get; set; }
        public Nullable<System.DateTime> Date_Rented { get; set; }
        public Nullable<System.DateTime> Date_Returned { get; set; }
        public Nullable<int> Car_Type { get; set; }
        public Nullable<float> Cost { get; set; }
    
        public virtual typeofcar typeofcar { get; set; }
    }
}
