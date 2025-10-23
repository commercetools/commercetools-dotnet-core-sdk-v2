

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ClientLogging : IClientLogging
    {
        public string ClientId { get; set; }

        public string ExternalUserId { get; set; }

        public ICustomerReference Customer { get; set; }

        public string AnonymousId { get; set; }

        public ICustomerReference Associate { get; set; }
    }
}
