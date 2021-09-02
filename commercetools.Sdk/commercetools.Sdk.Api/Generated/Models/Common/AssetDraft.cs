using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
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
