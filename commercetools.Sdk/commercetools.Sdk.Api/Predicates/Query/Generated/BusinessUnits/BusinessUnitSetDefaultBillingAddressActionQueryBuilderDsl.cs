// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl
    {
        public BusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl()
        {
        }

        public static BusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl Of()
        {
            return new BusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<BusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<BusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl>(p, BusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<BusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<BusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl>(p, BusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<BusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<BusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl>(p, BusinessUnitSetDefaultBillingAddressActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
