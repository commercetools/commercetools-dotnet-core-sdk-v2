namespace commercetools.Api.Models.Channels
{
    public partial class ChannelChangeKeyAction : IChannelChangeKeyAction
    {
        public string Action { get; set;}
        
        public string Key { get; set;}
        public ChannelChangeKeyAction()
        { 
           this.Action = "changeKey";
        }
    }
}
