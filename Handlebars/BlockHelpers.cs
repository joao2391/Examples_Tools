using HandlebarsDotNet;
using System;
using System.Collections.Generic;
using System.IO;

namespace Handlebars_Ex
{
    public class BlockHelpers
    {
        private static readonly string source = "{{#each @value}}The animal,{{@key}}, {{StringEqualityBlockHelper @value 'dog'}}is a dog{{else}}is not a dog{{/StringEqualityBlockHelper}}.\r\n{{/each}}";


        public static string Result()
        {
            HandlebarsBlockHelper _stringEqualityBlockHelper = (TextWriter output, HelperOptions options, dynamic context, object[] arguments) => {

                if (arguments.Length != 2)
                {
                    throw new HandlebarsException("{{StringEqualityBlockHelper}} helper must have exactly two argument");
                }

                string left = arguments[0] as string;
                string right = arguments[1] as string;

                if (left == right)
                {
                    options.Template(output, null);
                }
                else
                {
                    options.Inverse(output, null);
                }
            };

            Handlebars.RegisterHelper("StringEqualityBlockHelper", _stringEqualityBlockHelper);
            var animals = new Dictionary<string, string>() { {"Fluffy", "cat" }, {"Fido", "dog" }, {"Chewy", "hamster" } };

            Func<object, string> compiledTemplate = Handlebars.Compile(source);

            string templateOutput = compiledTemplate(animals);

            return templateOutput;

        }
    }
}
