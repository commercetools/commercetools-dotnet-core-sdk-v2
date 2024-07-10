using commercetools.Sdk.Api.Models.States;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductTransitionStateAction : IProductTransitionStateAction
    {
        public string Action { get; set; }

        public IStateResourceIdentifier State { get; set; }

        public bool? Force { get; set; }
        public ProductTransitionStateAction()
        {
            this.Action = "transitionState";
        }
    }
}
