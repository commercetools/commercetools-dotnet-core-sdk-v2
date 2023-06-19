using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class LastModifiedByQueryBuilderDsl
    {
        public LastModifiedByQueryBuilderDsl()
        {
        }

        public static LastModifiedByQueryBuilderDsl Of()
        {
            return new LastModifiedByQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<LastModifiedByQueryBuilderDsl, string> ClientId()
        {
            return new ComparisonPredicateBuilder<LastModifiedByQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("clientId")),
            p => new CombinationQueryPredicate<LastModifiedByQueryBuilderDsl>(p, LastModifiedByQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<LastModifiedByQueryBuilderDsl, string> ExternalUserId()
        {
            return new ComparisonPredicateBuilder<LastModifiedByQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("externalUserId")),
            p => new CombinationQueryPredicate<LastModifiedByQueryBuilderDsl>(p, LastModifiedByQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<LastModifiedByQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<LastModifiedByQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl.Of())),
                LastModifiedByQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<LastModifiedByQueryBuilderDsl, string> AnonymousId()
        {
            return new ComparisonPredicateBuilder<LastModifiedByQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("anonymousId")),
            p => new CombinationQueryPredicate<LastModifiedByQueryBuilderDsl>(p, LastModifiedByQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
