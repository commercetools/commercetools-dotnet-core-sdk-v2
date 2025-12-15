using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl
    {
        public BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl()
        {
        }

        public static BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl Of()
        {
            return new BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl> CustomerGroupAssignments(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroupAssignments"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl.Of())),
                BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl> CustomerGroupAssignments()
        {
            return new CollectionPredicateBuilder<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customerGroupAssignments")),
                    p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl> OldCustomerGroupAssignments(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldCustomerGroupAssignments"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl.Of())),
                BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl> OldCustomerGroupAssignments()
        {
            return new CollectionPredicateBuilder<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldCustomerGroupAssignments")),
                    p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentsSetMessageQueryBuilderDsl.Of));
        }

    }
}
