using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitCustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl
    {
        public BusinessUnitCustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static BusinessUnitCustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl Of()
        {
            return new BusinessUnitCustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl> CustomerGroupAssignments(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroupAssignments"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl.Of())),
                BusinessUnitCustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitCustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl> CustomerGroupAssignments()
        {
            return new CollectionPredicateBuilder<BusinessUnitCustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerGroupAssignments")),
                    p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl> OldCustomerGroupAssignments(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldCustomerGroupAssignments"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl.Of())),
                BusinessUnitCustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitCustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl> OldCustomerGroupAssignments()
        {
            return new CollectionPredicateBuilder<BusinessUnitCustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldCustomerGroupAssignments")),
                    p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl.Of));
        }

    }
}
