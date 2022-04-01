using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.DiscountCodes
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
