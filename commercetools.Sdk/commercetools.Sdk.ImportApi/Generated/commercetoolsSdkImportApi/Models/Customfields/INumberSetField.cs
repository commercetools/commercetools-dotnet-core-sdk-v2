using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.NumberSetField))]
    public partial interface INumberSetField : ICustomField
    {
        IList<decimal> Value { get; set; }

        IEnumerable<decimal> ValueEnumerable { set => Value = value.ToList(); }

    }
}
