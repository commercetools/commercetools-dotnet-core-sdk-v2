using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Errors.DuplicateVariantValuesError))]
    public partial interface IDuplicateVariantValuesError : IErrorObject
    {
        IVariantValues VariantValues { get; set; }
    }
}
