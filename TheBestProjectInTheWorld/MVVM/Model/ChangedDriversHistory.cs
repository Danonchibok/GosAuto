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
    
    public partial class ChangedDriversHistory
    {
        public int Id { get; set; }
        public int changedFromDriversId { get; set; }
        public int changedToDriversId { get; set; }
        public System.DateTime date { get; set; }
        public int carId { get; set; }
    
        public virtual Cars Cars { get; set; }
        public virtual Drivers Drivers { get; set; }
        public virtual Drivers Drivers1 { get; set; }
    }
}
