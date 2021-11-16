using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.EnumKeyDoesNotExistError))]
    public partial interface IEnumKeyDoesNotExistError : IErrorObject
    {
        string ConflictingEnumKey { get; set; }

        string ConflictingAttributeName { get; set; }
    }
}
