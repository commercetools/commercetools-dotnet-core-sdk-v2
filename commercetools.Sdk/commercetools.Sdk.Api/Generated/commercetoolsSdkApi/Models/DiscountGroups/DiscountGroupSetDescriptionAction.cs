using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.DiscountGroups
{

    public partial class DiscountGroupSetDescriptionAction : IDiscountGroupSetDescriptionAction
    {
        public string Action { get; set; }

        public ILocalizedString Description { get; set; }
        public DiscountGroupSetDescriptionAction()
        {
            this.Action = "setDescription";
        }
    }
}
