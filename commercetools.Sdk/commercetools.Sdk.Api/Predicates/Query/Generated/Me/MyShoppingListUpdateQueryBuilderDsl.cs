using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyShoppingListUpdateQueryBuilderDsl
    {
        public MyShoppingListUpdateQueryBuilderDsl()
        {
        }

        public static MyShoppingListUpdateQueryBuilderDsl Of()
        {
            return new MyShoppingListUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyShoppingListUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<MyShoppingListUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<MyShoppingListUpdateQueryBuilderDsl>(p, MyShoppingListUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyShoppingListUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyShoppingListUpdateActionQueryBuilderDsl.Of())),
                MyShoppingListUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<MyShoppingListUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<MyShoppingListUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<MyShoppingListUpdateQueryBuilderDsl>(p, MyShoppingListUpdateQueryBuilderDsl.Of));
        }

    }
}
