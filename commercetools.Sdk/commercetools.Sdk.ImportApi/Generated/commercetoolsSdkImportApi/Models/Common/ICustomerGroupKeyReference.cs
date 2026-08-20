using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Common.CustomerGroupKeyReference))]
    public partial interface ICustomerGroupKeyReference : IKeyReference
    {
        new IReferenceType TypeId { get; set; }

        new string Key { get; set; }

    }
}
