using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class OrderEditPreviewFailureQueryBuilderDsl
    {
        public OrderEditPreviewFailureQueryBuilderDsl()
        {
        }

        public static OrderEditPreviewFailureQueryBuilderDsl Of()
        {
            return new OrderEditPreviewFailureQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderEditPreviewFailureQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderEditPreviewFailureQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderEditPreviewFailureQueryBuilderDsl>(p, OrderEditPreviewFailureQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderEditPreviewFailureQueryBuilderDsl> Errors(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ErrorObjectQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ErrorObjectQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditPreviewFailureQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("errors"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ErrorObjectQueryBuilderDsl.Of())),
                OrderEditPreviewFailureQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderEditPreviewFailureQueryBuilderDsl> Errors()
        {
            return new CollectionPredicateBuilder<OrderEditPreviewFailureQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("errors")),
                    p => new CombinationQueryPredicate<OrderEditPreviewFailureQueryBuilderDsl>(p, OrderEditPreviewFailureQueryBuilderDsl.Of));
        }

    }
}
