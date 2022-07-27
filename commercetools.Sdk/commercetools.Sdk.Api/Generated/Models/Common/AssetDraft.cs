using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Common
{

    public partial class AssetDraft : IAssetDraft
    {
        public List<IAssetSource> Sources { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public List<string> Tags { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public string Key { get; set; }
    }
}
