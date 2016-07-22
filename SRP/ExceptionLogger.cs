namespace BreakingSingleResponsibility
{
    public class ExceptionLogger
    {
        static string fileName = @"C:\Error.txt";
        public static void Log( string message)
        {
            System.IO.File.WriteAllText(fileName, message);
        }
    }
}