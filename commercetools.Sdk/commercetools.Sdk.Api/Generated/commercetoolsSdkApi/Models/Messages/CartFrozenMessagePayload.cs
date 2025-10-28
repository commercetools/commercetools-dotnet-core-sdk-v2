

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CartFrozenMessagePayload : ICartFrozenMessagePayload
    {
        public string Type { get; set; }
        public CartFrozenMessagePayload()
        {
            this.Type = "CartFrozen";
        }
    }
}
