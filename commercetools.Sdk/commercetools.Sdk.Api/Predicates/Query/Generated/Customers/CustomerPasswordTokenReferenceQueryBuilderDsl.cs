using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerPasswordTokenReferenceQueryBuilderDsl
    {
        public CustomerPasswordTokenReferenceQueryBuilderDsl()
        {
        }

        public static CustomerPasswordTokenReferenceQueryBuilderDsl Of()
        {
            return new CustomerPasswordTokenReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerPasswordTokenReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<CustomerPasswordTokenReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<CustomerPasswordTokenReferenceQueryBuilderDsl>(p, CustomerPasswordTokenReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerPasswordTokenReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CustomerPasswordTokenReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CustomerPasswordTokenReferenceQueryBuilderDsl>(p, CustomerPasswordTokenReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
