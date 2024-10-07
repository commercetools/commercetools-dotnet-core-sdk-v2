using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Labels
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Labels.CustomerLabel))]
    public partial interface ICustomerLabel : ILabel
    {
        new string Type { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string CustomerNumber { get; set; }

    }
}
