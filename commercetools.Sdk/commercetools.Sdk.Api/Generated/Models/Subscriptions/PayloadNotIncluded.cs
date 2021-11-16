namespace commercetools.Api.Models.Subscriptions
{
    public partial class PayloadNotIncluded : IPayloadNotIncluded
    {
        public string Reason { get; set; }

        public string PayloadType { get; set; }
    }
}
