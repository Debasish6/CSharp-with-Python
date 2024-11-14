using System;
using Python.Runtime;

class Program
{
    static void Main(string[] args)
    {
        RunScript("mypythonScript");
    }

    static void RunScript(string scriptName)
    {
        // Ensure the path to the Python DLL is correct
        PythonEngine.PythonHome = @"C:\Users\edominer\AppData\Local\Programs\Python\Python310\python310.dll";

        // Initialize the Python engine
        PythonEngine.Initialize();

        // Use the Python GIL to ensure thread safety
        using (Py.GIL())
        {
            // Import the specified Python script
            dynamic pythonScript = Py.Import(scriptName);

            // Invoke the "home" method from the imported script
            dynamic result = pythonScript.home();

            // Print the result to the console
            Console.WriteLine(result);
        }

        // Shutdown the Python engine
        PythonEngine.Shutdown();
    }
}
