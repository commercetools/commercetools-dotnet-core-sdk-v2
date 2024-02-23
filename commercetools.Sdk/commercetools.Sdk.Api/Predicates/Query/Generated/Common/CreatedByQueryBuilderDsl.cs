using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class CreatedByQueryBuilderDsl
    {
        public CreatedByQueryBuilderDsl()
        {
        }

        public static CreatedByQueryBuilderDsl Of()
        {
            return new CreatedByQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CreatedByQueryBuilderDsl, string> ClientId()
        {
            return new ComparisonPredicateBuilder<CreatedByQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("clientId")),
            p => new CombinationQueryPredicate<CreatedByQueryBuilderDsl>(p, CreatedByQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CreatedByQueryBuilderDsl, string> ExternalUserId()
        {
            return new ComparisonPredicateBuilder<CreatedByQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("externalUserId")),
            p => new CombinationQueryPredicate<CreatedByQueryBuilderDsl>(p, CreatedByQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CreatedByQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CreatedByQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl.Of())),
                CreatedByQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CreatedByQueryBuilderDsl, string> AnonymousId()
        {
            return new ComparisonPredicateBuilder<CreatedByQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("anonymousId")),
            p => new CombinationQueryPredicate<CreatedByQueryBuilderDsl>(p, CreatedByQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CreatedByQueryBuilderDsl> Associate(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CreatedByQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl.Of())),
                CreatedByQueryBuilderDsl.Of);
        }


    }
}
