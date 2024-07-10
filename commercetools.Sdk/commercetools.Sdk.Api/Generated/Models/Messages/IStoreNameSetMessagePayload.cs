using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

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
