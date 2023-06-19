using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class DivisionQueryBuilderDsl
    {
        public DivisionQueryBuilderDsl()
        {
        }

        public static DivisionQueryBuilderDsl Of()
        {
            return new DivisionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DivisionQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<DivisionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<DivisionQueryBuilderDsl>(p, DivisionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DivisionQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<DivisionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<DivisionQueryBuilderDsl>(p, DivisionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DivisionQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<DivisionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<DivisionQueryBuilderDsl>(p, DivisionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DivisionQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<DivisionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<DivisionQueryBuilderDsl>(p, DivisionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DivisionQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DivisionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                DivisionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DivisionQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DivisionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                DivisionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DivisionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<DivisionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<DivisionQueryBuilderDsl>(p, DivisionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DivisionQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<DivisionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<DivisionQueryBuilderDsl>(p, DivisionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DivisionQueryBuilderDsl> Stores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DivisionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                DivisionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<DivisionQueryBuilderDsl> Stores()
        {
            return new CollectionPredicateBuilder<DivisionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stores")),
                    p => new CombinationQueryPredicate<DivisionQueryBuilderDsl>(p, DivisionQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<DivisionQueryBuilderDsl, string> StoreMode()
        {
            return new ComparisonPredicateBuilder<DivisionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("storeMode")),
            p => new CombinationQueryPredicate<DivisionQueryBuilderDsl>(p, DivisionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DivisionQueryBuilderDsl, string> UnitType()
        {
            return new ComparisonPredicateBuilder<DivisionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("unitType")),
            p => new CombinationQueryPredicate<DivisionQueryBuilderDsl>(p, DivisionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DivisionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<DivisionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<DivisionQueryBuilderDsl>(p, DivisionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DivisionQueryBuilderDsl, string> ContactEmail()
        {
            return new ComparisonPredicateBuilder<DivisionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("contactEmail")),
            p => new CombinationQueryPredicate<DivisionQueryBuilderDsl>(p, DivisionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DivisionQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DivisionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                DivisionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DivisionQueryBuilderDsl> Addresses(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DivisionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("addresses"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                DivisionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<DivisionQueryBuilderDsl> Addresses()
        {
            return new CollectionPredicateBuilder<DivisionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addresses")),
                    p => new CombinationQueryPredicate<DivisionQueryBuilderDsl>(p, DivisionQueryBuilderDsl.Of));
        }
        public IComparableCollectionPredicateBuilder<DivisionQueryBuilderDsl, string> ShippingAddressIds()
        {
            return new ComparableCollectionPredicateBuilder<DivisionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingAddressIds")),
            p => new CombinationQueryPredicate<DivisionQueryBuilderDsl>(p, DivisionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DivisionQueryBuilderDsl, string> DefaultShippingAddressId()
        {
            return new ComparisonPredicateBuilder<DivisionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("defaultShippingAddressId")),
            p => new CombinationQueryPredicate<DivisionQueryBuilderDsl>(p, DivisionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<DivisionQueryBuilderDsl, string> BillingAddressIds()
        {
            return new ComparableCollectionPredicateBuilder<DivisionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("billingAddressIds")),
            p => new CombinationQueryPredicate<DivisionQueryBuilderDsl>(p, DivisionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DivisionQueryBuilderDsl, string> DefaultBillingAddressId()
        {
            return new ComparisonPredicateBuilder<DivisionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("defaultBillingAddressId")),
            p => new CombinationQueryPredicate<DivisionQueryBuilderDsl>(p, DivisionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DivisionQueryBuilderDsl, string> AssociateMode()
        {
            return new ComparisonPredicateBuilder<DivisionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("associateMode")),
            p => new CombinationQueryPredicate<DivisionQueryBuilderDsl>(p, DivisionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DivisionQueryBuilderDsl> Associates(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DivisionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associates"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateQueryBuilderDsl.Of())),
                DivisionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<DivisionQueryBuilderDsl> Associates()
        {
            return new CollectionPredicateBuilder<DivisionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("associates")),
                    p => new CombinationQueryPredicate<DivisionQueryBuilderDsl>(p, DivisionQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<DivisionQueryBuilderDsl> InheritedAssociates(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.InheritedAssociateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.InheritedAssociateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DivisionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("inheritedAssociates"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.InheritedAssociateQueryBuilderDsl.Of())),
                DivisionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<DivisionQueryBuilderDsl> InheritedAssociates()
        {
            return new CollectionPredicateBuilder<DivisionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("inheritedAssociates")),
                    p => new CombinationQueryPredicate<DivisionQueryBuilderDsl>(p, DivisionQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<DivisionQueryBuilderDsl> ParentUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DivisionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("parentUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl.Of())),
                DivisionQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<DivisionQueryBuilderDsl> TopLevelUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DivisionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("topLevelUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl.Of())),
                DivisionQueryBuilderDsl.Of);
        }


    }
}
