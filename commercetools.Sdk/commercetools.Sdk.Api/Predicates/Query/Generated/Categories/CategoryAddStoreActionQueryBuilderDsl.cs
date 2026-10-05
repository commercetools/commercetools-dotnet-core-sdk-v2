using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategoryAddStoreActionQueryBuilderDsl
    {
        public CategoryAddStoreActionQueryBuilderDsl()
        {
        }

        public static CategoryAddStoreActionQueryBuilderDsl Of()
        {
            return new CategoryAddStoreActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategoryAddStoreActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategoryAddStoreActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategoryAddStoreActionQueryBuilderDsl>(p, CategoryAddStoreActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CategoryAddStoreActionQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryAddStoreActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                CategoryAddStoreActionQueryBuilderDsl.Of);
        }


    }
}
