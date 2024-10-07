using commercetools.Sdk.Api.Models.Customers;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.CreatedBy))]
    public partial interface ICreatedBy : IClientLogging
    {
        new string ClientId { get; set; }

        new string ExternalUserId { get; set; }

        new ICustomerReference Customer { get; set; }

        new string AnonymousId { get; set; }

        IAttribution AttributedTo { get; set; }

        new ICustomerReference Associate { get; set; }

    }
}
