// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class AttributeMoneyTypeQueryBuilderDsl
    {
        public AttributeMoneyTypeQueryBuilderDsl()
        {
        }

        public static AttributeMoneyTypeQueryBuilderDsl Of()
        {
            return new AttributeMoneyTypeQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeMoneyTypeQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<AttributeMoneyTypeQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<AttributeMoneyTypeQueryBuilderDsl>(p, AttributeMoneyTypeQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
