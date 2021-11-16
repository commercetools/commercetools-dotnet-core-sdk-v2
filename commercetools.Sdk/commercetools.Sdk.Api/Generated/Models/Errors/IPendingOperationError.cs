using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.PendingOperationError))]
    public partial interface IPendingOperationError : IErrorObject
    {
    }
}
