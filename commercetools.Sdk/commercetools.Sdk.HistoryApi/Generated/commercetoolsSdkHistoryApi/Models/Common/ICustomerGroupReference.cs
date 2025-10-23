using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.CustomerGroupReference))]
    public partial interface ICustomerGroupReference : IReference
    {
        new string Id { get; set; }

    }
}
