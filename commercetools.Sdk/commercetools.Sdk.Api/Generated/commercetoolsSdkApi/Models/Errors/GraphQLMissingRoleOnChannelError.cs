using commercetools.Sdk.Api.Models.Channels;

namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLMissingRoleOnChannelError : IGraphQLMissingRoleOnChannelError
    {
        public string Code { get; set; }

        public IChannelResourceIdentifier Channel { get; set; }

        public IChannelRoleEnum MissingRole { get; set; }
        public GraphQLMissingRoleOnChannelError()
        {
            this.Code = "MissingRoleOnChannel";
        }
    }
}
