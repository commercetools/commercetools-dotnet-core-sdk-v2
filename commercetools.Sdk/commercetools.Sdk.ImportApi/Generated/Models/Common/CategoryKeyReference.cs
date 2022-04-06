namespace commercetools.Sdk.ImportApi.Models.Common
{
    public partial class CategoryKeyReference : ICategoryKeyReference
    {
        public string Key { get; set; }

        public IReferenceType TypeId { get; set; }
        public CategoryKeyReference()
        {
            this.TypeId = IReferenceType.FindEnum("category");
        }
    }
}
