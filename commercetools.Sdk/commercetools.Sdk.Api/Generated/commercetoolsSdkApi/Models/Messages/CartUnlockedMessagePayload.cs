

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CartUnlockedMessagePayload : ICartUnlockedMessagePayload
    {
        public string Type { get; set; }
        public CartUnlockedMessagePayload()
        {
            this.Type = "CartUnlocked";
        }
    }
}
