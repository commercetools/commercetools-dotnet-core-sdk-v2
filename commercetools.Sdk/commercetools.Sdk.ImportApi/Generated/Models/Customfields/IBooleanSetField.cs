using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.BooleanSetField))]
    public partial interface IBooleanSetField : ICustomField
    {
        IList<bool> Value { get; set; }
        IEnumerable<bool> ValueEnumerable { set => Value = value.ToList(); }


    }
}
