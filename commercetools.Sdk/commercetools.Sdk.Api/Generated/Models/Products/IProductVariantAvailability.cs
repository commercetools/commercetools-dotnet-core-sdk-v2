using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductVariantAvailability))]
    public partial interface IProductVariantAvailability 
    {
        bool? IsOnStock { get; set;}
        
        long? RestockableInDays { get; set;}
        
        long? AvailableQuantity { get; set;}
        
        IProductVariantChannelAvailabilityMap Channels { get; set;}
    }
}
