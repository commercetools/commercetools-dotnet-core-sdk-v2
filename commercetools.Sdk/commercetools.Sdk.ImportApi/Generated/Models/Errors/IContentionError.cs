using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Errors.ContentionError))]
    public partial interface IContentionError : IErrorObject
    {
    }
}
