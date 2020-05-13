using DevLab.JmesPath;

namespace Jmespath
{
    public class FlattenProjections
    {
        private static JmesPath jmes;
        private static string[] expression = { "reservations[*].instances[*].state", "[]" };
        private static string[] json = { @"{'reservations': [{'instances': {'state': 'running'},
                                                             {'state': 'stopped'}]},
                                            {'instances': [{'state': 'terminated'},{'state': 'running'}]}]}'",
                                         @"[[0, 1],2,[3],4,[5, [6, 7]]]"};

        public FlattenProjections()
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
