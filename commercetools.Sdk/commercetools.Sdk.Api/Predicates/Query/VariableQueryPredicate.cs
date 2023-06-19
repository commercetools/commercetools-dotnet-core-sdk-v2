namespace commercetools.Sdk.Api.Predicates.Query
{
    public class VariableQueryPredicate : IQueryPredicate
    {

        private readonly string _variable;

        public VariableQueryPredicate(string variable)
        {
            this._variable = variable;
        }

        public VariableQueryPredicate()
        {
            this._variable = null;
        }

        public string Variable()
        {
            return _variable;
        }

        public VariableQueryPredicate Variable(string variable)
        {
            return new VariableQueryPredicate(variable);
        }

        public string Render()
        {
            return $":{_variable}";
        }

        public static VariableQueryPredicate Of()
        {
            return new VariableQueryPredicate();
        }
    }
}