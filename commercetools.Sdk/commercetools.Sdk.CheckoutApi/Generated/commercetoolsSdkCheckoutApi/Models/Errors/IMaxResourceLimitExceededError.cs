using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Errors.MaxResourceLimitExceededError))]
    public partial interface IMaxResourceLimitExceededError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        decimal Limit { get; set; }

        string ResourceTypeId { get; set; }

    }
}
