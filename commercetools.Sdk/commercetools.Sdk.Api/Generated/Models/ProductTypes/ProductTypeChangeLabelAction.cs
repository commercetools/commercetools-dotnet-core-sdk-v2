using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class ProductTypeChangeLabelAction : IProductTypeChangeLabelAction
    {
        public string Action { get; set; }

        public string AttributeName { get; set; }

        public ILocalizedString Label { get; set; }
        public ProductTypeChangeLabelAction()
        {
            this.Action = "changeLabel";
        }
    }
}
