using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.TaxCategories
{

    public partial class TaxCategoryDraftQueryBuilderDsl
    {
        public TaxCategoryDraftQueryBuilderDsl()
        {
        }

        public static TaxCategoryDraftQueryBuilderDsl Of()
        {
            return new TaxCategoryDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TaxCategoryDraftQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<TaxCategoryDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<TaxCategoryDraftQueryBuilderDsl>(p, TaxCategoryDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxCategoryDraftQueryBuilderDsl, string> Description()
        {
            return new ComparisonPredicateBuilder<TaxCategoryDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("description")),
            p => new CombinationQueryPredicate<TaxCategoryDraftQueryBuilderDsl>(p, TaxCategoryDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TaxCategoryDraftQueryBuilderDsl> Rates(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxCategoryDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("rates"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateDraftQueryBuilderDsl.Of())),
                TaxCategoryDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<TaxCategoryDraftQueryBuilderDsl> Rates()
        {
            return new CollectionPredicateBuilder<TaxCategoryDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("rates")),
                    p => new CombinationQueryPredicate<TaxCategoryDraftQueryBuilderDsl>(p, TaxCategoryDraftQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<TaxCategoryDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<TaxCategoryDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<TaxCategoryDraftQueryBuilderDsl>(p, TaxCategoryDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
