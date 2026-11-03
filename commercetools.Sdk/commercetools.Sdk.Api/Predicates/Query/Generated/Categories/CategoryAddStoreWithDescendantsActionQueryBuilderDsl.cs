using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategoryAddStoreWithDescendantsActionQueryBuilderDsl
    {
        public CategoryAddStoreWithDescendantsActionQueryBuilderDsl()
        {
        }

        public static CategoryAddStoreWithDescendantsActionQueryBuilderDsl Of()
        {
            return new CategoryAddStoreWithDescendantsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategoryAddStoreWithDescendantsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategoryAddStoreWithDescendantsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategoryAddStoreWithDescendantsActionQueryBuilderDsl>(p, CategoryAddStoreWithDescendantsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CategoryAddStoreWithDescendantsActionQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryAddStoreWithDescendantsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                CategoryAddStoreWithDescendantsActionQueryBuilderDsl.Of);
        }


    }
}
