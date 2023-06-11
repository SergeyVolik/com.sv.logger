using System.Diagnostics;
using UnityEngine;

namespace SV
{
    public interface ILogger
    {
        public void Log(string str);
        public void LogError(string str);
        public void LogWarning(string str);
    }

    public class DefaultLogger : ILogger
    {
        public void Log(string str)
        {
            UnityEngine.Debug.Log(str);
        }

        public void LogError(string str)
        {
            UnityEngine.Debug.LogError(str);
        }

        public void LogWarning(string str)
        {
            UnityEngine.Debug.LogError(str);
        }
    }

    public class CustomLogger
    {

        public static ILogger Instance = new DefaultLogger();
        public const string DedSymbol = "EnableLogger";

        [Conditional(DedSymbol)]
        public static void Log(string str)
        {
            Instance.Log(str);
        }

        [Conditional(DedSymbol)]
        public static void LogWarning(string str)
        {
            Instance.LogWarning(str);

        }

        [Conditional(DedSymbol)]
        public static void LogError(string str)
        {
            Instance.LogError(str);
        }

       
    }
}
