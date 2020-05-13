using DevLab.JmesPath;

namespace Jmespath
{
    public class FilterProjections
    {
        private static JmesPath jmes;
        private static string[] expression = { "machines[?state=='running'].name" };
        private static string[] json = { @"{'machines':[{'name': 'a', 'state':'running'},
                                                        {'name': 'b', 'state':'stopped'},
                                                        {'name': 'b', 'state':'running'}]}" };

        public FilterProjections()
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
