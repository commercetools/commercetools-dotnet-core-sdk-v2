namespace commercetools.Sdk.Api.Models.Me
{
    public partial class MyCustomerSetTitleAction : IMyCustomerSetTitleAction
    {
        public string Action { get; set; }

        public string Title { get; set; }
        public MyCustomerSetTitleAction()
        {
            this.Action = "setTitle";
        }
    }
}
