using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountCodes
{

    public partial class DiscountCodeQueryBuilderDsl
    {
        public DiscountCodeQueryBuilderDsl()
        {
        }

        public static DiscountCodeQueryBuilderDsl Of()
        {
            return new DiscountCodeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<DiscountCodeQueryBuilderDsl>(p, DiscountCodeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<DiscountCodeQueryBuilderDsl>(p, DiscountCodeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<DiscountCodeQueryBuilderDsl>(p, DiscountCodeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<DiscountCodeQueryBuilderDsl>(p, DiscountCodeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<DiscountCodeQueryBuilderDsl>(p, DiscountCodeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountCodeQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                DiscountCodeQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DiscountCodeQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                DiscountCodeQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DiscountCodeQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                DiscountCodeQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DiscountCodeQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                DiscountCodeQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<DiscountCodeQueryBuilderDsl>(p, DiscountCodeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountCodeQueryBuilderDsl> CartDiscounts(
            Func<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("cartDiscounts"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CartDiscounts.CartDiscountReferenceQueryBuilderDsl.Of())),
                DiscountCodeQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<DiscountCodeQueryBuilderDsl> CartDiscounts()
        {
            return new CollectionPredicateBuilder<DiscountCodeQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("cartDiscounts")),
                    p => new CombinationQueryPredicate<DiscountCodeQueryBuilderDsl>(p, DiscountCodeQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, string> CartPredicate()
        {
            return new ComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("cartPredicate")),
            p => new CombinationQueryPredicate<DiscountCodeQueryBuilderDsl>(p, DiscountCodeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, bool> IsActive()
        {
            return new ComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isActive")),
            p => new CombinationQueryPredicate<DiscountCodeQueryBuilderDsl>(p, DiscountCodeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountCodeQueryBuilderDsl> References(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("references"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                DiscountCodeQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<DiscountCodeQueryBuilderDsl> References()
        {
            return new CollectionPredicateBuilder<DiscountCodeQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("references")),
                    p => new CombinationQueryPredicate<DiscountCodeQueryBuilderDsl>(p, DiscountCodeQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, long> MaxApplications()
        {
            return new ComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("maxApplications")),
            p => new CombinationQueryPredicate<DiscountCodeQueryBuilderDsl>(p, DiscountCodeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, long> MaxApplicationsPerCustomer()
        {
            return new ComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("maxApplicationsPerCustomer")),
            p => new CombinationQueryPredicate<DiscountCodeQueryBuilderDsl>(p, DiscountCodeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountCodeQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                DiscountCodeQueryBuilderDsl.Of);
        }

        public IComparableCollectionPredicateBuilder<DiscountCodeQueryBuilderDsl, string> Groups()
        {
            return new ComparableCollectionPredicateBuilder<DiscountCodeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("groups")),
            p => new CombinationQueryPredicate<DiscountCodeQueryBuilderDsl>(p, DiscountCodeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<DiscountCodeQueryBuilderDsl>(p, DiscountCodeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<DiscountCodeQueryBuilderDsl>(p, DiscountCodeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, long> ApplicationVersion()
        {
            return new ComparisonPredicateBuilder<DiscountCodeQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("applicationVersion")),
            p => new CombinationQueryPredicate<DiscountCodeQueryBuilderDsl>(p, DiscountCodeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
