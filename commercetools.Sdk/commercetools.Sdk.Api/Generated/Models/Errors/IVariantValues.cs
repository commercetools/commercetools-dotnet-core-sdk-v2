using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.VariantValues))]
    public partial interface IVariantValues
    {
        string Sku { get; set; }

        List<IPriceDraft> Prices { get; set; }

        List<IAttribute> Attributes { get; set; }
    }
}
