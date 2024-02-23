using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.CustomerGroups;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class MatchingPriceNotFoundError : IMatchingPriceNotFoundError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string ProductId { get; set; }

        public int VariantId { get; set; }

        public string Currency { get; set; }

        public string Country { get; set; }

        public ICustomerGroupReference CustomerGroup { get; set; }

        public IChannelReference Channel { get; set; }
        public MatchingPriceNotFoundError()
        {
            this.Code = "MatchingPriceNotFound";
        }
    }
}
