using commercetools.ImportApi.Models.Prices;
using commercetools.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    public partial class VariantValues : IVariantValues
    {
        public string Sku { get; set;}
        
        public List<IPriceImport> Prices { get; set;}
        
        public List<IAttribute> Attributes { get; set;}
    }
}
