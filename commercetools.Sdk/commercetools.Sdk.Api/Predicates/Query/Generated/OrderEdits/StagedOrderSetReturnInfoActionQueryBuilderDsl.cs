using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderSetReturnInfoActionQueryBuilderDsl
    {
        public StagedOrderSetReturnInfoActionQueryBuilderDsl()
        {
        }

        public static StagedOrderSetReturnInfoActionQueryBuilderDsl Of()
        {
            return new StagedOrderSetReturnInfoActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderSetReturnInfoActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderSetReturnInfoActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderSetReturnInfoActionQueryBuilderDsl>(p, StagedOrderSetReturnInfoActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderSetReturnInfoActionQueryBuilderDsl> Items(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ReturnInfoDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ReturnInfoDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderSetReturnInfoActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("items"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ReturnInfoDraftQueryBuilderDsl.Of())),
                StagedOrderSetReturnInfoActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StagedOrderSetReturnInfoActionQueryBuilderDsl> Items()
        {
            return new CollectionPredicateBuilder<StagedOrderSetReturnInfoActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("items")),
                    p => new CombinationQueryPredicate<StagedOrderSetReturnInfoActionQueryBuilderDsl>(p, StagedOrderSetReturnInfoActionQueryBuilderDsl.Of));
        }

    }
}
