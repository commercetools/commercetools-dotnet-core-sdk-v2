namespace commercetools.Api.Models.ProductTypes
{
    public partial class AttributeMoneyType : IAttributeMoneyType
    {
        public string Name { get; set;}
        public AttributeMoneyType()
        { 
           this.Name = "money";
        }
    }
}
