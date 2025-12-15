using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl
    {
        public BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl()
        {
        }

        public static BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl Of()
        {
            return new BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl> CustomerGroupAssignment(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroupAssignment"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl.Of())),
                BusinessUnitCustomerGroupAssignmentRemovedMessageQueryBuilderDsl.Of);
        }


    }
}
