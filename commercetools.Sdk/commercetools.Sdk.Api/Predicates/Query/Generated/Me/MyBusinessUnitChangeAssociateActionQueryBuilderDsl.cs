using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyBusinessUnitChangeAssociateActionQueryBuilderDsl
    {
        public MyBusinessUnitChangeAssociateActionQueryBuilderDsl()
        {
        }

        public static MyBusinessUnitChangeAssociateActionQueryBuilderDsl Of()
        {
            return new MyBusinessUnitChangeAssociateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyBusinessUnitChangeAssociateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitChangeAssociateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyBusinessUnitChangeAssociateActionQueryBuilderDsl>(p, MyBusinessUnitChangeAssociateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyBusinessUnitChangeAssociateActionQueryBuilderDsl> Associate(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitChangeAssociateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateDraftQueryBuilderDsl.Of())),
                MyBusinessUnitChangeAssociateActionQueryBuilderDsl.Of);
        }


    }
}
