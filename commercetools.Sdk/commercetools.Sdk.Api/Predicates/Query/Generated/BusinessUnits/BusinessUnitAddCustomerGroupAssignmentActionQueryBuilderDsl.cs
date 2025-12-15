using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitAddCustomerGroupAssignmentActionQueryBuilderDsl
    {
        public BusinessUnitAddCustomerGroupAssignmentActionQueryBuilderDsl()
        {
        }

        public static BusinessUnitAddCustomerGroupAssignmentActionQueryBuilderDsl Of()
        {
            return new BusinessUnitAddCustomerGroupAssignmentActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitAddCustomerGroupAssignmentActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddCustomerGroupAssignmentActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<BusinessUnitAddCustomerGroupAssignmentActionQueryBuilderDsl>(p, BusinessUnitAddCustomerGroupAssignmentActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitAddCustomerGroupAssignmentActionQueryBuilderDsl> CustomerGroupAssignment(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitAddCustomerGroupAssignmentActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroupAssignment"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentDraftQueryBuilderDsl.Of())),
                BusinessUnitAddCustomerGroupAssignmentActionQueryBuilderDsl.Of);
        }


    }
}
