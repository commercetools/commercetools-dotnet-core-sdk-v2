

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class RecurringOrderKeySetMessagePayload : IRecurringOrderKeySetMessagePayload
    {
        public string Type { get; set; }

        public string Key { get; set; }

        public string OldKey { get; set; }
        public RecurringOrderKeySetMessagePayload()
        {
            this.Type = "RecurringOrderKeySet";
        }
    }
}
