using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.InvalidItemShippingDetailsError))]
    public partial interface IInvalidItemShippingDetailsError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        string Subject { get; set; }

        string ItemId { get; set; }

    }
}
