namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class MessageModel : IMessage
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }
    }
}
