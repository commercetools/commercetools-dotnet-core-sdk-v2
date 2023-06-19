// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.AttributeGroups
{

    public partial class AttributeGroupResourceIdentifierQueryBuilderDsl
    {
        public AttributeGroupResourceIdentifierQueryBuilderDsl()
        {
        }

        public static AttributeGroupResourceIdentifierQueryBuilderDsl Of()
        {
            return new AttributeGroupResourceIdentifierQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AttributeGroupResourceIdentifierQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<AttributeGroupResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<AttributeGroupResourceIdentifierQueryBuilderDsl>(p, AttributeGroupResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeGroupResourceIdentifierQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<AttributeGroupResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<AttributeGroupResourceIdentifierQueryBuilderDsl>(p, AttributeGroupResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AttributeGroupResourceIdentifierQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<AttributeGroupResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<AttributeGroupResourceIdentifierQueryBuilderDsl>(p, AttributeGroupResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
