using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Channels.ChannelDraft))]
    public partial interface IChannelDraft
    {
        string Key { get; set; }

        List<IChannelRoleEnum> Roles { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        IBaseAddress Address { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        IGeoJson GeoLocation { get; set; }
    }
}
