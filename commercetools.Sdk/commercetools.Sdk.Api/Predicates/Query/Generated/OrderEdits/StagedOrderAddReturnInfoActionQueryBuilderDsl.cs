using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderAddReturnInfoActionQueryBuilderDsl
    {
        public StagedOrderAddReturnInfoActionQueryBuilderDsl()
        {
        }

        public static StagedOrderAddReturnInfoActionQueryBuilderDsl Of()
        {
            return new StagedOrderAddReturnInfoActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderAddReturnInfoActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderAddReturnInfoActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderAddReturnInfoActionQueryBuilderDsl>(p, StagedOrderAddReturnInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderAddReturnInfoActionQueryBuilderDsl, string> ReturnTrackingId()
        {
            return new ComparisonPredicateBuilder<StagedOrderAddReturnInfoActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnTrackingId")),
            p => new CombinationQueryPredicate<StagedOrderAddReturnInfoActionQueryBuilderDsl>(p, StagedOrderAddReturnInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderAddReturnInfoActionQueryBuilderDsl> Items(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ReturnItemDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ReturnItemDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderAddReturnInfoActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("items"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ReturnItemDraftQueryBuilderDsl.Of())),
                StagedOrderAddReturnInfoActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StagedOrderAddReturnInfoActionQueryBuilderDsl> Items()
        {
            return new CollectionPredicateBuilder<StagedOrderAddReturnInfoActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("items")),
                    p => new CombinationQueryPredicate<StagedOrderAddReturnInfoActionQueryBuilderDsl>(p, StagedOrderAddReturnInfoActionQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<StagedOrderAddReturnInfoActionQueryBuilderDsl, DateTime> ReturnDate()
        {
            return new ComparisonPredicateBuilder<StagedOrderAddReturnInfoActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnDate")),
            p => new CombinationQueryPredicate<StagedOrderAddReturnInfoActionQueryBuilderDsl>(p, StagedOrderAddReturnInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
