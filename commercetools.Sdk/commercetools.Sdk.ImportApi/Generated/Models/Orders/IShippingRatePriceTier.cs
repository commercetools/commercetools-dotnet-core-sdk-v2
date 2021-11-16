using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.ImportApi.Models.Orders.ShippingRatePriceTier))]
    [SubTypeDiscriminator("CartClassification", typeof(commercetools.ImportApi.Models.Orders.CartClassificationTier))]
    public partial interface IShippingRatePriceTier 
    {
        IShippingRateTierType Type { get; set;}
    }
}
