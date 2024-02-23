using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class OrderEditResultQueryBuilderDsl
    {
        public OrderEditResultQueryBuilderDsl()
        {
        }

        public static OrderEditResultQueryBuilderDsl Of()
        {
            return new OrderEditResultQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderEditResultQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderEditResultQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderEditResultQueryBuilderDsl>(p, OrderEditResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<OrderEditResultQueryBuilderDsl> AsApplied(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditAppliedQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditAppliedQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditResultQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditAppliedQueryBuilderDsl.Of()),
                OrderEditResultQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderEditResultQueryBuilderDsl> AsNotProcessed(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditNotProcessedQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditNotProcessedQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditResultQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditNotProcessedQueryBuilderDsl.Of()),
                OrderEditResultQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderEditResultQueryBuilderDsl> AsPreviewFailure(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditPreviewFailureQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditPreviewFailureQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditResultQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditPreviewFailureQueryBuilderDsl.Of()),
                OrderEditResultQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderEditResultQueryBuilderDsl> AsPreviewSuccess(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditPreviewSuccessQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditPreviewSuccessQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditResultQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditPreviewSuccessQueryBuilderDsl.Of()),
                OrderEditResultQueryBuilderDsl.Of);
        }
    }
}
