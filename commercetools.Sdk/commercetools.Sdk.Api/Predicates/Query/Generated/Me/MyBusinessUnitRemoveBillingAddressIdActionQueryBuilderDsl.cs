using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyBusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl
    {
        public MyBusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl()
        {
        }

        public static MyBusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl Of()
        {
            return new MyBusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyBusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyBusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl>(p, MyBusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<MyBusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl>(p, MyBusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyBusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<MyBusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<MyBusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl>(p, MyBusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
