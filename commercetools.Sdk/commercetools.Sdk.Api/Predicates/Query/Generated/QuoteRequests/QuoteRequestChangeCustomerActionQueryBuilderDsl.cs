using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.QuoteRequests
{

    public partial class QuoteRequestChangeCustomerActionQueryBuilderDsl
    {
        public QuoteRequestChangeCustomerActionQueryBuilderDsl()
        {
        }

        public static QuoteRequestChangeCustomerActionQueryBuilderDsl Of()
        {
            return new QuoteRequestChangeCustomerActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteRequestChangeCustomerActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<QuoteRequestChangeCustomerActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<QuoteRequestChangeCustomerActionQueryBuilderDsl>(p, QuoteRequestChangeCustomerActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteRequestChangeCustomerActionQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRequestChangeCustomerActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl.Of())),
                QuoteRequestChangeCustomerActionQueryBuilderDsl.Of);
        }


    }
}
