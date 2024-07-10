using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyShoppingListSetLineItemCustomTypeActionQueryBuilderDsl
    {
        public MyShoppingListSetLineItemCustomTypeActionQueryBuilderDsl()
        {
        }

        public static MyShoppingListSetLineItemCustomTypeActionQueryBuilderDsl Of()
        {
            return new MyShoppingListSetLineItemCustomTypeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyShoppingListSetLineItemCustomTypeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyShoppingListSetLineItemCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyShoppingListSetLineItemCustomTypeActionQueryBuilderDsl>(p, MyShoppingListSetLineItemCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListSetLineItemCustomTypeActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<MyShoppingListSetLineItemCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<MyShoppingListSetLineItemCustomTypeActionQueryBuilderDsl>(p, MyShoppingListSetLineItemCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyShoppingListSetLineItemCustomTypeActionQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListSetLineItemCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl.Of())),
                MyShoppingListSetLineItemCustomTypeActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<MyShoppingListSetLineItemCustomTypeActionQueryBuilderDsl> Fields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListSetLineItemCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl.Of())),
                MyShoppingListSetLineItemCustomTypeActionQueryBuilderDsl.Of);
        }


    }
}
