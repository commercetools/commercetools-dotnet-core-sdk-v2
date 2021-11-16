using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.InvalidCurrentPasswordError))]
    public partial interface IInvalidCurrentPasswordError : IErrorObject
    {
    }
}
