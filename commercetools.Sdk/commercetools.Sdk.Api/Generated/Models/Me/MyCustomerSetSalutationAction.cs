namespace commercetools.Sdk.Api.Models.Me
{
    public partial class MyCustomerSetSalutationAction : IMyCustomerSetSalutationAction
    {
        public string Action { get; set; }

        public string Salutation { get; set; }
        public MyCustomerSetSalutationAction()
        {
            this.Action = "setSalutation";
        }
    }
}
