using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.AttributeNameDoesNotExistError))]
    public partial interface IAttributeNameDoesNotExistError : IErrorObject
    {
        string InvalidAttributeName { get; set;}
    }
}
