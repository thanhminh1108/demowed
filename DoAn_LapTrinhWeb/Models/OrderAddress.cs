//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn_LapTrinhWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderAddress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderAddress()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int orderAddressId { get; set; }
        public string orderPhonenumber { get; set; }
        public string orderUsername { get; set; }
        public string content { get; set; }
        public int timesEdit { get; set; }
        public Nullable<int> province_id { get; set; }
        public Nullable<int> district_id { get; set; }
        public Nullable<int> ward_id { get; set; }
    
        public virtual District District { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        public virtual Province Province { get; set; }
        public virtual Ward Ward { get; set; }
    }
}
