using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class ProductTypeSetInputTipAction : IProductTypeSetInputTipAction
    {
        public string Action { get; set;}
        
        public string AttributeName { get; set;}
        
        public ILocalizedString InputTip { get; set;}
        public ProductTypeSetInputTipAction()
        { 
           this.Action = "setInputTip";
        }
    }
}
