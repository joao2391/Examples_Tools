using HandlebarsDotNet;

namespace Handlebars_Ex
{
    public class Helpers
    {
        private static readonly string source = @"Click here: {{link_to}}";
        

        public static string Result()
        {
            Handlebars.RegisterHelper("link_to", (writer, context, parameters) => {
                writer.WriteSafeString("<a href='" + "URL" + "'>" + "TEXT" + "</a>");
            });

            var template = Handlebars.Compile(source);

            var data = new
            {
                url = "https://github.com/rexm/handlebars.net",
                text = "Handlebars.Net"
            };

            var result = template(data);

            return result;
        }
    }
}
