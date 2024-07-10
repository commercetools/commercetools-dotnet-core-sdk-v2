using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitUpdateActionQueryBuilderDsl
    {
        public BusinessUnitUpdateActionQueryBuilderDsl()
        {
        }

        public static BusinessUnitUpdateActionQueryBuilderDsl Of()
        {
            return new BusinessUnitUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<BusinessUnitUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(p, BusinessUnitUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsAddAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitAddAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitAddAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitAddAddressActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsAddAssociate(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitAddAssociateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitAddAssociateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitAddAssociateActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsAddBillingAddressId(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitAddBillingAddressIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitAddBillingAddressIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitAddBillingAddressIdActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsAddShippingAddressId(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitAddShippingAddressIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitAddShippingAddressIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitAddShippingAddressIdActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsAddStore(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitAddStoreActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitAddStoreActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitAddStoreActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsChangeAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitChangeAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitChangeAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitChangeAddressActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsChangeApprovalRuleMode(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitChangeApprovalRuleModeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitChangeApprovalRuleModeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitChangeApprovalRuleModeActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsChangeAssociate(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitChangeAssociateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitChangeAssociateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitChangeAssociateActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsChangeAssociateMode(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitChangeAssociateModeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitChangeAssociateModeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitChangeAssociateModeActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsChangeName(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitChangeNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitChangeNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitChangeNameActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsChangeParentUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitChangeParentUnitActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitChangeParentUnitActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitChangeParentUnitActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsChangeStatus(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitChangeStatusActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitChangeStatusActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitChangeStatusActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsRemoveAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitRemoveAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitRemoveAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitRemoveAddressActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsRemoveAssociate(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitRemoveAssociateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitRemoveAssociateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitRemoveAssociateActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsRemoveBillingAddressId(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsRemoveShippingAddressId(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitRemoveShippingAddressIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitRemoveShippingAddressIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitRemoveShippingAddressIdActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsRemoveStore(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitRemoveStoreActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitRemoveStoreActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitRemoveStoreActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsSetAddressCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetAddressCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetAddressCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetAddressCustomFieldActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsSetAddressCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetAddressCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetAddressCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetAddressCustomTypeActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsSetAssociates(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetAssociatesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetAssociatesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetAssociatesActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsSetContactEmail(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetContactEmailActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetContactEmailActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetContactEmailActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetCustomFieldActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetCustomTypeActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsSetDefaultBillingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsSetDefaultShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsSetStoreMode(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetStoreModeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetStoreModeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetStoreModeActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl> AsSetStores(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetStoresActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetStoresActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitSetStoresActionQueryBuilderDsl.Of()),
                BusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
    }
}
