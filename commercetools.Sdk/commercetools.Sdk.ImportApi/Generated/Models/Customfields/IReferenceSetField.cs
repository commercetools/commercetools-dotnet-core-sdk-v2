using commercetools.ImportApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Customfields.ReferenceSetField))]
    public partial interface IReferenceSetField : ICustomField
    {
        List<IKeyReference> Value { get; set;}
    }
}
