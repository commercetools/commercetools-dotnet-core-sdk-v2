namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class OrderEditNotProcessed : IOrderEditNotProcessed
    {
        public string Type { get; set; }
        public OrderEditNotProcessed()
        {
            this.Type = "NotProcessed";
        }
    }
}
