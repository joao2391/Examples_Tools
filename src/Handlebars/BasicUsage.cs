using HandlebarsDotNet;

namespace Handlebars_Ex
{
    public class BasicUsage
    {
        private static readonly string source = @"<div class=""entry"">
                                    <h1>{{title}}</h1>
                                        <div class=""body"">
                                            {{body}}
                                        </div>
                                  </div>";

        public static string Result()
        {
            var template = Handlebars.Compile(source);

            var data = new
            {
                title = "My new post",
                body = "This is my first post!"
            };

            var result = template(data);

            return result;
        }


    }
}
