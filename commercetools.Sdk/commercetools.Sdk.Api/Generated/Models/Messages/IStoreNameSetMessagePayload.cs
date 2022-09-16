using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreNameSetMessagePayload))]
    public partial interface IStoreNameSetMessagePayload : IMessagePayload
    {
        ILocalizedString Name { get; set; }

        List<ILocalizedString> NameAllLocales { get; set; }

    }
}
