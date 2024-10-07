using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.StandalonePrices;
using System;
using commercetools.Base.CustomAttributes;
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
