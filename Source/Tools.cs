using Verse;
using RimWorld;
using System.IO;
using System;
using Harmony;

namespace Rimteractive
{
    [StaticConstructorOnStartup]
    static class Tools
    {
        public static bool CheckLogFile(string logPath)
        {
            if (logPath.Length >= 8)
            {
                if (File.Exists(logPath))
                {
                    if (Path.GetExtension(logPath) == ".txt")
                    {
                        return true;
                    }
                    else
                    {
                        Messages.Message("Это не текстовый файл", MessageTypeDefOf.RejectInput);
                        return false;
                    }
                }
                else
                {
                    Messages.Message("Файл не существует", MessageTypeDefOf.RejectInput);
                    return false;
                }
            }
            else
            {
                Messages.Message("Некорректный путь", MessageTypeDefOf.RejectInput);
                return false;
            }
        }

        public static void AutoExposeDataWithDefaults<T>(this T settings) where T : new()
        {
            var defaults = new T();
            AccessTools.GetFieldNames(settings).Do(name =>
            {
                var finfo = AccessTools.Field(settings.GetType(), name);
                var value = finfo.GetValue(settings);
                var type = value.GetType();
                var defaultValue = Traverse.Create(defaults).Field(name).GetValue();
                var m_Look = AccessTools.Method(typeof(Scribe_Values), "Look", null, new Type[] { type });
                var arguments = new object[] { value, name, defaultValue, false };
                m_Look.Invoke(null, arguments);
                finfo.SetValue(settings, arguments[0]);
            });
        }
    }
}
