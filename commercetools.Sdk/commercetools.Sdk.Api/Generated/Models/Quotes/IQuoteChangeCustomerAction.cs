using commercetools.Sdk.Api.Models.Customers;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Quotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Quotes.QuoteChangeCustomerAction))]
    public partial interface IQuoteChangeCustomerAction : IQuoteUpdateAction
    {
        ICustomerResourceIdentifier Customer { get; set; }

    }
}
