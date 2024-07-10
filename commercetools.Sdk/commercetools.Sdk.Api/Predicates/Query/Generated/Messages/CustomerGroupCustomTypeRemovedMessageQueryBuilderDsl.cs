using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl
    {
        public CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl()
        {
        }

        public static CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl Of()
        {
            return new CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl>(p, CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl>(p, CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl>(p, CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl>(p, CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl>(p, CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl>(p, CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl>(p, CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl, string> OldTypeId()
        {
            return new ComparisonPredicateBuilder<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldTypeId")),
            p => new CombinationQueryPredicate<CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl>(p, CustomerGroupCustomTypeRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
