using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class OrderEditAppliedQueryBuilderDsl
    {
        public OrderEditAppliedQueryBuilderDsl()
        {
        }

        public static OrderEditAppliedQueryBuilderDsl Of()
        {
            return new OrderEditAppliedQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderEditAppliedQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderEditAppliedQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderEditAppliedQueryBuilderDsl>(p, OrderEditAppliedQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderEditAppliedQueryBuilderDsl, DateTime> AppliedAt()
        {
            return new ComparisonPredicateBuilder<OrderEditAppliedQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("appliedAt")),
            p => new CombinationQueryPredicate<OrderEditAppliedQueryBuilderDsl>(p, OrderEditAppliedQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderEditAppliedQueryBuilderDsl> ExcerptBeforeEdit(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderExcerptQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderExcerptQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditAppliedQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("excerptBeforeEdit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderExcerptQueryBuilderDsl.Of())),
                OrderEditAppliedQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderEditAppliedQueryBuilderDsl> ExcerptAfterEdit(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderExcerptQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderExcerptQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditAppliedQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("excerptAfterEdit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderExcerptQueryBuilderDsl.Of())),
                OrderEditAppliedQueryBuilderDsl.Of);
        }


    }
}
