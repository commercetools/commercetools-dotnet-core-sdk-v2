using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.EnumKeyAlreadyExistsError))]
    public partial interface IEnumKeyAlreadyExistsError : IErrorObject
    {
        string ConflictingEnumKey { get; set; }

        string ConflictingAttributeName { get; set; }

    }
}
