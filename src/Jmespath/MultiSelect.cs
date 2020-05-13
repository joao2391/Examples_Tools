using DevLab.JmesPath;

namespace Jmespath
{
    public class MultiSelect
    {
        private static JmesPath jmes;
        private static string[] expression = { "people[].[name, state.name]", "people[].{Name: name, State: state.name}" };
        private static string[] json = { @"{'people':[{'name': 'a','state': {'name':'up'}},
                                                      {'name': 'b','state':'name':'down'}},
                                                      {'name': 'c','state': {'name': 'up'}}]}" };

        public MultiSelect()
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
