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

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLOverlappingStandalonePriceValidityError))]
    public partial interface IGraphQLOverlappingStandalonePriceValidityError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        IStandalonePriceReference ConflictingStandalonePrice { get; set; }

        string Sku { get; set; }

        string Currency { get; set; }

        string Country { get; set; }

        ICustomerGroupResourceIdentifier CustomerGroup { get; set; }

        IChannelResourceIdentifier Channel { get; set; }

        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        DateTime? ConflictingValidFrom { get; set; }

        DateTime? ConflictingValidUntil { get; set; }

    }
}
