// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class CentPrecisionMoneyQueryBuilderDsl
    {
        public CentPrecisionMoneyQueryBuilderDsl()
        {
        }

        public static CentPrecisionMoneyQueryBuilderDsl Of()
        {
            return new CentPrecisionMoneyQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CentPrecisionMoneyQueryBuilderDsl, long> CentAmount()
        {
            return new ComparisonPredicateBuilder<CentPrecisionMoneyQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("centAmount")),
            p => new CombinationQueryPredicate<CentPrecisionMoneyQueryBuilderDsl>(p, CentPrecisionMoneyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CentPrecisionMoneyQueryBuilderDsl, string> CurrencyCode()
        {
            return new ComparisonPredicateBuilder<CentPrecisionMoneyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currencyCode")),
            p => new CombinationQueryPredicate<CentPrecisionMoneyQueryBuilderDsl>(p, CentPrecisionMoneyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CentPrecisionMoneyQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CentPrecisionMoneyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CentPrecisionMoneyQueryBuilderDsl>(p, CentPrecisionMoneyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CentPrecisionMoneyQueryBuilderDsl, long> FractionDigits()
        {
            return new ComparisonPredicateBuilder<CentPrecisionMoneyQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fractionDigits")),
            p => new CombinationQueryPredicate<CentPrecisionMoneyQueryBuilderDsl>(p, CentPrecisionMoneyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
