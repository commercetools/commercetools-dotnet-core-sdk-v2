// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategorySetCustomFieldActionQueryBuilderDsl
    {
        public CategorySetCustomFieldActionQueryBuilderDsl()
        {
        }

        public static CategorySetCustomFieldActionQueryBuilderDsl Of()
        {
            return new CategorySetCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategorySetCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategorySetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategorySetCustomFieldActionQueryBuilderDsl>(p, CategorySetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategorySetCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CategorySetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CategorySetCustomFieldActionQueryBuilderDsl>(p, CategorySetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategorySetCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<CategorySetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<CategorySetCustomFieldActionQueryBuilderDsl>(p, CategorySetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
