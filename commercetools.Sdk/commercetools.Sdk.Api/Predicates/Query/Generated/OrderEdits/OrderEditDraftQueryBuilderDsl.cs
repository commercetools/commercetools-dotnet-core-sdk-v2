using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class OrderEditDraftQueryBuilderDsl
    {
        public OrderEditDraftQueryBuilderDsl()
        {
        }

        public static OrderEditDraftQueryBuilderDsl Of()
        {
            return new OrderEditDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderEditDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<OrderEditDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<OrderEditDraftQueryBuilderDsl>(p, OrderEditDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderEditDraftQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderReferenceQueryBuilderDsl.Of())),
                OrderEditDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderEditDraftQueryBuilderDsl> StagedActions(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.StagedOrderUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.StagedOrderUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stagedActions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.StagedOrderUpdateActionQueryBuilderDsl.Of())),
                OrderEditDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<OrderEditDraftQueryBuilderDsl> StagedActions()
        {
            return new CollectionPredicateBuilder<OrderEditDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stagedActions")),
                    p => new CombinationQueryPredicate<OrderEditDraftQueryBuilderDsl>(p, OrderEditDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<OrderEditDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderEditDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                OrderEditDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderEditDraftQueryBuilderDsl, string> Comment()
        {
            return new ComparisonPredicateBuilder<OrderEditDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("comment")),
            p => new CombinationQueryPredicate<OrderEditDraftQueryBuilderDsl>(p, OrderEditDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderEditDraftQueryBuilderDsl, bool> DryRun()
        {
            return new ComparisonPredicateBuilder<OrderEditDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("dryRun")),
            p => new CombinationQueryPredicate<OrderEditDraftQueryBuilderDsl>(p, OrderEditDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
