using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.TaxCategories
{

    public partial class TaxCategoryQueryBuilderDsl
    {
        public TaxCategoryQueryBuilderDsl()
        {
        }

        public static TaxCategoryQueryBuilderDsl Of()
        {
            return new TaxCategoryQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TaxCategoryQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<TaxCategoryQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<TaxCategoryQueryBuilderDsl>(p, TaxCategoryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxCategoryQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<TaxCategoryQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<TaxCategoryQueryBuilderDsl>(p, TaxCategoryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxCategoryQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<TaxCategoryQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<TaxCategoryQueryBuilderDsl>(p, TaxCategoryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxCategoryQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<TaxCategoryQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<TaxCategoryQueryBuilderDsl>(p, TaxCategoryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TaxCategoryQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxCategoryQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                TaxCategoryQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<TaxCategoryQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxCategoryQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                TaxCategoryQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<TaxCategoryQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<TaxCategoryQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<TaxCategoryQueryBuilderDsl>(p, TaxCategoryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxCategoryQueryBuilderDsl, string> Description()
        {
            return new ComparisonPredicateBuilder<TaxCategoryQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("description")),
            p => new CombinationQueryPredicate<TaxCategoryQueryBuilderDsl>(p, TaxCategoryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TaxCategoryQueryBuilderDsl> Rates(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxCategoryQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("rates"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxRateQueryBuilderDsl.Of())),
                TaxCategoryQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<TaxCategoryQueryBuilderDsl> Rates()
        {
            return new CollectionPredicateBuilder<TaxCategoryQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("rates")),
                    p => new CombinationQueryPredicate<TaxCategoryQueryBuilderDsl>(p, TaxCategoryQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<TaxCategoryQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<TaxCategoryQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<TaxCategoryQueryBuilderDsl>(p, TaxCategoryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
