using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLMatchingPriceNotFoundError))]
    public partial interface IGraphQLMatchingPriceNotFoundError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        string ProductId { get; set; }

        int VariantId { get; set; }

        string Currency { get; set; }

        string Country { get; set; }

        ICustomerGroupReference CustomerGroup { get; set; }

        IChannelReference Channel { get; set; }

    }
}
