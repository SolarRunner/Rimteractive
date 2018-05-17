using UnityEngine;
using System.Collections.Generic;
using RimWorld;
using UnityEngine;
using Verse;

namespace Rimteractive
{
    partial class Settings
    {
        public struct RimteractiveEvent : IExposable
        {
            private string incidentName;
            private string description;
            private int price;
            private bool allowToUse;
            private bool deffered;
            private float defferTime;

            public RimteractiveEvent(string incidentName, string description, int price, bool allowToUse, bool deffered, float defferTime)
            {
                this.incidentName = incidentName;
                this.description = description;
                this.price = price;
                this.allowToUse = allowToUse;
                this.deffered = deffered;
                this.defferTime = defferTime;
            }

            public string IncidentName { get => incidentName; set => incidentName = value; }
            public string Description { get => description; set => description = value; }
            public int Price { get => price; set => price = value; }
            public bool AllowToUse { get => allowToUse; set => allowToUse = value; }
            public bool Deffered { get => deffered; set => deffered = value; }
            public float DefferTime { get => defferTime; set => defferTime = value; }

            public void ExposeData()
            {
                // no base.ExposeData() to call

                this.AutoExposeDataWithDefaults();
            }
        }
    }
}
