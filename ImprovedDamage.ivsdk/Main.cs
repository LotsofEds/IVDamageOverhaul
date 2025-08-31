using CCL;
using CCL.GTAIV;
using IVSDKDotNet;
using IVSDKDotNet.Enums;
using IVSDKDotNet.Native;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using static IVSDKDotNet.Native.Natives;

namespace ImprovedDamage.ivsdk
{
    internal class Values
    {
        internal static string GetBone(Int32 iBone)
        {
            if (iBone == 0) return "ROOT";
            if (iBone == 0x1A1) return "PELVIS";
            if (iBone == 0x4B2) return "SPINE";
            if (iBone == 0x4B3) return "SPINE1";
            if (iBone == 0x36A0) return "SPINE2";
            if (iBone == 0x36A1) return "SPINE3";
            if (iBone == 0x4B4) return "NECK";
            if (iBone == 0x4B5) return "HEAD";
            if (iBone == 0x37A0) return "NECKROLL";
            if (iBone == 0x4C7) return "R_CLAVICLE";
            if (iBone == 0x4C8) return "R_UPPERARM";
            if (iBone == 0x4C9) return "R_FOREARM";
            if (iBone == 0x4D0) return "R_HAND";
            if (iBone == 0x35B0) return "R_FINGER0";
            if (iBone == 0x35B1) return "R_FINGER01";
            if (iBone == 0x35B2) return "R_FINGER02";
            if (iBone == 0x35B3) return "R_FINGER1";
            if (iBone == 0x35B4) return "R_FINGER11";
            if (iBone == 0x35B5) return "R_FINGER12";
            if (iBone == 0x35B6) return "R_FINGER2";
            if (iBone == 0x35B7) return "R_FINGER21";
            if (iBone == 0x35B8) return "R_FINGER22";
            if (iBone == 0x35B9) return "R_FINGER3";
            if (iBone == 0x35C0) return "R_FINGER31";
            if (iBone == 0x35C1) return "R_FINGER32";
            if (iBone == 0x35C2) return "R_FINGER4";
            if (iBone == 0x35C3) return "R_FINGER41";
            if (iBone == 0x35C4) return "R_FINGER42";
            if (iBone == 0x39A1) return "R_FORETWIST";
            if (iBone == 0x39A2) return "R_FORETWIST1";
            if (iBone == 0x39A0) return "R_UPPPERARMROLL";
            if (iBone == 0x3E01) return "R_ARMROLL";
            if (iBone == 0x4C0) return "L_CLAVICLE";
            if (iBone == 0x4C1) return "L_UPPERARM";
            if (iBone == 0x4C2) return "L_FOREARM";
            if (iBone == 0x4C3) return "L_HAND";
            if (iBone == 0x35D0) return "L_FINGER0";
            if (iBone == 0x35D1) return "L_FINGER01";
            if (iBone == 0x35D2) return "L_FINGER02";
            if (iBone == 0x35D3) return "L_FINGER1";
            if (iBone == 0x35D4) return "L_FINGER11";
            if (iBone == 0x35D5) return "L_FINGER12";
            if (iBone == 0x35D6) return "L_FINGER2";
            if (iBone == 0x35D7) return "L_FINGER21";
            if (iBone == 0x35D8) return "L_FINGER22";
            if (iBone == 0x35D9) return "L_FINGER3";
            if (iBone == 0x35E0) return "L_FINGER31";
            if (iBone == 0x35E1) return "L_FINGER32";
            if (iBone == 0x35E2) return "L_FINGER4";
            if (iBone == 0x35E3) return "L_FINGER41";
            if (iBone == 0x35E4) return "L_FINGER42";
            if (iBone == 0x38A1) return "L_FORETWIST";
            if (iBone == 0x38A2) return "L_FORETWIST1";
            if (iBone == 0x38A0) return "L_UPPPERARMROLL";
            if (iBone == 0x3DF1) return "L_ARMROLL";
            if (iBone == 0x1A2) return "L_THIGH";
            if (iBone == 0x1A3) return "L_CALF";
            if (iBone == 0x1A4) return "L_FOOT";
            if (iBone == 0x1A5) return "L_TOE";
            if (iBone == 0x38B0) return "L_CALFROLL";
            if (iBone == 0x1A7) return "R_THIGH";
            if (iBone == 0x1A8) return "R_CALF";
            if (iBone == 0x1A9) return "R_FOOT";
            if (iBone == 0x4B0) return "R_TOE";
            if (iBone == 0x39B0) return "R_CALFROLL";
            if (iBone == 0x78F7) return "L_BROWAJNT";
            if (iBone == 0x78F8) return "L_BROWBJNT";
            if (iBone == 0x78F9) return "L_LIDJNT";
            if (iBone == 0x78FA) return "C_LOWLIDJNT";
            if (iBone == 0x78FB) return "L_CHEEKJNT";
            if (iBone == 0x78FC) return "L_EYEJNT";
            if (iBone == 0x7903) return "L_CORNERAJNT";
            if (iBone == 0x79F4) return "L_CORNERBJNT";
            if (iBone == 0x7904) return "L_JAWAJNT";
            if (iBone == 0x7905) return "L_JAWBJNT";
            if (iBone == 0x7906) return "L_LIPUPAJNT";
            if (iBone == 0x7907) return "R_BROWAJNT";
            if (iBone == 0x7908) return "R_BROWBJNT";
            if (iBone == 0x7909) return "R_LIDJNT";
            if (iBone == 0x790A) return "R_CHEEKJNT";
            if (iBone == 0x790B) return "R_EYEJNT";
            if (iBone == 0x790C) return "R_CORNERAJNT";
            if (iBone == 0x79F3) return "R_CORNERBJNT";
            if (iBone == 0x7913) return "R_JAWAJNT";
            if (iBone == 0x7914) return "R_JAWBJNT";
            if (iBone == 0x7915) return "R_LIPUPAJNT";
            if (iBone == 0x7916) return "C_JAWAJNT";
            if (iBone == 0x7F94) return "FB_C_BROW";
            if (iBone == 0x7F9B) return "FB_C_JAW";
            if (iBone == 0x7FA7) return "FB_L_LIPLOWER";
            if (iBone == 0x7FA6) return "FB_R_LIPLOWER";
            if (iBone == 0x7F9A) return "FB_L_BROW";
            if (iBone == 0x7FA5) return "FB_L_CRN_MOUTH";
            if (iBone == 0x7F98) return "FB_L_EYEBALL";
            if (iBone == 0x7F99) return "FB_L_EYELID";
            if (iBone == 0x7F9D) return "FB_L_LIPUPPER";
            if (iBone == 0x7F95) return "FB_R_BROW";
            if (iBone == 0x7FA4) return "FB_R_CRN_MOUTH";
            if (iBone == 0x7F97) return "FB_R_EYEBALL";
            if (iBone == 0x7F96) return "FB_R_EYELID";
            if (iBone == 0x7F9C) return "FB_R_LIPUPPER";
            if (iBone == 0x0A917) return "FB_L_BROWBJNT";
            if (iBone == 0x0A905) return "FB_L_BROWAJNT";
            if (iBone == 0x0A8F6) return "FB_C_FOREHEAD";
            if (iBone == 0x0A8F7) return "FB_L_EYEJNT";
            if (iBone == 0x0A8F8) return "FB_L_UPPCHEEKJNT";
            if (iBone == 0x0A8F9) return "FB_L_CORNERLIPJNT";
            if (iBone == 0x0A8FA) return "FB_L_LOCHEEKJNT";
            if (iBone == 0x0A8FB) return "FB_L_UPPLIPJNT";
            if (iBone == 0x0A8FC) return "FB_L_UPPLIDJNT";
            if (iBone == 0x0A903) return "FB_L_LOLIDJNT";
            if (iBone == 0x0A904) return "FB_R_BROWAJNT";
            if (iBone == 0x0A916) return "FB_R_EYEJNT";
            if (iBone == 0x0A906) return "FB_R_UPPLIDJNT";
            if (iBone == 0x0A907) return "FB_R_LOLIDJNT";
            if (iBone == 0x0A908) return "FB_R_BROWBJNT";
            if (iBone == 0x0A909) return "FB_R_UPPCHEEKJNT";
            if (iBone == 0x0A90A) return "FB_R_UPPLIPJNT";
            if (iBone == 0x0A90B) return "FB_R_CORNERLIPJNT";
            if (iBone == 0x0A90C) return "FB_R_LOCHEEKJNT";
            if (iBone == 0x0A913) return "FB_C_JAWJNT";
            if (iBone == 0x0A914) return "FB_R_LOLIPJNT";
            if (iBone == 0x0A915) return "FB_L_LOLIPJNT";
            if (iBone == 0x0A8F5) return "FB_C_TONGUE_A_JNT";
            if (iBone == 0x0A8F4) return "FB_C_TONGUE_B_JNT";
            if (iBone == 0x0C944) return "POINTFB_C_JAW";
            if (iBone == 0x0C947) return "POINTFB_R_LIPLOWER";
            if (iBone == 0x0C948) return "POINTFB_L_LIPLOWER";
            if (iBone == 0x0C946) return "POINTFB_L_LIPUPPER";
            if (iBone == 0x0C945) return "POINTFB_R_LIPUPPER";
            if (iBone == 0x0B064) return "EXTRA1";
            if (iBone == 0x0B065) return "EXTRA2";
            if (iBone == 0x0B066) return "EXTRA3";
            return "UNKNOWN";
        }
    }
    public class Main : Script
    {
        bool scriptActive = true;
        bool noHeadshots = false;
        private static int numOfWeapIDs;
        private static List<int> pedList = new List<int>();
        private static List<uint> healthList = new List<uint>();
        private static List<uint> armorList = new List<uint>();
        Keys ActivateKey;
        private static float scriptRange;

