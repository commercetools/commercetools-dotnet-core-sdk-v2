using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Categories
{
    public partial class CategoryResourceIdentifier : ICategoryResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set;}
        
        public string Id { get; set;}
        
        public string Key { get; set;}
        public CategoryResourceIdentifier()
        { 
           this.TypeId = IReferenceTypeId.FindEnum("category");
        }
    }
}
