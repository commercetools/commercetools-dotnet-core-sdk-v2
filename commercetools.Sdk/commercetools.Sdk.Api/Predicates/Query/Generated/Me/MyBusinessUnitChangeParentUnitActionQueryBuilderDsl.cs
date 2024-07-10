using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyBusinessUnitChangeParentUnitActionQueryBuilderDsl
    {
        public MyBusinessUnitChangeParentUnitActionQueryBuilderDsl()
        {
        }

        public static MyBusinessUnitChangeParentUnitActionQueryBuilderDsl Of()
        {
            return new MyBusinessUnitChangeParentUnitActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyBusinessUnitChangeParentUnitActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitChangeParentUnitActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyBusinessUnitChangeParentUnitActionQueryBuilderDsl>(p, MyBusinessUnitChangeParentUnitActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyBusinessUnitChangeParentUnitActionQueryBuilderDsl> ParentUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitChangeParentUnitActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("parentUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl.Of())),
                MyBusinessUnitChangeParentUnitActionQueryBuilderDsl.Of);
        }


    }
}
