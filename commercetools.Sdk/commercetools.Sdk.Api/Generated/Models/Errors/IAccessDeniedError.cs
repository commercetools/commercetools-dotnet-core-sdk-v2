using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.AccessDeniedError))]
    public partial interface IAccessDeniedError : IErrorObject
    {
    }
}
