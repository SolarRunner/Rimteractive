using System.Collections.Generic;
using UnityEngine;
using Verse;
using RimWorld;

namespace Rimteractive
{
    partial class Settings
    {

        public class RimteractiveMod : Mod
        {
            public static RimteractiveSettings Settings;

            public RimteractiveMod(ModContentPack content) : base(content)
            {
                Settings = GetSettings<RimteractiveSettings>();
            }

            public override void DoSettingsWindowContents(Rect inRect)
            {
                Settings.DoWindowContents(inRect);
            }

            public override string SettingsCategory()
            {
                return "Настройки Rimteractive";
            }
        }

        public class RimteractiveSettings : ModSettings
        {
            public static RimteractiveEvent eventAmbush = new RimteractiveEvent("Ambush", "", 0, true, false, 0f);
            public static RimteractiveEvent eventManhunterAmbush = new RimteractiveEvent("ManhunterAmbush", "", 0, true, false, 0f);
            public static RimteractiveEvent eventCaravanMeeting = new RimteractiveEvent("CaravanMeeting", "", 0, true, false, 0f);
            public static RimteractiveEvent eventCaravanDemand = new RimteractiveEvent("CaravanDemand", "", 0, true, false, 0f);
            public static RimteractiveEvent eventDisease_Flu = new RimteractiveEvent("Disease_Flu", "", 0, true, false, 0f);
            public static RimteractiveEvent eventDisease_Plague = new RimteractiveEvent("Disease_Plague", "", 0, true, false, 0f);
            public static RimteractiveEvent eventDisease_Malaria = new RimteractiveEvent("Disease_Malaria", "", 0, true, false, 0f);
            public static RimteractiveEvent eventDisease_SleepingSickness = new RimteractiveEvent("Disease_SleepingSickness", "", 0, true, false, 0f);
            public static RimteractiveEvent eventDisease_FibrousMechanites = new RimteractiveEvent("Disease_FibrousMechanites", "", 0, true, false, 0f);
            public static RimteractiveEvent eventDisease_SensoryMechanites = new RimteractiveEvent("Disease_SensoryMechanites", "", 0, true, false, 0f);
            public static RimteractiveEvent eventDisease_GutWorms = new RimteractiveEvent("Disease_GutWorms", "", 0, true, false, 0f);
            public static RimteractiveEvent eventDisease_MuscleParasites = new RimteractiveEvent("Disease_MuscleParasites", "", 0, true, false, 0f);
            public static RimteractiveEvent eventResourcePodCrash = new RimteractiveEvent("ResourcePodCrash", "", 0, true, false, 0f);
            public static RimteractiveEvent eventPsychicSoothe = new RimteractiveEvent("PsychicSoothe", "", 0, true, false, 0f);
            public static RimteractiveEvent eventSelfTame = new RimteractiveEvent("SelfTame", "", 0, true, false, 0f);
            public static RimteractiveEvent eventAmbrosiaSprout = new RimteractiveEvent("AmbrosiaSprout", "", 0, true, false, 0f);
            public static RimteractiveEvent eventFarmAnimalsWanderIn = new RimteractiveEvent("FarmAnimalsWanderIn", "", 0, true, false, 0f);
            public static RimteractiveEvent eventWandererJoin = new RimteractiveEvent("WandererJoin", "", 0, true, false, 0f);
            public static RimteractiveEvent eventRefugeePodCrash = new RimteractiveEvent("RefugeePodCrash", "", 0, true, false, 0f);
            public static RimteractiveEvent eventRefugeeChased = new RimteractiveEvent("RefugeeChased", "", 0, true, false, 0f);
            public static RimteractiveEvent eventThrumboPasses = new RimteractiveEvent("ThrumboPasses", "", 0, true, false, 0f);
            public static RimteractiveEvent eventRansomDemand = new RimteractiveEvent("RansomDemand", "", 0, true, false, 0f);
            public static RimteractiveEvent eventCaravanRequest = new RimteractiveEvent("CaravanRequest", "", 0, true, false, 0f);
            public static RimteractiveEvent eventMeteoriteImpact = new RimteractiveEvent("MeteoriteImpact", "", 0, true, false, 0f);
            public static RimteractiveEvent eventHerdMigration = new RimteractiveEvent("HerdMigration", "", 0, true, false, 0f);
            public static RimteractiveEvent eventPsychicDrone = new RimteractiveEvent("PsychicDrone", "", 0, true, false, 0f);
            public static RimteractiveEvent eventToxicFallout = new RimteractiveEvent("ToxicFallout", "", 0, true, false, 0f);
            public static RimteractiveEvent eventVolcanicWinter = new RimteractiveEvent("VolcanicWinter", "", 0, true, false, 0f);
            public static RimteractiveEvent eventHeatWave = new RimteractiveEvent("HeatWave", "", 0, true, false, 0f);
            public static RimteractiveEvent eventColdSnap = new RimteractiveEvent("ColdSnap", "", 0, true, false, 0f);
            public static RimteractiveEvent eventAurora = new RimteractiveEvent("Aurora", "", 0, true, false, 0f);
            public static RimteractiveEvent eventFlashstorm = new RimteractiveEvent("Flashstorm", "", 0, true, false, 0f);
            public static RimteractiveEvent eventTornado = new RimteractiveEvent("Tornado", "", 0, true, false, 0f);
            public static RimteractiveEvent eventShortCircuit = new RimteractiveEvent("ShortCircuit", "", 0, true, false, 0f);
            public static RimteractiveEvent eventCropBlight = new RimteractiveEvent("CropBlight", "", 0, true, false, 0f);
            public static RimteractiveEvent eventAlphabeavers = new RimteractiveEvent("Alphabeavers", "", 0, true, false, 0f);
            public static RimteractiveEvent eventShipChunkDrop = new RimteractiveEvent("ShipChunkDrop", "", 0, true, false, 0f);
            public static RimteractiveEvent eventOrbitalTraderArrival = new RimteractiveEvent("OrbitalTraderArrival", "", 0, true, false, 0f);
            public static RimteractiveEvent eventTraderCaravanArrival = new RimteractiveEvent("TraderCaravanArrival", "", 0, true, false, 0f);
            public static RimteractiveEvent eventVisitorGroup = new RimteractiveEvent("VisitorGroup", "", 0, true, false, 0f);
            public static RimteractiveEvent eventTravelerGroup = new RimteractiveEvent("TravelerGroup", "", 0, true, false, 0f);
            public static RimteractiveEvent eventRaidFriendly = new RimteractiveEvent("RaidFriendly", "", 0, true, false, 0f);
            public static RimteractiveEvent eventRaidEnemyEscapeShip = new RimteractiveEvent("RaidEnemyEscapeShip", "", 0, true, false, 0f);
            public static RimteractiveEvent eventRaidEnemy = new RimteractiveEvent("RaidEnemy", "", 0, true, false, 0f);
            public static RimteractiveEvent eventInfestation = new RimteractiveEvent("Infestation", "", 0, true, false, 0f);
            public static RimteractiveEvent eventManhunterPack = new RimteractiveEvent("ManhunterPack", "", 0, true, false, 0f);
            public static RimteractiveEvent eventPsychicEmanatorShipPartCrash = new RimteractiveEvent("PsychicEmanatorShipPartCrash", "", 0, true, false, 0f);
            public static RimteractiveEvent eventPoisonShipPartCrash = new RimteractiveEvent("PoisonShipPartCrash", "", 0, true, false, 0f);
            public static RimteractiveEvent eventAnimalInsanityMass = new RimteractiveEvent("AnimalInsanityMass", "", 0, true, false, 0f);
            public static RimteractiveEvent eventAnimalInsanitySingle = new RimteractiveEvent("AnimalInsanitySingle", "", 0, true, false, 0f);
            public static RimteractiveEvent eventEclipse = new RimteractiveEvent("Eclipse", "", 0, true, false, 0f);
            public static RimteractiveEvent eventSolarFlare = new RimteractiveEvent("SolarFlare", "", 0, true, false, 0f);
            public static RimteractiveEvent eventQuestBanditCamp = new RimteractiveEvent("QuestBanditCamp", "", 0, true, false, 0f);
            public static RimteractiveEvent eventQuestItemStash = new RimteractiveEvent("QuestItemStash", "", 0, true, false, 0f);
            public static RimteractiveEvent eventQuestDownedRefugee = new RimteractiveEvent("QuestDownedRefugee", "", 0, true, false, 0f);
            public static RimteractiveEvent eventQuestPrisonerWillingToJoin = new RimteractiveEvent("QuestPrisonerWillingToJoin", "", 0, true, false, 0f);
            public static RimteractiveEvent eventQuestPeaceTalks = new RimteractiveEvent("QuestPeaceTalks", "", 0, true, false, 0f);
            public static RimteractiveEvent eventJourneyOffer = new RimteractiveEvent("JourneyOffer", "", 0, true, false, 0f);

