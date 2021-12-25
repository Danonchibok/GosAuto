//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheBestProjectInTheWorld.MVVM.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Drivers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Drivers()
        {
            this.Cars = new HashSet<Cars>();
            this.ChangedDriversHistory = new HashSet<ChangedDriversHistory>();
            this.ChangedDriversHistory1 = new HashSet<ChangedDriversHistory>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string middlename { get; set; }
        public Nullable<int> passportSerial { get; set; }
        public Nullable<int> passportNumber { get; set; }
        public Nullable<int> postcode { get; set; }
        public string address { get; set; }
        public string addressLife { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string photo { get; set; }
        public string description { get; set; }
        public Nullable<int> companyId { get; set; }
        public Nullable<int> jobId { get; set; }
        public Nullable<int> licenceId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cars> Cars { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChangedDriversHistory> ChangedDriversHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChangedDriversHistory> ChangedDriversHistory1 { get; set; }
        public virtual Companies Companies { get; set; }
        public virtual Jobs Jobs { get; set; }
        public virtual Licences Licences { get; set; }
    }
}
