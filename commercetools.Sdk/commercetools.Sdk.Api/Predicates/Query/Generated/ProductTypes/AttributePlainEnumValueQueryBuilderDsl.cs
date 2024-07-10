// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class AttributePlainEnumValueQueryBuilderDsl
    {
        public AttributePlainEnumValueQueryBuilderDsl()
        {
        }

        public static AttributePlainEnumValueQueryBuilderDsl Of()
        {
            return new AttributePlainEnumValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributePlainEnumValueQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<AttributePlainEnumValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<AttributePlainEnumValueQueryBuilderDsl>(p, AttributePlainEnumValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributePlainEnumValueQueryBuilderDsl, string> Label()
        {
            return new ComparisonPredicateBuilder<AttributePlainEnumValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("label")),
            p => new CombinationQueryPredicate<AttributePlainEnumValueQueryBuilderDsl>(p, AttributePlainEnumValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
