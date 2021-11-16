using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Errors.GenericError))]
    public partial interface IGenericError : IErrorObject
    {
    }
}
