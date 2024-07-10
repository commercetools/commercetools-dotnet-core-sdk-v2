using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

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
