//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SocialTravel
{
    using System;
    using System.Collections.Generic;
    
    public partial class App_Driver_Schedule
    {
        public int car_pool_id { get; set; }
        public string day { get; set; }
        public System.DateTime leaving_time { get; set; }
        public System.DateTime reaching_time { get; set; }
    
        public virtual App_Car_Pool App_Car_Pool { get; set; }
    }
}
