using commercetools.Sdk.ImportApi.Models.Prices;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Errors
{

    public partial class VariantValues : IVariantValues
    {
        public string Sku { get; set; }

        public List<IPriceImport> Prices { get; set; }

        public List<IAttribute> Attributes { get; set; }
    }
}
