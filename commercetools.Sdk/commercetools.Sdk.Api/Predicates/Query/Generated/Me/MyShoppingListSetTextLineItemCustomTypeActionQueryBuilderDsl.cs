using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl
    {
        public MyShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl()
        {
        }

        public static MyShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl Of()
        {
            return new MyShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl>(p, MyShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl, string> TextLineItemId()
        {
            return new ComparisonPredicateBuilder<MyShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("textLineItemId")),
            p => new CombinationQueryPredicate<MyShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl>(p, MyShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl, string> TextLineItemKey()
        {
            return new ComparisonPredicateBuilder<MyShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("textLineItemKey")),
            p => new CombinationQueryPredicate<MyShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl>(p, MyShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl> Type(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("type"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeResourceIdentifierQueryBuilderDsl.Of())),
                MyShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<MyShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl> Fields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("fields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.FieldContainerQueryBuilderDsl.Of())),
                MyShoppingListSetTextLineItemCustomTypeActionQueryBuilderDsl.Of);
        }


    }
}
