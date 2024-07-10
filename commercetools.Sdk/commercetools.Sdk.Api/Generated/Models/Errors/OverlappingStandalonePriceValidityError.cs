using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.Errors;
using commercetools.Sdk.Api.Models.StandalonePrices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class OverlappingStandalonePriceValidityError : IOverlappingStandalonePriceValidityError
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

        public DateTime? ConflictingValidFrom { get; set; }

        public DateTime? ConflictingValidUntil { get; set; }
        public OverlappingStandalonePriceValidityError()
        {
            this.Code = "OverlappingStandalonePriceValidity";
        }
    }
}
