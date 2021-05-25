using Markdig;
using System;
using System.IO;

namespace BasicConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configure the pipeline with all advanced extensions active
            var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
            var result = Markdown.ToHtml(File.ReadAllText("Test.md"), pipeline);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
