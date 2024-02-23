using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.EnumKeyDoesNotExistError))]
    public partial interface IEnumKeyDoesNotExistError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        string ConflictingEnumKey { get; set; }

        string ConflictingAttributeName { get; set; }

    }
}
