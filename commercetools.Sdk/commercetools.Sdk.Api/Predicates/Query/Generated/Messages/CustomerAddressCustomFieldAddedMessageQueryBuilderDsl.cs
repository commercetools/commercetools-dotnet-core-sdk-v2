using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerAddressCustomFieldAddedMessageQueryBuilderDsl
    {
        public CustomerAddressCustomFieldAddedMessageQueryBuilderDsl()
        {
        }

        public static CustomerAddressCustomFieldAddedMessageQueryBuilderDsl Of()
        {
            return new CustomerAddressCustomFieldAddedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl>(p, CustomerAddressCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl>(p, CustomerAddressCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl>(p, CustomerAddressCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl>(p, CustomerAddressCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                CustomerAddressCustomFieldAddedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                CustomerAddressCustomFieldAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl>(p, CustomerAddressCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                CustomerAddressCustomFieldAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl>(p, CustomerAddressCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl>(p, CustomerAddressCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                CustomerAddressCustomFieldAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl>(p, CustomerAddressCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl>(p, CustomerAddressCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<CustomerAddressCustomFieldAddedMessageQueryBuilderDsl>(p, CustomerAddressCustomFieldAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
