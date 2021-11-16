namespace commercetools.Api.Models.Me
{
    public partial class MyPaymentSetMethodInfoInterfaceAction : IMyPaymentSetMethodInfoInterfaceAction
    {
        public string Action { get; set;}
        
        public string Interface { get; set;}
        public MyPaymentSetMethodInfoInterfaceAction()
        { 
           this.Action = "setMethodInfoInterface";
        }
    }
}
