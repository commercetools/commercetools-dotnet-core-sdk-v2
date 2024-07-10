using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerSetFirstNameActionQueryBuilderDsl
    {
        public CustomerSetFirstNameActionQueryBuilderDsl()
        {
        }

        public static CustomerSetFirstNameActionQueryBuilderDsl Of()
        {
            return new CustomerSetFirstNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerSetFirstNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerSetFirstNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerSetFirstNameActionQueryBuilderDsl>(p, CustomerSetFirstNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSetFirstNameActionQueryBuilderDsl, string> FirstName()
        {
            return new ComparisonPredicateBuilder<CustomerSetFirstNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("firstName")),
            p => new CombinationQueryPredicate<CustomerSetFirstNameActionQueryBuilderDsl>(p, CustomerSetFirstNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
