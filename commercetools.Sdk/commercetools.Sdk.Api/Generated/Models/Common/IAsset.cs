using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.Asset))]
    public partial interface IAsset
    {
        string Id { get; set; }

        IList<IAssetSource> Sources { get; set; }
        IEnumerable<IAssetSource> SourcesEnumerable { set => Sources = value.ToList(); }


        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        IList<string> Tags { get; set; }
        IEnumerable<string> TagsEnumerable { set => Tags = value.ToList(); }


        ICustomFields Custom { get; set; }

        string Key { get; set; }

    }
}
