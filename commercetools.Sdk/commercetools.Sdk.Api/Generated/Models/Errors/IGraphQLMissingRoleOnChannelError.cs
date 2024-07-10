using commercetools.Sdk.Api.Models.Channels;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLMissingRoleOnChannelError))]
    public partial interface IGraphQLMissingRoleOnChannelError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        IChannelResourceIdentifier Channel { get; set; }

        IChannelRoleEnum MissingRole { get; set; }

    }
}
