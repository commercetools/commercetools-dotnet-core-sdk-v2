// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerTitleSetMessagePayloadQueryBuilderDsl
    {
        public CustomerTitleSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerTitleSetMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerTitleSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerTitleSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerTitleSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerTitleSetMessagePayloadQueryBuilderDsl>(p, CustomerTitleSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerTitleSetMessagePayloadQueryBuilderDsl, string> Title()
        {
            return new ComparisonPredicateBuilder<CustomerTitleSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("title")),
            p => new CombinationQueryPredicate<CustomerTitleSetMessagePayloadQueryBuilderDsl>(p, CustomerTitleSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
