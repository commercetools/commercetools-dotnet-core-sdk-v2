using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitDraftQueryBuilderDsl
    {
        public BusinessUnitDraftQueryBuilderDsl()
        {
        }

        public static BusinessUnitDraftQueryBuilderDsl Of()
        {
            return new BusinessUnitDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<BusinessUnitDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl>(p, BusinessUnitDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitDraftQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<BusinessUnitDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl>(p, BusinessUnitDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl> Stores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                BusinessUnitDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitDraftQueryBuilderDsl> Stores()
        {
            return new CollectionPredicateBuilder<BusinessUnitDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stores")),
                    p => new CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl>(p, BusinessUnitDraftQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<BusinessUnitDraftQueryBuilderDsl, string> StoreMode()
        {
            return new ComparisonPredicateBuilder<BusinessUnitDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("storeMode")),
            p => new CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl>(p, BusinessUnitDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitDraftQueryBuilderDsl, string> UnitType()
        {
            return new ComparisonPredicateBuilder<BusinessUnitDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("unitType")),
            p => new CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl>(p, BusinessUnitDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitDraftQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<BusinessUnitDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl>(p, BusinessUnitDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitDraftQueryBuilderDsl, string> ContactEmail()
        {
            return new ComparisonPredicateBuilder<BusinessUnitDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("contactEmail")),
            p => new CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl>(p, BusinessUnitDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitDraftQueryBuilderDsl, string> AssociateMode()
        {
            return new ComparisonPredicateBuilder<BusinessUnitDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("associateMode")),
            p => new CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl>(p, BusinessUnitDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl> Associates(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associates"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateDraftQueryBuilderDsl.Of())),
                BusinessUnitDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitDraftQueryBuilderDsl> Associates()
        {
            return new CollectionPredicateBuilder<BusinessUnitDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("associates")),
                    p => new CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl>(p, BusinessUnitDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl> Addresses(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("addresses"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                BusinessUnitDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitDraftQueryBuilderDsl> Addresses()
        {
            return new CollectionPredicateBuilder<BusinessUnitDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addresses")),
                    p => new CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl>(p, BusinessUnitDraftQueryBuilderDsl.Of));
        }
        public IComparableCollectionPredicateBuilder<BusinessUnitDraftQueryBuilderDsl, string> ShippingAddresses()
        {
            return new ComparableCollectionPredicateBuilder<BusinessUnitDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingAddresses")),
            p => new CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl>(p, BusinessUnitDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitDraftQueryBuilderDsl, long> DefaultShippingAddress()
        {
            return new ComparisonPredicateBuilder<BusinessUnitDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("defaultShippingAddress")),
            p => new CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl>(p, BusinessUnitDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<BusinessUnitDraftQueryBuilderDsl, string> BillingAddresses()
        {
            return new ComparableCollectionPredicateBuilder<BusinessUnitDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("billingAddresses")),
            p => new CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl>(p, BusinessUnitDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitDraftQueryBuilderDsl, long> DefaultBillingAddress()
        {
            return new ComparisonPredicateBuilder<BusinessUnitDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("defaultBillingAddress")),
            p => new CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl>(p, BusinessUnitDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                BusinessUnitDraftQueryBuilderDsl.Of);
        }


        public CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl> AsCompany(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.CompanyDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.CompanyDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.CompanyDraftQueryBuilderDsl.Of()),
                BusinessUnitDraftQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl> AsDivision(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.DivisionDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.DivisionDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitDraftQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.DivisionDraftQueryBuilderDsl.Of()),
                BusinessUnitDraftQueryBuilderDsl.Of);
        }
    }
}
