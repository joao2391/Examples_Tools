using DevLab.JmesPath;

namespace Jmespath
{
    public class PipeExpressions
    {
        private static JmesPath jmes;
        private static string[] expression = { "people[*].first | [0]" };
        private static string[] json = { @"{'people':[{'first': 'James', 'last': 'd'},{'first': 'Jacob', 'last': 'e'},
                                                      {'first': 'Jayden','last':'f'},'missing':'different'}],
                                                    'foo': {'bar': 'baz'}}'"};

        public PipeExpressions()
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
