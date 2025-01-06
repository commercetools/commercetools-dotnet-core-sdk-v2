using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class PatternComponentQueryBuilderDsl
    {
        public PatternComponentQueryBuilderDsl()
        {
        }

        public static PatternComponentQueryBuilderDsl Of()
        {
            return new PatternComponentQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PatternComponentQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PatternComponentQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PatternComponentQueryBuilderDsl>(p, PatternComponentQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<PatternComponentQueryBuilderDsl> AsCountOnCustomLineItemUnits(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CountOnCustomLineItemUnitsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CountOnCustomLineItemUnitsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PatternComponentQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CountOnCustomLineItemUnitsQueryBuilderDsl.Of()),
                PatternComponentQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<PatternComponentQueryBuilderDsl> AsCountOnLineItemUnits(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CountOnLineItemUnitsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CountOnLineItemUnitsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PatternComponentQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CountOnLineItemUnitsQueryBuilderDsl.Of()),
                PatternComponentQueryBuilderDsl.Of);
        }
    }
}
