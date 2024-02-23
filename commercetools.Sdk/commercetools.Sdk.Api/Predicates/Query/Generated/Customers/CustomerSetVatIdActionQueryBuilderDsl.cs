// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerSetVatIdActionQueryBuilderDsl
    {
        public CustomerSetVatIdActionQueryBuilderDsl()
        {
        }

        public static CustomerSetVatIdActionQueryBuilderDsl Of()
        {
            return new CustomerSetVatIdActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerSetVatIdActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerSetVatIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerSetVatIdActionQueryBuilderDsl>(p, CustomerSetVatIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSetVatIdActionQueryBuilderDsl, string> VatId()
        {
            return new ComparisonPredicateBuilder<CustomerSetVatIdActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("vatId")),
            p => new CombinationQueryPredicate<CustomerSetVatIdActionQueryBuilderDsl>(p, CustomerSetVatIdActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
