// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountGroups
{

    public partial class DiscountGroupResourceIdentifierQueryBuilderDsl
    {
        public DiscountGroupResourceIdentifierQueryBuilderDsl()
        {
        }

        public static DiscountGroupResourceIdentifierQueryBuilderDsl Of()
        {
            return new DiscountGroupResourceIdentifierQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountGroupResourceIdentifierQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<DiscountGroupResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<DiscountGroupResourceIdentifierQueryBuilderDsl>(p, DiscountGroupResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupResourceIdentifierQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<DiscountGroupResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<DiscountGroupResourceIdentifierQueryBuilderDsl>(p, DiscountGroupResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupResourceIdentifierQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<DiscountGroupResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<DiscountGroupResourceIdentifierQueryBuilderDsl>(p, DiscountGroupResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
