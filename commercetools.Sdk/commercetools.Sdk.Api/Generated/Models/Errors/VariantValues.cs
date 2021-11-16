using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System.Collections.Generic;


namespace commercetools.Api.Models.Errors
{
    public partial class VariantValues : IVariantValues
    {
        public string Sku { get; set;}
        
        public List<IPriceDraft> Prices { get; set;}
        
        public List<IAttribute> Attributes { get; set;}
    }
}
