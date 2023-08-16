using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyShoppingListChangeTextLineItemNameActionQueryBuilderDsl
    {
        public MyShoppingListChangeTextLineItemNameActionQueryBuilderDsl()
        {
        }

        public static MyShoppingListChangeTextLineItemNameActionQueryBuilderDsl Of()
        {
            return new MyShoppingListChangeTextLineItemNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyShoppingListChangeTextLineItemNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyShoppingListChangeTextLineItemNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyShoppingListChangeTextLineItemNameActionQueryBuilderDsl>(p, MyShoppingListChangeTextLineItemNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListChangeTextLineItemNameActionQueryBuilderDsl, string> TextLineItemId()
        {
            return new ComparisonPredicateBuilder<MyShoppingListChangeTextLineItemNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("textLineItemId")),
            p => new CombinationQueryPredicate<MyShoppingListChangeTextLineItemNameActionQueryBuilderDsl>(p, MyShoppingListChangeTextLineItemNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListChangeTextLineItemNameActionQueryBuilderDsl, string> TextLineItemKey()
        {
            return new ComparisonPredicateBuilder<MyShoppingListChangeTextLineItemNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("textLineItemKey")),
            p => new CombinationQueryPredicate<MyShoppingListChangeTextLineItemNameActionQueryBuilderDsl>(p, MyShoppingListChangeTextLineItemNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyShoppingListChangeTextLineItemNameActionQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListChangeTextLineItemNameActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                MyShoppingListChangeTextLineItemNameActionQueryBuilderDsl.Of);
        }


    }
}
