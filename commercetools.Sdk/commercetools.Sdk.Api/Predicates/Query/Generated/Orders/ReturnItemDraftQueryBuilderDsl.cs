using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class ReturnItemDraftQueryBuilderDsl
    {
        public ReturnItemDraftQueryBuilderDsl()
        {
        }

        public static ReturnItemDraftQueryBuilderDsl Of()
        {
            return new ReturnItemDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReturnItemDraftQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<ReturnItemDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<ReturnItemDraftQueryBuilderDsl>(p, ReturnItemDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReturnItemDraftQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<ReturnItemDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<ReturnItemDraftQueryBuilderDsl>(p, ReturnItemDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReturnItemDraftQueryBuilderDsl, string> CustomLineItemId()
        {
            return new ComparisonPredicateBuilder<ReturnItemDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customLineItemId")),
            p => new CombinationQueryPredicate<ReturnItemDraftQueryBuilderDsl>(p, ReturnItemDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReturnItemDraftQueryBuilderDsl, string> Comment()
        {
            return new ComparisonPredicateBuilder<ReturnItemDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("comment")),
            p => new CombinationQueryPredicate<ReturnItemDraftQueryBuilderDsl>(p, ReturnItemDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReturnItemDraftQueryBuilderDsl, string> ShipmentState()
        {
            return new ComparisonPredicateBuilder<ReturnItemDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shipmentState")),
            p => new CombinationQueryPredicate<ReturnItemDraftQueryBuilderDsl>(p, ReturnItemDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ReturnItemDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReturnItemDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                ReturnItemDraftQueryBuilderDsl.Of);
        }


    }
}
