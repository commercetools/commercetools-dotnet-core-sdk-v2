// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class AttributeLocalizableTextTypeQueryBuilderDsl
    {
        public AttributeLocalizableTextTypeQueryBuilderDsl()
        {
        }

        public static AttributeLocalizableTextTypeQueryBuilderDsl Of()
        {
            return new AttributeLocalizableTextTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeLocalizableTextTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<AttributeLocalizableTextTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<AttributeLocalizableTextTypeQueryBuilderDsl>(p, AttributeLocalizableTextTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
