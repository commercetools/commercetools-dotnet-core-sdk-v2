using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.EnumKeyAlreadyExistsError))]
    public partial interface IEnumKeyAlreadyExistsError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        string ConflictingEnumKey { get; set; }

        string ConflictingAttributeName { get; set; }

    }
}
