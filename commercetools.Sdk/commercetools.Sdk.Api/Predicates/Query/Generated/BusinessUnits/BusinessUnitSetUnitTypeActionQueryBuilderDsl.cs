using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitSetUnitTypeActionQueryBuilderDsl
    {
        public BusinessUnitSetUnitTypeActionQueryBuilderDsl()
        {
        }

        public static BusinessUnitSetUnitTypeActionQueryBuilderDsl Of()
        {
            return new BusinessUnitSetUnitTypeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitSetUnitTypeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<BusinessUnitSetUnitTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<BusinessUnitSetUnitTypeActionQueryBuilderDsl>(p, BusinessUnitSetUnitTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitSetUnitTypeActionQueryBuilderDsl, string> UnitType()
        {
            return new ComparisonPredicateBuilder<BusinessUnitSetUnitTypeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("unitType")),
            p => new CombinationQueryPredicate<BusinessUnitSetUnitTypeActionQueryBuilderDsl>(p, BusinessUnitSetUnitTypeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitSetUnitTypeActionQueryBuilderDsl> ParentUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitSetUnitTypeActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("parentUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitResourceIdentifierQueryBuilderDsl.Of())),
                BusinessUnitSetUnitTypeActionQueryBuilderDsl.Of);
        }


    }
}
