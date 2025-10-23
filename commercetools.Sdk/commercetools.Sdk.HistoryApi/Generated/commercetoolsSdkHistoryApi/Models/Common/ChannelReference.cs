

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ChannelReference : IChannelReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }
        public ChannelReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("channel");
        }
    }
}
