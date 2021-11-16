using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.PriceFunction))]
    public partial interface IPriceFunction 
    {
        string CurrencyCode { get; set;}
        
        string Function { get; set;}
    }
}
