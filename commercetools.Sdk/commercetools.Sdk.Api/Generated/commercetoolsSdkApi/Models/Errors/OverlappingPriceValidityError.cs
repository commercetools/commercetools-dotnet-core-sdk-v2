using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.CustomerGroups;
using System;

namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class OverlappingPriceValidityError : IOverlappingPriceValidityError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string ConflictingPrice { get; set; }

        public string Currency { get; set; }

        public string Country { get; set; }

        public ICustomerGroupResourceIdentifier CustomerGroup { get; set; }

        public IChannelResourceIdentifier Channel { get; set; }

        public DateTime? ValidFrom { get; set; }

        public DateTime? ValidUntil { get; set; }

        public DateTime? ConflictingValidFrom { get; set; }

        public DateTime? ConflictingValidUntil { get; set; }
        public OverlappingPriceValidityError()
        {
            this.Code = "OverlappingPriceValidity";
        }
    }
}
