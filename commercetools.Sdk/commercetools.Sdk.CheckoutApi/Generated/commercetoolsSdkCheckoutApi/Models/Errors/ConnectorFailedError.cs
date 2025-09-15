

namespace commercetools.Sdk.CheckoutApi.Models.Errors
{

    public partial class ConnectorFailedError : IConnectorFailedError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public ConnectorFailedError()
        {
            this.Code = "ConnectorFailed";
        }
    }
}
