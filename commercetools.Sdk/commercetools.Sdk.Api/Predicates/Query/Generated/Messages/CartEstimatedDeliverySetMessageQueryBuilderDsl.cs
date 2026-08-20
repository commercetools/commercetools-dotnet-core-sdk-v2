using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CartEstimatedDeliverySetMessageQueryBuilderDsl
    {
        public CartEstimatedDeliverySetMessageQueryBuilderDsl()
        {
        }

        public static CartEstimatedDeliverySetMessageQueryBuilderDsl Of()
        {
            return new CartEstimatedDeliverySetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartEstimatedDeliverySetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CartEstimatedDeliverySetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CartEstimatedDeliverySetMessageQueryBuilderDsl>(p, CartEstimatedDeliverySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartEstimatedDeliverySetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CartEstimatedDeliverySetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CartEstimatedDeliverySetMessageQueryBuilderDsl>(p, CartEstimatedDeliverySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartEstimatedDeliverySetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CartEstimatedDeliverySetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CartEstimatedDeliverySetMessageQueryBuilderDsl>(p, CartEstimatedDeliverySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartEstimatedDeliverySetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<CartEstimatedDeliverySetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<CartEstimatedDeliverySetMessageQueryBuilderDsl>(p, CartEstimatedDeliverySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartEstimatedDeliverySetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartEstimatedDeliverySetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                CartEstimatedDeliverySetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartEstimatedDeliverySetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartEstimatedDeliverySetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                CartEstimatedDeliverySetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartEstimatedDeliverySetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<CartEstimatedDeliverySetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<CartEstimatedDeliverySetMessageQueryBuilderDsl>(p, CartEstimatedDeliverySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartEstimatedDeliverySetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartEstimatedDeliverySetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                CartEstimatedDeliverySetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartEstimatedDeliverySetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<CartEstimatedDeliverySetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<CartEstimatedDeliverySetMessageQueryBuilderDsl>(p, CartEstimatedDeliverySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartEstimatedDeliverySetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartEstimatedDeliverySetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartEstimatedDeliverySetMessageQueryBuilderDsl>(p, CartEstimatedDeliverySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartEstimatedDeliverySetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartEstimatedDeliverySetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                CartEstimatedDeliverySetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartEstimatedDeliverySetMessageQueryBuilderDsl> EstimatedDelivery(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.EstimatedDeliveryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.EstimatedDeliveryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartEstimatedDeliverySetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("estimatedDelivery"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.EstimatedDeliveryQueryBuilderDsl.Of())),
                CartEstimatedDeliverySetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartEstimatedDeliverySetMessageQueryBuilderDsl, string> ShippingKey()
        {
            return new ComparisonPredicateBuilder<CartEstimatedDeliverySetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingKey")),
            p => new CombinationQueryPredicate<CartEstimatedDeliverySetMessageQueryBuilderDsl>(p, CartEstimatedDeliverySetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
