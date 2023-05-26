using commercetools.Sdk.Api.Models.Customers;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.QuoteRequests
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestChangeCustomerAction))]
    public partial interface IQuoteRequestChangeCustomerAction : IQuoteRequestUpdateAction
    {
        ICustomerResourceIdentifier Customer { get; set; }

    }
}
