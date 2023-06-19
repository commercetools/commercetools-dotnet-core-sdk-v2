using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class CompanyQueryBuilderDsl
    {
        public CompanyQueryBuilderDsl()
        {
        }

        public static CompanyQueryBuilderDsl Of()
        {
            return new CompanyQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CompanyQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CompanyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CompanyQueryBuilderDsl>(p, CompanyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CompanyQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<CompanyQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<CompanyQueryBuilderDsl>(p, CompanyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CompanyQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<CompanyQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<CompanyQueryBuilderDsl>(p, CompanyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CompanyQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<CompanyQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<CompanyQueryBuilderDsl>(p, CompanyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CompanyQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CompanyQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                CompanyQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CompanyQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CompanyQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                CompanyQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CompanyQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CompanyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CompanyQueryBuilderDsl>(p, CompanyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CompanyQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<CompanyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<CompanyQueryBuilderDsl>(p, CompanyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CompanyQueryBuilderDsl> Stores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CompanyQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                CompanyQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CompanyQueryBuilderDsl> Stores()
        {
            return new CollectionPredicateBuilder<CompanyQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stores")),
                    p => new CombinationQueryPredicate<CompanyQueryBuilderDsl>(p, CompanyQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<CompanyQueryBuilderDsl, string> StoreMode()
        {
            return new ComparisonPredicateBuilder<CompanyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("storeMode")),
            p => new CombinationQueryPredicate<CompanyQueryBuilderDsl>(p, CompanyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CompanyQueryBuilderDsl, string> UnitType()
        {
            return new ComparisonPredicateBuilder<CompanyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("unitType")),
            p => new CombinationQueryPredicate<CompanyQueryBuilderDsl>(p, CompanyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CompanyQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CompanyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CompanyQueryBuilderDsl>(p, CompanyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CompanyQueryBuilderDsl, string> ContactEmail()
        {
            return new ComparisonPredicateBuilder<CompanyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("contactEmail")),
            p => new CombinationQueryPredicate<CompanyQueryBuilderDsl>(p, CompanyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CompanyQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CompanyQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                CompanyQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CompanyQueryBuilderDsl> Addresses(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CompanyQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("addresses"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                CompanyQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CompanyQueryBuilderDsl> Addresses()
        {
            return new CollectionPredicateBuilder<CompanyQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addresses")),
                    p => new CombinationQueryPredicate<CompanyQueryBuilderDsl>(p, CompanyQueryBuilderDsl.Of));
        }
        public IComparableCollectionPredicateBuilder<CompanyQueryBuilderDsl, string> ShippingAddressIds()
        {
            return new ComparableCollectionPredicateBuilder<CompanyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingAddressIds")),
            p => new CombinationQueryPredicate<CompanyQueryBuilderDsl>(p, CompanyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CompanyQueryBuilderDsl, string> DefaultShippingAddressId()
        {
            return new ComparisonPredicateBuilder<CompanyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("defaultShippingAddressId")),
            p => new CombinationQueryPredicate<CompanyQueryBuilderDsl>(p, CompanyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<CompanyQueryBuilderDsl, string> BillingAddressIds()
        {
            return new ComparableCollectionPredicateBuilder<CompanyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("billingAddressIds")),
            p => new CombinationQueryPredicate<CompanyQueryBuilderDsl>(p, CompanyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CompanyQueryBuilderDsl, string> DefaultBillingAddressId()
        {
            return new ComparisonPredicateBuilder<CompanyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("defaultBillingAddressId")),
            p => new CombinationQueryPredicate<CompanyQueryBuilderDsl>(p, CompanyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CompanyQueryBuilderDsl, string> AssociateMode()
        {
            return new ComparisonPredicateBuilder<CompanyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("associateMode")),
            p => new CombinationQueryPredicate<CompanyQueryBuilderDsl>(p, CompanyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CompanyQueryBuilderDsl> Associates(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CompanyQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associates"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateQueryBuilderDsl.Of())),
                CompanyQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CompanyQueryBuilderDsl> Associates()
        {
            return new CollectionPredicateBuilder<CompanyQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("associates")),
                    p => new CombinationQueryPredicate<CompanyQueryBuilderDsl>(p, CompanyQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<CompanyQueryBuilderDsl> InheritedAssociates(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.InheritedAssociateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.InheritedAssociateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CompanyQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("inheritedAssociates"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.InheritedAssociateQueryBuilderDsl.Of())),
                CompanyQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CompanyQueryBuilderDsl> InheritedAssociates()
        {
            return new CollectionPredicateBuilder<CompanyQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("inheritedAssociates")),
                    p => new CombinationQueryPredicate<CompanyQueryBuilderDsl>(p, CompanyQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<CompanyQueryBuilderDsl> ParentUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CompanyQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("parentUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl.Of())),
                CompanyQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<CompanyQueryBuilderDsl> TopLevelUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CompanyQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("topLevelUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl.Of())),
                CompanyQueryBuilderDsl.Of);
        }


    }
}
