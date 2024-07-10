using commercetools.Sdk.Api.Models.DiscountCodes;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class DiscountCodeCreatedMessagePayload : IDiscountCodeCreatedMessagePayload
    {
        public string Type { get; set; }

        public IDiscountCode DiscountCode { get; set; }
        public DiscountCodeCreatedMessagePayload()
        {
            this.Type = "DiscountCodeCreated";
        }
    }
}
