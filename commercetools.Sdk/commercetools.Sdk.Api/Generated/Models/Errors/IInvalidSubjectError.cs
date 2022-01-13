using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.InvalidSubjectError))]
    public partial interface IInvalidSubjectError : IErrorObject
    {
    }
}
