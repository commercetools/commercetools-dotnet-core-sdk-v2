using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Common
{
    public partial class Asset : IAsset
    {
        public string Id { get; set; }

        public List<IAssetSource> Sources { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public List<string> Tags { get; set; }

        public ICustomFields Custom { get; set; }

        public string Key { get; set; }
    }
}
