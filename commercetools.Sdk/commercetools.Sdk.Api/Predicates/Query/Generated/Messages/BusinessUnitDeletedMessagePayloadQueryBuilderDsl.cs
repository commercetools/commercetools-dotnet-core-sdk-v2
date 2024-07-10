// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitDeletedMessagePayloadQueryBuilderDsl
    {
        public BusinessUnitDeletedMessagePayloadQueryBuilderDsl()
        {
        }

        public static BusinessUnitDeletedMessagePayloadQueryBuilderDsl Of()
        {
            return new BusinessUnitDeletedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitDeletedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitDeletedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitDeletedMessagePayloadQueryBuilderDsl>(p, BusinessUnitDeletedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
