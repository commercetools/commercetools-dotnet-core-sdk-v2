using commercetools.Sdk.Api.Models.Channels;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.MissingRoleOnChannelError))]
    public partial interface IMissingRoleOnChannelError : IErrorObject
    {
        IChannelResourceIdentifier Channel { get; set; }

        IChannelRoleEnum MissingRole { get; set; }
    }
}
