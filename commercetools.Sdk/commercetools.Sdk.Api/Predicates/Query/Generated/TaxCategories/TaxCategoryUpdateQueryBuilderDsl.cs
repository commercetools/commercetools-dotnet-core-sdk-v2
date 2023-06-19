using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.TaxCategories
{

    public partial class TaxCategoryUpdateQueryBuilderDsl
    {
        public TaxCategoryUpdateQueryBuilderDsl()
        {
        }

        public static TaxCategoryUpdateQueryBuilderDsl Of()
        {
            return new TaxCategoryUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TaxCategoryUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<TaxCategoryUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<TaxCategoryUpdateQueryBuilderDsl>(p, TaxCategoryUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TaxCategoryUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxCategoryUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryUpdateActionQueryBuilderDsl.Of())),
                TaxCategoryUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<TaxCategoryUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<TaxCategoryUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<TaxCategoryUpdateQueryBuilderDsl>(p, TaxCategoryUpdateQueryBuilderDsl.Of));
        }

    }
}
