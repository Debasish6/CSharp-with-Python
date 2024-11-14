using System;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

class Program
{
    static void Main(string[] args)
    {
        RunScript();
    }

    static void RunScript()
    {
        // Create the Python engine
        ScriptEngine engine = Python.CreateEngine();


        // Add paths to the Python environment 
        var paths = engine.GetSearchPaths(); 
        paths.Add(@"C:\Users\edominer\Python Project\.venv\Lib\site-packages\"); 
        engine.SetSearchPaths(paths);

        // Load the Python script
        string scriptPath = @"C:\Users\edominer\Python Project\CSharp_with_Python\SimpleAPP\another_app.py";

        if (!System.IO.File.Exists(scriptPath))
        {
            Console.WriteLine($"Error: The script file '{scriptPath}' does not exist.");
            return;
        }

        try
        {
            // Load the Python script
            ScriptSource source = engine.CreateScriptSourceFromFile(scriptPath);

            // Create a scope (a context) for the script execution
            ScriptScope scope = engine.CreateScope();

            // Execute the script
            source.Execute(scope);

            // // Get the greet function from the script 
            // dynamic greet = scope.GetVariable("student_details");

            // // Call the greet function with an argument 
            // string result = greet("",10,12);
            // Console.WriteLine(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error executing script: {ex.Message}");
        }
    }
}
