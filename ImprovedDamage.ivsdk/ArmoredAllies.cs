using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCL;
using CCL.GTAIV;
using IVSDKDotNet;
using IVSDKDotNet.Enums;
using IVSDKDotNet.Native;
using static IVSDKDotNet.Native.Natives;

namespace ImprovedDamage.ivsdk
{
    internal class ArmoredAllies
    {
        private static readonly List<string> SCOList = new List<string>();
        private static readonly List<int> HealthList = new List<int>();

        public static void Init(SettingsFile settings)
        {
            string SCOString = settings.GetValue("MAIN", "BuffedSCOList", "");

            SCOList.Clear();
            foreach (string SCOName in SCOString.Split(','))
            {
                SCOList.Add(SCOName);
            }
            string HealthString = settings.GetValue("MAIN", "HealthList", "");

            HealthList.Clear();
            foreach (var HealthValue in HealthString.Split(','))
            {
                int HealthAmount = Int32.Parse(HealthValue.Trim());
                HealthList.Add(HealthAmount);
            }
        }
        public static void Tick()
        {
            foreach (string MissionSCO in SCOList)
            {
                if (NativeGame.IsScriptRunning(MissionSCO))
                {
                    foreach (var ped in PedHelper.PedHandles)
                    {
                        int pedHandle = ped.Value;
                        if (!IS_PED_A_MISSION_PED(pedHandle))
                            continue;
                        if (pedHandle == Main.PlayerHandle)
                            continue;
                        if (!IS_PED_IN_GROUP(pedHandle))
                            continue;
                        if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 57))
                            continue;

                        GET_CHAR_ARMOUR(pedHandle, out uint pArmor);

                        if (pArmor > 0)
                            continue;

                        GET_CHAR_HEALTH(pedHandle, out uint pHealth);
                        SET_CHAR_HEALTH(pedHandle, (uint)(pHealth + HealthList[SCOList.IndexOf(MissionSCO)]));
                        ADD_ARMOUR_TO_CHAR(pedHandle, 100);
                    }
                }
            }
        }
    }
}
