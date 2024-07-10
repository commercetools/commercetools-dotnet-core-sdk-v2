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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StoreNameSetMessagePayload))]
    public partial interface IStoreNameSetMessagePayload : IMessagePayload
    {
        ILocalizedString Name { get; set; }

        IList<ILocalizedString> NameAllLocales { get; set; }
        IEnumerable<ILocalizedString> NameAllLocalesEnumerable { set => NameAllLocales = value.ToList(); }


    }
}
