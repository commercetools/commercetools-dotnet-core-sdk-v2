using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StandalonePrices
{

    public partial class StandalonePriceChangeValueActionQueryBuilderDsl
    {
        public StandalonePriceChangeValueActionQueryBuilderDsl()
        {
        }

        public static StandalonePriceChangeValueActionQueryBuilderDsl Of()
        {
            return new StandalonePriceChangeValueActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceChangeValueActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StandalonePriceChangeValueActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StandalonePriceChangeValueActionQueryBuilderDsl>(p, StandalonePriceChangeValueActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceChangeValueActionQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceChangeValueActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                StandalonePriceChangeValueActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StandalonePriceChangeValueActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<StandalonePriceChangeValueActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<StandalonePriceChangeValueActionQueryBuilderDsl>(p, StandalonePriceChangeValueActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
