//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CallShop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Phone
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phone()
        {
            this.FixingAct = new HashSet<FixingAct>();
        }
    
        public string IdPhone { get; set; }
        public Nullable<int> IdType { get; set; }
        public string PhoneName { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<System.DateTime> DateOfBuy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FixingAct> FixingAct { get; set; }
        public virtual PhoneType PhoneType { get; set; }
    }
}
