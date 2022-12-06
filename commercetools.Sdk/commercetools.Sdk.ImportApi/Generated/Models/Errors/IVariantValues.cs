using commercetools.Sdk.ImportApi.Models.Prices;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Errors.VariantValues))]
    public partial interface IVariantValues
    {
        string Sku { get; set; }

        IList<IPriceImport> Prices { get; set; }
        IEnumerable<IPriceImport> PricesEnumerable { set => Prices = value.ToList(); }


        IList<IAttribute> Attributes { get; set; }
        IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }


    }
}
