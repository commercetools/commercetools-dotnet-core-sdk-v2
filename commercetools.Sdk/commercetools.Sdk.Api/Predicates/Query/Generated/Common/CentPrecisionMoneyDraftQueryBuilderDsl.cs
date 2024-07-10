// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class CentPrecisionMoneyDraftQueryBuilderDsl
    {
        public CentPrecisionMoneyDraftQueryBuilderDsl()
        {
        }

        public static CentPrecisionMoneyDraftQueryBuilderDsl Of()
        {
            return new CentPrecisionMoneyDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CentPrecisionMoneyDraftQueryBuilderDsl, long> CentAmount()
        {
            return new ComparisonPredicateBuilder<CentPrecisionMoneyDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("centAmount")),
            p => new CombinationQueryPredicate<CentPrecisionMoneyDraftQueryBuilderDsl>(p, CentPrecisionMoneyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CentPrecisionMoneyDraftQueryBuilderDsl, string> CurrencyCode()
        {
            return new ComparisonPredicateBuilder<CentPrecisionMoneyDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currencyCode")),
            p => new CombinationQueryPredicate<CentPrecisionMoneyDraftQueryBuilderDsl>(p, CentPrecisionMoneyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CentPrecisionMoneyDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CentPrecisionMoneyDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CentPrecisionMoneyDraftQueryBuilderDsl>(p, CentPrecisionMoneyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CentPrecisionMoneyDraftQueryBuilderDsl, long> FractionDigits()
        {
            return new ComparisonPredicateBuilder<CentPrecisionMoneyDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fractionDigits")),
            p => new CombinationQueryPredicate<CentPrecisionMoneyDraftQueryBuilderDsl>(p, CentPrecisionMoneyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
