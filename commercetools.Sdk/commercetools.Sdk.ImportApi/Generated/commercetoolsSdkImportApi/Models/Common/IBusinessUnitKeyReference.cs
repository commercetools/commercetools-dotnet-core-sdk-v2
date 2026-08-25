using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Common.BusinessUnitKeyReference))]
    public partial interface IBusinessUnitKeyReference : IKeyReference
    {
        new IReferenceType TypeId { get; set; }

        new string Key { get; set; }

    }
}
