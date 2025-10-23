using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.CustomerGroupAssignment))]
    public partial interface ICustomerGroupAssignment
    {
        ICustomerGroupReference CustomerGroup { get; set; }

    }
}
