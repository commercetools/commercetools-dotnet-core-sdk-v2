using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CustomerGroups
{

    public partial class CustomerGroupSetKeyActionQueryBuilderDsl
    {
        public CustomerGroupSetKeyActionQueryBuilderDsl()
        {
        }

        public static CustomerGroupSetKeyActionQueryBuilderDsl Of()
        {
            return new CustomerGroupSetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerGroupSetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerGroupSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerGroupSetKeyActionQueryBuilderDsl>(p, CustomerGroupSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupSetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CustomerGroupSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CustomerGroupSetKeyActionQueryBuilderDsl>(p, CustomerGroupSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
