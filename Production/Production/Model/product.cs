//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Production.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        public int IDproduct { get; set; }
        public string NameProduct { get; set; }
        public int IsTypicalID { get; set; }
        public string Note { get; set; }
        public int ManufacturingСompany { get; set; }
        public int MaterialID { get; set; }
        public byte[] Picture { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Material Material { get; set; }
        public virtual Typical Typical { get; set; }
    }
}
