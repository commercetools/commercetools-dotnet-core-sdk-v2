using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.LocalizedEnumSetField))]
    public partial interface ILocalizedEnumSetField : ICustomField
    {
        IList<string> Value { get; set; }

        IEnumerable<string> ValueEnumerable { set => Value = value.ToList(); }

    }
}
