using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitChangeAssociateActionQueryBuilderDsl
    {
        public BusinessUnitChangeAssociateActionQueryBuilderDsl()
        {
        }

        public static BusinessUnitChangeAssociateActionQueryBuilderDsl Of()
        {
            return new BusinessUnitChangeAssociateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitChangeAssociateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<BusinessUnitChangeAssociateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<BusinessUnitChangeAssociateActionQueryBuilderDsl>(p, BusinessUnitChangeAssociateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitChangeAssociateActionQueryBuilderDsl> Associate(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitChangeAssociateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associate"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateDraftQueryBuilderDsl.Of())),
                BusinessUnitChangeAssociateActionQueryBuilderDsl.Of);
        }


    }
}
