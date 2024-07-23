using System;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderCustomFieldAddedMessagePayload : IOrderCustomFieldAddedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public OrderCustomFieldAddedMessagePayload()
        {
            this.Type = "OrderCustomFieldAdded";
        }
    }
}
