using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.InternalConstraintViolatedError))]
    public partial interface IInternalConstraintViolatedError : IErrorObject
    {
    }
}
