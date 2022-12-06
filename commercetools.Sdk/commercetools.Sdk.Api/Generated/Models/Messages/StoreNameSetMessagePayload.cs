using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;


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
