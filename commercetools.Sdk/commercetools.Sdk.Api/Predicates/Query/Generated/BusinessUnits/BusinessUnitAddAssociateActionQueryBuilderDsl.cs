using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitAddAssociateActionQueryBuilderDsl
    {
        public BusinessUnitAddAssociateActionQueryBuilderDsl()
        {
        }

        public static BusinessUnitAddAssociateActionQueryBuilderDsl Of()
        {
            return new BusinessUnitAddAssociateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitAddAssociateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddAssociateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<BusinessUnitAddAssociateActionQueryBuilderDsl>(p, BusinessUnitAddAssociateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitAddAssociateActionQueryBuilderDsl> Associate(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitAddAssociateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateDraftQueryBuilderDsl.Of())),
                BusinessUnitAddAssociateActionQueryBuilderDsl.Of);
        }


    }
}
