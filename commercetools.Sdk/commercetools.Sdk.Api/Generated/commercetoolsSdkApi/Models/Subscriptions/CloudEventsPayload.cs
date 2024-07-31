using System;

namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class CloudEventsPayload : ICloudEventsPayload
    {
        public string Specversion { get; set; }

        public string Id { get; set; }

        public string Type { get; set; }

        public string Source { get; set; }

        public string Subject { get; set; }

        public DateTime Time { get; set; }

        public string Sequence { get; set; }

        public string Sequencetype { get; set; }

        public string Dataref { get; set; }

        public IDeliveryPayload Data { get; set; }
    }
}
