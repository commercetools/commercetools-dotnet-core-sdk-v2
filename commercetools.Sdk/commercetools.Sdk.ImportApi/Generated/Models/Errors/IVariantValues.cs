using commercetools.Sdk.ImportApi.Models.Prices;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Errors.VariantValues))]
    public partial interface IVariantValues
    {
        string Sku { get; set; }

        List<IPriceImport> Prices { get; set; }

        List<IAttribute> Attributes { get; set; }
    }
}
