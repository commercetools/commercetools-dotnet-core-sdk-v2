using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetPurchaseOrderNumberActionQueryBuilderDsl
    {
        public StagedOrderSetPurchaseOrderNumberActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetPurchaseOrderNumberActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetPurchaseOrderNumberActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetPurchaseOrderNumberActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetPurchaseOrderNumberActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetPurchaseOrderNumberActionQueryBuilderDsl>(p, StagedOrderSetPurchaseOrderNumberActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderSetPurchaseOrderNumberActionQueryBuilderDsl, string> PurchaseOrderNumber()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetPurchaseOrderNumberActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("purchaseOrderNumber")),
            p => new CombinationQueryPredicate<StagedOrderSetPurchaseOrderNumberActionQueryBuilderDsl>(p, StagedOrderSetPurchaseOrderNumberActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
