using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class VariantValues : IVariantValues
    {
        public string Sku { get; set; }

        public List<IPriceDraft> Prices { get; set; }

        public List<IAttribute> Attributes { get; set; }
    }
}
