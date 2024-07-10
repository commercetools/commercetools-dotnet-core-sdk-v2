using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class ExternalTaxRateDraftQueryBuilderDsl
    {
        public ExternalTaxRateDraftQueryBuilderDsl()
        {
        }

        public static ExternalTaxRateDraftQueryBuilderDsl Of()
        {
            return new ExternalTaxRateDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExternalTaxRateDraftQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ExternalTaxRateDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ExternalTaxRateDraftQueryBuilderDsl>(p, ExternalTaxRateDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExternalTaxRateDraftQueryBuilderDsl, decimal> Amount()
        {
            return new ComparisonPredicateBuilder<ExternalTaxRateDraftQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("amount")),
            p => new CombinationQueryPredicate<ExternalTaxRateDraftQueryBuilderDsl>(p, ExternalTaxRateDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExternalTaxRateDraftQueryBuilderDsl, bool> IncludedInPrice()
        {
            return new ComparisonPredicateBuilder<ExternalTaxRateDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("includedInPrice")),
            p => new CombinationQueryPredicate<ExternalTaxRateDraftQueryBuilderDsl>(p, ExternalTaxRateDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExternalTaxRateDraftQueryBuilderDsl, string> Country()
        {
            return new ComparisonPredicateBuilder<ExternalTaxRateDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("country")),
            p => new CombinationQueryPredicate<ExternalTaxRateDraftQueryBuilderDsl>(p, ExternalTaxRateDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExternalTaxRateDraftQueryBuilderDsl, string> State()
        {
            return new ComparisonPredicateBuilder<ExternalTaxRateDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
            p => new CombinationQueryPredicate<ExternalTaxRateDraftQueryBuilderDsl>(p, ExternalTaxRateDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ExternalTaxRateDraftQueryBuilderDsl> SubRates(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.SubRateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.SubRateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExternalTaxRateDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("subRates"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.SubRateQueryBuilderDsl.Of())),
                ExternalTaxRateDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ExternalTaxRateDraftQueryBuilderDsl> SubRates()
        {
            return new CollectionPredicateBuilder<ExternalTaxRateDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("subRates")),
                    p => new CombinationQueryPredicate<ExternalTaxRateDraftQueryBuilderDsl>(p, ExternalTaxRateDraftQueryBuilderDsl.Of));
        }

    }
}
