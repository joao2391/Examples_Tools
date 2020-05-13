using DevLab.JmesPath;

namespace Jmespath
{
    class Functions
    {
        private static JmesPath jmes;
        private static string[] expression = { "length(people)", "max_by(people, &age).name", "myarray[?contains(@, 'foo') == `true`]" };
        private static string[] json = { @"{'people':[{'name': 'b','age': 30,'state':{'name': 'up'}},
                                                      {'name': 'a','age': 50,'state': {'name': 'down'}},
                                                      {'name':'c','age': 40,'state': {'name': 'up'}}]}",
                                         @"{'people':[{'name': 'b','age': 30},{'name': 'a','age': 50},
                                                      {'name': 'c','age': 40}]}",
                                        @"{'myarray': ['foo','foobar','barfoo','bar','baz','barbaz','barfoobaz']}" };

        public Functions()
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
