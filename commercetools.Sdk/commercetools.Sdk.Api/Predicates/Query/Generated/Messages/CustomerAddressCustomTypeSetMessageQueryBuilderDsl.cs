using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerAddressCustomTypeSetMessageQueryBuilderDsl
    {
        public CustomerAddressCustomTypeSetMessageQueryBuilderDsl()
        {
        }

        public static CustomerAddressCustomTypeSetMessageQueryBuilderDsl Of()
        {
            return new CustomerAddressCustomTypeSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerAddressCustomTypeSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomTypeSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CustomerAddressCustomTypeSetMessageQueryBuilderDsl>(p, CustomerAddressCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerAddressCustomTypeSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomTypeSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CustomerAddressCustomTypeSetMessageQueryBuilderDsl>(p, CustomerAddressCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerAddressCustomTypeSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomTypeSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CustomerAddressCustomTypeSetMessageQueryBuilderDsl>(p, CustomerAddressCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerAddressCustomTypeSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomTypeSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<CustomerAddressCustomTypeSetMessageQueryBuilderDsl>(p, CustomerAddressCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerAddressCustomTypeSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerAddressCustomTypeSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                CustomerAddressCustomTypeSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomerAddressCustomTypeSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerAddressCustomTypeSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                CustomerAddressCustomTypeSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerAddressCustomTypeSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomTypeSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<CustomerAddressCustomTypeSetMessageQueryBuilderDsl>(p, CustomerAddressCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerAddressCustomTypeSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerAddressCustomTypeSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                CustomerAddressCustomTypeSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerAddressCustomTypeSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomTypeSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<CustomerAddressCustomTypeSetMessageQueryBuilderDsl>(p, CustomerAddressCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerAddressCustomTypeSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomTypeSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerAddressCustomTypeSetMessageQueryBuilderDsl>(p, CustomerAddressCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerAddressCustomTypeSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerAddressCustomTypeSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                CustomerAddressCustomTypeSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CustomerAddressCustomTypeSetMessageQueryBuilderDsl> CustomFields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerAddressCustomTypeSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customFields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                CustomerAddressCustomTypeSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerAddressCustomTypeSetMessageQueryBuilderDsl, string> PreviousTypeId()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomTypeSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("previousTypeId")),
            p => new CombinationQueryPredicate<CustomerAddressCustomTypeSetMessageQueryBuilderDsl>(p, CustomerAddressCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerAddressCustomTypeSetMessageQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomTypeSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<CustomerAddressCustomTypeSetMessageQueryBuilderDsl>(p, CustomerAddressCustomTypeSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
