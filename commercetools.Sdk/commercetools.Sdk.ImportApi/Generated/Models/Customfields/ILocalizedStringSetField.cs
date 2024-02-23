using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.LocalizedStringSetField))]
    public partial interface ILocalizedStringSetField : ICustomField
    {
        IList<ILocalizedString> Value { get; set; }
        IEnumerable<ILocalizedString> ValueEnumerable { set => Value = value.ToList(); }


    }
}
