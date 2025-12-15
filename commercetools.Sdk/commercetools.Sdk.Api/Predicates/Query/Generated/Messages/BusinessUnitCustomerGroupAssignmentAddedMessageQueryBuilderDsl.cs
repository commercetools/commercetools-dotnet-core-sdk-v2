using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl
    {
        public BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl()
        {
        }

        public static BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl Of()
        {
            return new BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl>(p, BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl> CustomerGroupAssignment(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroupAssignment"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerGroupAssignmentQueryBuilderDsl.Of())),
                BusinessUnitCustomerGroupAssignmentAddedMessageQueryBuilderDsl.Of);
        }


    }
}
