//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChainOfStores.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SUPPLY
    {
        public int ID { get; set; }
        public int storeID { get; set; }
        public int providerID { get; set; }
    
        public virtual PROVIDER PROVIDER { get; set; }
        public virtual STORE STORE { get; set; }
    }
}
