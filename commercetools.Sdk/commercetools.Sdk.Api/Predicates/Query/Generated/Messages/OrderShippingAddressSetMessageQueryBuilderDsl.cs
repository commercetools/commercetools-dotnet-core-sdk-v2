using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderShippingAddressSetMessageQueryBuilderDsl
    {
        public OrderShippingAddressSetMessageQueryBuilderDsl()
        {
        }

        public static OrderShippingAddressSetMessageQueryBuilderDsl Of()
        {
            return new OrderShippingAddressSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderShippingAddressSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<OrderShippingAddressSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<OrderShippingAddressSetMessageQueryBuilderDsl>(p, OrderShippingAddressSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderShippingAddressSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<OrderShippingAddressSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<OrderShippingAddressSetMessageQueryBuilderDsl>(p, OrderShippingAddressSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderShippingAddressSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<OrderShippingAddressSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<OrderShippingAddressSetMessageQueryBuilderDsl>(p, OrderShippingAddressSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderShippingAddressSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<OrderShippingAddressSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<OrderShippingAddressSetMessageQueryBuilderDsl>(p, OrderShippingAddressSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderShippingAddressSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderShippingAddressSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                OrderShippingAddressSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderShippingAddressSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderShippingAddressSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                OrderShippingAddressSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderShippingAddressSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<OrderShippingAddressSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<OrderShippingAddressSetMessageQueryBuilderDsl>(p, OrderShippingAddressSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderShippingAddressSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderShippingAddressSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                OrderShippingAddressSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderShippingAddressSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<OrderShippingAddressSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<OrderShippingAddressSetMessageQueryBuilderDsl>(p, OrderShippingAddressSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderShippingAddressSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderShippingAddressSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderShippingAddressSetMessageQueryBuilderDsl>(p, OrderShippingAddressSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderShippingAddressSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderShippingAddressSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                OrderShippingAddressSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderShippingAddressSetMessageQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderShippingAddressSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                OrderShippingAddressSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderShippingAddressSetMessageQueryBuilderDsl> OldAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderShippingAddressSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldAddress"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                OrderShippingAddressSetMessageQueryBuilderDsl.Of);
        }


    }
}
