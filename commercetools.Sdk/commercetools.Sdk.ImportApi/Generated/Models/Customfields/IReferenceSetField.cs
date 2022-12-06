using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.ReferenceSetField))]
    public partial interface IReferenceSetField : ICustomField
    {
        IList<IKeyReference> Value { get; set; }
        IEnumerable<IKeyReference> ValueEnumerable { set => Value = value.ToList(); }


    }
}
