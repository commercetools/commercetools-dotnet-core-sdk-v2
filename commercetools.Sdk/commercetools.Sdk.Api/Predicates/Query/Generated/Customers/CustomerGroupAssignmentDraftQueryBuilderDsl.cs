using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerGroupAssignmentDraftQueryBuilderDsl
    {
        public CustomerGroupAssignmentDraftQueryBuilderDsl()
        {
        }

        public static CustomerGroupAssignmentDraftQueryBuilderDsl Of()
        {
            return new CustomerGroupAssignmentDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<CustomerGroupAssignmentDraftQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerGroupAssignmentDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupResourceIdentifierQueryBuilderDsl.Of())),
                CustomerGroupAssignmentDraftQueryBuilderDsl.Of);
        }


    }
}
