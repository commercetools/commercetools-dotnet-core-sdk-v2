using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.PendingOperationError))]
    public partial interface IPendingOperationError : IErrorObject
    {
    }
}
