

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class DiscountCodeKeySetMessagePayload : IDiscountCodeKeySetMessagePayload
    {
        public string Type { get; set; }

        public string Key { get; set; }

        public string OldKey { get; set; }
        public DiscountCodeKeySetMessagePayload()
        {
            this.Type = "DiscountCodeKeySet";
        }
    }
}
