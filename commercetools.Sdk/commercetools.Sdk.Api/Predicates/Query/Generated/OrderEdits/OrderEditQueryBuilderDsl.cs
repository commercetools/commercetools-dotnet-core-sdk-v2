using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class OrderEditQueryBuilderDsl
    {
        public OrderEditQueryBuilderDsl()
        {
        }

        public static OrderEditQueryBuilderDsl Of()
        {
            return new OrderEditQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderEditQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<OrderEditQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<OrderEditQueryBuilderDsl>(p, OrderEditQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderEditQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<OrderEditQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<OrderEditQueryBuilderDsl>(p, OrderEditQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderEditQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<OrderEditQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<OrderEditQueryBuilderDsl>(p, OrderEditQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderEditQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<OrderEditQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<OrderEditQueryBuilderDsl>(p, OrderEditQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderEditQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<OrderEditQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<OrderEditQueryBuilderDsl>(p, OrderEditQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderEditQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl.Of())),
                OrderEditQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderEditQueryBuilderDsl> StagedActions(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.StagedOrderUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.StagedOrderUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stagedActions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.StagedOrderUpdateActionQueryBuilderDsl.Of())),
                OrderEditQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderEditQueryBuilderDsl> StagedActions()
        {
            return new CollectionPredicateBuilder<OrderEditQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stagedActions")),
                    p => new CombinationQueryPredicate<OrderEditQueryBuilderDsl>(p, OrderEditQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<OrderEditQueryBuilderDsl> Result(
            Func<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditResultQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditResultQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("result"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.OrderEdits.OrderEditResultQueryBuilderDsl.Of())),
                OrderEditQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderEditQueryBuilderDsl, string> Comment()
        {
            return new ComparisonPredicateBuilder<OrderEditQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("comment")),
            p => new CombinationQueryPredicate<OrderEditQueryBuilderDsl>(p, OrderEditQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderEditQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                OrderEditQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderEditQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                OrderEditQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderEditQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                OrderEditQueryBuilderDsl.Of);
        }


    }
}
