using System;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderCustomFieldChangedMessagePayload : IOrderCustomFieldChangedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }

        public Object PreviousValue { get; set; }
        public OrderCustomFieldChangedMessagePayload()
        {
            this.Type = "OrderCustomFieldChanged";
        }
    }
}
