using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitCustomerGroupAssignmentAddedMessagePayloadQueryBuilderDsl
    {
        public BusinessUnitCustomerGroupAssignmentAddedMessagePayloadQueryBuilderDsl()
        {
        }

        public static BusinessUnitCustomerGroupAssignmentAddedMessagePayloadQueryBuilderDsl Of()
        {
            return new BusinessUnitCustomerGroupAssignmentAddedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentAddedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentAddedMessagePayloadQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentAddedMessagePayloadQueryBuilderDsl> CustomerGroupAssignment(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentAddedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroupAssignment"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl.Of())),
                BusinessUnitCustomerGroupAssignmentAddedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
