// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class HighPrecisionMoneyDraftQueryBuilderDsl
    {
        public HighPrecisionMoneyDraftQueryBuilderDsl()
        {
        }

        public static HighPrecisionMoneyDraftQueryBuilderDsl Of()
        {
            return new HighPrecisionMoneyDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<HighPrecisionMoneyDraftQueryBuilderDsl, long> CentAmount()
        {
            return new ComparisonPredicateBuilder<HighPrecisionMoneyDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("centAmount")),
            p => new CombinationQueryPredicate<HighPrecisionMoneyDraftQueryBuilderDsl>(p, HighPrecisionMoneyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<HighPrecisionMoneyDraftQueryBuilderDsl, string> CurrencyCode()
        {
            return new ComparisonPredicateBuilder<HighPrecisionMoneyDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currencyCode")),
            p => new CombinationQueryPredicate<HighPrecisionMoneyDraftQueryBuilderDsl>(p, HighPrecisionMoneyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<HighPrecisionMoneyDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<HighPrecisionMoneyDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<HighPrecisionMoneyDraftQueryBuilderDsl>(p, HighPrecisionMoneyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<HighPrecisionMoneyDraftQueryBuilderDsl, long> FractionDigits()
        {
            return new ComparisonPredicateBuilder<HighPrecisionMoneyDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fractionDigits")),
            p => new CombinationQueryPredicate<HighPrecisionMoneyDraftQueryBuilderDsl>(p, HighPrecisionMoneyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<HighPrecisionMoneyDraftQueryBuilderDsl, long> PreciseAmount()
        {
            return new ComparisonPredicateBuilder<HighPrecisionMoneyDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("preciseAmount")),
            p => new CombinationQueryPredicate<HighPrecisionMoneyDraftQueryBuilderDsl>(p, HighPrecisionMoneyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
