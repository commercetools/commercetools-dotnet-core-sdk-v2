using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class TypedMoneyDraftQueryBuilderDsl
    {
        public TypedMoneyDraftQueryBuilderDsl()
        {
        }

        public static TypedMoneyDraftQueryBuilderDsl Of()
        {
            return new TypedMoneyDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TypedMoneyDraftQueryBuilderDsl, long> CentAmount()
        {
            return new ComparisonPredicateBuilder<TypedMoneyDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("centAmount")),
            p => new CombinationQueryPredicate<TypedMoneyDraftQueryBuilderDsl>(p, TypedMoneyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TypedMoneyDraftQueryBuilderDsl, string> CurrencyCode()
        {
            return new ComparisonPredicateBuilder<TypedMoneyDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("currencyCode")),
            p => new CombinationQueryPredicate<TypedMoneyDraftQueryBuilderDsl>(p, TypedMoneyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TypedMoneyDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<TypedMoneyDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<TypedMoneyDraftQueryBuilderDsl>(p, TypedMoneyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TypedMoneyDraftQueryBuilderDsl, long> FractionDigits()
        {
            return new ComparisonPredicateBuilder<TypedMoneyDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("fractionDigits")),
            p => new CombinationQueryPredicate<TypedMoneyDraftQueryBuilderDsl>(p, TypedMoneyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<TypedMoneyDraftQueryBuilderDsl> AsCentPrecision(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypedMoneyDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyDraftQueryBuilderDsl.Of()),
                TypedMoneyDraftQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<TypedMoneyDraftQueryBuilderDsl> AsHighPrecision(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.HighPrecisionMoneyDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.HighPrecisionMoneyDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypedMoneyDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.HighPrecisionMoneyDraftQueryBuilderDsl.Of()),
                TypedMoneyDraftQueryBuilderDsl.Of);
        }
    }
}
