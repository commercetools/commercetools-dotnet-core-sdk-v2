using commercetools.Sdk.ImportApi.Models.Prices;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Errors
{

    public partial class VariantValues : IVariantValues
    {
        public string Sku { get; set; }

        public IList<IPriceImport> Prices { get; set; }
        public IEnumerable<IPriceImport> PricesEnumerable { set => Prices = value.ToList(); }


        public IList<IAttribute> Attributes { get; set; }
        public IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }

    }
}
