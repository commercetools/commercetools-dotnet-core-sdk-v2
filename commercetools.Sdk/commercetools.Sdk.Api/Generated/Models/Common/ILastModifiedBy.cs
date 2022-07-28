using commercetools.Sdk.Api.Models.Customers;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.LastModifiedBy))]
    public partial interface ILastModifiedBy : IClientLogging
    {
        new string ClientId { get; set; }

        new string ExternalUserId { get; set; }

        new ICustomerReference Customer { get; set; }

        new string AnonymousId { get; set; }

    }
}
