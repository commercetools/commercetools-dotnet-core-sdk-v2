

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CartLockedMessagePayload : ICartLockedMessagePayload
    {
        public string Type { get; set; }
        public CartLockedMessagePayload()
        {
            this.Type = "CartLocked";
        }
    }
}
