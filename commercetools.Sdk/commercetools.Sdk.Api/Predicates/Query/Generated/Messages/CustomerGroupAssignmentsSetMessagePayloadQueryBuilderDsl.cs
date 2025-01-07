using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl
    {
        public CustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl>(p, CustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl> CustomerGroupAssignments(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroupAssignments"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl.Of())),
                CustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl> CustomerGroupAssignments()
        {
            return new CollectionPredicateBuilder<CustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerGroupAssignments")),
                    p => new CombinationQueryPredicate<CustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl>(p, CustomerGroupAssignmentsSetMessagePayloadQueryBuilderDsl.Of));
        }

    }
}
