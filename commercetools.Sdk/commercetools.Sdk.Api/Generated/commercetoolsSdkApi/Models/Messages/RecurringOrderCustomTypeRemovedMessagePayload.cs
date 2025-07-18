

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class RecurringOrderCustomTypeRemovedMessagePayload : IRecurringOrderCustomTypeRemovedMessagePayload
    {
        public string Type { get; set; }

        public string PreviousTypeId { get; set; }
        public RecurringOrderCustomTypeRemovedMessagePayload()
        {
            this.Type = "RecurringOrderCustomTypeRemoved";
        }
    }
}
