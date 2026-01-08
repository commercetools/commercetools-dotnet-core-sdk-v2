using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CartPurchaseOrderNumberSetMessageQueryBuilderDsl
    {
        public CartPurchaseOrderNumberSetMessageQueryBuilderDsl()
        {
        }

        public static CartPurchaseOrderNumberSetMessageQueryBuilderDsl Of()
        {
            return new CartPurchaseOrderNumberSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CartPurchaseOrderNumberSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CartPurchaseOrderNumberSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CartPurchaseOrderNumberSetMessageQueryBuilderDsl>(p, CartPurchaseOrderNumberSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartPurchaseOrderNumberSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CartPurchaseOrderNumberSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CartPurchaseOrderNumberSetMessageQueryBuilderDsl>(p, CartPurchaseOrderNumberSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartPurchaseOrderNumberSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CartPurchaseOrderNumberSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CartPurchaseOrderNumberSetMessageQueryBuilderDsl>(p, CartPurchaseOrderNumberSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartPurchaseOrderNumberSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<CartPurchaseOrderNumberSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<CartPurchaseOrderNumberSetMessageQueryBuilderDsl>(p, CartPurchaseOrderNumberSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartPurchaseOrderNumberSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartPurchaseOrderNumberSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                CartPurchaseOrderNumberSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CartPurchaseOrderNumberSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartPurchaseOrderNumberSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                CartPurchaseOrderNumberSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartPurchaseOrderNumberSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<CartPurchaseOrderNumberSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<CartPurchaseOrderNumberSetMessageQueryBuilderDsl>(p, CartPurchaseOrderNumberSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartPurchaseOrderNumberSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartPurchaseOrderNumberSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                CartPurchaseOrderNumberSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartPurchaseOrderNumberSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<CartPurchaseOrderNumberSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<CartPurchaseOrderNumberSetMessageQueryBuilderDsl>(p, CartPurchaseOrderNumberSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartPurchaseOrderNumberSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CartPurchaseOrderNumberSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CartPurchaseOrderNumberSetMessageQueryBuilderDsl>(p, CartPurchaseOrderNumberSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CartPurchaseOrderNumberSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CartPurchaseOrderNumberSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                CartPurchaseOrderNumberSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CartPurchaseOrderNumberSetMessageQueryBuilderDsl, string> PurchaseOrderNumber()
        {
            return new ComparisonPredicateBuilder<CartPurchaseOrderNumberSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("purchaseOrderNumber")),
            p => new CombinationQueryPredicate<CartPurchaseOrderNumberSetMessageQueryBuilderDsl>(p, CartPurchaseOrderNumberSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CartPurchaseOrderNumberSetMessageQueryBuilderDsl, string> OldPurchaseOrderNumber()
        {
            return new ComparisonPredicateBuilder<CartPurchaseOrderNumberSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldPurchaseOrderNumber")),
            p => new CombinationQueryPredicate<CartPurchaseOrderNumberSetMessageQueryBuilderDsl>(p, CartPurchaseOrderNumberSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
