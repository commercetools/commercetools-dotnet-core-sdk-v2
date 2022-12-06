using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.EnumSetField))]
    public partial interface IEnumSetField : ICustomField
    {
        IList<string> Value { get; set; }
        IEnumerable<string> ValueEnumerable { set => Value = value.ToList(); }


    }
}
