using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    public partial class VariantValues : IVariantValues
    {
        public string Sku { get; set;}
        
        public List<IPriceDraft> Prices { get; set;}
        
        public List<IAttribute> Attributes { get; set;}
    }
}
