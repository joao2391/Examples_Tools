using DevLab.JmesPath;

namespace Jmespath
{
    public class ObjectProjections
    {
        private static JmesPath jmes;
        private static string[] expression = { "ops.*.numArgs" };
        private static string[] json = { @"{'ops': {'functionA': {'numArgs': 2},
                                                    'functionB': {'numArgs': 3},
                                                    'functionC': {'variadic': true} }}" };

        public ObjectProjections()
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
