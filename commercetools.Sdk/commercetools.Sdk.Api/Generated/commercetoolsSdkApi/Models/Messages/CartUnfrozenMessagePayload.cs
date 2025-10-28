

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CartUnfrozenMessagePayload : ICartUnfrozenMessagePayload
    {
        public string Type { get; set; }
        public CartUnfrozenMessagePayload()
        {
            this.Type = "CartUnfrozen";
        }
    }
}
