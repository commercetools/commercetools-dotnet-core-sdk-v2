using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderPurchaseOrderNumberSetMessageQueryBuilderDsl
    {
        public OrderPurchaseOrderNumberSetMessageQueryBuilderDsl()
        {
        }

        public static OrderPurchaseOrderNumberSetMessageQueryBuilderDsl Of()
        {
            return new OrderPurchaseOrderNumberSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl>(p, OrderPurchaseOrderNumberSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl>(p, OrderPurchaseOrderNumberSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl>(p, OrderPurchaseOrderNumberSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl>(p, OrderPurchaseOrderNumberSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                OrderPurchaseOrderNumberSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                OrderPurchaseOrderNumberSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl>(p, OrderPurchaseOrderNumberSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                OrderPurchaseOrderNumberSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl>(p, OrderPurchaseOrderNumberSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl>(p, OrderPurchaseOrderNumberSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                OrderPurchaseOrderNumberSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl, string> PurchaseOrderNumber()
        {
            return new ComparisonPredicateBuilder<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("purchaseOrderNumber")),
            p => new CombinationQueryPredicate<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl>(p, OrderPurchaseOrderNumberSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl, string> OldPurchaseOrderNumber()
        {
            return new ComparisonPredicateBuilder<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldPurchaseOrderNumber")),
            p => new CombinationQueryPredicate<OrderPurchaseOrderNumberSetMessageQueryBuilderDsl>(p, OrderPurchaseOrderNumberSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
