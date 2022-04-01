using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.Asset))]
    public partial interface IAsset
    {
        string Id { get; set; }

        List<IAssetSource> Sources { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        List<string> Tags { get; set; }

        ICustomFields Custom { get; set; }

        string Key { get; set; }
    }
}
