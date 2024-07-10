// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountCodes
{

    public partial class DiscountCodeResourceIdentifierQueryBuilderDsl
    {
        public DiscountCodeResourceIdentifierQueryBuilderDsl()
        {
        }

        public static DiscountCodeResourceIdentifierQueryBuilderDsl Of()
        {
            return new DiscountCodeResourceIdentifierQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountCodeResourceIdentifierQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<DiscountCodeResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<DiscountCodeResourceIdentifierQueryBuilderDsl>(p, DiscountCodeResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeResourceIdentifierQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<DiscountCodeResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<DiscountCodeResourceIdentifierQueryBuilderDsl>(p, DiscountCodeResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeResourceIdentifierQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<DiscountCodeResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<DiscountCodeResourceIdentifierQueryBuilderDsl>(p, DiscountCodeResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
