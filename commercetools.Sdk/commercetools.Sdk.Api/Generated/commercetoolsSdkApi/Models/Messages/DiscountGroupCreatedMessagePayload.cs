using commercetools.Sdk.Api.Models.DiscountGroups;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class DiscountGroupCreatedMessagePayload : IDiscountGroupCreatedMessagePayload
    {
        public string Type { get; set; }

        public IDiscountGroup DiscountGroup { get; set; }
        public DiscountGroupCreatedMessagePayload()
        {
            this.Type = "DiscountGroupCreated";
        }
    }
}
