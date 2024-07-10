using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerGroupCustomFieldAddedMessageQueryBuilderDsl
    {
        public CustomerGroupCustomFieldAddedMessageQueryBuilderDsl()
        {
        }

        public static CustomerGroupCustomFieldAddedMessageQueryBuilderDsl Of()
        {
            return new CustomerGroupCustomFieldAddedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl>(p, CustomerGroupCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl>(p, CustomerGroupCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl>(p, CustomerGroupCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl>(p, CustomerGroupCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                CustomerGroupCustomFieldAddedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                CustomerGroupCustomFieldAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl>(p, CustomerGroupCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                CustomerGroupCustomFieldAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl>(p, CustomerGroupCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl>(p, CustomerGroupCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                CustomerGroupCustomFieldAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl>(p, CustomerGroupCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<CustomerGroupCustomFieldAddedMessageQueryBuilderDsl>(p, CustomerGroupCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
