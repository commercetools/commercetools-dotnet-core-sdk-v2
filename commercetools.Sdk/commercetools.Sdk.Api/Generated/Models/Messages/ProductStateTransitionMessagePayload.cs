using commercetools.Api.Models.States;


namespace commercetools.Api.Models.Messages
{
    public partial class ProductStateTransitionMessagePayload : IProductStateTransitionMessagePayload
    {
        public string Type { get; set; }

        public IStateReference State { get; set; }

        public bool Force { get; set; }
        public ProductStateTransitionMessagePayload()
        {
            this.Type = "ProductStateTransition";
        }
    }
}
