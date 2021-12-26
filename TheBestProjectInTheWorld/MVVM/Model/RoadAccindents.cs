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
    
    public partial class RoadAccindents
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RoadAccindents()
        {
            this.CarsAccindent = new HashSet<CarsAccindent>();
            this.driversAccindet = new HashSet<driversAccindet>();
        }
    
        public int Id { get; set; }
        public int classId { get; set; }
        public string address { get; set; }
        public System.DateTime date { get; set; }
        public int CountOfVictims { get; set; }
        public string imgSchema { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarsAccindent> CarsAccindent { get; set; }
        public virtual Classifications Classifications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<driversAccindet> driversAccindet { get; set; }
    }
}
