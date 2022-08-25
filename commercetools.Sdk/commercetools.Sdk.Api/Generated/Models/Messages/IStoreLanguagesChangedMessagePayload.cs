using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreLanguagesChangedMessagePayload))]
    public partial interface IStoreLanguagesChangedMessagePayload : IMessagePayload
    {
        List<string> AddedLanguages { get; set; }

        List<string> RemovedLanguages { get; set; }

    }
}
