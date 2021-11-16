namespace commercetools.Api.Models.ProductTypes
{
    public partial class AttributeTextType : IAttributeTextType
    {
        public string Name { get; set;}
        public AttributeTextType()
        { 
           this.Name = "text";
        }
    }
}
