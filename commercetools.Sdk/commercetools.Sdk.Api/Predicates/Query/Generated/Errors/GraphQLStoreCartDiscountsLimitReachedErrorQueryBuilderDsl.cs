using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLStoreCartDiscountsLimitReachedErrorQueryBuilderDsl
    {
        public GraphQLStoreCartDiscountsLimitReachedErrorQueryBuilderDsl()
        {
        }

        public static GraphQLStoreCartDiscountsLimitReachedErrorQueryBuilderDsl Of()
        {
            return new GraphQLStoreCartDiscountsLimitReachedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLStoreCartDiscountsLimitReachedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLStoreCartDiscountsLimitReachedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLStoreCartDiscountsLimitReachedErrorQueryBuilderDsl>(p, GraphQLStoreCartDiscountsLimitReachedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<GraphQLStoreCartDiscountsLimitReachedErrorQueryBuilderDsl> Stores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLStoreCartDiscountsLimitReachedErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                GraphQLStoreCartDiscountsLimitReachedErrorQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<GraphQLStoreCartDiscountsLimitReachedErrorQueryBuilderDsl> Stores()
        {
            return new CollectionPredicateBuilder<GraphQLStoreCartDiscountsLimitReachedErrorQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stores")),
                    p => new CombinationQueryPredicate<GraphQLStoreCartDiscountsLimitReachedErrorQueryBuilderDsl>(p, GraphQLStoreCartDiscountsLimitReachedErrorQueryBuilderDsl.Of));
        }

    }
}
