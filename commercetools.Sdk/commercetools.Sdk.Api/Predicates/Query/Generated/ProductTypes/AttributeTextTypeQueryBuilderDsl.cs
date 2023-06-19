// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class AttributeTextTypeQueryBuilderDsl
    {
        public AttributeTextTypeQueryBuilderDsl()
        {
        }

        public static AttributeTextTypeQueryBuilderDsl Of()
        {
            return new AttributeTextTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeTextTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<AttributeTextTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<AttributeTextTypeQueryBuilderDsl>(p, AttributeTextTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