            public static bool modEnabled = true;
            public static bool eventEnabled = true;
            public static string logPath = "C:\\RU\\chat.log";
            static Vector2 scrollPosition = Vector2.zero;

            public static List<RimteractiveEvent> rimteractiveEventsList = new List<RimteractiveEvent>();


            public override void ExposeData()
            {
                base.ExposeData();
                rimteractiveEventsList.Clear();

                foreach (IncidentDef incedent in DefDatabase<IncidentDef>.AllDefs)
                {
                    rimteractiveEventsList.Add(new RimteractiveEvent(incedent.defName, "", 0, true, false, 0f));
                }

                Scribe_Values.Look(ref modEnabled, "modEnabled", true, true);
                Scribe_Values.Look(ref logPath, "logPath", "C:\\RU\\RSSD\\chat.log", true);
                Scribe_Collections.Look<RimteractiveEvent>(ref rimteractiveEventsList, "forcedApparel", LookMode.Deep, new object[0]);

            }

            public void DoWindowContents(Rect canvas)
            {
                Rect rect = canvas.AtZero();
                rect.y += 45f;
                rect.yMax -= 90f;

                var outRect = new Rect(canvas.x, canvas.y, canvas.width, canvas.height);
                var scrollRect = new Rect(0f, 0f, canvas.width - 16f, canvas.height * 3f);
                Widgets.BeginScrollView(outRect, ref scrollPosition, scrollRect, true);

                Listing_Standard listing_Standard = new Listing_Standard
                {
                    ColumnWidth = (rect.width - 34f) / 3f
                };
                listing_Standard.Begin(scrollRect);

                /*** Первая колонка ***/
                Text.Font = GameFont.Medium;
                listing_Standard.Label("Настройка мода", -1f);
                listing_Standard.Gap(12f);

                Text.Font = GameFont.Small;
                listing_Standard.CheckboxLabeledSelectable("Активен ", ref modEnabled, ref modEnabled);
                listing_Standard.Gap(12f);
                listing_Standard.GapLine(6f);
                listing_Standard.Gap(12f);

                listing_Standard.Label("Путь к логу чата ");
                logPath = listing_Standard.TextEntry(logPath, 1);

                /*** Вторая колонка ***/
                listing_Standard.NewColumn();
                Text.Font = GameFont.Medium;
                listing_Standard.Label("События".Translate(), -1f);
                listing_Standard.Gap(12f);

                Text.Font = GameFont.Small;

                listing_Standard.CheckboxLabeledSelectable(rimEvent.IncidentName, ref tempRef, ref tempRef);

                /*** Третья колонка ***/
                listing_Standard.NewColumn();
                Text.Font = GameFont.Medium;
                listing_Standard.Label("Цена".Translate(), -1f);
                listing_Standard.Gap(12f);

                Text.Font = GameFont.Small;
                listing_Standard.Label("Путь к логу чата asdfdfasdgggggggggggggggggggggggasddddddddddd");
                listing_Standard.Gap(12f);
                listing_Standard.Gap(12f);
                listing_Standard.Label("Путь к логу чата asdf");
                listing_Standard.Label("Путь к логу чата fasdfsdf");
                listing_Standard.Label("Путь к логу чата asdjfhgsajfhgaksjdfgaksjfgakjsdfa");

                listing_Standard.End();
                Widgets.EndScrollView();
            }
        }
    }
}
