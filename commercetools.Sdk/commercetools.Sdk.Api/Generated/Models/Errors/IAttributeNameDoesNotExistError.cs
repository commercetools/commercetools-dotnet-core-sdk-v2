using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.AttributeNameDoesNotExistError))]
    public partial interface IAttributeNameDoesNotExistError : IErrorObject
    {
        string InvalidAttributeName { get; set; }

    }
}
