namespace commercetools.Api.Models.Me
{
    public partial class MyCustomerSetVatIdAction : IMyCustomerSetVatIdAction
    {
        public string Action { get; set; }

        public string VatId { get; set; }
        public MyCustomerSetVatIdAction()
        {
            this.Action = "setVatId";
        }
    }
}
