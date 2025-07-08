// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies
{

    public partial class RecurrencePolicyResourceIdentifierQueryBuilderDsl
    {
        public RecurrencePolicyResourceIdentifierQueryBuilderDsl()
        {
        }

        public static RecurrencePolicyResourceIdentifierQueryBuilderDsl Of()
        {
            return new RecurrencePolicyResourceIdentifierQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurrencePolicyResourceIdentifierQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<RecurrencePolicyResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<RecurrencePolicyResourceIdentifierQueryBuilderDsl>(p, RecurrencePolicyResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurrencePolicyResourceIdentifierQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<RecurrencePolicyResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<RecurrencePolicyResourceIdentifierQueryBuilderDsl>(p, RecurrencePolicyResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurrencePolicyResourceIdentifierQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<RecurrencePolicyResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<RecurrencePolicyResourceIdentifierQueryBuilderDsl>(p, RecurrencePolicyResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