        private static readonly List<eWeaponType> Exceptions = new List<eWeaponType>();
        private static readonly List<eWeaponType> Shotties = new List<eWeaponType>();
        private static readonly List<eWeaponType> Explosives = new List<eWeaponType>();
        public static IVPed PlayerPed { get; set; }
        public static uint PlayerIndex { get; set; }
        public static int PlayerHandle { get; set; }
        public static Vector3 PlayerPos { get; set; }

        public Main()
        {
            Uninitialize += Main_Uninitialize;
            Initialized += Main_Initialized;
            if (scriptActive)
                Tick += Main_Tick;
            KeyDown += Main_KeyDown;
        }
        private void Main_Uninitialize(object sender, EventArgs e)
        {
            pedList.Clear();
            healthList.Clear();
            armorList.Clear();
        }
        private void Main_Initialized(object sender, EventArgs e)
        {
            pedList.Clear();
            healthList.Clear();
            armorList.Clear();
            LoadINI(Settings);
        }
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            //IVGame.ShowSubtitleMessage(e.KeyValue.ToString() + "  " + ((int)ActivateKey).ToString());
            if (e.KeyValue == (int)ActivateKey)
            {
                Activate();
            }
        }
        void Main_Tick(object sender, EventArgs e)
        {
            PlayerPed = IVPed.FromUIntPtr(IVPlayerInfo.FindThePlayerPed());
            PlayerIndex = GET_PLAYER_ID();
            PlayerHandle = PlayerPed.GetHandle();
            PlayerPos = PlayerPed.Matrix.Pos;

            PedHelper.GrabAllPeds();
            CleanLists();
            FillLists();
            CheckHealthArmor();
        }
        void CleanLists()
        {
            if (pedList.Count > 0)
            {
                for (int i = 0; i < pedList.Count; i++)
                {
                    if (!DOES_CHAR_EXIST(pedList[i]) || IS_CHAR_DEAD(pedList[i]) || IS_CHAR_INJURED(pedList[i]))
                    {
                        pedList.RemoveAt(i);
                        healthList.RemoveAt(i);
                        armorList.RemoveAt(i);
                    }
                }
            }
        }
        void FillLists()
        {
            foreach (var ped in PedHelper.PedHandles)
            {
                int pedHandle = ped.Value;
                if (!LOCATE_CHAR_ANY_MEANS_3D(pedHandle, PlayerPos.X, PlayerPos.Y, PlayerPos.Z, scriptRange, scriptRange, scriptRange, false))
                    continue;
                if (IS_CHAR_DEAD(pedHandle) || IS_CHAR_INJURED(pedHandle))
                    continue;
                if (pedList.Contains(pedHandle)) continue;

                if (noHeadshots)
                    SET_CHAR_SUFFERS_CRITICAL_HITS(pedHandle, false);

                uint initHealth = 0;
                uint initArmor = 0;

                GET_CHAR_ARMOUR(pedHandle, out initArmor);
                if (!HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 57) && initArmor <= 0) continue;

                GET_CHAR_HEALTH(pedHandle, out initHealth);
                pedList.Add(pedHandle);
                healthList.Add(initHealth);
                armorList.Add(initArmor);
            }
        }
        private uint GetHeadMult(SettingsFile settings, int weap)
        {
            return (settings.GetUInteger(weap.ToString(), "PedHeadMult", 100));
        }
        private uint GetPlyrHeadMult(SettingsFile settings, int weap)
        {
            return (settings.GetUInteger(weap.ToString(), "PlyrHeadMult", 100));
        }
        private uint GetHeadArmorMult(SettingsFile settings, int weap)
        {
            return (settings.GetUInteger(weap.ToString(), "PedHeadArmorMult", 100));
        }
        private uint GetPlyrHeadArmorMult(SettingsFile settings, int weap)
        {
            return (settings.GetUInteger(weap.ToString(), "PlyrHeadArmorMult", 100));
        }
        private uint GetHeadArmorPenetMult(SettingsFile settings, int weap)
        {
            return (settings.GetUInteger(weap.ToString(), "PedHeadArmorPenetMult", 100));
        }
        private uint GetPlyrHeadArmorPenetMult(SettingsFile settings, int weap)
        {
            return (settings.GetUInteger(weap.ToString(), "PlyrHeadArmorPenetMult", 0));
        }
        private uint GetBodyMult(SettingsFile settings, int weap)
        {
            return (settings.GetUInteger(weap.ToString(), "PedBodyMult", 100));
        }
        private uint GetPlyrBodyMult(SettingsFile settings, int weap)
        {
            return (settings.GetUInteger(weap.ToString(), "PlyrBodyMult", 100));
        }
        private uint GetArmorMult(SettingsFile settings, int weap)
        {
            return (settings.GetUInteger(weap.ToString(), "PedBodyArmorMult", 100));
        }
        private uint GetPlyrArmorMult(SettingsFile settings, int weap)
        {
            return (settings.GetUInteger(weap.ToString(), "PlyrBodyArmorMult", 100));
        }
        private uint GetArmorPenetMult(SettingsFile settings, int weap)
        {
            return (settings.GetUInteger(weap.ToString(), "PedBodyArmorPenetMult", 100));
        }
        private uint GetPlyrArmorPenetMult(SettingsFile settings, int weap)
        {
            return (settings.GetUInteger(weap.ToString(), "PlyrBodyArmorPenetMult", 0));
        }
        private uint GetLimbMult(SettingsFile settings, int weap)
        {
            return (settings.GetUInteger(weap.ToString(), "PedLimbMult", 100));
        }
        private uint GetPlyrLimbMult(SettingsFile settings, int weap)
        {
            return (settings.GetUInteger(weap.ToString(), "PlyrLimbMult", 100));
        }
        private uint GetHandFeetMult(SettingsFile settings, int weap)
        {
            return (settings.GetUInteger(weap.ToString(), "PedHandsAndFeetMult", 100));
        }
        private uint GetPlyrHandFeetMult(SettingsFile settings, int weap)
        {
            return (settings.GetUInteger(weap.ToString(), "PlyrHandsAndFeetMult", 100));
        }
        private void LoadINI(SettingsFile settings)
        {
            scriptRange = settings.GetFloat("MAIN", "scriptRange", 120);
            numOfWeapIDs = settings.GetInteger("MAIN", "NumOfWeaponIDs", 60);
            noHeadshots = settings.GetBoolean("MAIN", "NoHeadshots", false);

            string NotWeap = settings.GetValue("WEAPON TYPES", "Exceptions", "");
            Exceptions.Clear();
            foreach (var weaponName in NotWeap.Split(','))
            {
                eWeaponType weaponType = (eWeaponType)Enum.Parse(typeof(eWeaponType), weaponName.Trim(), true);
                Exceptions.Add(weaponType);
            }
            string Shotguns = settings.GetValue("WEAPON TYPES", "Shotguns", "");
            Shotties.Clear();
            foreach (var weaponName in Shotguns.Split(','))
            {
                eWeaponType weaponType = (eWeaponType)Enum.Parse(typeof(eWeaponType), weaponName.Trim(), true);
                Shotties.Add(weaponType);
            }
            string Explosive = settings.GetValue("WEAPON TYPES", "Explosives", "");
            Explosives.Clear();
            foreach (var weaponName in Explosive.Split(','))
            {
                eWeaponType weaponType = (eWeaponType)Enum.Parse(typeof(eWeaponType), weaponName.Trim(), true);
                Explosives.Add(weaponType);
            }

            ActivateKey = settings.GetKey("MAIN", "ActivateKey", Keys.F5);
        }
        private void Activate()
        {
            scriptActive = !scriptActive;
            ShowSubtitleMessage("Damage Tracking: " + (scriptActive ? "On" : "Off"));
            if (scriptActive)
            {
                Tick += Main_Tick;
            }
            else
            {
                Tick -= Main_Tick;
                pedList.Clear();
                healthList.Clear();
                armorList.Clear();
            }
        }
        void CheckHealthArmor()
        {
            foreach (int myPed in pedList)
            {
                int pedHandle = myPed;

                bool hasDamaged = (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 57));

                if (hasDamaged)
                {
                    uint weapHeadMult = 0;
                    uint weapPlyrHeadMult = 0;
                    uint weapHeadArmrMult = 0;
                    uint weapPlyrHeadArmrMult = 0;
                    uint weapHeadArmrPntMult = 0;
                    uint weapPlyrHeadArmrPntMult = 0;

                    uint weapBodyMult = 0;
                    uint weapPlyrBodyMult = 0;
                    uint weapArmrMult = 0;
                    uint weapPlyrArmrMult = 0;
                    uint weapArmrPntMult = 0;
                    uint weapPlyrArmrPntMult = 0;

                    uint weapLimbMult = 0;
                    uint weapPlyrLimbMult = 0;
                    uint weapHandMult = 0;
                    uint weapPlyrHandMult = 0;

                    uint initHealth = healthList[pedList.IndexOf(myPed)];
                    uint initArmor = armorList[pedList.IndexOf(myPed)];
                    uint newHealth;
                    uint newArmor;

                    GET_CHAR_HEALTH(pedHandle, out newHealth);
                    GET_CHAR_ARMOUR(pedHandle, out newArmor);
                    GET_CHAR_LAST_DAMAGE_BONE(pedHandle, out Int32 iBone);
                    string boneHit = Values.GetBone(iBone);

                    if (newHealth > initHealth)
                    {
                        healthList[pedList.IndexOf(myPed)] = newHealth;
                        initHealth = healthList[pedList.IndexOf(myPed)];
                    }
                    if (newArmor > initArmor)
                    {
                        armorList[pedList.IndexOf(myPed)] = newArmor; 
                        initArmor = armorList[pedList.IndexOf(myPed)];
                    }

                    for (int i = 0; i < numOfWeapIDs; i++)
                    {
                        if (i == 57)
                            continue;

                        if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, i))
                        {
                            //IVGame.ShowSubtitleMessage(i.ToString());
                            weapHeadMult = GetHeadMult(Settings, i);
                            weapPlyrHeadMult = GetPlyrHeadMult(Settings, i);
                            weapHeadArmrMult = GetHeadArmorMult(Settings, i);
                            weapPlyrHeadArmrMult = GetPlyrHeadArmorMult(Settings, i);
                            weapHeadArmrPntMult = GetHeadArmorPenetMult(Settings, i);
                            weapPlyrHeadArmrPntMult = GetPlyrHeadArmorPenetMult(Settings, i);

                            weapBodyMult = GetBodyMult(Settings, i);
                            weapPlyrBodyMult = GetPlyrBodyMult(Settings, i);
                            weapArmrMult = GetArmorMult(Settings, i);
                            weapPlyrArmrMult = GetPlyrArmorMult(Settings, i);
                            weapArmrPntMult = GetArmorPenetMult(Settings, i);
                            weapPlyrArmrPntMult = GetPlyrArmorPenetMult(Settings, i);

                            weapLimbMult = GetLimbMult(Settings, i);
                            weapPlyrLimbMult = GetPlyrLimbMult(Settings, i);
                            weapHandMult = GetHandFeetMult(Settings, i);
                            weapPlyrHandMult = GetPlyrHandFeetMult(Settings, i);
                            break;
                        }
                    }

                    uint dmgInit = (initHealth - newHealth);
                    uint armrDmgInit = (initArmor - newArmor);

                    uint initHeadDmg = (((200 - newHealth) * (weapHeadMult - 100)) / 100);
                    uint plyrInitHeadDmg = (((200 - newHealth) * (weapPlyrHeadMult - 100)) / 100);
                    uint headDmg = ((dmgInit * weapHeadMult) / 100);
                    uint plyrHeadDmg = ((dmgInit * weapPlyrHeadMult) / 100);

                    /*uint initHeadArmrDmg = (((100 - newArmor) * weapHeadMult) / 100);
                    uint plyrInitHeadArmrDmg = (((100 - newArmor) * weapPlyrHeadMult) / 100);
                    uint headArmrDmg = ((armrDmgInit * weapHeadMult) / 100);
                    uint plyrHeadArmrDmg = ((armrDmgInit * weapPlyrHeadMult) / 100);*/

                    uint headArmrDmg = ((armrDmgInit * weapHeadArmrMult) / 100);
                    uint plyrHeadArmrDmg = ((armrDmgInit * weapPlyrHeadArmrMult) / 100);
                    uint headArmrPntDmg = ((armrDmgInit * weapHeadArmrPntMult) / 100);
                    uint plyrHeadArmrPntDmg = ((armrDmgInit * weapPlyrHeadArmrPntMult) / 100);

                    uint initBodyDmg = (((200 - newHealth) * (weapBodyMult - 100)) / 100);
                    uint plyrInitBodyDmg = (((200 - newHealth) * (weapPlyrBodyMult - 100)) / 100);
                    uint bodyDmg = ((dmgInit * weapBodyMult) / 100);
                    uint plyrBodyDmg = ((dmgInit * weapPlyrBodyMult) / 100);

                    uint armrDmg = ((armrDmgInit * weapArmrMult) / 100);
                    uint plyrArmrDmg = ((armrDmgInit * weapPlyrArmrMult) / 100);
                    uint armrPntDmg = ((armrDmgInit * weapArmrPntMult) / 100);
                    uint plyrArmrPntDmg = ((armrDmgInit * weapPlyrArmrPntMult) / 100);

                    uint initLimbDmg = (((200 - newHealth) * (weapLimbMult - 100)) / 100);
                    uint initLimbArmrDmg = (((100 - newArmor) * weapLimbMult) / 100);
                    uint plyrInitLimbDmg = (((200 - newHealth) * (weapPlyrLimbMult - 100)) / 100);
                    uint plyrInitLimbArmrDmg = (((100 - newArmor) * weapPlyrLimbMult) / 100);
                    uint limbDmg = ((dmgInit * weapLimbMult) / 100);
                    uint plyrLimbDmg = ((dmgInit * weapPlyrLimbMult) / 100);
                    uint limbArmrDmg = ((armrDmgInit * weapLimbMult) / 100);
                    uint plyrLimbArmrDmg = ((armrDmgInit * weapPlyrLimbMult) / 100);

                    uint initHandDmg = (((200 - newHealth) * (weapHandMult - 100)) / 100);
                    uint initHandArmrDmg = (((100 - newArmor) * weapHandMult) / 100);
                    uint plyrInitHandDmg = (((200 - newHealth) * (weapPlyrHandMult - 100)) / 100);
                    uint plyrInitHandArmrDmg = (((100 - newArmor) * weapPlyrHandMult) / 100);
                    uint handDmg = ((dmgInit * weapHandMult) / 100);
                    uint plyrHandDmg = ((dmgInit * weapPlyrHandMult) / 100);
                    uint handArmrDmg = ((armrDmgInit * weapHandMult) / 100);
                    uint plyrHandArmrDmg = ((armrDmgInit * weapPlyrHandMult) / 100);

                    //uint HandDmg = ((armrDmgInit * weapArmrPntMult) / 100);
                    //uint plyrHandPntDmg = ((armrDmgInit * weapPlyrArmrPntMult) / 100);

                    //IVGame.ShowSubtitleMessage(dmgInit.ToString() + "  " + initHealth.ToString() + "  " + newHealth.ToString() + "  " + armrDmgInit.ToString() + "  " + initArmor + "  " + newArmor.ToString());
                    if (!HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 49) && !HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 50) && !HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 53) && !HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 54) && !HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 55) && !HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 56))
                    {
                        foreach (eWeaponType weaponType in Exceptions)
                        {
                            if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, (int)weaponType))
                                CLEAR_CHAR_LAST_DAMAGE_BONE(pedHandle);
                        }
                        foreach (eWeaponType weaponType in Explosives)
                        {
                            if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, (int)weaponType))
                                boneHit = "ROOT";
                        }
                        foreach (eWeaponType weaponType in Shotties)
                        {
                            if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, (int)weaponType) && boneHit != "HEAD")
                                boneHit = "ROOT";
                        }
                        if (!IS_CHAR_DEAD(pedHandle) && boneHit == "HEAD")
                        {
                            /*if (weapPlyrHeadMult >= 0)
                            {
                                if (pedHandle == PlayerHandle && dmgInit > 1 && newArmor <= 0)
                                {
                                    SET_CHAR_HEALTH(pedHandle, newHealth + (dmgInit - plyrHeadDmg));
                                }
                                else if (pedHandle == PlayerHandle && dmgInit <= 1 && newArmor <= 0)
                                {
                                    SET_CHAR_HEALTH(pedHandle, (newHealth - plyrInitHeadDmg));
                                }
                            }
                            if (weapHeadMult >= 0)
                            {
                                if (pedHandle != PlayerHandle && dmgInit > 1 && newArmor <= 0)
                                {
                                    SET_CHAR_HEALTH(pedHandle, newHealth + (dmgInit - headDmg));
                                }
                                else if (pedHandle != PlayerHandle && dmgInit <= 1 && newArmor <= 0)
                                {
                                    SET_CHAR_HEALTH(pedHandle, (newHealth - initHeadDmg));
                                }
                            }
                            GET_CHAR_HEALTH(pedHandle, out newHealth);

                            if (weapPlyrHeadMult >= 0)
                            {
                                if (pedHandle == PlayerHandle && armrDmgInit > 1 && newArmor > 0)
                                {
                                    ADD_ARMOUR_TO_CHAR(pedHandle, (int)armrDmgInit);
                                    SET_CHAR_HEALTH(pedHandle, newHealth - plyrHeadArmrDmg);
                                }
                                else if (pedHandle == PlayerHandle && armrDmgInit > 1 && newArmor <= 0)
                                {
                                    ADD_ARMOUR_TO_CHAR(pedHandle, (int)armrDmgInit);
                                    SET_CHAR_HEALTH(pedHandle, newHealth - plyrHeadArmrDmg);
                                }
                                else if (pedHandle == PlayerHandle && armrDmgInit <= 1 && newArmor > 0)
                                {
                                    ADD_ARMOUR_TO_CHAR(pedHandle, (int)(100 - newArmor));
                                    SET_CHAR_HEALTH(pedHandle, newHealth - plyrInitHeadArmrDmg);
                                }
                            }
                            if (weapHeadMult >= 0)
                            {
                                if (pedHandle != PlayerHandle && armrDmgInit > 1 && newArmor > 0)
                                {
                                    ADD_ARMOUR_TO_CHAR(pedHandle, (int)armrDmgInit);
                                    SET_CHAR_HEALTH(pedHandle, newHealth - headArmrDmg);
                                }
                                else if (pedHandle != PlayerHandle && armrDmgInit > 1 && newArmor <= 0)
                                {
                                    ADD_ARMOUR_TO_CHAR(pedHandle, (int)armrDmgInit);
                                    SET_CHAR_HEALTH(pedHandle, newHealth - headArmrDmg);
                                }
                                else if (pedHandle != PlayerHandle && armrDmgInit <= 1 && newArmor > 0)
                                {
                                    ADD_ARMOUR_TO_CHAR(pedHandle, (int)(100 - newArmor));
                                    SET_CHAR_HEALTH(pedHandle, newHealth - initHeadArmrDmg);
                                }
                            }*/

                            if (pedHandle == PlayerHandle && dmgInit > 0 && newArmor <= 0)
                                SET_CHAR_HEALTH(pedHandle, newHealth + (dmgInit - plyrHeadDmg));

                            else if (pedHandle == PlayerHandle && dmgInit <= 0 && newArmor <= 0)
                                SET_CHAR_HEALTH(pedHandle, newHealth - plyrInitHeadDmg);

                            else if (pedHandle != PlayerHandle && dmgInit > 0 && newArmor <= 0)
                                SET_CHAR_HEALTH(pedHandle, newHealth + (dmgInit - headDmg));

                            else if (pedHandle != PlayerHandle && dmgInit <= 0 && newArmor <= 0)
                                SET_CHAR_HEALTH(pedHandle, newHealth - initHeadDmg);

                            GET_CHAR_HEALTH(pedHandle, out newHealth);

                            if (initArmor > 0)
                            {
                                if (pedHandle == PlayerHandle && armrDmgInit > 0)
                                {
                                    ADD_ARMOUR_TO_CHAR(pedHandle, (int)(armrDmgInit - plyrHeadArmrDmg));

                                    if ((plyrHeadArmrDmg - armrDmgInit) > newArmor)
                                        SET_CHAR_HEALTH(pedHandle, newHealth - (((newArmor + armrDmgInit) * weapPlyrHeadArmrPntMult) / 100) - (((plyrHeadArmrDmg - armrDmgInit - newArmor) * weapPlyrHeadMult) / 300));
                                    else
                                        SET_CHAR_HEALTH(pedHandle, newHealth - ((plyrHeadArmrDmg * weapPlyrHeadArmrPntMult) / 100));

                                    GET_CHAR_HEALTH(pedHandle, out newHealth);
                                }
                                else if (pedHandle == PlayerHandle && armrDmgInit < 1)
                                {
                                    ADD_ARMOUR_TO_CHAR(pedHandle, (int)(0 - (((100 - newArmor) * (weapPlyrHeadArmrMult - 100)) / 100)));
                                    SET_CHAR_HEALTH(pedHandle, newHealth - (((100 - newArmor) * (weapPlyrHeadArmrMult * weapPlyrHeadArmrPntMult)) / 10000));
                                }
                                else if (pedHandle != PlayerHandle && armrDmgInit > 0)
                                {
                                    ADD_ARMOUR_TO_CHAR(pedHandle, (int)(armrDmgInit - ((armrDmgInit * weapHeadArmrMult) / 100)));

                                    if ((headArmrDmg - armrDmgInit) > newArmor)
                                        SET_CHAR_HEALTH(pedHandle, newHealth - (((newArmor + armrDmgInit) * weapHeadArmrPntMult) / 100) - (((headArmrDmg - armrDmgInit - newArmor) * weapHeadMult) / 100));
                                    else
                                        SET_CHAR_HEALTH(pedHandle, newHealth - ((headArmrDmg * weapHeadArmrPntMult) / 100));

                                    GET_CHAR_HEALTH(pedHandle, out newHealth);
                                }
                                else if (pedHandle != PlayerHandle && armrDmgInit < 1)
                                {
                                    ADD_ARMOUR_TO_CHAR(pedHandle, (int)(0 - (((100 - newArmor) * (weapHeadArmrMult - 100)) / 100)));
                                    SET_CHAR_HEALTH(pedHandle, newHealth - (((100 - newArmor) * (weapHeadArmrMult * weapHeadArmrPntMult)) / 10000));
                                }
                            }
                        }
                        else if (!IS_CHAR_DEAD(pedHandle) && (boneHit.Contains("SPINE") || boneHit.Contains("CLAVICLE") || boneHit == "ROOT"))
                        {
                            if (pedHandle == PlayerHandle && dmgInit > 0 && newArmor <= 0)
                                SET_CHAR_HEALTH(pedHandle, newHealth + (dmgInit - plyrBodyDmg));

                            else if (pedHandle == PlayerHandle && dmgInit <= 0 && newArmor <= 0)
                                SET_CHAR_HEALTH(pedHandle, newHealth - plyrInitBodyDmg);

                            else if (pedHandle != PlayerHandle && dmgInit > 0 && newArmor <= 0)
                                SET_CHAR_HEALTH(pedHandle, newHealth + (dmgInit - bodyDmg));

                            else if (pedHandle != PlayerHandle && dmgInit <= 0 && newArmor <= 0)
                                SET_CHAR_HEALTH(pedHandle, newHealth - initBodyDmg);

                            GET_CHAR_HEALTH(pedHandle, out newHealth);
                            
                            if (initArmor > 0)
                            {
                                if (pedHandle == PlayerHandle && armrDmgInit > 0)
                                {
                                    ADD_ARMOUR_TO_CHAR(pedHandle, (int)(armrDmgInit - plyrArmrDmg));

                                    if ((plyrArmrDmg - armrDmgInit) > newArmor)
                                        SET_CHAR_HEALTH(pedHandle, newHealth - (((newArmor + armrDmgInit) * weapPlyrArmrPntMult) / 100) - (((plyrArmrDmg - armrDmgInit - newArmor) * weapPlyrBodyMult) / 300));
                                    else
                                        SET_CHAR_HEALTH(pedHandle, newHealth - ((plyrArmrDmg * weapPlyrArmrPntMult) / 100));

                                    GET_CHAR_HEALTH(pedHandle, out newHealth);
                                }
                                else if (pedHandle == PlayerHandle && armrDmgInit < 1)
                                {
                                    ADD_ARMOUR_TO_CHAR(pedHandle, (int)(0 - (((100 - newArmor) * (weapPlyrArmrMult - 100)) / 100)));
                                    SET_CHAR_HEALTH(pedHandle, newHealth - (((100 - newArmor) * (weapPlyrArmrMult * weapPlyrArmrPntMult)) / 10000));
                                }
                                else if (pedHandle != PlayerHandle && armrDmgInit > 0)
                                {
                                    ADD_ARMOUR_TO_CHAR(pedHandle, (int)(armrDmgInit - ((armrDmgInit * weapArmrMult) / 100)));

                                    if ((armrDmg - armrDmgInit) > newArmor)
                                        SET_CHAR_HEALTH(pedHandle, newHealth - (((newArmor + armrDmgInit) * weapArmrPntMult) / 100) - (((armrDmg - armrDmgInit - newArmor) * weapBodyMult) / 100));
                                    else
                                        SET_CHAR_HEALTH(pedHandle, newHealth - ((armrDmg * weapArmrPntMult) / 100));

                                    GET_CHAR_HEALTH(pedHandle, out newHealth);
                                }
                                else if (pedHandle != PlayerHandle && armrDmgInit < 1)
                                {
                                    ADD_ARMOUR_TO_CHAR(pedHandle, (int)(0 - (((100 - newArmor) * (weapArmrMult - 100)) / 100)));
                                    SET_CHAR_HEALTH(pedHandle, newHealth - (((100 - newArmor) * (weapArmrMult * weapArmrPntMult)) / 10000));
                                }
                            }
                        }
                        else if (!IS_CHAR_DEAD(pedHandle) && (boneHit.Contains("THIGH") || boneHit.Contains("CALF") || boneHit.Contains("ARM")))
                        {
                            if (pedHandle == PlayerHandle && dmgInit > 1 && newArmor <= 0)
                            {
                                SET_CHAR_HEALTH(pedHandle, newHealth + (dmgInit - plyrLimbDmg));
                            }
                            else if (pedHandle == PlayerHandle && dmgInit <= 1 && newArmor <= 0)
                            {
                                SET_CHAR_HEALTH(pedHandle, (newHealth - plyrInitLimbDmg));
                            }
                            else if (pedHandle != PlayerHandle && dmgInit > 1 && newArmor <= 0)
                            {
                                SET_CHAR_HEALTH(pedHandle, newHealth + (dmgInit - limbDmg));
                            }
                            else if (pedHandle != PlayerHandle && dmgInit <= 1 && newArmor <= 0)
                            {
                                SET_CHAR_HEALTH(pedHandle, (newHealth - initLimbDmg));
                            }
                            GET_CHAR_HEALTH(pedHandle, out newHealth);

                            if (pedHandle == PlayerHandle && armrDmgInit > 1 && newArmor > 0)
                            {
                                ADD_ARMOUR_TO_CHAR(pedHandle, (int)armrDmgInit);
                                SET_CHAR_HEALTH(pedHandle, newHealth - plyrLimbArmrDmg);
                            }
                            else if (pedHandle == PlayerHandle && armrDmgInit > 1 && newArmor <= 0)
                            {
                                ADD_ARMOUR_TO_CHAR(pedHandle, (int)armrDmgInit);
                                SET_CHAR_HEALTH(pedHandle, newHealth - plyrLimbArmrDmg);
                            }
                            else if (pedHandle == PlayerHandle && armrDmgInit <= 1 && newArmor > 0)
                            {
                                ADD_ARMOUR_TO_CHAR(pedHandle, (int)(100 - newArmor));
                                SET_CHAR_HEALTH(pedHandle, newHealth - plyrInitLimbArmrDmg);
                            }
                            else if (pedHandle != PlayerHandle && armrDmgInit > 1 && newArmor > 0)
                            {
                                ADD_ARMOUR_TO_CHAR(pedHandle, (int)armrDmgInit);
                                SET_CHAR_HEALTH(pedHandle, newHealth - limbArmrDmg);
                            }
                            else if (pedHandle != PlayerHandle && armrDmgInit > 1 && newArmor <= 0)
                            {
                                ADD_ARMOUR_TO_CHAR(pedHandle, (int)armrDmgInit);
                                SET_CHAR_HEALTH(pedHandle, newHealth - limbArmrDmg);
                            }
                            else if (pedHandle != PlayerHandle && armrDmgInit <= 1 && newArmor > 0)
                            {
                                ADD_ARMOUR_TO_CHAR(pedHandle, (int)(100 - newArmor));
                                SET_CHAR_HEALTH(pedHandle, newHealth - initLimbArmrDmg);
                            }
                        }
                        else if (!IS_CHAR_DEAD(pedHandle) && (boneHit.Contains("HAND") || boneHit.Contains("FOOT") || boneHit.Contains("TOE") || boneHit.Contains("FINGER")))
                        {
                            if (pedHandle == PlayerHandle && dmgInit > 1 && newArmor <= 0)
                            {
                                SET_CHAR_HEALTH(pedHandle, newHealth + (dmgInit - plyrHandDmg));
                            }
                            else if (pedHandle == PlayerHandle && dmgInit <= 1 && newArmor <= 0)
                            {
                                SET_CHAR_HEALTH(pedHandle, (newHealth - plyrInitHandDmg));
                            }
                            else if (pedHandle != PlayerHandle && dmgInit > 1 && newArmor <= 0)
                            {
                                SET_CHAR_HEALTH(pedHandle, newHealth + (dmgInit - handDmg));
                            }
                            else if (pedHandle != PlayerHandle && dmgInit <= 1 && newArmor <= 0)
                            {
                                SET_CHAR_HEALTH(pedHandle, (newHealth - initHandDmg));
                            }
                            GET_CHAR_HEALTH(pedHandle, out newHealth);

                            if (pedHandle == PlayerHandle && armrDmgInit > 1 && newArmor > 0)
                            {
                                ADD_ARMOUR_TO_CHAR(pedHandle, (int)armrDmgInit);
                                SET_CHAR_HEALTH(pedHandle, newHealth - plyrHandArmrDmg);
                            }
                            else if (pedHandle == PlayerHandle && armrDmgInit > 1 && newArmor <= 0)
                            {
                                ADD_ARMOUR_TO_CHAR(pedHandle, (int)armrDmgInit);
                                SET_CHAR_HEALTH(pedHandle, newHealth - plyrHandArmrDmg);
                            }
                            else if (pedHandle == PlayerHandle && armrDmgInit <= 1 && newArmor > 0)
                            {
                                ADD_ARMOUR_TO_CHAR(pedHandle, (int)(100 - newArmor));
                                SET_CHAR_HEALTH(pedHandle, newHealth - plyrInitHandArmrDmg);
                            }
                            else if (pedHandle != PlayerHandle && armrDmgInit > 1 && newArmor > 0)
                            {
                                ADD_ARMOUR_TO_CHAR(pedHandle, (int)armrDmgInit);
                                SET_CHAR_HEALTH(pedHandle, newHealth - handArmrDmg);
                            }
                            else if (pedHandle != PlayerHandle && armrDmgInit > 1 && newArmor <= 0)
                            {
                                ADD_ARMOUR_TO_CHAR(pedHandle, (int)armrDmgInit);
                                SET_CHAR_HEALTH(pedHandle, newHealth - handArmrDmg);
                            }
                            else if (pedHandle != PlayerHandle && armrDmgInit <= 1 && newArmor > 0)
                            {
                                ADD_ARMOUR_TO_CHAR(pedHandle, (int)(100 - newArmor));
                                SET_CHAR_HEALTH(pedHandle, newHealth - initHandArmrDmg);
                            }
                        }
                    }
                    CLEAR_CHAR_LAST_WEAPON_DAMAGE(pedHandle);
                    CLEAR_CHAR_LAST_DAMAGE_BONE(pedHandle);

                    GET_CHAR_HEALTH(pedHandle, out newHealth);
                    GET_CHAR_ARMOUR(pedHandle, out newArmor);

                    healthList[pedList.IndexOf(myPed)] = newHealth;
                    armorList[pedList.IndexOf(myPed)] = newArmor;
                }
            }
        }
    }
}
