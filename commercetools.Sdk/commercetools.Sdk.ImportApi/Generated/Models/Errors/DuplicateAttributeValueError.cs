using commercetools.Sdk.ImportApi.Models.Productvariants;


namespace commercetools.Sdk.ImportApi.Models.Errors
{

    public partial class DuplicateAttributeValueError : IDuplicateAttributeValueError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IAttribute Attribute { get; set; }
        public DuplicateAttributeValueError()
        {
            this.Code = "DuplicateAttributeValue";
        }
    }
}
