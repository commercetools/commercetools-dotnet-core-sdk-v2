using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class TypedMoneyQueryBuilderDsl
    {
        public TypedMoneyQueryBuilderDsl()
        {
        }

        public static TypedMoneyQueryBuilderDsl Of()
        {
            return new TypedMoneyQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TypedMoneyQueryBuilderDsl, long> CentAmount()
        {
            return new ComparisonPredicateBuilder<TypedMoneyQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("centAmount")),
            p => new CombinationQueryPredicate<TypedMoneyQueryBuilderDsl>(p, TypedMoneyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TypedMoneyQueryBuilderDsl, string> CurrencyCode()
        {
            return new ComparisonPredicateBuilder<TypedMoneyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currencyCode")),
            p => new CombinationQueryPredicate<TypedMoneyQueryBuilderDsl>(p, TypedMoneyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TypedMoneyQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<TypedMoneyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<TypedMoneyQueryBuilderDsl>(p, TypedMoneyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TypedMoneyQueryBuilderDsl, long> FractionDigits()
        {
            return new ComparisonPredicateBuilder<TypedMoneyQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fractionDigits")),
            p => new CombinationQueryPredicate<TypedMoneyQueryBuilderDsl>(p, TypedMoneyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<TypedMoneyQueryBuilderDsl> AsCentPrecision(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypedMoneyQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl.Of()),
                TypedMoneyQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<TypedMoneyQueryBuilderDsl> AsHighPrecision(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.HighPrecisionMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.HighPrecisionMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypedMoneyQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.HighPrecisionMoneyQueryBuilderDsl.Of()),
                TypedMoneyQueryBuilderDsl.Of);
        }
    }
}
