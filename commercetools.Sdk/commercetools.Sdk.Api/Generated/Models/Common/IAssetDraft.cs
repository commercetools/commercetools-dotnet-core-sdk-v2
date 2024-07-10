using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.AssetDraft))]
    public partial interface IAssetDraft
    {
        IList<IAssetSource> Sources { get; set; }
        IEnumerable<IAssetSource> SourcesEnumerable { set => Sources = value.ToList(); }


        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        IList<string> Tags { get; set; }
        IEnumerable<string> TagsEnumerable { set => Tags = value.ToList(); }


        ICustomFieldsDraft Custom { get; set; }

        string Key { get; set; }

    }
}
