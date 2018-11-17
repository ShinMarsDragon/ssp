using System;
using System.IO;
using System.Reflection;
using Stubble.Core.Builders;

namespace Ssp
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new PageData {Game = "Fatal Fury 1", Character = "Terry Bogard"};
            
            var stubble = new StubbleBuilder().Build();
            var renderer = new PageRenderer(stubble, LoadTemplate("character-page"));
            
            Console.WriteLine(renderer.Render(data));
        }

        private static string LoadTemplate(string filename)
        {
            using (Stream resource = Assembly.GetExecutingAssembly().GetManifestResourceStream($"Ssp.templates.{filename}.html.mustache"))
            using (StreamReader sr = new StreamReader(resource))
            {
                return sr.ReadToEnd();
            }
        }
    }
}
