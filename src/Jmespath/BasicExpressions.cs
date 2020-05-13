using DevLab.JmesPath;

namespace Jmespath
{
    public class BasicExpressions
    {
        private static JmesPath jmes;
        private static string[] expression = { "a", "a.b.c.d", "[1]", "a.b.c[0].d[1][0]" };   
        private static string[] json = { @"{'a': 'foo', 'b': 'bar', 'c': 'baz'}",
                                  @"{'a': {'b': {'c': {'d': 'value'}}}}",
                                  @"['a', 'b', 'c', 'd', 'e', 'f']",
                                  @"{'a': {'b': {'c': [{'d': [0, [1, 2]]},{'d': [3, 4]}]}}}"};

        public BasicExpressions()
        {
            jmes = new JmesPath();
        }
        
        
        public static string Transform()
        {
            
            var resultJson = jmes.Transform(json[0], expression[0]);

            return resultJson;
        }
       
    }
}
