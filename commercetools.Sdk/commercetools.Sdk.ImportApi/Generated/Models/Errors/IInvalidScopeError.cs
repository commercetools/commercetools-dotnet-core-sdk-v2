using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Errors.InvalidScopeError))]
    public partial interface IInvalidScopeError : IErrorObject
    {
    }
}
