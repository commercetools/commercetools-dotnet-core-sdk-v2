using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitQueryBuilderDsl
    {
        public BusinessUnitQueryBuilderDsl()
        {
        }

        public static BusinessUnitQueryBuilderDsl Of()
        {
            return new BusinessUnitQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(p, BusinessUnitQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(p, BusinessUnitQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(p, BusinessUnitQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(p, BusinessUnitQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                BusinessUnitQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<BusinessUnitQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                BusinessUnitQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(p, BusinessUnitQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(p, BusinessUnitQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitQueryBuilderDsl> Stores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                BusinessUnitQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitQueryBuilderDsl> Stores()
        {
            return new CollectionPredicateBuilder<BusinessUnitQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stores")),
                    p => new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(p, BusinessUnitQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<BusinessUnitQueryBuilderDsl> InheritedStores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("inheritedStores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                BusinessUnitQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitQueryBuilderDsl> InheritedStores()
        {
            return new CollectionPredicateBuilder<BusinessUnitQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("inheritedStores")),
                    p => new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(p, BusinessUnitQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, string> StoreMode()
        {
            return new ComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("storeMode")),
            p => new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(p, BusinessUnitQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, string> UnitType()
        {
            return new ComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("unitType")),
            p => new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(p, BusinessUnitQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(p, BusinessUnitQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, string> ContactEmail()
        {
            return new ComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("contactEmail")),
            p => new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(p, BusinessUnitQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                BusinessUnitQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<BusinessUnitQueryBuilderDsl> Addresses(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("addresses"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                BusinessUnitQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitQueryBuilderDsl> Addresses()
        {
            return new CollectionPredicateBuilder<BusinessUnitQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addresses")),
                    p => new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(p, BusinessUnitQueryBuilderDsl.Of));
        }
        public IComparableCollectionPredicateBuilder<BusinessUnitQueryBuilderDsl, string> ShippingAddressIds()
        {
            return new ComparableCollectionPredicateBuilder<BusinessUnitQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingAddressIds")),
            p => new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(p, BusinessUnitQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, string> DefaultShippingAddressId()
        {
            return new ComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("defaultShippingAddressId")),
            p => new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(p, BusinessUnitQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<BusinessUnitQueryBuilderDsl, string> BillingAddressIds()
        {
            return new ComparableCollectionPredicateBuilder<BusinessUnitQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("billingAddressIds")),
            p => new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(p, BusinessUnitQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, string> DefaultBillingAddressId()
        {
            return new ComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("defaultBillingAddressId")),
            p => new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(p, BusinessUnitQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, string> AssociateMode()
        {
            return new ComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("associateMode")),
            p => new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(p, BusinessUnitQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitQueryBuilderDsl> Associates(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associates"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateQueryBuilderDsl.Of())),
                BusinessUnitQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitQueryBuilderDsl> Associates()
        {
            return new CollectionPredicateBuilder<BusinessUnitQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("associates")),
                    p => new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(p, BusinessUnitQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<BusinessUnitQueryBuilderDsl> InheritedAssociates(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.InheritedAssociateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.InheritedAssociateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("inheritedAssociates"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.InheritedAssociateQueryBuilderDsl.Of())),
                BusinessUnitQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitQueryBuilderDsl> InheritedAssociates()
        {
            return new CollectionPredicateBuilder<BusinessUnitQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("inheritedAssociates")),
                    p => new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(p, BusinessUnitQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<BusinessUnitQueryBuilderDsl> ParentUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("parentUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl.Of())),
                BusinessUnitQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<BusinessUnitQueryBuilderDsl> TopLevelUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("topLevelUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl.Of())),
                BusinessUnitQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, string> ApprovalRuleMode()
        {
            return new ComparisonPredicateBuilder<BusinessUnitQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("approvalRuleMode")),
            p => new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(p, BusinessUnitQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<BusinessUnitQueryBuilderDsl> AsCompany(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.CompanyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.CompanyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.CompanyQueryBuilderDsl.Of()),
                BusinessUnitQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitQueryBuilderDsl> AsDivision(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.DivisionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.DivisionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.DivisionQueryBuilderDsl.Of()),
                BusinessUnitQueryBuilderDsl.Of);
        }
    }
}
