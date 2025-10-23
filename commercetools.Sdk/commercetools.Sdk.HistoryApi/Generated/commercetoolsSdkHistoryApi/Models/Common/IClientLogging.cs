using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ClientLogging))]
    public partial interface IClientLogging
    {
        string ClientId { get; set; }

        string ExternalUserId { get; set; }

        ICustomerReference Customer { get; set; }

        string AnonymousId { get; set; }

        ICustomerReference Associate { get; set; }

    }
}
