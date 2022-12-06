using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.LocalizableTextSetAttribute))]
    public partial interface ILocalizableTextSetAttribute : IAttribute
    {
        IList<ILocalizedString> Value { get; set; }
        IEnumerable<ILocalizedString> ValueEnumerable { set => Value = value.ToList(); }


    }
}
