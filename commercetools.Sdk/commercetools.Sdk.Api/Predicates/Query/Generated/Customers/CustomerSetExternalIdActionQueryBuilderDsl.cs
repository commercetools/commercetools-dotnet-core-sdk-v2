using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerSetExternalIdActionQueryBuilderDsl
    {
        public CustomerSetExternalIdActionQueryBuilderDsl()
        {
        }

        public static CustomerSetExternalIdActionQueryBuilderDsl Of()
        {
            return new CustomerSetExternalIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerSetExternalIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerSetExternalIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerSetExternalIdActionQueryBuilderDsl>(p, CustomerSetExternalIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSetExternalIdActionQueryBuilderDsl, string> ExternalId()
        {
            return new ComparisonPredicateBuilder<CustomerSetExternalIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("externalId")),
            p => new CombinationQueryPredicate<CustomerSetExternalIdActionQueryBuilderDsl>(p, CustomerSetExternalIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
