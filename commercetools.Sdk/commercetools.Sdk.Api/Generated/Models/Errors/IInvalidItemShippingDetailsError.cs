using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.InvalidItemShippingDetailsError))]
    public partial interface IInvalidItemShippingDetailsError : IErrorObject
    {
        string Subject { get; set; }

        string ItemId { get; set; }
    }
}
