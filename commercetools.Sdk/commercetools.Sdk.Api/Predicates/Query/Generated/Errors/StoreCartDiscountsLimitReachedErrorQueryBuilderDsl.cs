using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class StoreCartDiscountsLimitReachedErrorQueryBuilderDsl
    {
        public StoreCartDiscountsLimitReachedErrorQueryBuilderDsl()
        {
        }

        public static StoreCartDiscountsLimitReachedErrorQueryBuilderDsl Of()
        {
            return new StoreCartDiscountsLimitReachedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreCartDiscountsLimitReachedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<StoreCartDiscountsLimitReachedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<StoreCartDiscountsLimitReachedErrorQueryBuilderDsl>(p, StoreCartDiscountsLimitReachedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StoreCartDiscountsLimitReachedErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<StoreCartDiscountsLimitReachedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<StoreCartDiscountsLimitReachedErrorQueryBuilderDsl>(p, StoreCartDiscountsLimitReachedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreCartDiscountsLimitReachedErrorQueryBuilderDsl> Stores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreCartDiscountsLimitReachedErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                StoreCartDiscountsLimitReachedErrorQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StoreCartDiscountsLimitReachedErrorQueryBuilderDsl> Stores()
        {
            return new CollectionPredicateBuilder<StoreCartDiscountsLimitReachedErrorQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stores")),
                    p => new CombinationQueryPredicate<StoreCartDiscountsLimitReachedErrorQueryBuilderDsl>(p, StoreCartDiscountsLimitReachedErrorQueryBuilderDsl.Of));
        }

    }
}
