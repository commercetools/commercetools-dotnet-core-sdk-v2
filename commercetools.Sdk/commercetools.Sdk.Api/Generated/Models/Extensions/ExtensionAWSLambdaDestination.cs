namespace commercetools.Api.Models.Extensions
{
    public partial class ExtensionAWSLambdaDestination : IExtensionAWSLambdaDestination
    {
        public string Type { get; set;}
        
        public string Arn { get; set;}
        
        public string AccessKey { get; set;}
        
        public string AccessSecret { get; set;}
        public ExtensionAWSLambdaDestination()
        { 
           this.Type = "AWSLambda";
        }
    }
}
