// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitAddBillingAddressIdActionQueryBuilderDsl
    {
        public BusinessUnitAddBillingAddressIdActionQueryBuilderDsl()
        {
        }

        public static BusinessUnitAddBillingAddressIdActionQueryBuilderDsl Of()
        {
            return new BusinessUnitAddBillingAddressIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitAddBillingAddressIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddBillingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<BusinessUnitAddBillingAddressIdActionQueryBuilderDsl>(p, BusinessUnitAddBillingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitAddBillingAddressIdActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddBillingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<BusinessUnitAddBillingAddressIdActionQueryBuilderDsl>(p, BusinessUnitAddBillingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitAddBillingAddressIdActionQueryBuilderDsl, string> AddressKey()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddBillingAddressIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressKey")),
            p => new CombinationQueryPredicate<BusinessUnitAddBillingAddressIdActionQueryBuilderDsl>(p, BusinessUnitAddBillingAddressIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
