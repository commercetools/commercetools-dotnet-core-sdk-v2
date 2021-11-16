using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Errors.InvalidOperation))]
    public partial interface IInvalidOperation : IErrorObject
    {
    }
}
