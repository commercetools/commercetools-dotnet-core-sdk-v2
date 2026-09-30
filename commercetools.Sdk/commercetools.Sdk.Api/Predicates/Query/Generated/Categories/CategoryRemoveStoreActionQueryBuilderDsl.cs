using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategoryRemoveStoreActionQueryBuilderDsl
    {
        public CategoryRemoveStoreActionQueryBuilderDsl()
        {
        }

        public static CategoryRemoveStoreActionQueryBuilderDsl Of()
        {
            return new CategoryRemoveStoreActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategoryRemoveStoreActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategoryRemoveStoreActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategoryRemoveStoreActionQueryBuilderDsl>(p, CategoryRemoveStoreActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CategoryRemoveStoreActionQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryRemoveStoreActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                CategoryRemoveStoreActionQueryBuilderDsl.Of);
        }


    }
}
