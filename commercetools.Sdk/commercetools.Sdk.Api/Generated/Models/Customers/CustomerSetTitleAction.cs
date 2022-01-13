namespace commercetools.Api.Models.Customers
{
    public partial class CustomerSetTitleAction : ICustomerSetTitleAction
    {
        public string Action { get; set; }

        public string Title { get; set; }
        public CustomerSetTitleAction()
        {
            this.Action = "setTitle";
        }
    }
}
