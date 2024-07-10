using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerCustomFieldChangedMessageQueryBuilderDsl
    {
        public CustomerCustomFieldChangedMessageQueryBuilderDsl()
        {
        }

        public static CustomerCustomFieldChangedMessageQueryBuilderDsl Of()
        {
            return new CustomerCustomFieldChangedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerCustomFieldChangedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CustomerCustomFieldChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CustomerCustomFieldChangedMessageQueryBuilderDsl>(p, CustomerCustomFieldChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerCustomFieldChangedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CustomerCustomFieldChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CustomerCustomFieldChangedMessageQueryBuilderDsl>(p, CustomerCustomFieldChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerCustomFieldChangedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CustomerCustomFieldChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CustomerCustomFieldChangedMessageQueryBuilderDsl>(p, CustomerCustomFieldChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerCustomFieldChangedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<CustomerCustomFieldChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<CustomerCustomFieldChangedMessageQueryBuilderDsl>(p, CustomerCustomFieldChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerCustomFieldChangedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerCustomFieldChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                CustomerCustomFieldChangedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomerCustomFieldChangedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerCustomFieldChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                CustomerCustomFieldChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerCustomFieldChangedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<CustomerCustomFieldChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<CustomerCustomFieldChangedMessageQueryBuilderDsl>(p, CustomerCustomFieldChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerCustomFieldChangedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerCustomFieldChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                CustomerCustomFieldChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerCustomFieldChangedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<CustomerCustomFieldChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<CustomerCustomFieldChangedMessageQueryBuilderDsl>(p, CustomerCustomFieldChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerCustomFieldChangedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerCustomFieldChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerCustomFieldChangedMessageQueryBuilderDsl>(p, CustomerCustomFieldChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerCustomFieldChangedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerCustomFieldChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                CustomerCustomFieldChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerCustomFieldChangedMessageQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CustomerCustomFieldChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CustomerCustomFieldChangedMessageQueryBuilderDsl>(p, CustomerCustomFieldChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerCustomFieldChangedMessageQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<CustomerCustomFieldChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<CustomerCustomFieldChangedMessageQueryBuilderDsl>(p, CustomerCustomFieldChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerCustomFieldChangedMessageQueryBuilderDsl, string> PreviousValue()
        {
            return new ComparisonPredicateBuilder<CustomerCustomFieldChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("previousValue")),
            p => new CombinationQueryPredicate<CustomerCustomFieldChangedMessageQueryBuilderDsl>(p, CustomerCustomFieldChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
