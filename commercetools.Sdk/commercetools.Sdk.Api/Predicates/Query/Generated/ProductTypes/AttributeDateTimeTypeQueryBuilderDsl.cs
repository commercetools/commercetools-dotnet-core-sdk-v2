// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class AttributeDateTimeTypeQueryBuilderDsl
    {
        public AttributeDateTimeTypeQueryBuilderDsl()
        {
        }

        public static AttributeDateTimeTypeQueryBuilderDsl Of()
        {
            return new AttributeDateTimeTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeDateTimeTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<AttributeDateTimeTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<AttributeDateTimeTypeQueryBuilderDsl>(p, AttributeDateTimeTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
