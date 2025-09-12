

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class DiscountGroupIsActiveSetMessagePayload : IDiscountGroupIsActiveSetMessagePayload
    {
        public string Type { get; set; }

        public bool? IsActive { get; set; }

        public bool? OldIsActive { get; set; }
        public DiscountGroupIsActiveSetMessagePayload()
        {
            this.Type = "DiscountGroupIsActiveSet";
        }
    }
}
