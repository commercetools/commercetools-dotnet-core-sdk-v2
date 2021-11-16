namespace commercetools.ImportApi.Models.Common
{
    public partial class TaxCategoryKeyReference : ITaxCategoryKeyReference
    {
        public string Key { get; set;}
        
        public IReferenceType TypeId { get; set;}
        public TaxCategoryKeyReference()
        { 
           this.TypeId = IReferenceType.FindEnum("tax-category");
        }
    }
}
