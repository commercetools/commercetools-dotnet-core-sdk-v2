using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerEmailTokenReferenceQueryBuilderDsl
    {
        public CustomerEmailTokenReferenceQueryBuilderDsl()
        {
        }

        public static CustomerEmailTokenReferenceQueryBuilderDsl Of()
        {
            return new CustomerEmailTokenReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerEmailTokenReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<CustomerEmailTokenReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<CustomerEmailTokenReferenceQueryBuilderDsl>(p, CustomerEmailTokenReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerEmailTokenReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CustomerEmailTokenReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CustomerEmailTokenReferenceQueryBuilderDsl>(p, CustomerEmailTokenReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
