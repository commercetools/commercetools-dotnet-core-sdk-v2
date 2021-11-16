using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.EnumKeyAlreadyExistsError))]
    public partial interface IEnumKeyAlreadyExistsError : IErrorObject
    {
        string ConflictingEnumKey { get; set;}
        
        string ConflictingAttributeName { get; set;}
    }
}
