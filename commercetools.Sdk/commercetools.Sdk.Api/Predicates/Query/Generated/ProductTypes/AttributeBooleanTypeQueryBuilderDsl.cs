// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class AttributeBooleanTypeQueryBuilderDsl
    {
        public AttributeBooleanTypeQueryBuilderDsl()
        {
        }

        public static AttributeBooleanTypeQueryBuilderDsl Of()
        {
            return new AttributeBooleanTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeBooleanTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<AttributeBooleanTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<AttributeBooleanTypeQueryBuilderDsl>(p, AttributeBooleanTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
