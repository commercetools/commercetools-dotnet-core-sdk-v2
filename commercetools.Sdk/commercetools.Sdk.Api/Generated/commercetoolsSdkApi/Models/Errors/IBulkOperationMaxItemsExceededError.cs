using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.BulkOperationMaxItemsExceededError))]
    public partial interface IBulkOperationMaxItemsExceededError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        int Limit { get; set; }

        int Provided { get; set; }

    }
}
