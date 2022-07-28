using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.ReferenceAttribute))]
    public partial interface IReferenceAttribute : IAttribute
    {
        IKeyReference Value { get; set; }

    }
}
