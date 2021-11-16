using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.ShippingMethodDoesNotMatchCartError))]
    public partial interface IShippingMethodDoesNotMatchCartError : IErrorObject
    {
    }
}
