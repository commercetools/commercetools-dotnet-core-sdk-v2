using commercetools.Sdk.ImportApi.Models.Customfields;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Common.Asset))]
    public partial interface IAsset
    {
        string Key { get; set; }

        IList<IAssetSource> Sources { get; set; }

        IEnumerable<IAssetSource> SourcesEnumerable { set => Sources = value.ToList(); }

        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        IList<string> Tags { get; set; }

        IEnumerable<string> TagsEnumerable { set => Tags = value.ToList(); }

        ICustom Custom { get; set; }

    }
}
