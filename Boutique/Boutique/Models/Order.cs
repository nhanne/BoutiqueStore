//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Boutique.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int Id { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string Status { get; set; }
        public string Address { get; set; }
        public Nullable<bool> Payment { get; set; }
        public Nullable<System.DateTime> OrdTime { get; set; }
        public Nullable<System.DateTime> DeliTime { get; set; }
        public Nullable<double> TotalPrice { get; set; }
        public Nullable<int> TotalQuantity { get; set; }
        public string Note { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual OrderStatus OrderStatu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
