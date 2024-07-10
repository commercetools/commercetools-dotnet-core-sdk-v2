using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class DeliveryAddressSetMessageQueryBuilderDsl
    {
        public DeliveryAddressSetMessageQueryBuilderDsl()
        {
        }

        public static DeliveryAddressSetMessageQueryBuilderDsl Of()
        {
            return new DeliveryAddressSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DeliveryAddressSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<DeliveryAddressSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<DeliveryAddressSetMessageQueryBuilderDsl>(p, DeliveryAddressSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DeliveryAddressSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<DeliveryAddressSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<DeliveryAddressSetMessageQueryBuilderDsl>(p, DeliveryAddressSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DeliveryAddressSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<DeliveryAddressSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<DeliveryAddressSetMessageQueryBuilderDsl>(p, DeliveryAddressSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DeliveryAddressSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<DeliveryAddressSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<DeliveryAddressSetMessageQueryBuilderDsl>(p, DeliveryAddressSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DeliveryAddressSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryAddressSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                DeliveryAddressSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DeliveryAddressSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryAddressSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                DeliveryAddressSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DeliveryAddressSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<DeliveryAddressSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<DeliveryAddressSetMessageQueryBuilderDsl>(p, DeliveryAddressSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DeliveryAddressSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryAddressSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                DeliveryAddressSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DeliveryAddressSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<DeliveryAddressSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<DeliveryAddressSetMessageQueryBuilderDsl>(p, DeliveryAddressSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DeliveryAddressSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<DeliveryAddressSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<DeliveryAddressSetMessageQueryBuilderDsl>(p, DeliveryAddressSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DeliveryAddressSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryAddressSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                DeliveryAddressSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DeliveryAddressSetMessageQueryBuilderDsl, string> DeliveryId()
        {
            return new ComparisonPredicateBuilder<DeliveryAddressSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deliveryId")),
            p => new CombinationQueryPredicate<DeliveryAddressSetMessageQueryBuilderDsl>(p, DeliveryAddressSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DeliveryAddressSetMessageQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryAddressSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                DeliveryAddressSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DeliveryAddressSetMessageQueryBuilderDsl> OldAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DeliveryAddressSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldAddress"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                DeliveryAddressSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DeliveryAddressSetMessageQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<DeliveryAddressSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<DeliveryAddressSetMessageQueryBuilderDsl>(p, DeliveryAddressSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
