using commercetools.Sdk.ImportApi.Models.Customfields;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.ImportApi.Models.Common
{

    public partial class Asset : IAsset
    {
        public string Key { get; set; }

        public IList<IAssetSource> Sources { get; set; }
        public IEnumerable<IAssetSource> SourcesEnumerable { set => Sources = value.ToList(); }


        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public IList<string> Tags { get; set; }
        public IEnumerable<string> TagsEnumerable { set => Tags = value.ToList(); }


        public ICustom Custom { get; set; }
    }
}
