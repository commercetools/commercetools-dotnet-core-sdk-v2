namespace commercetools.Api.Models.ProductTypes
{
    public partial class ProductTypeChangeAttributeConstraintAction : IProductTypeChangeAttributeConstraintAction
    {
        public string Action { get; set; }

        public string AttributeName { get; set; }

        public IAttributeConstraintEnumDraft NewValue { get; set; }
        public ProductTypeChangeAttributeConstraintAction()
        {
            this.Action = "changeAttributeConstraint";
        }
    }
}
