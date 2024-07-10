using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Quotes
{

    public partial class QuoteChangeCustomerActionQueryBuilderDsl
    {
        public QuoteChangeCustomerActionQueryBuilderDsl()
        {
        }

        public static QuoteChangeCustomerActionQueryBuilderDsl Of()
        {
            return new QuoteChangeCustomerActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteChangeCustomerActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<QuoteChangeCustomerActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<QuoteChangeCustomerActionQueryBuilderDsl>(p, QuoteChangeCustomerActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteChangeCustomerActionQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteChangeCustomerActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl.Of())),
                QuoteChangeCustomerActionQueryBuilderDsl.Of);
        }


    }
}
