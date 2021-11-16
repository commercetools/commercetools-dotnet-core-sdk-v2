namespace commercetools.Api.Models.Subscriptions
{
    public partial class SnsDestination : ISnsDestination
    {
        public string Type { get; set;}
        
        public string AccessKey { get; set;}
        
        public string AccessSecret { get; set;}
        
        public string TopicArn { get; set;}
        public SnsDestination()
        { 
           this.Type = "SNS";
        }
    }
}
