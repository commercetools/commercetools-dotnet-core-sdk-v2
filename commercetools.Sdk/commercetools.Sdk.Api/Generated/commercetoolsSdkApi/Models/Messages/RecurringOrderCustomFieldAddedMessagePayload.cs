using System;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class RecurringOrderCustomFieldAddedMessagePayload : IRecurringOrderCustomFieldAddedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public RecurringOrderCustomFieldAddedMessagePayload()
        {
            this.Type = "RecurringOrderCustomFieldAdded";
        }
    }
}
