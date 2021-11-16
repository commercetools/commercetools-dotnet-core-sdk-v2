using commercetools.ImportApi.Models.Prices;
using commercetools.ImportApi.Models.Productvariants;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Errors.VariantValues))]
    public partial interface IVariantValues 
    {
        string Sku { get; set;}
        
        List<IPriceImport> Prices { get; set;}
        
        List<IAttribute> Attributes { get; set;}
    }
}
