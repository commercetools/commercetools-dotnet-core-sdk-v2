using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreLanguagesChangedMessage))]
    public partial interface IStoreLanguagesChangedMessage : IMessage
    {
        IList<string> AddedLanguages { get; set; }
        IEnumerable<string> AddedLanguagesEnumerable { set => AddedLanguages = value.ToList(); }


        IList<string> RemovedLanguages { get; set; }
        IEnumerable<string> RemovedLanguagesEnumerable { set => RemovedLanguages = value.ToList(); }


    }
}
