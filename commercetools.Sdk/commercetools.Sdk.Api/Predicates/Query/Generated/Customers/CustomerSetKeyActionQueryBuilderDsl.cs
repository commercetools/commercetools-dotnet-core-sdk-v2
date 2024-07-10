using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerSetKeyActionQueryBuilderDsl
    {
        public CustomerSetKeyActionQueryBuilderDsl()
        {
        }

        public static CustomerSetKeyActionQueryBuilderDsl Of()
        {
            return new CustomerSetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerSetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerSetKeyActionQueryBuilderDsl>(p, CustomerSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CustomerSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CustomerSetKeyActionQueryBuilderDsl>(p, CustomerSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
