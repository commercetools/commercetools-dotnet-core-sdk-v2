using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategorySetStoresWithDescendantsActionQueryBuilderDsl
    {
        public CategorySetStoresWithDescendantsActionQueryBuilderDsl()
        {
        }

        public static CategorySetStoresWithDescendantsActionQueryBuilderDsl Of()
        {
            return new CategorySetStoresWithDescendantsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategorySetStoresWithDescendantsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategorySetStoresWithDescendantsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategorySetStoresWithDescendantsActionQueryBuilderDsl>(p, CategorySetStoresWithDescendantsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CategorySetStoresWithDescendantsActionQueryBuilderDsl> Stores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategorySetStoresWithDescendantsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                CategorySetStoresWithDescendantsActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CategorySetStoresWithDescendantsActionQueryBuilderDsl> Stores()
        {
            return new CollectionPredicateBuilder<CategorySetStoresWithDescendantsActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stores")),
                    p => new CombinationQueryPredicate<CategorySetStoresWithDescendantsActionQueryBuilderDsl>(p, CategorySetStoresWithDescendantsActionQueryBuilderDsl.Of));
        }

    }
}
