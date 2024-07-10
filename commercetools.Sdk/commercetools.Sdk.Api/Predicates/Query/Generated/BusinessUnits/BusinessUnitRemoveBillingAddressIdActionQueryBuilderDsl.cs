using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl
    {
        public BusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl()
        {
        }

        public static BusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl Of()
        {
            return new BusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<BusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<BusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl>(p, BusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<BusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<BusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl>(p, BusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<BusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<BusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl>(p, BusinessUnitRemoveBillingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
