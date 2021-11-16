namespace commercetools.Api.Models.ProductTypes
{
    public partial class AttributeLocalizableTextType : IAttributeLocalizableTextType
    {
        public string Name { get; set; }
        public AttributeLocalizableTextType()
        {
            this.Name = "ltext";
        }
    }
}
