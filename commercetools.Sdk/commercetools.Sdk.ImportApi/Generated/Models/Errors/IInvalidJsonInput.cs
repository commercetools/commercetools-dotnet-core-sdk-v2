using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Errors.InvalidJsonInput))]
    public partial interface IInvalidJsonInput : IErrorObject
    {
    }
}
