// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Customers
{

    public partial class CustomerSetLocaleActionQueryBuilderDsl
    {
        public CustomerSetLocaleActionQueryBuilderDsl()
        {
        }

        public static CustomerSetLocaleActionQueryBuilderDsl Of()
        {
            return new CustomerSetLocaleActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerSetLocaleActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CustomerSetLocaleActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CustomerSetLocaleActionQueryBuilderDsl>(p, CustomerSetLocaleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerSetLocaleActionQueryBuilderDsl, string> Locale()
        {
            return new ComparisonPredicateBuilder<CustomerSetLocaleActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("locale")),
            p => new CombinationQueryPredicate<CustomerSetLocaleActionQueryBuilderDsl>(p, CustomerSetLocaleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
