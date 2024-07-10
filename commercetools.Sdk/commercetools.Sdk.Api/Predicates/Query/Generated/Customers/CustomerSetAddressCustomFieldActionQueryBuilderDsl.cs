// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerSetAddressCustomFieldActionQueryBuilderDsl
    {
        public CustomerSetAddressCustomFieldActionQueryBuilderDsl()
        {
        }

        public static CustomerSetAddressCustomFieldActionQueryBuilderDsl Of()
        {
            return new CustomerSetAddressCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerSetAddressCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerSetAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerSetAddressCustomFieldActionQueryBuilderDsl>(p, CustomerSetAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSetAddressCustomFieldActionQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<CustomerSetAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<CustomerSetAddressCustomFieldActionQueryBuilderDsl>(p, CustomerSetAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSetAddressCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CustomerSetAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CustomerSetAddressCustomFieldActionQueryBuilderDsl>(p, CustomerSetAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSetAddressCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<CustomerSetAddressCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<CustomerSetAddressCustomFieldActionQueryBuilderDsl>(p, CustomerSetAddressCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
