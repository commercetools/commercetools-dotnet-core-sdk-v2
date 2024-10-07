using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.ReferenceField))]
    public partial interface IReferenceField : ICustomField
    {
        IKeyReference Value { get; set; }

    }
}
