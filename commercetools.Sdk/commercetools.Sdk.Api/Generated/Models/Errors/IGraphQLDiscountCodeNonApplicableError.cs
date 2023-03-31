using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLDiscountCodeNonApplicableError))]
    public partial interface IGraphQLDiscountCodeNonApplicableError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        string DiscountCode { get; set; }

        string Reason { get; set; }

        string DiscountCodeId { get; set; }

        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        DateTime? ValidityCheckTime { get; set; }

    }
}
