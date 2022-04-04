namespace commercetools.Sdk.Api.Models.Errors
{
    public partial class AttributeNameDoesNotExistError : IAttributeNameDoesNotExistError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string InvalidAttributeName { get; set; }
        public AttributeNameDoesNotExistError()
        {
            this.Code = "AttributeNameDoesNotExist";
        }
    }
}
