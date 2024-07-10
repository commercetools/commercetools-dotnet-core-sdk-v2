using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class CompanyDraftQueryBuilderDsl
    {
        public CompanyDraftQueryBuilderDsl()
        {
        }

        public static CompanyDraftQueryBuilderDsl Of()
        {
            return new CompanyDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CompanyDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<CompanyDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<CompanyDraftQueryBuilderDsl>(p, CompanyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CompanyDraftQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<CompanyDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<CompanyDraftQueryBuilderDsl>(p, CompanyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CompanyDraftQueryBuilderDsl> Stores(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CompanyDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stores"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                CompanyDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CompanyDraftQueryBuilderDsl> Stores()
        {
            return new CollectionPredicateBuilder<CompanyDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stores")),
                    p => new CombinationQueryPredicate<CompanyDraftQueryBuilderDsl>(p, CompanyDraftQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<CompanyDraftQueryBuilderDsl, string> StoreMode()
        {
            return new ComparisonPredicateBuilder<CompanyDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("storeMode")),
            p => new CombinationQueryPredicate<CompanyDraftQueryBuilderDsl>(p, CompanyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CompanyDraftQueryBuilderDsl, string> UnitType()
        {
            return new ComparisonPredicateBuilder<CompanyDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("unitType")),
            p => new CombinationQueryPredicate<CompanyDraftQueryBuilderDsl>(p, CompanyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CompanyDraftQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CompanyDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CompanyDraftQueryBuilderDsl>(p, CompanyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CompanyDraftQueryBuilderDsl, string> ContactEmail()
        {
            return new ComparisonPredicateBuilder<CompanyDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("contactEmail")),
            p => new CombinationQueryPredicate<CompanyDraftQueryBuilderDsl>(p, CompanyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CompanyDraftQueryBuilderDsl, string> AssociateMode()
        {
            return new ComparisonPredicateBuilder<CompanyDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("associateMode")),
            p => new CombinationQueryPredicate<CompanyDraftQueryBuilderDsl>(p, CompanyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CompanyDraftQueryBuilderDsl> Associates(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CompanyDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("associates"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.AssociateDraftQueryBuilderDsl.Of())),
                CompanyDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CompanyDraftQueryBuilderDsl> Associates()
        {
            return new CollectionPredicateBuilder<CompanyDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("associates")),
                    p => new CombinationQueryPredicate<CompanyDraftQueryBuilderDsl>(p, CompanyDraftQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<CompanyDraftQueryBuilderDsl, string> ApprovalRuleMode()
        {
            return new ComparisonPredicateBuilder<CompanyDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("approvalRuleMode")),
            p => new CombinationQueryPredicate<CompanyDraftQueryBuilderDsl>(p, CompanyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CompanyDraftQueryBuilderDsl> Addresses(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CompanyDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("addresses"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseAddressQueryBuilderDsl.Of())),
                CompanyDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CompanyDraftQueryBuilderDsl> Addresses()
        {
            return new CollectionPredicateBuilder<CompanyDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addresses")),
                    p => new CombinationQueryPredicate<CompanyDraftQueryBuilderDsl>(p, CompanyDraftQueryBuilderDsl.Of));
        }
        public IComparableCollectionPredicateBuilder<CompanyDraftQueryBuilderDsl, string> ShippingAddresses()
        {
            return new ComparableCollectionPredicateBuilder<CompanyDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("shippingAddresses")),
            p => new CombinationQueryPredicate<CompanyDraftQueryBuilderDsl>(p, CompanyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CompanyDraftQueryBuilderDsl, long> DefaultShippingAddress()
        {
            return new ComparisonPredicateBuilder<CompanyDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("defaultShippingAddress")),
            p => new CombinationQueryPredicate<CompanyDraftQueryBuilderDsl>(p, CompanyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<CompanyDraftQueryBuilderDsl, string> BillingAddresses()
        {
            return new ComparableCollectionPredicateBuilder<CompanyDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("billingAddresses")),
            p => new CombinationQueryPredicate<CompanyDraftQueryBuilderDsl>(p, CompanyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CompanyDraftQueryBuilderDsl, long> DefaultBillingAddress()
        {
            return new ComparisonPredicateBuilder<CompanyDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("defaultBillingAddress")),
            p => new CombinationQueryPredicate<CompanyDraftQueryBuilderDsl>(p, CompanyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CompanyDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CompanyDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                CompanyDraftQueryBuilderDsl.Of);
        }


    }
}
