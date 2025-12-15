using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitSetCustomerGroupAssignmentsActionQueryBuilderDsl
    {
        public BusinessUnitSetCustomerGroupAssignmentsActionQueryBuilderDsl()
        {
        }

        public static BusinessUnitSetCustomerGroupAssignmentsActionQueryBuilderDsl Of()
        {
            return new BusinessUnitSetCustomerGroupAssignmentsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitSetCustomerGroupAssignmentsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<BusinessUnitSetCustomerGroupAssignmentsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<BusinessUnitSetCustomerGroupAssignmentsActionQueryBuilderDsl>(p, BusinessUnitSetCustomerGroupAssignmentsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitSetCustomerGroupAssignmentsActionQueryBuilderDsl> CustomerGroupAssignments(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitSetCustomerGroupAssignmentsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroupAssignments"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentDraftQueryBuilderDsl.Of())),
                BusinessUnitSetCustomerGroupAssignmentsActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitSetCustomerGroupAssignmentsActionQueryBuilderDsl> CustomerGroupAssignments()
        {
            return new CollectionPredicateBuilder<BusinessUnitSetCustomerGroupAssignmentsActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerGroupAssignments")),
                    p => new CombinationQueryPredicate<BusinessUnitSetCustomerGroupAssignmentsActionQueryBuilderDsl>(p, BusinessUnitSetCustomerGroupAssignmentsActionQueryBuilderDsl.Of));
        }

    }
}
