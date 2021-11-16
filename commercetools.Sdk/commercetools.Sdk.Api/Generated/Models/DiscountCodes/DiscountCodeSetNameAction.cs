using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.DiscountCodes
{
    public partial class DiscountCodeSetNameAction : IDiscountCodeSetNameAction
    {
        public string Action { get; set;}
        
        public ILocalizedString Name { get; set;}
        public DiscountCodeSetNameAction()
        { 
           this.Action = "setName";
        }
    }
}
