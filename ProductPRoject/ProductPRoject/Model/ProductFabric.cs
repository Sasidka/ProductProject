//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductPRoject.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductFabric
    {
        public int ID { get; set; }
        public int TextileID { get; set; }
        public int ProductID { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Textile Textile { get; set; }
    }
}