namespace commercetools.Api.Models.Orders
{
    public partial class OrderSetLocaleAction : IOrderSetLocaleAction
    {
        public string Action { get; set; }

        public string Locale { get; set; }
        public OrderSetLocaleAction()
        {
            this.Action = "setLocale";
        }
    }
}
