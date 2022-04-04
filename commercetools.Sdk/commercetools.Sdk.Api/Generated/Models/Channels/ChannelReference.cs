using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Channels
{
    public partial class ChannelReference : IChannelReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IChannel Obj { get; set; }
        public ChannelReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("channel");
        }
    }
}
