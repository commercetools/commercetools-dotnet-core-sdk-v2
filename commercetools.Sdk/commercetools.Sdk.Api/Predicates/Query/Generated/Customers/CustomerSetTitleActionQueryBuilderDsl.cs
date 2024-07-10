using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerSetTitleActionQueryBuilderDsl
    {
        public CustomerSetTitleActionQueryBuilderDsl()
        {
        }

        public static CustomerSetTitleActionQueryBuilderDsl Of()
        {
            return new CustomerSetTitleActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerSetTitleActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerSetTitleActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerSetTitleActionQueryBuilderDsl>(p, CustomerSetTitleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSetTitleActionQueryBuilderDsl, string> Title()
        {
            return new ComparisonPredicateBuilder<CustomerSetTitleActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("title")),
            p => new CombinationQueryPredicate<CustomerSetTitleActionQueryBuilderDsl>(p, CustomerSetTitleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
