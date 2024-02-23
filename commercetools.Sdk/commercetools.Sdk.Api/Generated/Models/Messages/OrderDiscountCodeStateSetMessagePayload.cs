using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.DiscountCodes;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderDiscountCodeStateSetMessagePayload : IOrderDiscountCodeStateSetMessagePayload
    {
        public string Type { get; set; }

        public IDiscountCodeReference DiscountCode { get; set; }

        public IDiscountCodeState State { get; set; }

        public IDiscountCodeState OldState { get; set; }
        public OrderDiscountCodeStateSetMessagePayload()
        {
            this.Type = "OrderDiscountCodeStateSet";
        }
    }
}
