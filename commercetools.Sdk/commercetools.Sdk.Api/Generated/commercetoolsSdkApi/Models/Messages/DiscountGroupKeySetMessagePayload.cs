

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class DiscountGroupKeySetMessagePayload : IDiscountGroupKeySetMessagePayload
    {
        public string Type { get; set; }

        public string Key { get; set; }

        public string OldKey { get; set; }
        public DiscountGroupKeySetMessagePayload()
        {
            this.Type = "DiscountGroupKeySet";
        }
    }
}
