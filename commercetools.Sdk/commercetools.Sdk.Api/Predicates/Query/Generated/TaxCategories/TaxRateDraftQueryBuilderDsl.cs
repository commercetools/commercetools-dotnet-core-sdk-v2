using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.TaxCategories
{

    public partial class TaxRateDraftQueryBuilderDsl
    {
        public TaxRateDraftQueryBuilderDsl()
        {
        }

        public static TaxRateDraftQueryBuilderDsl Of()
        {
            return new TaxRateDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TaxRateDraftQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<TaxRateDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<TaxRateDraftQueryBuilderDsl>(p, TaxRateDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxRateDraftQueryBuilderDsl, decimal> Amount()
        {
            return new ComparisonPredicateBuilder<TaxRateDraftQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("amount")),
            p => new CombinationQueryPredicate<TaxRateDraftQueryBuilderDsl>(p, TaxRateDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxRateDraftQueryBuilderDsl, bool> IncludedInPrice()
        {
            return new ComparisonPredicateBuilder<TaxRateDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("includedInPrice")),
            p => new CombinationQueryPredicate<TaxRateDraftQueryBuilderDsl>(p, TaxRateDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxRateDraftQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<TaxRateDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<TaxRateDraftQueryBuilderDsl>(p, TaxRateDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxRateDraftQueryBuilderDsl, string> State()
        {
            return new ComparisonPredicateBuilder<TaxRateDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
            p => new CombinationQueryPredicate<TaxRateDraftQueryBuilderDsl>(p, TaxRateDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TaxRateDraftQueryBuilderDsl> SubRates(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.SubRateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.SubRateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxRateDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("subRates"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.SubRateQueryBuilderDsl.Of())),
                TaxRateDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<TaxRateDraftQueryBuilderDsl> SubRates()
        {
            return new CollectionPredicateBuilder<TaxRateDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("subRates")),
                    p => new CombinationQueryPredicate<TaxRateDraftQueryBuilderDsl>(p, TaxRateDraftQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<TaxRateDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<TaxRateDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<TaxRateDraftQueryBuilderDsl>(p, TaxRateDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
