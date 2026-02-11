using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.RecurrencePolicies;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.ValidityLockConflictError))]
    public partial interface IValidityLockConflictError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        string Sku { get; set; }

        string Currency { get; set; }

        string Country { get; set; }

        ICustomerGroupResourceIdentifier CustomerGroup { get; set; }

        IChannelResourceIdentifier Channel { get; set; }

        IRecurrencePolicyResourceIdentifier RecurrencePolicy { get; set; }

    }
}
