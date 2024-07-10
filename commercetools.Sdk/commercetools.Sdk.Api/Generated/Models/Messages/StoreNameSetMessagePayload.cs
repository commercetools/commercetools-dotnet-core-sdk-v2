using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StoreNameSetMessagePayload : IStoreNameSetMessagePayload
    {
        public string Type { get; set; }

        public ILocalizedString Name { get; set; }

        public IList<ILocalizedString> NameAllLocales { get; set; }
        public IEnumerable<ILocalizedString> NameAllLocalesEnumerable { set => NameAllLocales = value.ToList(); }

        public StoreNameSetMessagePayload()
        {
            this.Type = "StoreNameSet";
        }
    }
}
