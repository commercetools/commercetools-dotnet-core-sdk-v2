namespace commercetools.Sdk.Api.Predicates.Query
{
    public class VariableQueryPredicate : ConstantQueryPredicate {

        public VariableQueryPredicate(string variable): base(variable) {
        }

        public VariableQueryPredicate() : base(){
        }

        public new VariableQueryPredicate Constant(string variable) {
            return new VariableQueryPredicate(variable);
        }

        public new string Render() {
            return ":" + base.Render();
        }
        
        public new static VariableQueryPredicate Of()
        {
            return new VariableQueryPredicate();
        }
    }
}