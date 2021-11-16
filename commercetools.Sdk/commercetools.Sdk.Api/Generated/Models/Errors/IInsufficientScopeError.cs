using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.InsufficientScopeError))]
    public partial interface IInsufficientScopeError : IErrorObject
    {
    }
}
