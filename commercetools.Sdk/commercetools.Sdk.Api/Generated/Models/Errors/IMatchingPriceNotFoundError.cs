using commercetools.Sdk.Api.Models.Channels;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.MatchingPriceNotFoundError))]
    public partial interface IMatchingPriceNotFoundError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        string ProductId { get; set; }

        int VariantId { get; set; }

        string Currency { get; set; }

        string Country { get; set; }

        ICustomerGroupReference CustomerGroup { get; set; }

        IChannelReference Channel { get; set; }

    }
}
