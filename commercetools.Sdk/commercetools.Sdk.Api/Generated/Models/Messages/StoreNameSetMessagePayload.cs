using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StoreNameSetMessagePayload : IStoreNameSetMessagePayload
    {
        public string Type { get; set; }

        public ILocalizedString Name { get; set; }

        public List<ILocalizedString> NameAllLocales { get; set; }
        public StoreNameSetMessagePayload()
        {
            this.Type = "StoreNameSet";
        }
    }
}
