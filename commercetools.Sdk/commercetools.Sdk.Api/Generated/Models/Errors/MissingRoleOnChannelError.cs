using commercetools.Sdk.Api.Models.Channels;


namespace commercetools.Sdk.Api.Models.Errors
{
    public partial class MissingRoleOnChannelError : IMissingRoleOnChannelError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IChannelResourceIdentifier Channel { get; set; }

        public IChannelRoleEnum MissingRole { get; set; }
        public MissingRoleOnChannelError()
        {
            this.Code = "MissingRoleOnChannel";
        }
    }
}
