

namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyQuoteRequestCancelAction : IMyQuoteRequestCancelAction
    {
        public string Action { get; set; }
        public MyQuoteRequestCancelAction()
        {
            this.Action = "cancelQuoteRequest";
        }
    }
}
