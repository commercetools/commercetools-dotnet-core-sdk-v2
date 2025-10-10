using commercetools.Sdk.CheckoutApi.Models.Common;


namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class SetDescriptionUpdateAction : ISetDescriptionUpdateAction
    {
        public string Action { get; set; }

        public ILocalizedString Description { get; set; }
        public SetDescriptionUpdateAction()
        {
            this.Action = "setDescription";
        }
    }
}
