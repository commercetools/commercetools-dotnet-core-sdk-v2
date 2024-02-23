using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class PriceTierQueryBuilderDsl
    {
        public PriceTierQueryBuilderDsl()
        {
        }

        public static PriceTierQueryBuilderDsl Of()
        {
            return new PriceTierQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PriceTierQueryBuilderDsl, long> MinimumQuantity()
        {
            return new ComparisonPredicateBuilder<PriceTierQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("minimumQuantity")),
            p => new CombinationQueryPredicate<PriceTierQueryBuilderDsl>(p, PriceTierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PriceTierQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PriceTierQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.TypedMoneyQueryBuilderDsl.Of())),
                PriceTierQueryBuilderDsl.Of);
        }


    }
}
