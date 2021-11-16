using commercetools.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Productvariants.ProductVariantPatch))]
    public partial interface IProductVariantPatch 
    {
        IProductVariantKeyReference ProductVariant { get; set;}
        
        IAttributes Attributes { get; set;}
        
        bool? Staged { get; set;}
    }
}
