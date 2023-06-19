using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.TaxCategories
{

    public partial class TaxRateQueryBuilderDsl
    {
        public TaxRateQueryBuilderDsl()
        {
        }

        public static TaxRateQueryBuilderDsl Of()
        {
            return new TaxRateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TaxRateQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<TaxRateQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<TaxRateQueryBuilderDsl>(p, TaxRateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxRateQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<TaxRateQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<TaxRateQueryBuilderDsl>(p, TaxRateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxRateQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<TaxRateQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<TaxRateQueryBuilderDsl>(p, TaxRateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxRateQueryBuilderDsl, decimal> Amount()
        {
            return new ComparisonPredicateBuilder<TaxRateQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("amount")),
            p => new CombinationQueryPredicate<TaxRateQueryBuilderDsl>(p, TaxRateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxRateQueryBuilderDsl, bool> IncludedInPrice()
        {
            return new ComparisonPredicateBuilder<TaxRateQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("includedInPrice")),
            p => new CombinationQueryPredicate<TaxRateQueryBuilderDsl>(p, TaxRateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxRateQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<TaxRateQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<TaxRateQueryBuilderDsl>(p, TaxRateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TaxRateQueryBuilderDsl, string> State()
        {
            return new ComparisonPredicateBuilder<TaxRateQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
            p => new CombinationQueryPredicate<TaxRateQueryBuilderDsl>(p, TaxRateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TaxRateQueryBuilderDsl> SubRates(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.SubRateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.SubRateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TaxRateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("subRates"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.SubRateQueryBuilderDsl.Of())),
                TaxRateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<TaxRateQueryBuilderDsl> SubRates()
        {
            return new CollectionPredicateBuilder<TaxRateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("subRates")),
                    p => new CombinationQueryPredicate<TaxRateQueryBuilderDsl>(p, TaxRateQueryBuilderDsl.Of));
        }

    }
}
