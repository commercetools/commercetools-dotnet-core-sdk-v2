using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Common.Asset))]
    public partial interface IAsset
    {
        string Key { get; set; }

        List<IAssetSource> Sources { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        List<string> Tags { get; set; }

        ICustom Custom { get; set; }
    }
}
