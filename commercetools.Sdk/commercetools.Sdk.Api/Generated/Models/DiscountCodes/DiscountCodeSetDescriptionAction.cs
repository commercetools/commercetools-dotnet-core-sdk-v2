using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.DiscountCodes
{
    public partial class DiscountCodeSetDescriptionAction : IDiscountCodeSetDescriptionAction
    {
        public string Action { get; set; }

        public ILocalizedString Description { get; set; }
        public DiscountCodeSetDescriptionAction()
        {
            this.Action = "setDescription";
        }
    }
}
