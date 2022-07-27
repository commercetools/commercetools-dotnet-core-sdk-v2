namespace commercetools.Sdk.MLApi.Models.Common
{

    public partial class CategoryReference : ICategoryReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public CategoryReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("category");
        }
    }
}
