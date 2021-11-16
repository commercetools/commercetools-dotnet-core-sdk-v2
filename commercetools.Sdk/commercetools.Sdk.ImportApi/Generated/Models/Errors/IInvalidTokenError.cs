using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Errors.InvalidTokenError))]
    public partial interface IInvalidTokenError : IErrorObject
    {
    }
}
