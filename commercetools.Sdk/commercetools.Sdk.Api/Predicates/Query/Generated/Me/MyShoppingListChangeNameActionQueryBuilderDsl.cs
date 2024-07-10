using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyShoppingListChangeNameActionQueryBuilderDsl
    {
        public MyShoppingListChangeNameActionQueryBuilderDsl()
        {
        }

        public static MyShoppingListChangeNameActionQueryBuilderDsl Of()
        {
            return new MyShoppingListChangeNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyShoppingListChangeNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyShoppingListChangeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyShoppingListChangeNameActionQueryBuilderDsl>(p, MyShoppingListChangeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyShoppingListChangeNameActionQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListChangeNameActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                MyShoppingListChangeNameActionQueryBuilderDsl.Of);
        }


    }
}
