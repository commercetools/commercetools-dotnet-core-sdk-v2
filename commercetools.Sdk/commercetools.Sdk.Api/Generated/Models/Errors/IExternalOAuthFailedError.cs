using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.ExternalOAuthFailedError))]
    public partial interface IExternalOAuthFailedError : IErrorObject
    {
    }
}
