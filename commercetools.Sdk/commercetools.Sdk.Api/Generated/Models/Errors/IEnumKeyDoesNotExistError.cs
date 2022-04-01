using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.EnumKeyDoesNotExistError))]
    public partial interface IEnumKeyDoesNotExistError : IErrorObject
    {
        string ConflictingEnumKey { get; set; }

        string ConflictingAttributeName { get; set; }
    }
}
