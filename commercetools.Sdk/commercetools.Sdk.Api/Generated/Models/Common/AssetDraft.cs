using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Common
{

    public partial class AssetDraft : IAssetDraft
    {
        public IList<IAssetSource> Sources { get; set; }
        public IEnumerable<IAssetSource> SourcesEnumerable { set => Sources = value.ToList(); }


        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public IList<string> Tags { get; set; }
        public IEnumerable<string> TagsEnumerable { set => Tags = value.ToList(); }


        public ICustomFieldsDraft Custom { get; set; }

        public string Key { get; set; }
    }
}
