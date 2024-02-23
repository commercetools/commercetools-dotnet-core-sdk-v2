using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StandalonePrices
{

    public partial class StandalonePriceAddPriceTierActionQueryBuilderDsl
    {
        public StandalonePriceAddPriceTierActionQueryBuilderDsl()
        {
        }

        public static StandalonePriceAddPriceTierActionQueryBuilderDsl Of()
        {
            return new StandalonePriceAddPriceTierActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceAddPriceTierActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StandalonePriceAddPriceTierActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StandalonePriceAddPriceTierActionQueryBuilderDsl>(p, StandalonePriceAddPriceTierActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StandalonePriceAddPriceTierActionQueryBuilderDsl> Tier(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.PriceTierDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.PriceTierDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StandalonePriceAddPriceTierActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("tier"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.PriceTierDraftQueryBuilderDsl.Of())),
                StandalonePriceAddPriceTierActionQueryBuilderDsl.Of);
        }


    }
}
