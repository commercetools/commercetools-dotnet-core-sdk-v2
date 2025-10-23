using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.BusinessUnitKeyReference))]
    public partial interface IBusinessUnitKeyReference : IKeyReference
    {
        new string Key { get; set; }

    }
}
