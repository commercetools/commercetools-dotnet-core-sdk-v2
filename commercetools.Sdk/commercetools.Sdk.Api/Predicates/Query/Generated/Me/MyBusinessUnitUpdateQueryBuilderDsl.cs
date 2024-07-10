using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyBusinessUnitUpdateQueryBuilderDsl
    {
        public MyBusinessUnitUpdateQueryBuilderDsl()
        {
        }

        public static MyBusinessUnitUpdateQueryBuilderDsl Of()
        {
            return new MyBusinessUnitUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyBusinessUnitUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<MyBusinessUnitUpdateQueryBuilderDsl>(p, MyBusinessUnitUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyBusinessUnitUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitUpdateActionQueryBuilderDsl.Of())),
                MyBusinessUnitUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<MyBusinessUnitUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<MyBusinessUnitUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<MyBusinessUnitUpdateQueryBuilderDsl>(p, MyBusinessUnitUpdateQueryBuilderDsl.Of));
        }

    }
}
