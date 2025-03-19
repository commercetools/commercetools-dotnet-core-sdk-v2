using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerRemoveCustomerGroupAssignmentActionQueryBuilderDsl
    {
        public CustomerRemoveCustomerGroupAssignmentActionQueryBuilderDsl()
        {
        }

        public static CustomerRemoveCustomerGroupAssignmentActionQueryBuilderDsl Of()
        {
            return new CustomerRemoveCustomerGroupAssignmentActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerRemoveCustomerGroupAssignmentActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerRemoveCustomerGroupAssignmentActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerRemoveCustomerGroupAssignmentActionQueryBuilderDsl>(p, CustomerRemoveCustomerGroupAssignmentActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerRemoveCustomerGroupAssignmentActionQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerRemoveCustomerGroupAssignmentActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl.Of())),
                CustomerRemoveCustomerGroupAssignmentActionQueryBuilderDsl.Of);
        }


    }
}
