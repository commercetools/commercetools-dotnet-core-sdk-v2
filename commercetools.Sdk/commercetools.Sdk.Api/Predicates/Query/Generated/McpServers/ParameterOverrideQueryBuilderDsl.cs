// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.McpServers
{

    public partial class ParameterOverrideQueryBuilderDsl
    {
        public ParameterOverrideQueryBuilderDsl()
        {
        }

        public static ParameterOverrideQueryBuilderDsl Of()
        {
            return new ParameterOverrideQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ParameterOverrideQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ParameterOverrideQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ParameterOverrideQueryBuilderDsl>(p, ParameterOverrideQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParameterOverrideQueryBuilderDsl, string> Description()
        {
            return new ComparisonPredicateBuilder<ParameterOverrideQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("description")),
            p => new CombinationQueryPredicate<ParameterOverrideQueryBuilderDsl>(p, ParameterOverrideQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParameterOverrideQueryBuilderDsl, string> Const()
        {
            return new ComparisonPredicateBuilder<ParameterOverrideQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("const")),
            p => new CombinationQueryPredicate<ParameterOverrideQueryBuilderDsl>(p, ParameterOverrideQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParameterOverrideQueryBuilderDsl, string> Default()
        {
            return new ComparisonPredicateBuilder<ParameterOverrideQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("default")),
            p => new CombinationQueryPredicate<ParameterOverrideQueryBuilderDsl>(p, ParameterOverrideQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ParameterOverrideQueryBuilderDsl, string> AllowedTypes()
        {
            return new ComparisonPredicateBuilder<ParameterOverrideQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("allowedTypes")),
            p => new CombinationQueryPredicate<ParameterOverrideQueryBuilderDsl>(p, ParameterOverrideQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
