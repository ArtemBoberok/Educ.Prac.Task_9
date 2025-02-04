//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BAA_Task_9.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Good
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Good()
        {
            this.Sells = new HashSet<Sell>();
        }
    
        public int GoodId { get; set; }
        public string GoodName { get; set; }
        public int GoodSellId { get; set; }
        public System.DateTime YearOfIssue { get; set; }
        public string Owner { get; set; }
        public System.DateTime DateOfReceipt { get; set; }
        public int AssessedValue { get; set; }
        public string Description { get; set; }
    
        public virtual Directory Directory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sell> Sells { get; set; }
    }
}
