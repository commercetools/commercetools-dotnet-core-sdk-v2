using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Errors.InsufficientScopeError))]
    public partial interface IInsufficientScopeError : IErrorObject
    {
    }
}
