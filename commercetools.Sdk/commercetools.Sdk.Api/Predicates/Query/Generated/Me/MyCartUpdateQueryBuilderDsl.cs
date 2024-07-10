using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartUpdateQueryBuilderDsl
    {
        public MyCartUpdateQueryBuilderDsl()
        {
        }

        public static MyCartUpdateQueryBuilderDsl Of()
        {
            return new MyCartUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<MyCartUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<MyCartUpdateQueryBuilderDsl>(p, MyCartUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyCartUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCartUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCartUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCartUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCartUpdateActionQueryBuilderDsl.Of())),
                MyCartUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<MyCartUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<MyCartUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<MyCartUpdateQueryBuilderDsl>(p, MyCartUpdateQueryBuilderDsl.Of));
        }

    }
}
