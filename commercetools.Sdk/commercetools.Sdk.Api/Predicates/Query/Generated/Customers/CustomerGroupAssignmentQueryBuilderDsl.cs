using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerGroupAssignmentQueryBuilderDsl
    {
        public CustomerGroupAssignmentQueryBuilderDsl()
        {
        }

        public static CustomerGroupAssignmentQueryBuilderDsl Of()
        {
            return new CustomerGroupAssignmentQueryBuilderDsl();
        }

        public CombinationQueryPredicate<CustomerGroupAssignmentQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerGroupAssignmentQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl.Of())),
                CustomerGroupAssignmentQueryBuilderDsl.Of);
        }


    }
}
