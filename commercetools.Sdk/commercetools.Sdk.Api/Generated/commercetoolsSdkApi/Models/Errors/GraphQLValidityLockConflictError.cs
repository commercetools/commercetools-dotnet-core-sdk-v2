using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.RecurrencePolicies;

namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLValidityLockConflictError : IGraphQLValidityLockConflictError
    {
        public string Code { get; set; }

        public string Sku { get; set; }

        public string Currency { get; set; }

        public string Country { get; set; }

        public ICustomerGroupResourceIdentifier CustomerGroup { get; set; }

        public IChannelResourceIdentifier Channel { get; set; }

        public IRecurrencePolicyResourceIdentifier RecurrencePolicy { get; set; }
        public GraphQLValidityLockConflictError()
        {
            this.Code = "ValidityLockConflict";
        }
    }
}
