using DevLab.JmesPath;

namespace Jmespath
{
    public class Slicing
    {
        private static JmesPath jmes;
        private static string[] expression = { "[0:5]", "[5:10]", "[:5]", "[::2]", "[::-1]" };
        private static string[] json = { @"[0, 1, 2, 3, 4, 5, 6, 7, 8, 9]" };

        public Slicing()
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
