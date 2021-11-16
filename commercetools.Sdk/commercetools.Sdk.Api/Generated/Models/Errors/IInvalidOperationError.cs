using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.InvalidOperationError))]
    public partial interface IInvalidOperationError : IErrorObject
    {
    }
}
