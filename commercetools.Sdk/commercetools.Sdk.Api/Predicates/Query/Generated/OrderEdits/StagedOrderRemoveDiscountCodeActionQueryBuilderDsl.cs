using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderRemoveDiscountCodeActionQueryBuilderDsl
    {
        public StagedOrderRemoveDiscountCodeActionQueryBuilderDsl()
        {
        }

        public static StagedOrderRemoveDiscountCodeActionQueryBuilderDsl Of()
        {
            return new StagedOrderRemoveDiscountCodeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderRemoveDiscountCodeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderRemoveDiscountCodeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderRemoveDiscountCodeActionQueryBuilderDsl>(p, StagedOrderRemoveDiscountCodeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderRemoveDiscountCodeActionQueryBuilderDsl> DiscountCode(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderRemoveDiscountCodeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountCode"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeReferenceQueryBuilderDsl.Of())),
                StagedOrderRemoveDiscountCodeActionQueryBuilderDsl.Of);
        }


    }
}
