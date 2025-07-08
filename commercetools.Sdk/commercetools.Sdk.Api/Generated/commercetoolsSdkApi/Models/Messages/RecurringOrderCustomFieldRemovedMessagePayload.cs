

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class RecurringOrderCustomFieldRemovedMessagePayload : IRecurringOrderCustomFieldRemovedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }
        public RecurringOrderCustomFieldRemovedMessagePayload()
        {
            this.Type = "RecurringOrderCustomFieldRemoved";
        }
    }
}
