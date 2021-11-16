using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Errors.InvalidCredentialsError))]
    public partial interface IInvalidCredentialsError : IErrorObject
    {
    }
}
