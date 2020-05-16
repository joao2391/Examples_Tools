using HandlebarsDotNet;

namespace Handlebars_Ex
{
    public class Partials
    {
        private static readonly string source = @"<h2>Names</h2>
                                                    {{#names}}
                                                    {{> user}}
                                                    {{/names}}";

        private static readonly string partialSource = @"<strong>{{name}}</strong>";

        public static string Result()
        {
            Handlebars.RegisterTemplate("user", partialSource);

            var template = Handlebars.Compile(source);

            var data = new
            {
                names = new[] {
                    new {
                    name = "Karen"
                        },
                    new {
                    name = "Jon"
                        }
                }
            };

            var result = template(data);

            return result;
        }
    }
}
