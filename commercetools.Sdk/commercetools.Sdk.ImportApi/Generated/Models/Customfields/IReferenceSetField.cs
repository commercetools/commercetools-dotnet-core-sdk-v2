using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.ReferenceSetField))]
    public partial interface IReferenceSetField : ICustomField
    {
        List<IKeyReference> Value { get; set; }
    }
}
