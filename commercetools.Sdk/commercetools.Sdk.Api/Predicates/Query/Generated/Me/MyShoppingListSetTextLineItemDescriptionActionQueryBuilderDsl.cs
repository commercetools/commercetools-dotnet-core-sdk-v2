using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl
    {
        public MyShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl()
        {
        }

        public static MyShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl Of()
        {
            return new MyShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl>(p, MyShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl, string> TextLineItemId()
        {
            return new ComparisonPredicateBuilder<MyShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("textLineItemId")),
            p => new CombinationQueryPredicate<MyShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl>(p, MyShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                MyShoppingListSetTextLineItemDescriptionActionQueryBuilderDsl.Of);
        }


    }
}
