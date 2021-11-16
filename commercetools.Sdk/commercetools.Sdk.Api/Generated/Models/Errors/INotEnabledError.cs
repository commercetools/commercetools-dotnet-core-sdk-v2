using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.NotEnabledError))]
    public partial interface INotEnabledError : IErrorObject
    {
    }
}
