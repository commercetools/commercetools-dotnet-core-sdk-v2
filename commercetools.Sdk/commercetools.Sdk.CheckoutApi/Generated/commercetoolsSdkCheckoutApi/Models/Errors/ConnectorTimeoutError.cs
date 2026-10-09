

namespace commercetools.Sdk.CheckoutApi.Models.Errors
{

    public partial class ConnectorTimeoutError : IConnectorTimeoutError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public ConnectorTimeoutError()
        {
            this.Code = "ConnectorTimeout";
        }
    }
}
