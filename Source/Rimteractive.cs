using System.Reflection;
using System.Collections.Generic;
using RimWorld;
using UnityEngine;
using Verse;
using System;
using Harmony;


namespace Rimteractive
{
    [StaticConstructorOnStartup]
    public class Main
    {
        public static float startTime = Time.time;
        public static float lastEventTime;

        public static Rect framePosition;
        public static Rect boxPosition;

        public static Texture2D frameTex = SolidColorMaterials.NewSolidColorTexture(new Color(0.981f, 0.909f, 0.166f, 0.5f));

        public static MethodInfo groupFrameRectMethod;

        static Main()
        {
            var harmony = HarmonyInstance.Create("ru.solarrunner.rimworld.mod.rimteractive");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
            groupFrameRectMethod = typeof(ColonistBarColonistDrawer).GetMethod("GroupFrameRect", BindingFlags.Instance | BindingFlags.NonPublic,
                null, new Type[] { typeof(int) }, null);
        }

        [HarmonyPatch(typeof(ColonistBarColonistDrawer), "DrawColonist")]
        public class Rimteractive
        {
            public static bool Prefix(ColonistBarColonistDrawer __instance, ref Rect rect, ref Pawn colonist, ref Map pawnMap)
            {
                ColonistBar colonistBar = Find.ColonistBar;

                int group = colonistBar.Entries[0].group;
                framePosition = (Rect)groupFrameRectMethod.Invoke(__instance, new object[] { group });
                boxPosition = new Rect(framePosition.x, framePosition.y + colonistBar.Size.y + 48, framePosition.width, 48);
                framePosition = new Rect(boxPosition.x + 6, boxPosition.y + 6, boxPosition.width - 12, boxPosition.height - 12);

                Text.Font = GameFont.Tiny;
                GUI.color = new Color(0.5f, 0.5f, 0.5f, 0.2f);

                Widgets.ButtonImage(framePosition, frameTex, new Color(0.5f, 0.9f, 0.6f, 0.5f), new Color(0.5f, 0.9f, 0.6f, 1f));

                if (Mouse.IsOver(framePosition) && Settings.RimteractiveSettings.modEnabled)
                {
                    Widgets.DrawRectFast(boxPosition, new Color(0.9f, 0f, 0f, 0.5f), null);

                    TooltipHandler.TipRegion(framePosition, "Текущая статистика\n\nЗа первое событие:\nJohnny - 120 руб\nPain - 266 руб\nМатроскин - 488руб");

                    if (Input.GetMouseButtonDown(0))
                    {
                        if ((Time.time - lastEventTime) > 0.2f)
                        {
                            Messages.Message("[Rimteractive] [Event] X:" + framePosition.x.ToString()
                            + " Y: " + framePosition.y.ToString()
                            + " LastTime: " + lastEventTime.ToString()
                            + " Delta: " + (Time.time - lastEventTime).ToString(),
                            MessageTypeDefOf.PositiveEvent);

                            List<FloatMenuOption> list = new List<FloatMenuOption>();

                            foreach (IncidentDef incedent in DefDatabase<IncidentDef>.AllDefs)
                            {
                                list.Add(new FloatMenuOption(incedent.defName, delegate
                                {
                                    IncidentParms parms = new IncidentParms();
                                    parms.target = Find.VisibleMap;
                                    incedent.Worker.TryExecute(parms);
                                }, MenuOptionPriority.Default, null, null, 0f, null, null));

                                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Events.txt", true))
                                {
                                    file.WriteLine("public static RimteractiveEvent event" + incedent.defName + " = new RimteractiveEvent(\"" + incedent.defName + "\", \"" + incedent.description + "\", 0, true, false, 0f);");
                                }

                            }

                            FloatMenu floatMenu = new FloatMenu(list);
                            floatMenu.vanishIfMouseDistant = true;
                            Find.WindowStack.Add(floatMenu);

                            lastEventTime = Time.time;
                        }
                    }
                }
                return true;
            }
        }
    }
}