// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerCompanyNameSetMessagePayloadQueryBuilderDsl
    {
        public CustomerCompanyNameSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerCompanyNameSetMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerCompanyNameSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerCompanyNameSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerCompanyNameSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerCompanyNameSetMessagePayloadQueryBuilderDsl>(p, CustomerCompanyNameSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerCompanyNameSetMessagePayloadQueryBuilderDsl, string> CompanyName()
        {
            return new ComparisonPredicateBuilder<CustomerCompanyNameSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("companyName")),
            p => new CombinationQueryPredicate<CustomerCompanyNameSetMessagePayloadQueryBuilderDsl>(p, CustomerCompanyNameSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
