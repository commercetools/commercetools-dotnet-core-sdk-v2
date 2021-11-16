using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Errors.AccessDeniedError))]
    public partial interface IAccessDeniedError : IErrorObject
    {
    }
}
