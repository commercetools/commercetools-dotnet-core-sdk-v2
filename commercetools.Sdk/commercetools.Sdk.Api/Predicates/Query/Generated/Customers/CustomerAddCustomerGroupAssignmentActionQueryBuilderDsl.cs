using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerAddCustomerGroupAssignmentActionQueryBuilderDsl
    {
        public CustomerAddCustomerGroupAssignmentActionQueryBuilderDsl()
        {
        }

        public static CustomerAddCustomerGroupAssignmentActionQueryBuilderDsl Of()
        {
            return new CustomerAddCustomerGroupAssignmentActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerAddCustomerGroupAssignmentActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerAddCustomerGroupAssignmentActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerAddCustomerGroupAssignmentActionQueryBuilderDsl>(p, CustomerAddCustomerGroupAssignmentActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerAddCustomerGroupAssignmentActionQueryBuilderDsl> CustomerGroupAssignment(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerAddCustomerGroupAssignmentActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroupAssignment"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentDraftQueryBuilderDsl.Of())),
                CustomerAddCustomerGroupAssignmentActionQueryBuilderDsl.Of);
        }


    }
}
