using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class HighPrecisionMoneyQueryBuilderDsl
    {
        public HighPrecisionMoneyQueryBuilderDsl()
        {
        }

        public static HighPrecisionMoneyQueryBuilderDsl Of()
        {
            return new HighPrecisionMoneyQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<HighPrecisionMoneyQueryBuilderDsl, long> CentAmount()
        {
            return new ComparisonPredicateBuilder<HighPrecisionMoneyQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("centAmount")),
            p => new CombinationQueryPredicate<HighPrecisionMoneyQueryBuilderDsl>(p, HighPrecisionMoneyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<HighPrecisionMoneyQueryBuilderDsl, string> CurrencyCode()
        {
            return new ComparisonPredicateBuilder<HighPrecisionMoneyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currencyCode")),
            p => new CombinationQueryPredicate<HighPrecisionMoneyQueryBuilderDsl>(p, HighPrecisionMoneyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<HighPrecisionMoneyQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<HighPrecisionMoneyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<HighPrecisionMoneyQueryBuilderDsl>(p, HighPrecisionMoneyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<HighPrecisionMoneyQueryBuilderDsl, long> FractionDigits()
        {
            return new ComparisonPredicateBuilder<HighPrecisionMoneyQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fractionDigits")),
            p => new CombinationQueryPredicate<HighPrecisionMoneyQueryBuilderDsl>(p, HighPrecisionMoneyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<HighPrecisionMoneyQueryBuilderDsl, long> PreciseAmount()
        {
            return new ComparisonPredicateBuilder<HighPrecisionMoneyQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("preciseAmount")),
            p => new CombinationQueryPredicate<HighPrecisionMoneyQueryBuilderDsl>(p, HighPrecisionMoneyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
