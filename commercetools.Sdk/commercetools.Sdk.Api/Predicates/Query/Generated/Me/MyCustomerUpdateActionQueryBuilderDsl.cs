using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCustomerUpdateActionQueryBuilderDsl
    {
        public MyCustomerUpdateActionQueryBuilderDsl()
        {
        }

        public static MyCustomerUpdateActionQueryBuilderDsl Of()
        {
            return new MyCustomerUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCustomerUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCustomerUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl>(p, MyCustomerUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl> AsAddAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerAddAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerAddAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerAddAddressActionQueryBuilderDsl.Of()),
                MyCustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl> AsAddBillingAddressId(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerAddBillingAddressIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerAddBillingAddressIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerAddBillingAddressIdActionQueryBuilderDsl.Of()),
                MyCustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl> AsAddShippingAddressId(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerAddShippingAddressIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerAddShippingAddressIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerAddShippingAddressIdActionQueryBuilderDsl.Of()),
                MyCustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl> AsChangeAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerChangeAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerChangeAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerChangeAddressActionQueryBuilderDsl.Of()),
                MyCustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl> AsChangeEmail(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerChangeEmailActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerChangeEmailActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerChangeEmailActionQueryBuilderDsl.Of()),
                MyCustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl> AsRemoveAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerRemoveAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerRemoveAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerRemoveAddressActionQueryBuilderDsl.Of()),
                MyCustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl> AsRemoveBillingAddressId(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerRemoveBillingAddressIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerRemoveBillingAddressIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerRemoveBillingAddressIdActionQueryBuilderDsl.Of()),
                MyCustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl> AsRemoveShippingAddressId(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerRemoveShippingAddressIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerRemoveShippingAddressIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerRemoveShippingAddressIdActionQueryBuilderDsl.Of()),
                MyCustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl> AsSetCompanyName(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetCompanyNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetCompanyNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetCompanyNameActionQueryBuilderDsl.Of()),
                MyCustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetCustomFieldActionQueryBuilderDsl.Of()),
                MyCustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetCustomTypeActionQueryBuilderDsl.Of()),
                MyCustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl> AsSetDateOfBirth(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetDateOfBirthActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetDateOfBirthActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetDateOfBirthActionQueryBuilderDsl.Of()),
                MyCustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl> AsSetDefaultBillingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetDefaultBillingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetDefaultBillingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetDefaultBillingAddressActionQueryBuilderDsl.Of()),
                MyCustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl> AsSetDefaultShippingAddress(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetDefaultShippingAddressActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetDefaultShippingAddressActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetDefaultShippingAddressActionQueryBuilderDsl.Of()),
                MyCustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl> AsSetFirstName(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetFirstNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetFirstNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetFirstNameActionQueryBuilderDsl.Of()),
                MyCustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl> AsSetLastName(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetLastNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetLastNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetLastNameActionQueryBuilderDsl.Of()),
                MyCustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl> AsSetLocale(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetLocaleActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetLocaleActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetLocaleActionQueryBuilderDsl.Of()),
                MyCustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl> AsSetMiddleName(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetMiddleNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetMiddleNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetMiddleNameActionQueryBuilderDsl.Of()),
                MyCustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl> AsSetSalutation(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetSalutationActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetSalutationActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetSalutationActionQueryBuilderDsl.Of()),
                MyCustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl> AsSetTitle(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetTitleActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetTitleActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetTitleActionQueryBuilderDsl.Of()),
                MyCustomerUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl> AsSetVatId(
            Func<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetVatIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetVatIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyCustomerUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Me.MyCustomerSetVatIdActionQueryBuilderDsl.Of()),
                MyCustomerUpdateActionQueryBuilderDsl.Of);
        }
    }
}
