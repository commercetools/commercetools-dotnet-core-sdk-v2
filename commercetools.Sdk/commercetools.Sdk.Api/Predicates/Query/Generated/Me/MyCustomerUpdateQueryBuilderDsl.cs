using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCustomerUpdateQueryBuilderDsl
    {
        public MyCustomerUpdateQueryBuilderDsl()
        {
        }

        public static MyCustomerUpdateQueryBuilderDsl Of()
        {
            return new MyCustomerUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<MyCustomerUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<MyCustomerUpdateQueryBuilderDsl>(p, MyCustomerUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyCustomerUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerUpdateActionQueryBuilderDsl.Of())),
                MyCustomerUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<MyCustomerUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<MyCustomerUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<MyCustomerUpdateQueryBuilderDsl>(p, MyCustomerUpdateQueryBuilderDsl.Of));
        }

    }
}
