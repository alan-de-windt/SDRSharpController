using System.Linq;
using System.Reflection;

namespace SDRSharp.SDRSharpController
{
    class Info
    {
        public static string Title()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            return assembly
                .GetCustomAttributes(typeof(AssemblyTitleAttribute), false)
                .OfType<AssemblyTitleAttribute>().FirstOrDefault().Title;
        }

        public static string Version()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            return assembly.GetName().Version.ToString();
        }
    }
}
