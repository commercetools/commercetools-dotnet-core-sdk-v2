using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitRemoveCustomerGroupAssignmentActionQueryBuilderDsl
    {
        public BusinessUnitRemoveCustomerGroupAssignmentActionQueryBuilderDsl()
        {
        }

        public static BusinessUnitRemoveCustomerGroupAssignmentActionQueryBuilderDsl Of()
        {
            return new BusinessUnitRemoveCustomerGroupAssignmentActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitRemoveCustomerGroupAssignmentActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<BusinessUnitRemoveCustomerGroupAssignmentActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<BusinessUnitRemoveCustomerGroupAssignmentActionQueryBuilderDsl>(p, BusinessUnitRemoveCustomerGroupAssignmentActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitRemoveCustomerGroupAssignmentActionQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitRemoveCustomerGroupAssignmentActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl.Of())),
                BusinessUnitRemoveCustomerGroupAssignmentActionQueryBuilderDsl.Of);
        }


    }
}
