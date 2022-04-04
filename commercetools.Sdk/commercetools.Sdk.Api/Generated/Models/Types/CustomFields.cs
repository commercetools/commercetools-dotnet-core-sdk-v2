namespace commercetools.Sdk.Api.Models.Types
{
    public partial class CustomFields : ICustomFields
    {
        public ITypeReference Type { get; set; }

        public IFieldContainer Fields { get; set; }
    }
}
