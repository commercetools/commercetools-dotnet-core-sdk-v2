// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl
    {
        public BusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl()
        {
        }

        public static BusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl Of()
        {
            return new BusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<BusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<BusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl>(p, BusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<BusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<BusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl>(p, BusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<BusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<BusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl>(p, BusinessUnitSetDefaultShippingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
