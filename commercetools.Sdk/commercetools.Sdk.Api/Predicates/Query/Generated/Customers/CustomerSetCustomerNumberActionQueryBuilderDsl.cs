using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerSetCustomerNumberActionQueryBuilderDsl
    {
        public CustomerSetCustomerNumberActionQueryBuilderDsl()
        {
        }

        public static CustomerSetCustomerNumberActionQueryBuilderDsl Of()
        {
            return new CustomerSetCustomerNumberActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerSetCustomerNumberActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerSetCustomerNumberActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerSetCustomerNumberActionQueryBuilderDsl>(p, CustomerSetCustomerNumberActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSetCustomerNumberActionQueryBuilderDsl, string> CustomerNumber()
        {
            return new ComparisonPredicateBuilder<CustomerSetCustomerNumberActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerNumber")),
            p => new CombinationQueryPredicate<CustomerSetCustomerNumberActionQueryBuilderDsl>(p, CustomerSetCustomerNumberActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
