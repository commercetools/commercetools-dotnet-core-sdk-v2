using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Categories
{
    public partial class CategoryReference : ICategoryReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public ICategory Obj { get; set; }
        public CategoryReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("category");
        }
    }
}
