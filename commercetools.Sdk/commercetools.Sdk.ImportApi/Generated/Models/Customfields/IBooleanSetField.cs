using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.BooleanSetField))]
    public partial interface IBooleanSetField : ICustomField
    {
        IList<bool> Value { get; set; }
        IEnumerable<bool> ValueEnumerable { set => Value = value.ToList(); }


    }
}
