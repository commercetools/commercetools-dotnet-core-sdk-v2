using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Errors.DuplicateVariantValuesError))]
    public partial interface IDuplicateVariantValuesError : IErrorObject
    {
        IVariantValues VariantValues { get; set; }

    }
}
