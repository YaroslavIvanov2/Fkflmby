//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diplom_AladinSclad.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Postavshik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Postavshik()
        {
            this.Postavki = new HashSet<Postavki>();
        }
    
        public int ID_Postavshika { get; set; }
        public string Contact_data { get; set; }
        public string Name_postavshika { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Postavki> Postavki { get; set; }
    }
}
