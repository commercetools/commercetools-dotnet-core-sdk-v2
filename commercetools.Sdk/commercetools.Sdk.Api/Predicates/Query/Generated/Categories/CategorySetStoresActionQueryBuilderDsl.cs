using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategorySetStoresActionQueryBuilderDsl
    {
        public CategorySetStoresActionQueryBuilderDsl()
        {
        }

        public static CategorySetStoresActionQueryBuilderDsl Of()
        {
            return new CategorySetStoresActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategorySetStoresActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategorySetStoresActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategorySetStoresActionQueryBuilderDsl>(p, CategorySetStoresActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CategorySetStoresActionQueryBuilderDsl> Stores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategorySetStoresActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                CategorySetStoresActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CategorySetStoresActionQueryBuilderDsl> Stores()
        {
            return new CollectionPredicateBuilder<CategorySetStoresActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stores")),
                    p => new CombinationQueryPredicate<CategorySetStoresActionQueryBuilderDsl>(p, CategorySetStoresActionQueryBuilderDsl.Of));
        }

    }
}
