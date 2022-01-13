using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Errors.InvalidInput))]
    public partial interface IInvalidInput : IErrorObject
    {
    }
}
