using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreNameSetMessage))]
    public partial interface IStoreNameSetMessage : IMessage
    {
        ILocalizedString Name { get; set; }

        List<ILocalizedString> NameAllLocales { get; set; }

    }
}
