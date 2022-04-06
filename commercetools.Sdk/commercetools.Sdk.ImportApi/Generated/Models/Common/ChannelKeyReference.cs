namespace commercetools.Sdk.ImportApi.Models.Common
{
    public partial class ChannelKeyReference : IChannelKeyReference
    {
        public string Key { get; set; }

        public IReferenceType TypeId { get; set; }
        public ChannelKeyReference()
        {
            this.TypeId = IReferenceType.FindEnum("channel");
        }
    }
}
