using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.ReferenceSetAttribute))]
    public partial interface IReferenceSetAttribute : IAttribute
    {
        List<IKeyReference> Value { get; set; }
    }
}
