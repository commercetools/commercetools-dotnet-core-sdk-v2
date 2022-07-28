using commercetools.Sdk.Api.Models.Customers;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.ClientLogging))]
    public partial interface IClientLogging
    {
        string ClientId { get; set; }

        string ExternalUserId { get; set; }

        ICustomerReference Customer { get; set; }

        string AnonymousId { get; set; }

    }
}
