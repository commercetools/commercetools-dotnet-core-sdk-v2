using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerCustomFieldRemovedMessageQueryBuilderDsl
    {
        public CustomerCustomFieldRemovedMessageQueryBuilderDsl()
        {
        }

        public static CustomerCustomFieldRemovedMessageQueryBuilderDsl Of()
        {
            return new CustomerCustomFieldRemovedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerCustomFieldRemovedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CustomerCustomFieldRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CustomerCustomFieldRemovedMessageQueryBuilderDsl>(p, CustomerCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerCustomFieldRemovedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CustomerCustomFieldRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CustomerCustomFieldRemovedMessageQueryBuilderDsl>(p, CustomerCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerCustomFieldRemovedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CustomerCustomFieldRemovedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CustomerCustomFieldRemovedMessageQueryBuilderDsl>(p, CustomerCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerCustomFieldRemovedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<CustomerCustomFieldRemovedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<CustomerCustomFieldRemovedMessageQueryBuilderDsl>(p, CustomerCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerCustomFieldRemovedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerCustomFieldRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                CustomerCustomFieldRemovedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomerCustomFieldRemovedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerCustomFieldRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                CustomerCustomFieldRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerCustomFieldRemovedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<CustomerCustomFieldRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<CustomerCustomFieldRemovedMessageQueryBuilderDsl>(p, CustomerCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerCustomFieldRemovedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerCustomFieldRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                CustomerCustomFieldRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerCustomFieldRemovedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<CustomerCustomFieldRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<CustomerCustomFieldRemovedMessageQueryBuilderDsl>(p, CustomerCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerCustomFieldRemovedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerCustomFieldRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerCustomFieldRemovedMessageQueryBuilderDsl>(p, CustomerCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerCustomFieldRemovedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerCustomFieldRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                CustomerCustomFieldRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerCustomFieldRemovedMessageQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CustomerCustomFieldRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CustomerCustomFieldRemovedMessageQueryBuilderDsl>(p, CustomerCustomFieldRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
