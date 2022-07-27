using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.StandalonePrices;
using System;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class DuplicateStandalonePriceScopeError : IDuplicateStandalonePriceScopeError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IStandalonePriceReference ConflictingStandalonePrice { get; set; }

        public string Sku { get; set; }

        public string Currency { get; set; }

        public string Country { get; set; }

        public ICustomerGroupResourceIdentifier CustomerGroup { get; set; }

        public IChannelResourceIdentifier Channel { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }
        public DuplicateStandalonePriceScopeError()
        {
            this.Code = "DuplicateStandalonePriceScope";
        }
    }
}
