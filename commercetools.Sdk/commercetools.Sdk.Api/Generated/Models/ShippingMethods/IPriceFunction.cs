using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.PriceFunction))]
    public partial interface IPriceFunction
    {
        string CurrencyCode { get; set; }

        string Function { get; set; }
    }
}
