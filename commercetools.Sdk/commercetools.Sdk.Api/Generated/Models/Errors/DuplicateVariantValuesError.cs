namespace commercetools.Api.Models.Errors
{
    public partial class DuplicateVariantValuesError : IDuplicateVariantValuesError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IVariantValues VariantValues { get; set; }
        public DuplicateVariantValuesError()
        {
            this.Code = "DuplicateVariantValues";
        }
    }
}
