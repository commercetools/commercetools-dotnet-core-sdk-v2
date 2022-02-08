namespace commercetools.Api.Models.Extensions
{
    public partial class AWSLambdaDestination : IAWSLambdaDestination
    {
        public string Type { get; set; }

        public string Arn { get; set; }

        public string AccessKey { get; set; }

        public string AccessSecret { get; set; }
        public AWSLambdaDestination()
        {
            this.Type = "AWSLambda";
        }
    }
}
