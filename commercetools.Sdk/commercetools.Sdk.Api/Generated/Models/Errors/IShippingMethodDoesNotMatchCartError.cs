using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.ShippingMethodDoesNotMatchCartError))]
    public partial interface IShippingMethodDoesNotMatchCartError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

    }
}
