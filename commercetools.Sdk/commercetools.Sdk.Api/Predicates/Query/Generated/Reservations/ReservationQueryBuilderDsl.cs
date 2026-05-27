using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Reservations
{

    public partial class ReservationQueryBuilderDsl
    {
        public ReservationQueryBuilderDsl()
        {
        }

        public static ReservationQueryBuilderDsl Of()
        {
            return new ReservationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReservationQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ReservationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ReservationQueryBuilderDsl>(p, ReservationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReservationQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ReservationQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ReservationQueryBuilderDsl>(p, ReservationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReservationQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ReservationQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ReservationQueryBuilderDsl>(p, ReservationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReservationQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ReservationQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ReservationQueryBuilderDsl>(p, ReservationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReservationQueryBuilderDsl, DateTime> ExpiresAt()
        {
            return new ComparisonPredicateBuilder<ReservationQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("expiresAt")),
            p => new CombinationQueryPredicate<ReservationQueryBuilderDsl>(p, ReservationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ReservationQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReservationQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ReservationQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ReservationQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReservationQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ReservationQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ReservationQueryBuilderDsl> InventoryEntry(
            Func<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReservationQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("inventoryEntry"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Inventories.InventoryEntryReferenceQueryBuilderDsl.Of())),
                ReservationQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ReservationQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<ReservationQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<ReservationQueryBuilderDsl>(p, ReservationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ReservationQueryBuilderDsl> Owner(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReservationQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("owner"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ReservationQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ReservationQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<ReservationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<ReservationQueryBuilderDsl>(p, ReservationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReservationQueryBuilderDsl, string> State()
        {
            return new ComparisonPredicateBuilder<ReservationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
            p => new CombinationQueryPredicate<ReservationQueryBuilderDsl>(p, ReservationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
