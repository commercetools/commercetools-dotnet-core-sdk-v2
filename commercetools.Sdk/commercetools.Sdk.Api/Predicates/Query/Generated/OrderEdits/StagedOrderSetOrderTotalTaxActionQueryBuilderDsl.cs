using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetOrderTotalTaxActionQueryBuilderDsl
    {
        public StagedOrderSetOrderTotalTaxActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetOrderTotalTaxActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetOrderTotalTaxActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetOrderTotalTaxActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetOrderTotalTaxActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetOrderTotalTaxActionQueryBuilderDsl>(p, StagedOrderSetOrderTotalTaxActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderSetOrderTotalTaxActionQueryBuilderDsl> ExternalTotalGross(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetOrderTotalTaxActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTotalGross"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                StagedOrderSetOrderTotalTaxActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedOrderSetOrderTotalTaxActionQueryBuilderDsl> ExternalTaxPortions(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.TaxPortionDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.TaxPortionDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetOrderTotalTaxActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalTaxPortions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.TaxPortionDraftQueryBuilderDsl.Of())),
                StagedOrderSetOrderTotalTaxActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StagedOrderSetOrderTotalTaxActionQueryBuilderDsl> ExternalTaxPortions()
        {
            return new CollectionPredicateBuilder<StagedOrderSetOrderTotalTaxActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("externalTaxPortions")),
                    p => new CombinationQueryPredicate<StagedOrderSetOrderTotalTaxActionQueryBuilderDsl>(p, StagedOrderSetOrderTotalTaxActionQueryBuilderDsl.Of));
        }

    }
}
