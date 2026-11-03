using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategoryRemoveStoreWithDescendantsActionQueryBuilderDsl
    {
        public CategoryRemoveStoreWithDescendantsActionQueryBuilderDsl()
        {
        }

        public static CategoryRemoveStoreWithDescendantsActionQueryBuilderDsl Of()
        {
            return new CategoryRemoveStoreWithDescendantsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategoryRemoveStoreWithDescendantsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategoryRemoveStoreWithDescendantsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategoryRemoveStoreWithDescendantsActionQueryBuilderDsl>(p, CategoryRemoveStoreWithDescendantsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CategoryRemoveStoreWithDescendantsActionQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryRemoveStoreWithDescendantsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                CategoryRemoveStoreWithDescendantsActionQueryBuilderDsl.Of);
        }


    }
}
