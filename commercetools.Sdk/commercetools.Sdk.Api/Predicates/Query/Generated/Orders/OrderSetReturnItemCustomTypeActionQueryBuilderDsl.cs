using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetReturnItemCustomTypeActionQueryBuilderDsl
    {
        public OrderSetReturnItemCustomTypeActionQueryBuilderDsl()
        {
        }

        public static OrderSetReturnItemCustomTypeActionQueryBuilderDsl Of()
        {
            return new OrderSetReturnItemCustomTypeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetReturnItemCustomTypeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetReturnItemCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetReturnItemCustomTypeActionQueryBuilderDsl>(p, OrderSetReturnItemCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetReturnItemCustomTypeActionQueryBuilderDsl, string> ReturnItemId()
        {
            return new ComparisonPredicateBuilder<OrderSetReturnItemCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnItemId")),
            p => new CombinationQueryPredicate<OrderSetReturnItemCustomTypeActionQueryBuilderDsl>(p, OrderSetReturnItemCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetReturnItemCustomTypeActionQueryBuilderDsl, string> ReturnItemKey()
        {
            return new ComparisonPredicateBuilder<OrderSetReturnItemCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnItemKey")),
            p => new CombinationQueryPredicate<OrderSetReturnItemCustomTypeActionQueryBuilderDsl>(p, OrderSetReturnItemCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderSetReturnItemCustomTypeActionQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSetReturnItemCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl.Of())),
                OrderSetReturnItemCustomTypeActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderSetReturnItemCustomTypeActionQueryBuilderDsl> Fields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSetReturnItemCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl.Of())),
                OrderSetReturnItemCustomTypeActionQueryBuilderDsl.Of);
        }


    }
}
