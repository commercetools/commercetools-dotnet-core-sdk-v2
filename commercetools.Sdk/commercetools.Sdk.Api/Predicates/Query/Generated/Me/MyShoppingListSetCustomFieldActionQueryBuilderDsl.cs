using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyShoppingListSetCustomFieldActionQueryBuilderDsl
    {
        public MyShoppingListSetCustomFieldActionQueryBuilderDsl()
        {
        }

        public static MyShoppingListSetCustomFieldActionQueryBuilderDsl Of()
        {
            return new MyShoppingListSetCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyShoppingListSetCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyShoppingListSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyShoppingListSetCustomFieldActionQueryBuilderDsl>(p, MyShoppingListSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListSetCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<MyShoppingListSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<MyShoppingListSetCustomFieldActionQueryBuilderDsl>(p, MyShoppingListSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListSetCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<MyShoppingListSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<MyShoppingListSetCustomFieldActionQueryBuilderDsl>(p, MyShoppingListSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
