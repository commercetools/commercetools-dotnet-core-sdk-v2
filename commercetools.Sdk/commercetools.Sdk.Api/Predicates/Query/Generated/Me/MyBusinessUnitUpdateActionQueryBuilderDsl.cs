using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyBusinessUnitUpdateActionQueryBuilderDsl
    {
        public MyBusinessUnitUpdateActionQueryBuilderDsl()
        {
        }

        public static MyBusinessUnitUpdateActionQueryBuilderDsl Of()
        {
            return new MyBusinessUnitUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyBusinessUnitUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl>(p, MyBusinessUnitUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl> AsAddAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitAddAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitAddAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitAddAddressActionQueryBuilderDsl.Of()),
                MyBusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl> AsAddBillingAddressId(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitAddBillingAddressIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitAddBillingAddressIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitAddBillingAddressIdActionQueryBuilderDsl.Of()),
                MyBusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl> AsAddShippingAddressId(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitAddShippingAddressIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitAddShippingAddressIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitAddShippingAddressIdActionQueryBuilderDsl.Of()),
                MyBusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl> AsChangeAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitChangeAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitChangeAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitChangeAddressActionQueryBuilderDsl.Of()),
                MyBusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl> AsChangeAssociate(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitChangeAssociateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitChangeAssociateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitChangeAssociateActionQueryBuilderDsl.Of()),
                MyBusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl> AsChangeName(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitChangeNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitChangeNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitChangeNameActionQueryBuilderDsl.Of()),
                MyBusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl> AsChangeParentUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitChangeParentUnitActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitChangeParentUnitActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitChangeParentUnitActionQueryBuilderDsl.Of()),
                MyBusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl> AsRemoveAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitRemoveAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitRemoveAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitRemoveAddressActionQueryBuilderDsl.Of()),
                MyBusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl> AsRemoveAssociate(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitRemoveAssociateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitRemoveAssociateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitRemoveAssociateActionQueryBuilderDsl.Of()),
                MyBusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl> AsRemoveBillingAddressId(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl.Of()),
                MyBusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl> AsRemoveShippingAddressId(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitRemoveShippingAddressIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitRemoveShippingAddressIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitRemoveShippingAddressIdActionQueryBuilderDsl.Of()),
                MyBusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl> AsSetAddressCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitSetAddressCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitSetAddressCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitSetAddressCustomFieldActionQueryBuilderDsl.Of()),
                MyBusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl> AsSetAddressCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitSetAddressCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitSetAddressCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitSetAddressCustomTypeActionQueryBuilderDsl.Of()),
                MyBusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl> AsSetContactEmail(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitSetContactEmailActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitSetContactEmailActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitSetContactEmailActionQueryBuilderDsl.Of()),
                MyBusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitSetCustomFieldActionQueryBuilderDsl.Of()),
                MyBusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitSetCustomTypeActionQueryBuilderDsl.Of()),
                MyBusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl> AsSetDefaultBillingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl.Of()),
                MyBusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl> AsSetDefaultShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyBusinessUnitUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyBusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl.Of()),
                MyBusinessUnitUpdateActionQueryBuilderDsl.Of);
        }
    }
}
