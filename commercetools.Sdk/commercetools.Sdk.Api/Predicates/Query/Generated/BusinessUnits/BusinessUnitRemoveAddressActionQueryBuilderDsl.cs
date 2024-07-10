using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitRemoveAddressActionQueryBuilderDsl
    {
        public BusinessUnitRemoveAddressActionQueryBuilderDsl()
        {
        }

        public static BusinessUnitRemoveAddressActionQueryBuilderDsl Of()
        {
            return new BusinessUnitRemoveAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitRemoveAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<BusinessUnitRemoveAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<BusinessUnitRemoveAddressActionQueryBuilderDsl>(p, BusinessUnitRemoveAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitRemoveAddressActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<BusinessUnitRemoveAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<BusinessUnitRemoveAddressActionQueryBuilderDsl>(p, BusinessUnitRemoveAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitRemoveAddressActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<BusinessUnitRemoveAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<BusinessUnitRemoveAddressActionQueryBuilderDsl>(p, BusinessUnitRemoveAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
