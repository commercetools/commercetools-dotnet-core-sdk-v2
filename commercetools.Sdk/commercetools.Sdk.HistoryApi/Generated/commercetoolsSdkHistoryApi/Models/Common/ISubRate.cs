using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.SubRate))]
    public partial interface ISubRate
    {
        string Name { get; set; }

        int Amount { get; set; }

    }
}
