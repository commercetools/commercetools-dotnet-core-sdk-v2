using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl
    {
        public MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl()
        {
        }

        public static MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl Of()
        {
            return new MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl>(p, MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl, string> TextLineItemId()
        {
            return new ComparisonPredicateBuilder<MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("textLineItemId")),
            p => new CombinationQueryPredicate<MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl>(p, MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl, string> TextLineItemKey()
        {
            return new ComparisonPredicateBuilder<MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("textLineItemKey")),
            p => new CombinationQueryPredicate<MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl>(p, MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl>(p, MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl>(p, MyShoppingListSetTextLineItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
