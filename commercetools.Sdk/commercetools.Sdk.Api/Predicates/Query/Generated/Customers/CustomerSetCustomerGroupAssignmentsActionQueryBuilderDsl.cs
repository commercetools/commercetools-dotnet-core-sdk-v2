using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerSetCustomerGroupAssignmentsActionQueryBuilderDsl
    {
        public CustomerSetCustomerGroupAssignmentsActionQueryBuilderDsl()
        {
        }

        public static CustomerSetCustomerGroupAssignmentsActionQueryBuilderDsl Of()
        {
            return new CustomerSetCustomerGroupAssignmentsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerSetCustomerGroupAssignmentsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerSetCustomerGroupAssignmentsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerSetCustomerGroupAssignmentsActionQueryBuilderDsl>(p, CustomerSetCustomerGroupAssignmentsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerSetCustomerGroupAssignmentsActionQueryBuilderDsl> CustomerGroupAssignments(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerSetCustomerGroupAssignmentsActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroupAssignments"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentDraftQueryBuilderDsl.Of())),
                CustomerSetCustomerGroupAssignmentsActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CustomerSetCustomerGroupAssignmentsActionQueryBuilderDsl> CustomerGroupAssignments()
        {
            return new CollectionPredicateBuilder<CustomerSetCustomerGroupAssignmentsActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerGroupAssignments")),
                    p => new CombinationQueryPredicate<CustomerSetCustomerGroupAssignmentsActionQueryBuilderDsl>(p, CustomerSetCustomerGroupAssignmentsActionQueryBuilderDsl.Of));
        }

    }
}
