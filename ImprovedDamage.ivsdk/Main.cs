using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using IVSDKDotNet;
using static IVSDKDotNet.Native.Natives;
using CCL;
using CCL.GTAIV;
using IVSDKDotNet.Enums;
using IVSDKDotNet.Native;
using System.Reflection;

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
        List<IVPed> pedList = new List<IVPed>();
        List<uint> healthList = new List<uint>();
        List<uint> armorList = new List<uint>();
        Keys ActivateKey;
        private static float scriptRange;

        private static readonly List<eWeaponType> Exceptions = new List<eWeaponType>();
        private static readonly List<eWeaponType> Shotties = new List<eWeaponType>();
        private static readonly List<eWeaponType> Explosives = new List<eWeaponType>();
        public static IVPed PlayerPed { get; set; }
        public static uint PlayerIndex { get; set; }
        public static int PlayerHandle { get; set; }
        public static Vector3 PlayerPos { get; set; }

        uint BatHeadMult;
        uint BatPlyrHeadMult;
        uint BatBodyMult;
        uint BatPlyrBodyMult;
        uint BatLimbMult;
        uint BatPlyrLimbMult;
        uint BatHndFtMult;
        uint BatPlyrHndFtMult;
        uint BatArmorMult;
        uint BatPlyrArmorMult;
        uint BatArmrPntMult;
        uint BatPlyrArmrPntMult;

        uint PoolcueHeadMult;
        uint PoolcuePlyrHeadMult;
        uint PoolcueBodyMult;
        uint PoolcuePlyrBodyMult;
        uint PoolcueLimbMult;
        uint PoolcuePlyrLimbMult;
        uint PoolcueHndFtMult;
        uint PoolcuePlyrHndFtMult;
        uint PoolcueArmorMult;
        uint PoolcuePlyrArmorMult;
        uint PoolcueArmrPntMult;
        uint PoolcuePlyrArmrPntMult;

        uint KnifeHeadMult;
        uint KnifePlyrHeadMult;
        uint KnifeBodyMult;
        uint KnifePlyrBodyMult;
        uint KnifeLimbMult;
        uint KnifePlyrLimbMult;
        uint KnifeHndFtMult;
        uint KnifePlyrHndFtMult;
        uint KnifeArmorMult;
        uint KnifePlyrArmorMult;
        uint KnifeArmrPntMult;
        uint KnifePlyrArmrPntMult;

        uint GrenadeHeadMult;
        uint GrenadePlyrHeadMult;
        uint GrenadeBodyMult;
        uint GrenadePlyrBodyMult;
        uint GrenadeLimbMult;
        uint GrenadePlyrLimbMult;
        uint GrenadeHndFtMult;
        uint GrenadePlyrHndFtMult;
        uint GrenadeArmorMult;
        uint GrenadePlyrArmorMult;
        uint GrenadeArmrPntMult;
        uint GrenadePlyrArmrPntMult;

        uint MolotovHeadMult;
        uint MolotovPlyrHeadMult;
        uint MolotovBodyMult;
        uint MolotovPlyrBodyMult;
        uint MolotovLimbMult;
        uint MolotovPlyrLimbMult;
        uint MolotovHndFtMult;
        uint MolotovPlyrHndFtMult;
        uint MolotovArmorMult;
        uint MolotovPlyrArmorMult;
        uint MolotovArmrPntMult;
        uint MolotovPlyrArmrPntMult;

        uint RocketHeadMult;
        uint RocketPlyrHeadMult;
        uint RocketBodyMult;
        uint RocketPlyrBodyMult;
        uint RocketLimbMult;
        uint RocketPlyrLimbMult;
        uint RocketHndFtMult;
        uint RocketPlyrHndFtMult;
        uint RocketArmorMult;
        uint RocketPlyrArmorMult;
        uint RocketArmrPntMult;
        uint RocketPlyrArmrPntMult;

        uint PistolHeadMult;
        uint PistolPlyrHeadMult;
        uint PistolBodyMult;
        uint PistolPlyrBodyMult;
        uint PistolLimbMult;
        uint PistolPlyrLimbMult;
        uint PistolHndFtMult;
        uint PistolPlyrHndFtMult;
        uint PistolArmorMult;
        uint PistolPlyrArmorMult;
        uint PistolArmrPntMult;
        uint PistolPlyrArmrPntMult;

        uint SilencedHeadMult;
        uint SilencedPlyrHeadMult;
        uint SilencedBodyMult;
        uint SilencedPlyrBodyMult;
        uint SilencedLimbMult;
        uint SilencedPlyrLimbMult;
        uint SilencedHndFtMult;
        uint SilencedPlyrHndFtMult;
        uint SilencedArmorMult;
        uint SilencedPlyrArmorMult;
        uint SilencedArmrPntMult;
        uint SilencedPlyrArmrPntMult;

        uint DeagleHeadMult;
        uint DeaglePlyrHeadMult;
        uint DeagleBodyMult;
        uint DeaglePlyrBodyMult;
        uint DeagleLimbMult;
        uint DeaglePlyrLimbMult;
        uint DeagleHndFtMult;
        uint DeaglePlyrHndFtMult;
        uint DeagleArmorMult;
        uint DeaglePlyrArmorMult;
        uint DeagleArmrPntMult;
        uint DeaglePlyrArmrPntMult;

        uint PumpShotHeadMult;
        uint PumpShotPlyrHeadMult;
        uint PumpShotBodyMult;
        uint PumpShotPlyrBodyMult;
        uint PumpShotLimbMult;
        uint PumpShotPlyrLimbMult;
        uint PumpShotHndFtMult;
        uint PumpShotPlyrHndFtMult;
        uint PumpShotArmorMult;
        uint PumpShotPlyrArmorMult;
        uint PumpShotArmrPntMult;
        uint PumpShotPlyrArmrPntMult;

        uint CombatShotHeadMult;
        uint CombatShotPlyrHeadMult;
        uint CombatShotBodyMult;
        uint CombatShotPlyrBodyMult;
        uint CombatShotLimbMult;
        uint CombatShotPlyrLimbMult;
        uint CombatShotHndFtMult;
        uint CombatShotPlyrHndFtMult;
        uint CombatShotArmorMult;
        uint CombatShotPlyrArmorMult;
        uint CombatShotArmrPntMult;
        uint CombatShotPlyrArmrPntMult;

        uint UziHeadMult;
        uint UziPlyrHeadMult;
        uint UziBodyMult;
        uint UziPlyrBodyMult;
        uint UziLimbMult;
        uint UziPlyrLimbMult;
        uint UziHndFtMult;
        uint UziPlyrHndFtMult;
        uint UziArmorMult;
        uint UziPlyrArmorMult;
        uint UziArmrPntMult;
        uint UziPlyrArmrPntMult;

        uint MP5HeadMult;
        uint MP5PlyrHeadMult;
        uint MP5BodyMult;
        uint MP5PlyrBodyMult;
        uint MP5LimbMult;
        uint MP5PlyrLimbMult;
        uint MP5HndFtMult;
        uint MP5PlyrHndFtMult;
        uint MP5ArmorMult;
        uint MP5PlyrArmorMult;
        uint MP5ArmrPntMult;
        uint MP5PlyrArmrPntMult;

        uint Ak47HeadMult;
        uint Ak47PlyrHeadMult;
        uint Ak47BodyMult;
        uint Ak47PlyrBodyMult;
        uint Ak47LimbMult;
        uint Ak47PlyrLimbMult;
        uint Ak47HndFtMult;
        uint Ak47PlyrHndFtMult;
        uint Ak47ArmorMult;
        uint Ak47PlyrArmorMult;
        uint Ak47ArmrPntMult;
        uint Ak47PlyrArmrPntMult;

        uint M4HeadMult;
        uint M4PlyrHeadMult;
        uint M4BodyMult;
        uint M4PlyrBodyMult;
        uint M4LimbMult;
        uint M4PlyrLimbMult;
        uint M4HndFtMult;
        uint M4PlyrHndFtMult;
        uint M4ArmorMult;
        uint M4PlyrArmorMult;
        uint M4ArmrPntMult;
        uint M4PlyrArmrPntMult;

        uint PsgHeadMult;
        uint PsgPlyrHeadMult;
        uint PsgBodyMult;
        uint PsgPlyrBodyMult;
        uint PsgLimbMult;
        uint PsgPlyrLimbMult;
        uint PsgHndFtMult;
        uint PsgPlyrHndFtMult;
        uint PsgArmorMult;
        uint PsgPlyrArmorMult;
        uint PsgArmrPntMult;
        uint PsgPlyrArmrPntMult;

        uint M40HeadMult;
        uint M40PlyrHeadMult;
        uint M40BodyMult;
        uint M40PlyrBodyMult;
        uint M40LimbMult;
        uint M40PlyrLimbMult;
        uint M40HndFtMult;
        uint M40PlyrHndFtMult;
        uint M40ArmorMult;
        uint M40PlyrArmorMult;
        uint M40ArmrPntMult;
        uint M40PlyrArmrPntMult;

        uint RLauncherHeadMult;
        uint RLauncherPlyrHeadMult;
        uint RLauncherBodyMult;
        uint RLauncherPlyrBodyMult;
        uint RLauncherLimbMult;
        uint RLauncherPlyrLimbMult;
        uint RLauncherHndFtMult;
        uint RLauncherPlyrHndFtMult;
        uint RLauncherArmorMult;
        uint RLauncherPlyrArmorMult;
        uint RLauncherArmrPntMult;
        uint RLauncherPlyrArmrPntMult;

        uint FThrowerHeadMult;
        uint FThrowerPlyrHeadMult;
        uint FThrowerBodyMult;
        uint FThrowerPlyrBodyMult;
        uint FThrowerLimbMult;
        uint FThrowerPlyrLimbMult;
        uint FThrowerHndFtMult;
        uint FThrowerPlyrHndFtMult;
        uint FThrowerArmorMult;
        uint FThrowerPlyrArmorMult;
        uint FThrowerArmrPntMult;
        uint FThrowerPlyrArmrPntMult;

        uint MinigunHeadMult;
        uint MinigunPlyrHeadMult;
        uint MinigunBodyMult;
        uint MinigunPlyrBodyMult;
        uint MinigunLimbMult;
        uint MinigunPlyrLimbMult;
        uint MinigunHndFtMult;
        uint MinigunPlyrHndFtMult;
        uint MinigunArmorMult;
        uint MinigunPlyrArmorMult;
        uint MinigunArmrPntMult;
        uint MinigunPlyrArmrPntMult;

        uint GLauncherHeadMult;
        uint GLauncherPlyrHeadMult;
        uint GLauncherBodyMult;
        uint GLauncherPlyrBodyMult;
        uint GLauncherLimbMult;
        uint GLauncherPlyrLimbMult;
        uint GLauncherHndFtMult;
        uint GLauncherPlyrHndFtMult;
        uint GLauncherArmorMult;
        uint GLauncherPlyrArmorMult;
        uint GLauncherArmrPntMult;
        uint GLauncherPlyrArmrPntMult;

        uint ArmselHeadMult;
        uint ArmselPlyrHeadMult;
        uint ArmselBodyMult;
        uint ArmselPlyrBodyMult;
        uint ArmselLimbMult;
        uint ArmselPlyrLimbMult;
        uint ArmselHndFtMult;
        uint ArmselPlyrHndFtMult;
        uint ArmselArmorMult;
        uint ArmselPlyrArmorMult;
        uint ArmselArmrPntMult;
        uint ArmselPlyrArmrPntMult;

        uint Episodic3HeadMult;
        uint Episodic3PlyrHeadMult;
        uint Episodic3BodyMult;
        uint Episodic3PlyrBodyMult;
        uint Episodic3LimbMult;
        uint Episodic3PlyrLimbMult;
        uint Episodic3HndFtMult;
        uint Episodic3PlyrHndFtMult;
        uint Episodic3ArmorMult;
        uint Episodic3PlyrArmorMult;
        uint Episodic3ArmrPntMult;
        uint Episodic3PlyrArmrPntMult;

        uint BrokenCueHeadMult;
        uint BrokenCuePlyrHeadMult;
        uint BrokenCueBodyMult;
        uint BrokenCuePlyrBodyMult;
        uint BrokenCueLimbMult;
        uint BrokenCuePlyrLimbMult;
        uint BrokenCueHndFtMult;
        uint BrokenCuePlyrHndFtMult;
        uint BrokenCueArmorMult;
        uint BrokenCuePlyrArmorMult;
        uint BrokenCueArmrPntMult;
        uint BrokenCuePlyrArmrPntMult;

        uint GLaunGrndHeadMult;
        uint GLaunGrndPlyrHeadMult;
        uint GLaunGrndBodyMult;
        uint GLaunGrndPlyrBodyMult;
        uint GLaunGrndLimbMult;
        uint GLaunGrndPlyrLimbMult;
        uint GLaunGrndHndFtMult;
        uint GLaunGrndPlyrHndFtMult;
        uint GLaunGrndArmorMult;
        uint GLaunGrndPlyrArmorMult;
        uint GLaunGrndArmrPntMult;
        uint GLaunGrndPlyrArmrPntMult;

        uint SawnOffHeadMult;
        uint SawnOffPlyrHeadMult;
        uint SawnOffBodyMult;
        uint SawnOffPlyrBodyMult;
        uint SawnOffLimbMult;
        uint SawnOffPlyrLimbMult;
        uint SawnOffHndFtMult;
        uint SawnOffPlyrHndFtMult;
        uint SawnOffArmorMult;
        uint SawnOffPlyrArmorMult;
        uint SawnOffArmrPntMult;
        uint SawnOffPlyrArmrPntMult;

        uint AutoPistHeadMult;
        uint AutoPistPlyrHeadMult;
        uint AutoPistBodyMult;
        uint AutoPistPlyrBodyMult;
        uint AutoPistLimbMult;
        uint AutoPistPlyrLimbMult;
        uint AutoPistHndFtMult;
        uint AutoPistPlyrHndFtMult;
        uint AutoPistArmorMult;
        uint AutoPistPlyrArmorMult;
        uint AutoPistArmrPntMult;
        uint AutoPistPlyrArmrPntMult;

        uint PipeBombHeadMult;
        uint PipeBombPlyrHeadMult;
        uint PipeBombBodyMult;
        uint PipeBombPlyrBodyMult;
        uint PipeBombLimbMult;
        uint PipeBombPlyrLimbMult;
        uint PipeBombHndFtMult;
        uint PipeBombPlyrHndFtMult;
        uint PipeBombArmorMult;
        uint PipeBombPlyrArmorMult;
        uint PipeBombArmrPntMult;
        uint PipeBombPlyrArmrPntMult;

        uint AutoMagHeadMult;
        uint AutoMagPlyrHeadMult;
        uint AutoMagBodyMult;
        uint AutoMagPlyrBodyMult;
        uint AutoMagLimbMult;
        uint AutoMagPlyrLimbMult;
        uint AutoMagHndFtMult;
        uint AutoMagPlyrHndFtMult;
        uint AutoMagArmorMult;
        uint AutoMagPlyrArmorMult;
        uint AutoMagArmrPntMult;
        uint AutoMagPlyrArmrPntMult;

        uint AA12ExpHeadMult;
        uint AA12ExpPlyrHeadMult;
        uint AA12ExpBodyMult;
        uint AA12ExpPlyrBodyMult;
        uint AA12ExpLimbMult;
        uint AA12ExpPlyrLimbMult;
        uint AA12ExpHndFtMult;
        uint AA12ExpPlyrHndFtMult;
        uint AA12ExpArmorMult;
        uint AA12ExpPlyrArmorMult;
        uint AA12ExpArmrPntMult;
        uint AA12ExpPlyrArmrPntMult;

        uint AA12HeadMult;
        uint AA12PlyrHeadMult;
        uint AA12BodyMult;
        uint AA12PlyrBodyMult;
        uint AA12LimbMult;
        uint AA12PlyrLimbMult;
        uint AA12HndFtMult;
        uint AA12PlyrHndFtMult;
        uint AA12ArmorMult;
        uint AA12PlyrArmorMult;
        uint AA12ArmrPntMult;
        uint AA12PlyrArmrPntMult;

        uint P90HeadMult;
        uint P90PlyrHeadMult;
        uint P90BodyMult;
        uint P90PlyrBodyMult;
        uint P90LimbMult;
        uint P90PlyrLimbMult;
        uint P90HndFtMult;
        uint P90PlyrHndFtMult;
        uint P90ArmorMult;
        uint P90PlyrArmorMult;
        uint P90ArmrPntMult;
        uint P90PlyrArmrPntMult;

        uint GoldUziHeadMult;
        uint GoldUziPlyrHeadMult;
        uint GoldUziBodyMult;
        uint GoldUziPlyrBodyMult;
        uint GoldUziLimbMult;
        uint GoldUziPlyrLimbMult;
        uint GoldUziHndFtMult;
        uint GoldUziPlyrHndFtMult;
        uint GoldUziArmorMult;
        uint GoldUziPlyrArmorMult;
        uint GoldUziArmrPntMult;
        uint GoldUziPlyrArmrPntMult;

        uint M249HeadMult;
        uint M249PlyrHeadMult;
        uint M249BodyMult;
        uint M249PlyrBodyMult;
        uint M249LimbMult;
        uint M249PlyrLimbMult;
        uint M249HndFtMult;
        uint M249PlyrHndFtMult;
        uint M249ArmorMult;
        uint M249PlyrArmorMult;
        uint M249ArmrPntMult;
        uint M249PlyrArmrPntMult;

        uint DsrHeadMult;
        uint DsrPlyrHeadMult;
        uint DsrBodyMult;
        uint DsrPlyrBodyMult;
        uint DsrLimbMult;
        uint DsrPlyrLimbMult;
        uint DsrHndFtMult;
        uint DsrPlyrHndFtMult;
        uint DsrArmorMult;
        uint DsrPlyrArmorMult;
        uint DsrArmrPntMult;
        uint DsrPlyrArmrPntMult;

        uint StickyBombHeadMult;
        uint StickyBombPlyrHeadMult;
        uint StickyBombBodyMult;
        uint StickyBombPlyrBodyMult;
        uint StickyBombLimbMult;
        uint StickyBombPlyrLimbMult;
        uint StickyBombHndFtMult;
        uint StickyBombPlyrHndFtMult;
        uint StickyBombArmorMult;
        uint StickyBombPlyrArmorMult;
        uint StickyBombArmrPntMult;
        uint StickyBombPlyrArmrPntMult;

        uint BuzzardRLHeadMult;
        uint BuzzardRLPlyrHeadMult;
        uint BuzzardRLBodyMult;
        uint BuzzardRLPlyrBodyMult;
        uint BuzzardRLLimbMult;
        uint BuzzardRLPlyrLimbMult;
        uint BuzzardRLHndFtMult;
        uint BuzzardRLPlyrHndFtMult;
        uint BuzzardRLArmorMult;
        uint BuzzardRLPlyrArmorMult;
        uint BuzzardRLArmrPntMult;
        uint BuzzardRLPlyrArmrPntMult;

        uint BuzzardRHeadMult;
        uint BuzzardRPlyrHeadMult;
        uint BuzzardRBodyMult;
        uint BuzzardRPlyrBodyMult;
        uint BuzzardRLimbMult;
        uint BuzzardRPlyrLimbMult;
        uint BuzzardRHndFtMult;
        uint BuzzardRPlyrHndFtMult;
        uint BuzzardRArmorMult;
        uint BuzzardRPlyrArmorMult;
        uint BuzzardRArmrPntMult;
        uint BuzzardRPlyrArmrPntMult;

        uint BuzzardGHeadMult;
        uint BuzzardGPlyrHeadMult;
        uint BuzzardGBodyMult;
        uint BuzzardGPlyrBodyMult;
        uint BuzzardGLimbMult;
        uint BuzzardGPlyrLimbMult;
        uint BuzzardGHndFtMult;
        uint BuzzardGPlyrHndFtMult;
        uint BuzzardGArmorMult;
        uint BuzzardGPlyrArmorMult;
        uint BuzzardGArmrPntMult;
        uint BuzzardGPlyrArmrPntMult;

        uint APCHeadMult;
        uint APCPlyrHeadMult;
        uint APCBodyMult;
        uint APCPlyrBodyMult;
        uint APCLimbMult;
        uint APCPlyrLimbMult;
        uint APCHndFtMult;
        uint APCPlyrHndFtMult;
        uint APCArmorMult;
        uint APCPlyrArmorMult;
        uint APCArmrPntMult;
        uint APCPlyrArmrPntMult;

        uint ParachuteHeadMult;
        uint ParachutePlyrHeadMult;
        uint ParachuteBodyMult;
        uint ParachutePlyrBodyMult;
        uint ParachuteLimbMult;
        uint ParachutePlyrLimbMult;
        uint ParachuteHndFtMult;
        uint ParachutePlyrHndFtMult;
        uint ParachuteArmorMult;
        uint ParachutePlyrArmorMult;
        uint ParachuteArmrPntMult;
        uint ParachutePlyrArmrPntMult;

        uint Episodic22HeadMult;
        uint Episodic22PlyrHeadMult;
        uint Episodic22BodyMult;
        uint Episodic22PlyrBodyMult;
        uint Episodic22LimbMult;
        uint Episodic22PlyrLimbMult;
        uint Episodic22HndFtMult;
        uint Episodic22PlyrHndFtMult;
        uint Episodic22ArmorMult;
        uint Episodic22PlyrArmorMult;
        uint Episodic22ArmrPntMult;
        uint Episodic22PlyrArmrPntMult;

        uint Episodic23HeadMult;
        uint Episodic23PlyrHeadMult;
        uint Episodic23BodyMult;
        uint Episodic23PlyrBodyMult;
        uint Episodic23LimbMult;
        uint Episodic23PlyrLimbMult;
        uint Episodic23HndFtMult;
        uint Episodic23PlyrHndFtMult;
        uint Episodic23ArmorMult;
        uint Episodic23PlyrArmorMult;
        uint Episodic23ArmrPntMult;
        uint Episodic23PlyrArmrPntMult;

        uint Episodic24HeadMult;
        uint Episodic24PlyrHeadMult;
        uint Episodic24BodyMult;
        uint Episodic24PlyrBodyMult;
        uint Episodic24LimbMult;
        uint Episodic24PlyrLimbMult;
        uint Episodic24HndFtMult;
        uint Episodic24PlyrHndFtMult;
        uint Episodic24ArmorMult;
        uint Episodic24PlyrArmorMult;
        uint Episodic24ArmrPntMult;
        uint Episodic24PlyrArmrPntMult;

        uint CameraHeadMult;
        uint CameraPlyrHeadMult;
        uint CameraBodyMult;
        uint CameraPlyrBodyMult;
        uint CameraLimbMult;
        uint CameraPlyrLimbMult;
        uint CameraHndFtMult;
        uint CameraPlyrHndFtMult;
        uint CameraArmorMult;
        uint CameraPlyrArmorMult;
        uint CameraArmrPntMult;
        uint CameraPlyrArmrPntMult;

        uint ObjectHeadMult;
        uint ObjectPlyrHeadMult;
        uint ObjectBodyMult;
        uint ObjectPlyrBodyMult;
        uint ObjectLimbMult;
        uint ObjectPlyrLimbMult;
        uint ObjectHndFtMult;
        uint ObjectPlyrHndFtMult;
        uint ObjectArmorMult;
        uint ObjectPlyrArmorMult;
        uint ObjectArmrPntMult;
        uint ObjectPlyrArmrPntMult;

        uint ArmorHeadMult;
        uint ArmorPlyrHeadMult;
        uint ArmorBodyMult;
        uint ArmorPlyrBodyMult;
        uint ArmorLimbMult;
        uint ArmorPlyrLimbMult;
        uint ArmorHndFtMult;
        uint ArmorPlyrHndFtMult;
        uint ArmorArmorMult;
        uint ArmorPlyrArmorMult;
        uint ArmorArmrPntMult;
        uint ArmorPlyrArmrPntMult;

        uint ExplosionHeadMult;
        uint ExplosionPlyrHeadMult;
        uint ExplosionBodyMult;
        uint ExplosionPlyrBodyMult;
        uint ExplosionLimbMult;
        uint ExplosionPlyrLimbMult;
        uint ExplosionHndFtMult;
        uint ExplosionPlyrHndFtMult;
        uint ExplosionArmorMult;
        uint ExplosionPlyrArmorMult;
        uint ExplosionArmrPntMult;
        uint ExplosionPlyrArmrPntMult;

        uint Addon1HeadMult;
        uint Addon1PlyrHeadMult;
        uint Addon1BodyMult;
        uint Addon1PlyrBodyMult;
        uint Addon1LimbMult;
        uint Addon1PlyrLimbMult;
        uint Addon1HndFtMult;
        uint Addon1PlyrHndFtMult;
        uint Addon1ArmorMult;
        uint Addon1PlyrArmorMult;
        uint Addon1ArmrPntMult;
        uint Addon1PlyrArmrPntMult;

        uint Addon2HeadMult;
        uint Addon2PlyrHeadMult;
        uint Addon2BodyMult;
        uint Addon2PlyrBodyMult;
        uint Addon2LimbMult;
        uint Addon2PlyrLimbMult;
        uint Addon2HndFtMult;
        uint Addon2PlyrHndFtMult;
        uint Addon2ArmorMult;
        uint Addon2PlyrArmorMult;
        uint Addon2ArmrPntMult;
        uint Addon2PlyrArmrPntMult;

        uint Addon3HeadMult;
        uint Addon3PlyrHeadMult;
        uint Addon3BodyMult;
        uint Addon3PlyrBodyMult;
        uint Addon3LimbMult;
        uint Addon3PlyrLimbMult;
        uint Addon3HndFtMult;
        uint Addon3PlyrHndFtMult;
        uint Addon3ArmorMult;
        uint Addon3PlyrArmorMult;
        uint Addon3ArmrPntMult;
        uint Addon3PlyrArmrPntMult;

        uint Addon4HeadMult;
        uint Addon4PlyrHeadMult;
        uint Addon4BodyMult;
        uint Addon4PlyrBodyMult;
        uint Addon4LimbMult;
        uint Addon4PlyrLimbMult;
        uint Addon4HndFtMult;
        uint Addon4PlyrHndFtMult;
        uint Addon4ArmorMult;
        uint Addon4PlyrArmorMult;
        uint Addon4ArmrPntMult;
        uint Addon4PlyrArmrPntMult;

        uint Addon5HeadMult;
        uint Addon5PlyrHeadMult;
        uint Addon5BodyMult;
        uint Addon5PlyrBodyMult;
        uint Addon5LimbMult;
        uint Addon5PlyrLimbMult;
        uint Addon5HndFtMult;
        uint Addon5PlyrHndFtMult;
        uint Addon5ArmorMult;
        uint Addon5PlyrArmorMult;
        uint Addon5ArmrPntMult;
        uint Addon5PlyrArmrPntMult;

        uint Addon6HeadMult;
        uint Addon6PlyrHeadMult;
        uint Addon6BodyMult;
        uint Addon6PlyrBodyMult;
        uint Addon6LimbMult;
        uint Addon6PlyrLimbMult;
        uint Addon6HndFtMult;
        uint Addon6PlyrHndFtMult;
        uint Addon6ArmorMult;
        uint Addon6PlyrArmorMult;
        uint Addon6ArmrPntMult;
        uint Addon6PlyrArmrPntMult;

        uint Addon7HeadMult;
        uint Addon7PlyrHeadMult;
        uint Addon7BodyMult;
        uint Addon7PlyrBodyMult;
        uint Addon7LimbMult;
        uint Addon7PlyrLimbMult;
        uint Addon7HndFtMult;
        uint Addon7PlyrHndFtMult;
        uint Addon7ArmorMult;
        uint Addon7PlyrArmorMult;
        uint Addon7ArmrPntMult;
        uint Addon7PlyrArmrPntMult;

        uint Addon8HeadMult;
        uint Addon8PlyrHeadMult;
        uint Addon8BodyMult;
        uint Addon8PlyrBodyMult;
        uint Addon8LimbMult;
        uint Addon8PlyrLimbMult;
        uint Addon8HndFtMult;
        uint Addon8PlyrHndFtMult;
        uint Addon8ArmorMult;
        uint Addon8PlyrArmorMult;
        uint Addon8ArmrPntMult;
        uint Addon8PlyrArmrPntMult;

        uint Addon9HeadMult;
        uint Addon9PlyrHeadMult;
        uint Addon9BodyMult;
        uint Addon9PlyrBodyMult;
        uint Addon9LimbMult;
        uint Addon9PlyrLimbMult;
        uint Addon9HndFtMult;
        uint Addon9PlyrHndFtMult;
        uint Addon9ArmorMult;
        uint Addon9PlyrArmorMult;
        uint Addon9ArmrPntMult;
        uint Addon9PlyrArmrPntMult;

        uint Addon10HeadMult;
        uint Addon10PlyrHeadMult;
        uint Addon10BodyMult;
        uint Addon10PlyrBodyMult;
        uint Addon10LimbMult;
        uint Addon10PlyrLimbMult;
        uint Addon10HndFtMult;
        uint Addon10PlyrHndFtMult;
        uint Addon10ArmorMult;
        uint Addon10PlyrArmorMult;
        uint Addon10ArmrPntMult;
        uint Addon10PlyrArmrPntMult;

        uint Addon11HeadMult;
        uint Addon11PlyrHeadMult;
        uint Addon11BodyMult;
        uint Addon11PlyrBodyMult;
        uint Addon11LimbMult;
        uint Addon11PlyrLimbMult;
        uint Addon11HndFtMult;
        uint Addon11PlyrHndFtMult;
        uint Addon11ArmorMult;
        uint Addon11PlyrArmorMult;
        uint Addon11ArmrPntMult;
        uint Addon11PlyrArmrPntMult;

        uint Addon12HeadMult;
        uint Addon12PlyrHeadMult;
        uint Addon12BodyMult;
        uint Addon12PlyrBodyMult;
        uint Addon12LimbMult;
        uint Addon12PlyrLimbMult;
        uint Addon12HndFtMult;
        uint Addon12PlyrHndFtMult;
        uint Addon12ArmorMult;
        uint Addon12PlyrArmorMult;
        uint Addon12ArmrPntMult;
        uint Addon12PlyrArmrPntMult;

        uint Addon13HeadMult;
        uint Addon13PlyrHeadMult;
        uint Addon13BodyMult;
        uint Addon13PlyrBodyMult;
        uint Addon13LimbMult;
        uint Addon13PlyrLimbMult;
        uint Addon13HndFtMult;
        uint Addon13PlyrHndFtMult;
        uint Addon13ArmorMult;
        uint Addon13PlyrArmorMult;
        uint Addon13ArmrPntMult;
        uint Addon13PlyrArmrPntMult;

        uint Addon14HeadMult;
        uint Addon14PlyrHeadMult;
        uint Addon14BodyMult;
        uint Addon14PlyrBodyMult;
        uint Addon14LimbMult;
        uint Addon14PlyrLimbMult;
        uint Addon14HndFtMult;
        uint Addon14PlyrHndFtMult;
        uint Addon14ArmorMult;
        uint Addon14PlyrArmorMult;
        uint Addon14ArmrPntMult;
        uint Addon14PlyrArmrPntMult;

        uint Addon15HeadMult;
        uint Addon15PlyrHeadMult;
        uint Addon15BodyMult;
        uint Addon15PlyrBodyMult;
        uint Addon15LimbMult;
        uint Addon15PlyrLimbMult;
        uint Addon15HndFtMult;
        uint Addon15PlyrHndFtMult;
        uint Addon15ArmorMult;
        uint Addon15PlyrArmorMult;
        uint Addon15ArmrPntMult;
        uint Addon15PlyrArmrPntMult;

        uint Addon16HeadMult;
        uint Addon16PlyrHeadMult;
        uint Addon16BodyMult;
        uint Addon16PlyrBodyMult;
        uint Addon16LimbMult;
        uint Addon16PlyrLimbMult;
        uint Addon16HndFtMult;
        uint Addon16PlyrHndFtMult;
        uint Addon16ArmorMult;
        uint Addon16PlyrArmorMult;
        uint Addon16ArmrPntMult;
        uint Addon16PlyrArmrPntMult;

        uint Addon17HeadMult;
        uint Addon17PlyrHeadMult;
        uint Addon17BodyMult;
        uint Addon17PlyrBodyMult;
        uint Addon17LimbMult;
        uint Addon17PlyrLimbMult;
        uint Addon17HndFtMult;
        uint Addon17PlyrHndFtMult;
        uint Addon17ArmorMult;
        uint Addon17PlyrArmorMult;
        uint Addon17ArmrPntMult;
        uint Addon17PlyrArmrPntMult;

        uint Addon18HeadMult;
        uint Addon18PlyrHeadMult;
        uint Addon18BodyMult;
        uint Addon18PlyrBodyMult;
        uint Addon18LimbMult;
        uint Addon18PlyrLimbMult;
        uint Addon18HndFtMult;
        uint Addon18PlyrHndFtMult;
        uint Addon18ArmorMult;
        uint Addon18PlyrArmorMult;
        uint Addon18ArmrPntMult;
        uint Addon18PlyrArmrPntMult;

        uint Addon19HeadMult;
        uint Addon19PlyrHeadMult;
        uint Addon19BodyMult;
        uint Addon19PlyrBodyMult;
        uint Addon19LimbMult;
        uint Addon19PlyrLimbMult;
        uint Addon19HndFtMult;
        uint Addon19PlyrHndFtMult;
        uint Addon19ArmorMult;
        uint Addon19PlyrArmorMult;
        uint Addon19ArmrPntMult;
        uint Addon19PlyrArmrPntMult;

        uint Addon20HeadMult;
        uint Addon20PlyrHeadMult;
        uint Addon20BodyMult;
        uint Addon20PlyrBodyMult;
        uint Addon20LimbMult;
        uint Addon20PlyrLimbMult;
        uint Addon20HndFtMult;
        uint Addon20PlyrHndFtMult;
        uint Addon20ArmorMult;
        uint Addon20PlyrArmorMult;
        uint Addon20ArmrPntMult;
        uint Addon20PlyrArmrPntMult;

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
                    if (!DOES_CHAR_EXIST(pedList[i].GetHandle()) || IS_CHAR_DEAD(pedList[i].GetHandle()) || IS_CHAR_INJURED(pedList[i].GetHandle()))
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

                IVPed thisPed = NativeWorld.GetPedInstanceFromHandle(pedHandle);
                if (pedList.Contains(thisPed)) continue;

                uint initHealth = 0;
                uint initArmor = 0;

                GET_CHAR_ARMOUR(pedHandle, out initArmor);
                if (!HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 57) && initArmor <= 0) continue;

                GET_CHAR_HEALTH(pedHandle, out initHealth);
                pedList.Add(thisPed);
                healthList.Add(initHealth);
                armorList.Add(initArmor);
            }
        }
        private void LoadINI(SettingsFile settings)
        {
            scriptRange = settings.GetFloat("MAIN", "scriptRange", 120);
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

            BatHeadMult = settings.GetUInteger("BAT", "PedHeadMult", 100);
            BatPlyrHeadMult = settings.GetUInteger("BAT", "PlyrHeadMult", 100);
            BatBodyMult = settings.GetUInteger("BAT", "PedBodyMult", 100);
            BatPlyrBodyMult = settings.GetUInteger("BAT", "PlyrBodyMult", 100);
            BatLimbMult = settings.GetUInteger("BAT", "PedLimbMult", 100);
            BatPlyrLimbMult = settings.GetUInteger("BAT", "PlyrLimbMult", 100);
            BatHndFtMult = settings.GetUInteger("BAT", "PedHandsAndFeetMult", 100);
            BatPlyrHndFtMult = settings.GetUInteger("BAT", "PlyrHandsAndFeetMult", 100);
            BatArmorMult = settings.GetUInteger("BAT", "PedArmorMult", 100);
            BatPlyrArmorMult = settings.GetUInteger("BAT", "PlyrArmorMult", 100);
            BatArmrPntMult = settings.GetUInteger("BAT", "PedArmorPenetMult", 100);
            BatPlyrArmrPntMult = settings.GetUInteger("BAT", "PlyrArmorPenetMult", 0);

            PoolcueHeadMult = settings.GetUInteger("POOLCUE", "PedHeadMult", 100);
            PoolcuePlyrHeadMult = settings.GetUInteger("POOLCUE", "PlyrHeadMult", 100);
            PoolcueBodyMult = settings.GetUInteger("POOLCUE", "PedBodyMult", 100);
            PoolcuePlyrBodyMult = settings.GetUInteger("POOLCUE", "PlyrBodyMult", 100);
            PoolcueLimbMult = settings.GetUInteger("POOLCUE", "PedLimbMult", 100);
            PoolcuePlyrLimbMult = settings.GetUInteger("POOLCUE", "PlyrLimbMult", 100);
            PoolcueHndFtMult = settings.GetUInteger("POOLCUE", "PedHandsAndFeetMult", 100);
            PoolcuePlyrHndFtMult = settings.GetUInteger("POOLCUE", "PlyrHandsAndFeetMult", 100);
            PoolcueArmorMult = settings.GetUInteger("POOLCUE", "PedArmorMult", 100);
            PoolcuePlyrArmorMult = settings.GetUInteger("POOLCUE", "PlyrArmorMult", 100);
            PoolcueArmrPntMult = settings.GetUInteger("POOLCUE", "PedArmorPenetMult", 100);
            PoolcuePlyrArmrPntMult = settings.GetUInteger("POOLCUE", "PlyrArmorPenetMult", 0);

            KnifeHeadMult = settings.GetUInteger("KNIFE", "PedHeadMult", 100);
            KnifePlyrHeadMult = settings.GetUInteger("KNIFE", "PlyrHeadMult", 100);
            KnifeBodyMult = settings.GetUInteger("KNIFE", "PedBodyMult", 100);
            KnifePlyrBodyMult = settings.GetUInteger("KNIFE", "PlyrBodyMult", 100);
            KnifeLimbMult = settings.GetUInteger("KNIFE", "PedLimbMult", 100);
            KnifePlyrLimbMult = settings.GetUInteger("KNIFE", "PlyrLimbMult", 100);
            KnifeHndFtMult = settings.GetUInteger("KNIFE", "PedHandsAndFeetMult", 100);
            KnifePlyrHndFtMult = settings.GetUInteger("KNIFE", "PlyrHandsAndFeetMult", 100);
            KnifeArmorMult = settings.GetUInteger("KNIFE", "PedArmorMult", 100);
            KnifePlyrArmorMult = settings.GetUInteger("KNIFE", "PlyrArmorMult", 100);
            KnifeArmrPntMult = settings.GetUInteger("KNIFE", "PedArmorPenetMult", 100);
            KnifePlyrArmrPntMult = settings.GetUInteger("KNIFE", "PlyrArmorPenetMult", 0);

            GrenadeHeadMult = settings.GetUInteger("GRENADE", "PedHeadMult", 100);
            GrenadePlyrHeadMult = settings.GetUInteger("GRENADE", "PlyrHeadMult", 100);
            GrenadeBodyMult = settings.GetUInteger("GRENADE", "PedBodyMult", 100);
            GrenadePlyrBodyMult = settings.GetUInteger("GRENADE", "PlyrBodyMult", 100);
            GrenadeLimbMult = settings.GetUInteger("GRENADE", "PedLimbMult", 100);
            GrenadePlyrLimbMult = settings.GetUInteger("GRENADE", "PlyrLimbMult", 100);
            GrenadeHndFtMult = settings.GetUInteger("GRENADE", "PedHandsAndFeetMult", 100);
            GrenadePlyrHndFtMult = settings.GetUInteger("GRENADE", "PlyrHandsAndFeetMult", 100);
            GrenadeArmorMult = settings.GetUInteger("GRENADE", "PedArmorMult", 100);
            GrenadePlyrArmorMult = settings.GetUInteger("GRENADE", "PlyrArmorMult", 100);
            GrenadeArmrPntMult = settings.GetUInteger("GRENADE", "PedArmorPenetMult", 100);
            GrenadePlyrArmrPntMult = settings.GetUInteger("GRENADE", "PlyrArmorPenetMult", 0);

            MolotovHeadMult = settings.GetUInteger("MOLOTOV", "PedHeadMult", 100);
            MolotovPlyrHeadMult = settings.GetUInteger("MOLOTOV", "PlyrHeadMult", 100);
            MolotovBodyMult = settings.GetUInteger("MOLOTOV", "PedBodyMult", 100);
            MolotovPlyrBodyMult = settings.GetUInteger("MOLOTOV", "PlyrBodyMult", 100);
            MolotovLimbMult = settings.GetUInteger("MOLOTOV", "PedLimbMult", 100);
            MolotovPlyrLimbMult = settings.GetUInteger("MOLOTOV", "PlyrLimbMult", 100);
            MolotovHndFtMult = settings.GetUInteger("MOLOTOV", "PedHandsAndFeetMult", 100);
            MolotovPlyrHndFtMult = settings.GetUInteger("MOLOTOV", "PlyrHandsAndFeetMult", 100);
            MolotovArmorMult = settings.GetUInteger("MOLOTOV", "PedArmorMult", 100);
            MolotovPlyrArmorMult = settings.GetUInteger("MOLOTOV", "PlyrArmorMult", 100);
            MolotovArmrPntMult = settings.GetUInteger("MOLOTOV", "PedArmorPenetMult", 100);
            MolotovPlyrArmrPntMult = settings.GetUInteger("MOLOTOV", "PlyrArmorPenetMult", 0);

            RocketHeadMult = settings.GetUInteger("ROCKET", "PedHeadMult", 100);
            RocketPlyrHeadMult = settings.GetUInteger("ROCKET", "PlyrHeadMult", 100);
            RocketBodyMult = settings.GetUInteger("ROCKET", "PedBodyMult", 100);
            RocketPlyrBodyMult = settings.GetUInteger("ROCKET", "PlyrBodyMult", 100);
            RocketLimbMult = settings.GetUInteger("ROCKET", "PedLimbMult", 100);
            RocketPlyrLimbMult = settings.GetUInteger("ROCKET", "PlyrLimbMult", 100);
            RocketHndFtMult = settings.GetUInteger("ROCKET", "PedHandsAndFeetMult", 100);
            RocketPlyrHndFtMult = settings.GetUInteger("ROCKET", "PlyrHandsAndFeetMult", 100);
            RocketArmorMult = settings.GetUInteger("ROCKET", "PedArmorMult", 100);
            RocketPlyrArmorMult = settings.GetUInteger("ROCKET", "PlyrArmorMult", 100);
            RocketArmrPntMult = settings.GetUInteger("ROCKET", "PedArmorPenetMult", 100);
            RocketPlyrArmrPntMult = settings.GetUInteger("ROCKET", "PlyrArmorPenetMult", 0);

            PistolHeadMult = settings.GetUInteger("PISTOL", "PedHeadMult", 100);
            PistolPlyrHeadMult = settings.GetUInteger("PISTOL", "PlyrHeadMult", 100);
            PistolBodyMult = settings.GetUInteger("PISTOL", "PedBodyMult", 100);
            PistolPlyrBodyMult = settings.GetUInteger("PISTOL", "PlyrBodyMult", 100);
            PistolLimbMult = settings.GetUInteger("PISTOL", "PedLimbMult", 100);
            PistolPlyrLimbMult = settings.GetUInteger("PISTOL", "PlyrLimbMult", 100);
            PistolHndFtMult = settings.GetUInteger("PISTOL", "PedHandsAndFeetMult", 100);
            PistolPlyrHndFtMult = settings.GetUInteger("PISTOL", "PlyrHandsAndFeetMult", 100);
            PistolArmorMult = settings.GetUInteger("PISTOL", "PedArmorMult", 100);
            PistolPlyrArmorMult = settings.GetUInteger("PISTOL", "PlyrArmorMult", 100);
            PistolArmrPntMult = settings.GetUInteger("PISTOL", "PedArmorPenetMult", 100);
            PistolPlyrArmrPntMult = settings.GetUInteger("PISTOL", "PlyrArmorPenetMult", 0);

            SilencedHeadMult = settings.GetUInteger("SILENCED", "PedHeadMult", 100);
            SilencedPlyrHeadMult = settings.GetUInteger("SILENCED", "PlyrHeadMult", 100);
            SilencedBodyMult = settings.GetUInteger("SILENCED", "PedBodyMult", 100);
            SilencedPlyrBodyMult = settings.GetUInteger("SILENCED", "PlyrBodyMult", 100);
            SilencedLimbMult = settings.GetUInteger("SILENCED", "PedLimbMult", 100);
            SilencedPlyrLimbMult = settings.GetUInteger("SILENCED", "PlyrLimbMult", 100);
            SilencedHndFtMult = settings.GetUInteger("SILENCED", "PedHandsAndFeetMult", 100);
            SilencedPlyrHndFtMult = settings.GetUInteger("SILENCED", "PlyrHandsAndFeetMult", 100);
            SilencedArmorMult = settings.GetUInteger("SILENCED", "PedArmorMult", 100);
            SilencedPlyrArmorMult = settings.GetUInteger("SILENCED", "PlyrArmorMult", 100);
            SilencedArmrPntMult = settings.GetUInteger("SILENCED", "PedArmorPenetMult", 100);
            SilencedPlyrArmrPntMult = settings.GetUInteger("SILENCED", "PlyrArmorPenetMult", 0);

            DeagleHeadMult = settings.GetUInteger("DEAGLE", "PedHeadMult", 100);
            DeaglePlyrHeadMult = settings.GetUInteger("DEAGLE", "PlyrHeadMult", 100);
            DeagleBodyMult = settings.GetUInteger("DEAGLE", "PedBodyMult", 100);
            DeaglePlyrBodyMult = settings.GetUInteger("DEAGLE", "PlyrBodyMult", 100);
            DeagleLimbMult = settings.GetUInteger("DEAGLE", "PedLimbMult", 100);
            DeaglePlyrLimbMult = settings.GetUInteger("DEAGLE", "PlyrLimbMult", 100);
            DeagleHndFtMult = settings.GetUInteger("DEAGLE", "PedHandsAndFeetMult", 100);
            DeaglePlyrHndFtMult = settings.GetUInteger("DEAGLE", "PlyrHandsAndFeetMult", 100);
            DeagleArmorMult = settings.GetUInteger("DEAGLE", "PedArmorMult", 100);
            DeaglePlyrArmorMult = settings.GetUInteger("DEAGLE", "PlyrArmorMult", 100);
            DeagleArmrPntMult = settings.GetUInteger("DEAGLE", "PedArmorPenetMult", 100);
            DeaglePlyrArmrPntMult = settings.GetUInteger("DEAGLE", "PlyrArmorPenetMult", 0);

            PumpShotHeadMult = settings.GetUInteger("PUMPSHOT", "PedHeadMult", 100);
            PumpShotPlyrHeadMult = settings.GetUInteger("PUMPSHOT", "PlyrHeadMult", 100);
            PumpShotBodyMult = settings.GetUInteger("PUMPSHOT", "PedBodyMult", 100);
            PumpShotPlyrBodyMult = settings.GetUInteger("PUMPSHOT", "PlyrBodyMult", 100);
            PumpShotLimbMult = settings.GetUInteger("PUMPSHOT", "PedLimbMult", 100);
            PumpShotPlyrLimbMult = settings.GetUInteger("PUMPSHOT", "PlyrLimbMult", 100);
            PumpShotHndFtMult = settings.GetUInteger("PUMPSHOT", "PedHandsAndFeetMult", 100);
            PumpShotPlyrHndFtMult = settings.GetUInteger("PUMPSHOT", "PlyrHandsAndFeetMult", 100);
            PumpShotArmorMult = settings.GetUInteger("PUMPSHOT", "PedArmorMult", 100);
            PumpShotPlyrArmorMult = settings.GetUInteger("PUMPSHOT", "PlyrArmorMult", 100);
            PumpShotArmrPntMult = settings.GetUInteger("PUMPSHOT", "PedArmorPenetMult", 100);
            PumpShotPlyrArmrPntMult = settings.GetUInteger("PUMPSHOT", "PlyrArmorPenetMult", 0);

            CombatShotHeadMult = settings.GetUInteger("COMBATSHOT", "PedHeadMult", 100);
            CombatShotPlyrHeadMult = settings.GetUInteger("COMBATSHOT", "PlyrHeadMult", 100);
            CombatShotBodyMult = settings.GetUInteger("COMBATSHOT", "PedBodyMult", 100);
            CombatShotPlyrBodyMult = settings.GetUInteger("COMBATSHOT", "PlyrBodyMult", 100);
            CombatShotLimbMult = settings.GetUInteger("COMBATSHOT", "PedLimbMult", 100);
            CombatShotPlyrLimbMult = settings.GetUInteger("COMBATSHOT", "PlyrLimbMult", 100);
            CombatShotHndFtMult = settings.GetUInteger("COMBATSHOT", "PedHandsAndFeetMult", 100);
            CombatShotPlyrHndFtMult = settings.GetUInteger("COMBATSHOT", "PlyrHandsAndFeetMult", 100);
            CombatShotArmorMult = settings.GetUInteger("COMBATSHOT", "PedArmorMult", 100);
            CombatShotPlyrArmorMult = settings.GetUInteger("COMBATSHOT", "PlyrArmorMult", 100);
            CombatShotArmrPntMult = settings.GetUInteger("COMBATSHOT", "PedArmorPenetMult", 100);
            CombatShotPlyrArmrPntMult = settings.GetUInteger("COMBATSHOT", "PlyrArmorPenetMult", 0);

            UziHeadMult = settings.GetUInteger("MICROUZI", "PedHeadMult", 100);
            UziPlyrHeadMult = settings.GetUInteger("MICROUZI", "PlyrHeadMult", 100);
            UziBodyMult = settings.GetUInteger("MICROUZI", "PedBodyMult", 100);
            UziPlyrBodyMult = settings.GetUInteger("MICROUZI", "PlyrBodyMult", 100);
            UziLimbMult = settings.GetUInteger("MICROUZI", "PedLimbMult", 100);
            UziPlyrLimbMult = settings.GetUInteger("MICROUZI", "PlyrLimbMult", 100);
            UziHndFtMult = settings.GetUInteger("MICROUZI", "PedHandsAndFeetMult", 100);
            UziPlyrHndFtMult = settings.GetUInteger("MICROUZI", "PlyrHandsAndFeetMult", 100);
            UziArmorMult = settings.GetUInteger("MICROUZI", "PedArmorMult", 100);
            UziPlyrArmorMult = settings.GetUInteger("MICROUZI", "PlyrArmorMult", 100);
            UziArmrPntMult = settings.GetUInteger("MICROUZI", "PedArmorPenetMult", 100);
            UziPlyrArmrPntMult = settings.GetUInteger("MICROUZI", "PlyrArmorPenetMult", 0);

            MP5HeadMult = settings.GetUInteger("MP5", "PedHeadMult", 100);
            MP5PlyrHeadMult = settings.GetUInteger("MP5", "PlyrHeadMult", 100);
            MP5BodyMult = settings.GetUInteger("MP5", "PedBodyMult", 100);
            MP5PlyrBodyMult = settings.GetUInteger("MP5", "PlyrBodyMult", 100);
            MP5LimbMult = settings.GetUInteger("MP5", "PedLimbMult", 100);
            MP5PlyrLimbMult = settings.GetUInteger("MP5", "PlyrLimbMult", 100);
            MP5HndFtMult = settings.GetUInteger("MP5", "PedHandsAndFeetMult", 100);
            MP5PlyrHndFtMult = settings.GetUInteger("MP5", "PlyrHandsAndFeetMult", 100);
            MP5ArmorMult = settings.GetUInteger("MP5", "PedArmorMult", 100);
            MP5PlyrArmorMult = settings.GetUInteger("MP5", "PlyrArmorMult", 100);
            MP5ArmrPntMult = settings.GetUInteger("MP5", "PedArmorPenetMult", 100);
            MP5PlyrArmrPntMult = settings.GetUInteger("MP5", "PlyrArmorPenetMult", 0);

            Ak47HeadMult = settings.GetUInteger("AK47", "PedHeadMult", 100);
            Ak47PlyrHeadMult = settings.GetUInteger("AK47", "PlyrHeadMult", 100);
            Ak47BodyMult = settings.GetUInteger("AK47", "PedBodyMult", 100);
            Ak47PlyrBodyMult = settings.GetUInteger("AK47", "PlyrBodyMult", 100);
            Ak47LimbMult = settings.GetUInteger("AK47", "PedLimbMult", 100);
            Ak47PlyrLimbMult = settings.GetUInteger("AK47", "PlyrLimbMult", 100);
            Ak47HndFtMult = settings.GetUInteger("AK47", "PedHandsAndFeetMult", 100);
            Ak47PlyrHndFtMult = settings.GetUInteger("AK47", "PlyrHandsAndFeetMult", 100);
            Ak47ArmorMult = settings.GetUInteger("AK47", "PedArmorMult", 100);
            Ak47PlyrArmorMult = settings.GetUInteger("AK47", "PlyrArmorMult", 100);
            Ak47ArmrPntMult = settings.GetUInteger("AK47", "PedArmorPenetMult", 100);
            Ak47PlyrArmrPntMult = settings.GetUInteger("AK47", "PlyrArmorPenetMult", 0);

            M4HeadMult = settings.GetUInteger("M4", "PedHeadMult", 100);
            M4PlyrHeadMult = settings.GetUInteger("M4", "PlyrHeadMult", 100);
            M4BodyMult = settings.GetUInteger("M4", "PedBodyMult", 100);
            M4PlyrBodyMult = settings.GetUInteger("M4", "PlyrBodyMult", 100);
            M4LimbMult = settings.GetUInteger("M4", "PedLimbMult", 100);
            M4PlyrLimbMult = settings.GetUInteger("M4", "PlyrLimbMult", 100);
            M4HndFtMult = settings.GetUInteger("M4", "PedHandsAndFeetMult", 100);
            M4PlyrHndFtMult = settings.GetUInteger("M4", "PlyrHandsAndFeetMult", 100);
            M4ArmorMult = settings.GetUInteger("M4", "PedArmorMult", 100);
            M4PlyrArmorMult = settings.GetUInteger("M4", "PlyrArmorMult", 100);
            M4ArmrPntMult = settings.GetUInteger("M4", "PedArmorPenetMult", 100);
            M4PlyrArmrPntMult = settings.GetUInteger("M4", "PlyrArmorPenetMult", 0);

            PsgHeadMult = settings.GetUInteger("PSG1", "PedHeadMult", 100);
            PsgPlyrHeadMult = settings.GetUInteger("PSG1", "PlyrHeadMult", 100);
            PsgBodyMult = settings.GetUInteger("PSG1", "PedBodyMult", 100);
            PsgPlyrBodyMult = settings.GetUInteger("PSG1", "PlyrBodyMult", 100);
            PsgLimbMult = settings.GetUInteger("PSG1", "PedLimbMult", 100);
            PsgPlyrLimbMult = settings.GetUInteger("PSG1", "PlyrLimbMult", 100);
            PsgHndFtMult = settings.GetUInteger("PSG1", "PedHandsAndFeetMult", 100);
            PsgPlyrHndFtMult = settings.GetUInteger("PSG1", "PlyrHandsAndFeetMult", 100);
            PsgArmorMult = settings.GetUInteger("PSG1", "PedArmorMult", 100);
            PsgPlyrArmorMult = settings.GetUInteger("PSG1", "PlyrArmorMult", 100);
            PsgArmrPntMult = settings.GetUInteger("PSG1", "PedArmorPenetMult", 100);
            PsgPlyrArmrPntMult = settings.GetUInteger("PSG1", "PlyrArmorPenetMult", 0);

            M40HeadMult = settings.GetUInteger("M40", "PedHeadMult", 100);
            M40PlyrHeadMult = settings.GetUInteger("M40", "PlyrHeadMult", 100);
            M40BodyMult = settings.GetUInteger("M40", "PedBodyMult", 100);
            M40PlyrBodyMult = settings.GetUInteger("M40", "PlyrBodyMult", 100);
            M40LimbMult = settings.GetUInteger("M40", "PedLimbMult", 100);
            M40PlyrLimbMult = settings.GetUInteger("M40", "PlyrLimbMult", 100);
            M40HndFtMult = settings.GetUInteger("M40", "PedHandsAndFeetMult", 100);
            M40PlyrHndFtMult = settings.GetUInteger("M40", "PlyrHandsAndFeetMult", 100);
            M40ArmorMult = settings.GetUInteger("M40", "PedArmorMult", 100);
            M40PlyrArmorMult = settings.GetUInteger("M40", "PlyrArmorMult", 100);
            M40ArmrPntMult = settings.GetUInteger("M40", "PedArmorPenetMult", 100);
            M40PlyrArmrPntMult = settings.GetUInteger("M40", "PlyrArmorPenetMult", 0);

            RLauncherHeadMult = settings.GetUInteger("RPG", "PedHeadMult", 100);
            RLauncherPlyrHeadMult = settings.GetUInteger("RPG", "PlyrHeadMult", 100);
            RLauncherBodyMult = settings.GetUInteger("RPG", "PedBodyMult", 100);
            RLauncherPlyrBodyMult = settings.GetUInteger("RPG", "PlyrBodyMult", 100);
            RLauncherLimbMult = settings.GetUInteger("RPG", "PedLimbMult", 100);
            RLauncherPlyrLimbMult = settings.GetUInteger("RPG", "PlyrLimbMult", 100);
            RLauncherHndFtMult = settings.GetUInteger("RPG", "PedHandsAndFeetMult", 100);
            RLauncherPlyrHndFtMult = settings.GetUInteger("RPG", "PlyrHandsAndFeetMult", 100);
            RLauncherArmorMult = settings.GetUInteger("RPG", "PedArmorMult", 100);
            RLauncherPlyrArmorMult = settings.GetUInteger("RPG", "PlyrArmorMult", 100);
            RLauncherArmrPntMult = settings.GetUInteger("RPG", "PedArmorPenetMult", 100);
            RLauncherPlyrArmrPntMult = settings.GetUInteger("RPG", "PlyrArmorPenetMult", 0);

            FThrowerHeadMult = settings.GetUInteger("FTHROWER", "PedHeadMult", 100);
            FThrowerPlyrHeadMult = settings.GetUInteger("FTHROWER", "PlyrHeadMult", 100);
            FThrowerBodyMult = settings.GetUInteger("FTHROWER", "PedBodyMult", 100);
            FThrowerPlyrBodyMult = settings.GetUInteger("FTHROWER", "PlyrBodyMult", 100);
            FThrowerLimbMult = settings.GetUInteger("FTHROWER", "PedLimbMult", 100);
            FThrowerPlyrLimbMult = settings.GetUInteger("FTHROWER", "PlyrLimbMult", 100);
            FThrowerHndFtMult = settings.GetUInteger("FTHROWER", "PedHandsAndFeetMult", 100);
            FThrowerPlyrHndFtMult = settings.GetUInteger("FTHROWER", "PlyrHandsAndFeetMult", 100);
            FThrowerArmorMult = settings.GetUInteger("FTHROWER", "PedArmorMult", 100);
            FThrowerPlyrArmorMult = settings.GetUInteger("FTHROWER", "PlyrArmorMult", 100);
            FThrowerArmrPntMult = settings.GetUInteger("FTHROWER", "PedArmorPenetMult", 100);
            FThrowerPlyrArmrPntMult = settings.GetUInteger("FTHROWER", "PlyrArmorPenetMult", 0);

            MinigunHeadMult = settings.GetUInteger("MINIGUN", "PedHeadMult", 100);
            MinigunPlyrHeadMult = settings.GetUInteger("MINIGUN", "PlyrHeadMult", 100);
            MinigunBodyMult = settings.GetUInteger("MINIGUN", "PedBodyMult", 100);
            MinigunPlyrBodyMult = settings.GetUInteger("MINIGUN", "PlyrBodyMult", 100);
            MinigunLimbMult = settings.GetUInteger("MINIGUN", "PedLimbMult", 100);
            MinigunPlyrLimbMult = settings.GetUInteger("MINIGUN", "PlyrLimbMult", 100);
            MinigunHndFtMult = settings.GetUInteger("MINIGUN", "PedHandsAndFeetMult", 100);
            MinigunPlyrHndFtMult = settings.GetUInteger("MINIGUN", "PlyrHandsAndFeetMult", 100);
            MinigunArmorMult = settings.GetUInteger("MINIGUN", "PedArmorMult", 100);
            MinigunPlyrArmorMult = settings.GetUInteger("MINIGUN", "PlyrArmorMult", 100);
            MinigunArmrPntMult = settings.GetUInteger("MINIGUN", "PedArmorPenetMult", 100);
            MinigunPlyrArmrPntMult = settings.GetUInteger("MINIGUN", "PlyrArmorPenetMult", 0);

            GLauncherHeadMult = settings.GetUInteger("GRENADELAUNCHER", "PedHeadMult", 100);
            GLauncherPlyrHeadMult = settings.GetUInteger("GRENADELAUNCHER", "PlyrHeadMult", 100);
            GLauncherBodyMult = settings.GetUInteger("GRENADELAUNCHER", "PedBodyMult", 100);
            GLauncherPlyrBodyMult = settings.GetUInteger("GRENADELAUNCHER", "PlyrBodyMult", 100);
            GLauncherLimbMult = settings.GetUInteger("GRENADELAUNCHER", "PedLimbMult", 100);
            GLauncherPlyrLimbMult = settings.GetUInteger("GRENADELAUNCHER", "PlyrLimbMult", 100);
            GLauncherHndFtMult = settings.GetUInteger("GRENADELAUNCHER", "PedHandsAndFeetMult", 100);
            GLauncherPlyrHndFtMult = settings.GetUInteger("GRENADELAUNCHER", "PlyrHandsAndFeetMult", 100);
            GLauncherArmorMult = settings.GetUInteger("GRENADELAUNCHER", "PedArmorMult", 100);
            GLauncherPlyrArmorMult = settings.GetUInteger("GRENADELAUNCHER", "PlyrArmorMult", 100);
            GLauncherArmrPntMult = settings.GetUInteger("GRENADELAUNCHER", "PedArmorPenetMult", 100);
            GLauncherPlyrArmrPntMult = settings.GetUInteger("GRENADELAUNCHER", "PlyrArmorPenetMult", 0);

            ArmselHeadMult = settings.GetUInteger("ASSAULTSHOT", "PedHeadMult", 100);
            ArmselPlyrHeadMult = settings.GetUInteger("ASSAULTSHOT", "PlyrHeadMult", 100);
            ArmselBodyMult = settings.GetUInteger("ASSAULTSHOT", "PedBodyMult", 100);
            ArmselPlyrBodyMult = settings.GetUInteger("ASSAULTSHOT", "PlyrBodyMult", 100);
            ArmselLimbMult = settings.GetUInteger("ASSAULTSHOT", "PedLimbMult", 100);
            ArmselPlyrLimbMult = settings.GetUInteger("ASSAULTSHOT", "PlyrLimbMult", 100);
            ArmselHndFtMult = settings.GetUInteger("ASSAULTSHOT", "PedHandsAndFeetMult", 100);
            ArmselPlyrHndFtMult = settings.GetUInteger("ASSAULTSHOT", "PlyrHandsAndFeetMult", 100);
            ArmselArmorMult = settings.GetUInteger("ASSAULTSHOT", "PedArmorMult", 100);
            ArmselPlyrArmorMult = settings.GetUInteger("ASSAULTSHOT", "PlyrArmorMult", 100);
            ArmselArmrPntMult = settings.GetUInteger("ASSAULTSHOT", "PedArmorPenetMult", 100);
            ArmselPlyrArmrPntMult = settings.GetUInteger("ASSAULTSHOT", "PlyrArmorPenetMult", 0);

            Episodic3HeadMult = settings.GetUInteger("EPISODIC3", "PedHeadMult", 100);
            Episodic3PlyrHeadMult = settings.GetUInteger("EPISODIC3", "PlyrHeadMult", 100);
            Episodic3BodyMult = settings.GetUInteger("EPISODIC3", "PedBodyMult", 100);
            Episodic3PlyrBodyMult = settings.GetUInteger("EPISODIC3", "PlyrBodyMult", 100);
            Episodic3LimbMult = settings.GetUInteger("EPISODIC3", "PedLimbMult", 100);
            Episodic3PlyrLimbMult = settings.GetUInteger("EPISODIC3", "PlyrLimbMult", 100);
            Episodic3HndFtMult = settings.GetUInteger("EPISODIC3", "PedHandsAndFeetMult", 100);
            Episodic3PlyrHndFtMult = settings.GetUInteger("EPISODIC3", "PlyrHandsAndFeetMult", 100);
            Episodic3ArmorMult = settings.GetUInteger("EPISODIC3", "PedArmorMult", 100);
            Episodic3PlyrArmorMult = settings.GetUInteger("EPISODIC3", "PlyrArmorMult", 100);
            Episodic3ArmrPntMult = settings.GetUInteger("EPISODIC3", "PedArmorPenetMult", 100);
            Episodic3PlyrArmrPntMult = settings.GetUInteger("EPISODIC3", "PlyrArmorPenetMult", 0);

            BrokenCueHeadMult = settings.GetUInteger("TLADPOOLCUE", "PedHeadMult", 100);
            BrokenCuePlyrHeadMult = settings.GetUInteger("TLADPOOLCUE", "PlyrHeadMult", 100);
            BrokenCueBodyMult = settings.GetUInteger("TLADPOOLCUE", "PedBodyMult", 100);
            BrokenCuePlyrBodyMult = settings.GetUInteger("TLADPOOLCUE", "PlyrBodyMult", 100);
            BrokenCueLimbMult = settings.GetUInteger("TLADPOOLCUE", "PedLimbMult", 100);
            BrokenCuePlyrLimbMult = settings.GetUInteger("TLADPOOLCUE", "PlyrLimbMult", 100);
            BrokenCueHndFtMult = settings.GetUInteger("TLADPOOLCUE", "PedHandsAndFeetMult", 100);
            BrokenCuePlyrHndFtMult = settings.GetUInteger("TLADPOOLCUE", "PlyrHandsAndFeetMult", 100);
            BrokenCueArmorMult = settings.GetUInteger("TLADPOOLCUE", "PedArmorMult", 100);
            BrokenCuePlyrArmorMult = settings.GetUInteger("TLADPOOLCUE", "PlyrArmorMult", 100);
            BrokenCueArmrPntMult = settings.GetUInteger("TLADPOOLCUE", "PedArmorPenetMult", 100);
            BrokenCuePlyrArmrPntMult = settings.GetUInteger("TLADPOOLCUE", "PlyrArmorPenetMult", 0);

            GLaunGrndHeadMult = settings.GetUInteger("EPISODIC5", "PedHeadMult", 100);
            GLaunGrndPlyrHeadMult = settings.GetUInteger("EPISODIC5", "PlyrHeadMult", 100);
            GLaunGrndBodyMult = settings.GetUInteger("EPISODIC5", "PedBodyMult", 100);
            GLaunGrndPlyrBodyMult = settings.GetUInteger("EPISODIC5", "PlyrBodyMult", 100);
            GLaunGrndLimbMult = settings.GetUInteger("EPISODIC5", "PedLimbMult", 100);
            GLaunGrndPlyrLimbMult = settings.GetUInteger("EPISODIC5", "PlyrLimbMult", 100);
            GLaunGrndHndFtMult = settings.GetUInteger("EPISODIC5", "PedHandsAndFeetMult", 100);
            GLaunGrndPlyrHndFtMult = settings.GetUInteger("EPISODIC5", "PlyrHandsAndFeetMult", 100);
            GLaunGrndArmorMult = settings.GetUInteger("EPISODIC5", "PedArmorMult", 100);
            GLaunGrndPlyrArmorMult = settings.GetUInteger("EPISODIC5", "PlyrArmorMult", 100);
            GLaunGrndArmrPntMult = settings.GetUInteger("EPISODIC5", "PedArmorPenetMult", 100);
            GLaunGrndPlyrArmrPntMult = settings.GetUInteger("EPISODIC5", "PlyrArmorPenetMult", 0);

            SawnOffHeadMult = settings.GetUInteger("SAWNOFF", "PedHeadMult", 100);
            SawnOffPlyrHeadMult = settings.GetUInteger("SAWNOFF", "PlyrHeadMult", 100);
            SawnOffBodyMult = settings.GetUInteger("SAWNOFF", "PedBodyMult", 100);
            SawnOffPlyrBodyMult = settings.GetUInteger("SAWNOFF", "PlyrBodyMult", 100);
            SawnOffLimbMult = settings.GetUInteger("SAWNOFF", "PedLimbMult", 100);
            SawnOffPlyrLimbMult = settings.GetUInteger("SAWNOFF", "PlyrLimbMult", 100);
            SawnOffHndFtMult = settings.GetUInteger("SAWNOFF", "PedHandsAndFeetMult", 100);
            SawnOffPlyrHndFtMult = settings.GetUInteger("SAWNOFF", "PlyrHandsAndFeetMult", 100);
            SawnOffArmorMult = settings.GetUInteger("SAWNOFF", "PedArmorMult", 100);
            SawnOffPlyrArmorMult = settings.GetUInteger("SAWNOFF", "PlyrArmorMult", 100);
            SawnOffArmrPntMult = settings.GetUInteger("SAWNOFF", "PedArmorPenetMult", 100);
            SawnOffPlyrArmrPntMult = settings.GetUInteger("SAWNOFF", "PlyrArmorPenetMult", 0);

            AutoPistHeadMult = settings.GetUInteger("CZ75", "PedHeadMult", 100);
            AutoPistPlyrHeadMult = settings.GetUInteger("CZ75", "PlyrHeadMult", 100);
            AutoPistBodyMult = settings.GetUInteger("CZ75", "PedBodyMult", 100);
            AutoPistPlyrBodyMult = settings.GetUInteger("CZ75", "PlyrBodyMult", 100);
            AutoPistLimbMult = settings.GetUInteger("CZ75", "PedLimbMult", 100);
            AutoPistPlyrLimbMult = settings.GetUInteger("CZ75", "PlyrLimbMult", 100);
            AutoPistHndFtMult = settings.GetUInteger("CZ75", "PedHandsAndFeetMult", 100);
            AutoPistPlyrHndFtMult = settings.GetUInteger("CZ75", "PlyrHandsAndFeetMult", 100);
            AutoPistArmorMult = settings.GetUInteger("CZ75", "PedArmorMult", 100);
            AutoPistPlyrArmorMult = settings.GetUInteger("CZ75", "PlyrArmorMult", 100);
            AutoPistArmrPntMult = settings.GetUInteger("CZ75", "PedArmorPenetMult", 100);
            AutoPistPlyrArmrPntMult = settings.GetUInteger("CZ75", "PlyrArmorPenetMult", 0);

            PipeBombHeadMult = settings.GetUInteger("PIPEBOMB", "PedHeadMult", 100);
            PipeBombPlyrHeadMult = settings.GetUInteger("PIPEBOMB", "PlyrHeadMult", 100);
            PipeBombBodyMult = settings.GetUInteger("PIPEBOMB", "PedBodyMult", 100);
            PipeBombPlyrBodyMult = settings.GetUInteger("PIPEBOMB", "PlyrBodyMult", 100);
            PipeBombLimbMult = settings.GetUInteger("PIPEBOMB", "PedLimbMult", 100);
            PipeBombPlyrLimbMult = settings.GetUInteger("PIPEBOMB", "PlyrLimbMult", 100);
            PipeBombHndFtMult = settings.GetUInteger("PIPEBOMB", "PedHandsAndFeetMult", 100);
            PipeBombPlyrHndFtMult = settings.GetUInteger("PIPEBOMB", "PlyrHandsAndFeetMult", 100);
            PipeBombArmorMult = settings.GetUInteger("PIPEBOMB", "PedArmorMult", 100);
            PipeBombPlyrArmorMult = settings.GetUInteger("PIPEBOMB", "PlyrArmorMult", 100);
            PipeBombArmrPntMult = settings.GetUInteger("PIPEBOMB", "PedArmorPenetMult", 100);
            PipeBombPlyrArmrPntMult = settings.GetUInteger("PIPEBOMB", "PlyrArmorPenetMult", 0);

            AutoMagHeadMult = settings.GetUInteger("PISTOL44", "PedHeadMult", 100);
            AutoMagPlyrHeadMult = settings.GetUInteger("PISTOL44", "PlyrHeadMult", 100);
            AutoMagBodyMult = settings.GetUInteger("PISTOL44", "PedBodyMult", 100);
            AutoMagPlyrBodyMult = settings.GetUInteger("PISTOL44", "PlyrBodyMult", 100);
            AutoMagLimbMult = settings.GetUInteger("PISTOL44", "PedLimbMult", 100);
            AutoMagPlyrLimbMult = settings.GetUInteger("PISTOL44", "PlyrLimbMult", 100);
            AutoMagHndFtMult = settings.GetUInteger("PISTOL44", "PedHandsAndFeetMult", 100);
            AutoMagPlyrHndFtMult = settings.GetUInteger("PISTOL44", "PlyrHandsAndFeetMult", 100);
            AutoMagArmorMult = settings.GetUInteger("PISTOL44", "PedArmorMult", 100);
            AutoMagPlyrArmorMult = settings.GetUInteger("PISTOL44", "PlyrArmorMult", 100);
            AutoMagArmrPntMult = settings.GetUInteger("PISTOL44", "PedArmorPenetMult", 100);
            AutoMagPlyrArmrPntMult = settings.GetUInteger("PISTOL44", "PlyrArmorPenetMult", 0);

            AA12ExpHeadMult = settings.GetUInteger("AA12EXP", "PedHeadMult", 100);
            AA12ExpPlyrHeadMult = settings.GetUInteger("AA12EXP", "PlyrHeadMult", 100);
            AA12ExpBodyMult = settings.GetUInteger("AA12EXP", "PedBodyMult", 100);
            AA12ExpPlyrBodyMult = settings.GetUInteger("AA12EXP", "PlyrBodyMult", 100);
            AA12ExpLimbMult = settings.GetUInteger("AA12EXP", "PedLimbMult", 100);
            AA12ExpPlyrLimbMult = settings.GetUInteger("AA12EXP", "PlyrLimbMult", 100);
            AA12ExpHndFtMult = settings.GetUInteger("AA12EXP", "PedHandsAndFeetMult", 100);
            AA12ExpPlyrHndFtMult = settings.GetUInteger("AA12EXP", "PlyrHandsAndFeetMult", 100);
            AA12ExpArmorMult = settings.GetUInteger("AA12EXP", "PedArmorMult", 100);
            AA12ExpPlyrArmorMult = settings.GetUInteger("AA12EXP", "PlyrArmorMult", 100);
            AA12ExpArmrPntMult = settings.GetUInteger("AA12EXP", "PedArmorPenetMult", 100);
            AA12ExpPlyrArmrPntMult = settings.GetUInteger("AA12EXP", "PlyrArmorPenetMult", 0);

            AA12HeadMult = settings.GetUInteger("AA12", "PedHeadMult", 100);
            AA12PlyrHeadMult = settings.GetUInteger("AA12", "PlyrHeadMult", 100);
            AA12BodyMult = settings.GetUInteger("AA12", "PedBodyMult", 100);
            AA12PlyrBodyMult = settings.GetUInteger("AA12", "PlyrBodyMult", 100);
            AA12LimbMult = settings.GetUInteger("AA12", "PedLimbMult", 100);
            AA12PlyrLimbMult = settings.GetUInteger("AA12", "PlyrLimbMult", 100);
            AA12HndFtMult = settings.GetUInteger("AA12", "PedHandsAndFeetMult", 100);
            AA12PlyrHndFtMult = settings.GetUInteger("AA12", "PlyrHandsAndFeetMult", 100);
            AA12ArmorMult = settings.GetUInteger("AA12", "PedArmorMult", 100);
            AA12PlyrArmorMult = settings.GetUInteger("AA12", "PlyrArmorMult", 100);
            AA12ArmrPntMult = settings.GetUInteger("AA12", "PedArmorPenetMult", 100);
            AA12PlyrArmrPntMult = settings.GetUInteger("AA12", "PlyrArmorPenetMult", 0);

            P90HeadMult = settings.GetUInteger("P90", "PedHeadMult", 100);
            P90PlyrHeadMult = settings.GetUInteger("P90", "PlyrHeadMult", 100);
            P90BodyMult = settings.GetUInteger("P90", "PedBodyMult", 100);
            P90PlyrBodyMult = settings.GetUInteger("P90", "PlyrBodyMult", 100);
            P90LimbMult = settings.GetUInteger("P90", "PedLimbMult", 100);
            P90PlyrLimbMult = settings.GetUInteger("P90", "PlyrLimbMult", 100);
            P90HndFtMult = settings.GetUInteger("P90", "PedHandsAndFeetMult", 100);
            P90PlyrHndFtMult = settings.GetUInteger("P90", "PlyrHandsAndFeetMult", 100);
            P90ArmorMult = settings.GetUInteger("P90", "PedArmorMult", 100);
            P90PlyrArmorMult = settings.GetUInteger("P90", "PlyrArmorMult", 100);
            P90ArmrPntMult = settings.GetUInteger("P90", "PedArmorPenetMult", 100);
            P90PlyrArmrPntMult = settings.GetUInteger("P90", "PlyrArmorPenetMult", 0);

            GoldUziHeadMult = settings.GetUInteger("GOLDUZI", "PedHeadMult", 100);
            GoldUziPlyrHeadMult = settings.GetUInteger("GOLDUZI", "PlyrHeadMult", 100);
            GoldUziBodyMult = settings.GetUInteger("GOLDUZI", "PedBodyMult", 100);
            GoldUziPlyrBodyMult = settings.GetUInteger("GOLDUZI", "PlyrBodyMult", 100);
            GoldUziLimbMult = settings.GetUInteger("GOLDUZI", "PedLimbMult", 100);
            GoldUziPlyrLimbMult = settings.GetUInteger("GOLDUZI", "PlyrLimbMult", 100);
            GoldUziHndFtMult = settings.GetUInteger("GOLDUZI", "PedHandsAndFeetMult", 100);
            GoldUziPlyrHndFtMult = settings.GetUInteger("GOLDUZI", "PlyrHandsAndFeetMult", 100);
            GoldUziArmorMult = settings.GetUInteger("GOLDUZI", "PedArmorMult", 100);
            GoldUziPlyrArmorMult = settings.GetUInteger("GOLDUZI", "PlyrArmorMult", 100);
            GoldUziArmrPntMult = settings.GetUInteger("GOLDUZI", "PedArmorPenetMult", 100);
            GoldUziPlyrArmrPntMult = settings.GetUInteger("GOLDUZI", "PlyrArmorPenetMult", 0);

            M249HeadMult = settings.GetUInteger("M249", "PedHeadMult", 100);
            M249PlyrHeadMult = settings.GetUInteger("M249", "PlyrHeadMult", 100);
            M249BodyMult = settings.GetUInteger("M249", "PedBodyMult", 100);
            M249PlyrBodyMult = settings.GetUInteger("M249", "PlyrBodyMult", 100);
            M249LimbMult = settings.GetUInteger("M249", "PedLimbMult", 100);
            M249PlyrLimbMult = settings.GetUInteger("M249", "PlyrLimbMult", 100);
            M249HndFtMult = settings.GetUInteger("M249", "PedHandsAndFeetMult", 100);
            M249PlyrHndFtMult = settings.GetUInteger("M249", "PlyrHandsAndFeetMult", 100);
            M249ArmorMult = settings.GetUInteger("M249", "PedArmorMult", 100);
            M249PlyrArmorMult = settings.GetUInteger("M249", "PlyrArmorMult", 100);
            M249ArmrPntMult = settings.GetUInteger("M249", "PedArmorPenetMult", 100);
            M249PlyrArmrPntMult = settings.GetUInteger("M249", "PlyrArmorPenetMult", 0);

            DsrHeadMult = settings.GetUInteger("DSR1", "PedHeadMult", 100);
            DsrPlyrHeadMult = settings.GetUInteger("DSR1", "PlyrHeadMult", 100);
            DsrBodyMult = settings.GetUInteger("DSR1", "PedBodyMult", 100);
            DsrPlyrBodyMult = settings.GetUInteger("DSR1", "PlyrBodyMult", 100);
            DsrLimbMult = settings.GetUInteger("DSR1", "PedLimbMult", 100);
            DsrPlyrLimbMult = settings.GetUInteger("DSR1", "PlyrLimbMult", 100);
            DsrHndFtMult = settings.GetUInteger("DSR1", "PedHandsAndFeetMult", 100);
            DsrPlyrHndFtMult = settings.GetUInteger("DSR1", "PlyrHandsAndFeetMult", 100);
            DsrArmorMult = settings.GetUInteger("DSR1", "PedArmorMult", 100);
            DsrPlyrArmorMult = settings.GetUInteger("DSR1", "PlyrArmorMult", 100);
            DsrArmrPntMult = settings.GetUInteger("DSR1", "PedArmorPenetMult", 100);
            DsrPlyrArmrPntMult = settings.GetUInteger("DSR1", "PlyrArmorPenetMult", 0);

            StickyBombHeadMult = settings.GetUInteger("STICKYBOMB", "PedHeadMult", 100);
            StickyBombPlyrHeadMult = settings.GetUInteger("STICKYBOMB", "PlyrHeadMult", 100);
            StickyBombBodyMult = settings.GetUInteger("STICKYBOMB", "PedBodyMult", 100);
            StickyBombPlyrBodyMult = settings.GetUInteger("STICKYBOMB", "PlyrBodyMult", 100);
            StickyBombLimbMult = settings.GetUInteger("STICKYBOMB", "PedLimbMult", 100);
            StickyBombPlyrLimbMult = settings.GetUInteger("STICKYBOMB", "PlyrLimbMult", 100);
            StickyBombHndFtMult = settings.GetUInteger("STICKYBOMB", "PedHandsAndFeetMult", 100);
            StickyBombPlyrHndFtMult = settings.GetUInteger("STICKYBOMB", "PlyrHandsAndFeetMult", 100);
            StickyBombArmorMult = settings.GetUInteger("STICKYBOMB", "PedArmorMult", 100);
            StickyBombPlyrArmorMult = settings.GetUInteger("STICKYBOMB", "PlyrArmorMult", 100);
            StickyBombArmrPntMult = settings.GetUInteger("STICKYBOMB", "PedArmorPenetMult", 100);
            StickyBombPlyrArmrPntMult = settings.GetUInteger("STICKYBOMB", "PlyrArmorPenetMult", 0);

            BuzzardRLHeadMult = settings.GetUInteger("BUZZARDROCKETLAUNCHER", "PedHeadMult", 100);
            BuzzardRLPlyrHeadMult = settings.GetUInteger("BUZZARDROCKETLAUNCHER", "PlyrHeadMult", 100);
            BuzzardRLBodyMult = settings.GetUInteger("BUZZARDROCKETLAUNCHER", "PedBodyMult", 100);
            BuzzardRLPlyrBodyMult = settings.GetUInteger("BUZZARDROCKETLAUNCHER", "PlyrBodyMult", 100);
            BuzzardRLLimbMult = settings.GetUInteger("BUZZARDROCKETLAUNCHER", "PedLimbMult", 100);
            BuzzardRLPlyrLimbMult = settings.GetUInteger("BUZZARDROCKETLAUNCHER", "PlyrLimbMult", 100);
            BuzzardRLHndFtMult = settings.GetUInteger("BUZZARDROCKETLAUNCHER", "PedHandsAndFeetMult", 100);
            BuzzardRLPlyrHndFtMult = settings.GetUInteger("BUZZARDROCKETLAUNCHER", "PlyrHandsAndFeetMult", 100);
            BuzzardRLArmorMult = settings.GetUInteger("BUZZARDROCKETLAUNCHER", "PedArmorMult", 100);
            BuzzardRLPlyrArmorMult = settings.GetUInteger("BUZZARDROCKETLAUNCHER", "PlyrArmorMult", 100);
            BuzzardRLArmrPntMult = settings.GetUInteger("BUZZARDROCKETLAUNCHER", "PedArmorPenetMult", 100);
            BuzzardRLPlyrArmrPntMult = settings.GetUInteger("BUZZARDROCKETLAUNCHER", "PlyrArmorPenetMult", 0);

            BuzzardRHeadMult = settings.GetUInteger("BUZZARDROCKET", "PedHeadMult", 100);
            BuzzardRPlyrHeadMult = settings.GetUInteger("BUZZARDROCKET", "PlyrHeadMult", 100);
            BuzzardRBodyMult = settings.GetUInteger("BUZZARDROCKET", "PedBodyMult", 100);
            BuzzardRPlyrBodyMult = settings.GetUInteger("BUZZARDROCKET", "PlyrBodyMult", 100);
            BuzzardRLimbMult = settings.GetUInteger("BUZZARDROCKET", "PedLimbMult", 100);
            BuzzardRPlyrLimbMult = settings.GetUInteger("BUZZARDROCKET", "PlyrLimbMult", 100);
            BuzzardRHndFtMult = settings.GetUInteger("BUZZARDROCKET", "PedHandsAndFeetMult", 100);
            BuzzardRPlyrHndFtMult = settings.GetUInteger("BUZZARDROCKET", "PlyrHandsAndFeetMult", 100);
            BuzzardRArmorMult = settings.GetUInteger("BUZZARDROCKET", "PedArmorMult", 100);
            BuzzardRPlyrArmorMult = settings.GetUInteger("BUZZARDROCKET", "PlyrArmorMult", 100);
            BuzzardRArmrPntMult = settings.GetUInteger("BUZZARDROCKET", "PedArmorPenetMult", 100);
            BuzzardRPlyrArmrPntMult = settings.GetUInteger("BUZZARDROCKET", "PlyrArmorPenetMult", 0);

            BuzzardGHeadMult = settings.GetUInteger("BUZZARDGUN", "PedHeadMult", 100);
            BuzzardGPlyrHeadMult = settings.GetUInteger("BUZZARDGUN", "PlyrHeadMult", 100);
            BuzzardGBodyMult = settings.GetUInteger("BUZZARDGUN", "PedBodyMult", 100);
            BuzzardGPlyrBodyMult = settings.GetUInteger("BUZZARDGUN", "PlyrBodyMult", 100);
            BuzzardGLimbMult = settings.GetUInteger("BUZZARDGUN", "PedLimbMult", 100);
            BuzzardGPlyrLimbMult = settings.GetUInteger("BUZZARDGUN", "PlyrLimbMult", 100);
            BuzzardGHndFtMult = settings.GetUInteger("BUZZARDGUN", "PedHandsAndFeetMult", 100);
            BuzzardGPlyrHndFtMult = settings.GetUInteger("BUZZARDGUN", "PlyrHandsAndFeetMult", 100);
            BuzzardGArmorMult = settings.GetUInteger("BUZZARDGUN", "PedArmorMult", 100);
            BuzzardGPlyrArmorMult = settings.GetUInteger("BUZZARDGUN", "PlyrArmorMult", 100);
            BuzzardGArmrPntMult = settings.GetUInteger("BUZZARDGUN", "PedArmorPenetMult", 100);
            BuzzardGPlyrArmrPntMult = settings.GetUInteger("BUZZARDGUN", "PlyrArmorPenetMult", 0);

            APCHeadMult = settings.GetUInteger("APCCANNON", "PedHeadMult", 100);
            APCPlyrHeadMult = settings.GetUInteger("APCCANNON", "PlyrHeadMult", 100);
            APCBodyMult = settings.GetUInteger("APCCANNON", "PedBodyMult", 100);
            APCPlyrBodyMult = settings.GetUInteger("APCCANNON", "PlyrBodyMult", 100);
            APCLimbMult = settings.GetUInteger("APCCANNON", "PedLimbMult", 100);
            APCPlyrLimbMult = settings.GetUInteger("APCCANNON", "PlyrLimbMult", 100);
            APCHndFtMult = settings.GetUInteger("APCCANNON", "PedHandsAndFeetMult", 100);
            APCPlyrHndFtMult = settings.GetUInteger("APCCANNON", "PlyrHandsAndFeetMult", 100);
            APCArmorMult = settings.GetUInteger("APCCANNON", "PedArmorMult", 100);
            APCPlyrArmorMult = settings.GetUInteger("APCCANNON", "PlyrArmorMult", 100);
            APCArmrPntMult = settings.GetUInteger("APCCANNON", "PedArmorPenetMult", 100);
            APCPlyrArmrPntMult = settings.GetUInteger("APCCANNON", "PlyrArmorPenetMult", 0);

            ParachuteHeadMult = settings.GetUInteger("PARACHUTE", "PedHeadMult", 100);
            ParachutePlyrHeadMult = settings.GetUInteger("PARACHUTE", "PlyrHeadMult", 100);
            ParachuteBodyMult = settings.GetUInteger("PARACHUTE", "PedBodyMult", 100);
            ParachutePlyrBodyMult = settings.GetUInteger("PARACHUTE", "PlyrBodyMult", 100);
            ParachuteLimbMult = settings.GetUInteger("PARACHUTE", "PedLimbMult", 100);
            ParachutePlyrLimbMult = settings.GetUInteger("PARACHUTE", "PlyrLimbMult", 100);
            ParachuteHndFtMult = settings.GetUInteger("PARACHUTE", "PedHandsAndFeetMult", 100);
            ParachutePlyrHndFtMult = settings.GetUInteger("PARACHUTE", "PlyrHandsAndFeetMult", 100);
            ParachuteArmorMult = settings.GetUInteger("PARACHUTE", "PedArmorMult", 100);
            ParachutePlyrArmorMult = settings.GetUInteger("PARACHUTE", "PlyrArmorMult", 100);
            ParachuteArmrPntMult = settings.GetUInteger("PARACHUTE", "PedArmorPenetMult", 100);
            ParachutePlyrArmrPntMult = settings.GetUInteger("PARACHUTE", "PlyrArmorPenetMult", 0);

            Episodic22HeadMult = settings.GetUInteger("EPISODIC22", "PedHeadMult", 100);
            Episodic22PlyrHeadMult = settings.GetUInteger("EPISODIC22", "PlyrHeadMult", 100);
            Episodic22BodyMult = settings.GetUInteger("EPISODIC22", "PedBodyMult", 100);
            Episodic22PlyrBodyMult = settings.GetUInteger("EPISODIC22", "PlyrBodyMult", 100);
            Episodic22LimbMult = settings.GetUInteger("EPISODIC22", "PedLimbMult", 100);
            Episodic22PlyrLimbMult = settings.GetUInteger("EPISODIC22", "PlyrLimbMult", 100);
            Episodic22HndFtMult = settings.GetUInteger("EPISODIC22", "PedHandsAndFeetMult", 100);
            Episodic22PlyrHndFtMult = settings.GetUInteger("EPISODIC22", "PlyrHandsAndFeetMult", 100);
            Episodic22ArmorMult = settings.GetUInteger("EPISODIC22", "PedArmorMult", 100);
            Episodic22PlyrArmorMult = settings.GetUInteger("EPISODIC22", "PlyrArmorMult", 100);
            Episodic22ArmrPntMult = settings.GetUInteger("EPISODIC22", "PedArmorPenetMult", 100);
            Episodic22PlyrArmrPntMult = settings.GetUInteger("EPISODIC22", "PlyrArmorPenetMult", 0);

            Episodic23HeadMult = settings.GetUInteger("EPISODIC23", "PedHeadMult", 100);
            Episodic23PlyrHeadMult = settings.GetUInteger("EPISODIC23", "PlyrHeadMult", 100);
            Episodic23BodyMult = settings.GetUInteger("EPISODIC23", "PedBodyMult", 100);
            Episodic23PlyrBodyMult = settings.GetUInteger("EPISODIC23", "PlyrBodyMult", 100);
            Episodic23LimbMult = settings.GetUInteger("EPISODIC23", "PedLimbMult", 100);
            Episodic23PlyrLimbMult = settings.GetUInteger("EPISODIC23", "PlyrLimbMult", 100);
            Episodic23HndFtMult = settings.GetUInteger("EPISODIC23", "PedHandsAndFeetMult", 100);
            Episodic23PlyrHndFtMult = settings.GetUInteger("EPISODIC23", "PlyrHandsAndFeetMult", 100);
            Episodic23ArmorMult = settings.GetUInteger("EPISODIC23", "PedArmorMult", 100);
            Episodic23PlyrArmorMult = settings.GetUInteger("EPISODIC23", "PlyrArmorMult", 100);
            Episodic23ArmrPntMult = settings.GetUInteger("EPISODIC23", "PedArmorPenetMult", 100);
            Episodic23PlyrArmrPntMult = settings.GetUInteger("EPISODIC23", "PlyrArmorPenetMult", 0);

            Episodic24HeadMult = settings.GetUInteger("EPISODIC24", "PedHeadMult", 100);
            Episodic24PlyrHeadMult = settings.GetUInteger("EPISODIC24", "PlyrHeadMult", 100);
            Episodic24BodyMult = settings.GetUInteger("EPISODIC24", "PedBodyMult", 100);
            Episodic24PlyrBodyMult = settings.GetUInteger("EPISODIC24", "PlyrBodyMult", 100);
            Episodic24LimbMult = settings.GetUInteger("EPISODIC24", "PedLimbMult", 100);
            Episodic24PlyrLimbMult = settings.GetUInteger("EPISODIC24", "PlyrLimbMult", 100);
            Episodic24HndFtMult = settings.GetUInteger("EPISODIC24", "PedHandsAndFeetMult", 100);
            Episodic24PlyrHndFtMult = settings.GetUInteger("EPISODIC24", "PlyrHandsAndFeetMult", 100);
            Episodic24ArmorMult = settings.GetUInteger("EPISODIC24", "PedArmorMult", 100);
            Episodic24PlyrArmorMult = settings.GetUInteger("EPISODIC24", "PlyrArmorMult", 100);
            Episodic24ArmrPntMult = settings.GetUInteger("EPISODIC24", "PedArmorPenetMult", 100);
            Episodic24PlyrArmrPntMult = settings.GetUInteger("EPISODIC24", "PlyrArmorPenetMult", 0);

            CameraHeadMult = settings.GetUInteger("CAMERA", "PedHeadMult", 100);
            CameraPlyrHeadMult = settings.GetUInteger("CAMERA", "PlyrHeadMult", 100);
            CameraBodyMult = settings.GetUInteger("CAMERA", "PedBodyMult", 100);
            CameraPlyrBodyMult = settings.GetUInteger("CAMERA", "PlyrBodyMult", 100);
            CameraLimbMult = settings.GetUInteger("CAMERA", "PedLimbMult", 100);
            CameraPlyrLimbMult = settings.GetUInteger("CAMERA", "PlyrLimbMult", 100);
            CameraHndFtMult = settings.GetUInteger("CAMERA", "PedHandsAndFeetMult", 100);
            CameraPlyrHndFtMult = settings.GetUInteger("CAMERA", "PlyrHandsAndFeetMult", 100);
            CameraArmorMult = settings.GetUInteger("CAMERA", "PedArmorMult", 100);
            CameraPlyrArmorMult = settings.GetUInteger("CAMERA", "PlyrArmorMult", 100);
            CameraArmrPntMult = settings.GetUInteger("CAMERA", "PedArmorPenetMult", 100);
            CameraPlyrArmrPntMult = settings.GetUInteger("CAMERA", "PlyrArmorPenetMult", 0);

            ObjectHeadMult = settings.GetUInteger("OBJECT", "PedHeadMult", 100);
            ObjectPlyrHeadMult = settings.GetUInteger("OBJECT", "PlyrHeadMult", 100);
            ObjectBodyMult = settings.GetUInteger("OBJECT", "PedBodyMult", 100);
            ObjectPlyrBodyMult = settings.GetUInteger("OBJECT", "PlyrBodyMult", 100);
            ObjectLimbMult = settings.GetUInteger("OBJECT", "PedLimbMult", 100);
            ObjectPlyrLimbMult = settings.GetUInteger("OBJECT", "PlyrLimbMult", 100);
            ObjectHndFtMult = settings.GetUInteger("OBJECT", "PedHandsAndFeetMult", 100);
            ObjectPlyrHndFtMult = settings.GetUInteger("OBJECT", "PlyrHandsAndFeetMult", 100);
            ObjectArmorMult = settings.GetUInteger("OBJECT", "PedArmorMult", 100);
            ObjectPlyrArmorMult = settings.GetUInteger("OBJECT", "PlyrArmorMult", 100);
            ObjectArmrPntMult = settings.GetUInteger("OBJECT", "PedArmorPenetMult", 100);
            ObjectPlyrArmrPntMult = settings.GetUInteger("OBJECT", "PlyrArmorPenetMult", 0);

            ArmorHeadMult = settings.GetUInteger("ARMOR", "PedHeadMult", 100);
            ArmorPlyrHeadMult = settings.GetUInteger("ARMOR", "PlyrHeadMult", 100);
            ArmorBodyMult = settings.GetUInteger("ARMOR", "PedBodyMult", 100);
            ArmorPlyrBodyMult = settings.GetUInteger("ARMOR", "PlyrBodyMult", 100);
            ArmorLimbMult = settings.GetUInteger("ARMOR", "PedLimbMult", 100);
            ArmorPlyrLimbMult = settings.GetUInteger("ARMOR", "PlyrLimbMult", 100);
            ArmorHndFtMult = settings.GetUInteger("ARMOR", "PedHandsAndFeetMult", 100);
            ArmorPlyrHndFtMult = settings.GetUInteger("ARMOR", "PlyrHandsAndFeetMult", 100);
            ArmorArmorMult = settings.GetUInteger("ARMOR", "PedArmorMult", 100);
            ArmorPlyrArmorMult = settings.GetUInteger("ARMOR", "PlyrArmorMult", 100);
            ArmorArmrPntMult = settings.GetUInteger("ARMOR", "PedArmorPenetMult", 100);
            ArmorPlyrArmrPntMult = settings.GetUInteger("ARMOR", "PlyrArmorPenetMult", 0);

            ExplosionHeadMult = settings.GetUInteger("EXPLOSION", "PedHeadMult", 100);
            ExplosionPlyrHeadMult = settings.GetUInteger("EXPLOSION", "PlyrHeadMult", 100);
            ExplosionBodyMult = settings.GetUInteger("EXPLOSION", "PedBodyMult", 100);
            ExplosionPlyrBodyMult = settings.GetUInteger("EXPLOSION", "PlyrBodyMult", 100);
            ExplosionLimbMult = settings.GetUInteger("EXPLOSION", "PedLimbMult", 100);
            ExplosionPlyrLimbMult = settings.GetUInteger("EXPLOSION", "PlyrLimbMult", 100);
            ExplosionHndFtMult = settings.GetUInteger("EXPLOSION", "PedHandsAndFeetMult", 100);
            ExplosionPlyrHndFtMult = settings.GetUInteger("EXPLOSION", "PlyrHandsAndFeetMult", 100);
            ExplosionArmorMult = settings.GetUInteger("EXPLOSION", "PedArmorMult", 100);
            ExplosionPlyrArmorMult = settings.GetUInteger("EXPLOSION", "PlyrArmorMult", 100);
            ExplosionArmrPntMult = settings.GetUInteger("EXPLOSION", "PedArmorPenetMult", 100);
            ExplosionPlyrArmrPntMult = settings.GetUInteger("EXPLOSION", "PlyrArmorPenetMult", 0);

            Addon1HeadMult = settings.GetUInteger("ADDONWEAPON1", "PedHeadMult", 100);
            Addon1PlyrHeadMult = settings.GetUInteger("ADDONWEAPON1", "PlyrHeadMult", 100);
            Addon1BodyMult = settings.GetUInteger("ADDONWEAPON1", "PedBodyMult", 100);
            Addon1PlyrBodyMult = settings.GetUInteger("ADDONWEAPON1", "PlyrBodyMult", 100);
            Addon1LimbMult = settings.GetUInteger("ADDONWEAPON1", "PedLimbMult", 100);
            Addon1PlyrLimbMult = settings.GetUInteger("ADDONWEAPON1", "PlyrLimbMult", 100);
            Addon1HndFtMult = settings.GetUInteger("ADDONWEAPON1", "PedHandsAndFeetMult", 100);
            Addon1PlyrHndFtMult = settings.GetUInteger("ADDONWEAPON1", "PlyrHandsAndFeetMult", 100);
            Addon1ArmorMult = settings.GetUInteger("ADDONWEAPON1", "PedArmorMult", 100);
            Addon1PlyrArmorMult = settings.GetUInteger("ADDONWEAPON1", "PlyrArmorMult", 100);
            Addon1ArmrPntMult = settings.GetUInteger("ADDONWEAPON1", "PedArmorPenetMult", 100);
            Addon1PlyrArmrPntMult = settings.GetUInteger("ADDONWEAPON1", "PlyrArmorPenetMult", 0);

            Addon2HeadMult = settings.GetUInteger("ADDONWEAPON2", "PedHeadMult", 100);
            Addon2PlyrHeadMult = settings.GetUInteger("ADDONWEAPON2", "PlyrHeadMult", 100);
            Addon2BodyMult = settings.GetUInteger("ADDONWEAPON2", "PedBodyMult", 100);
            Addon2PlyrBodyMult = settings.GetUInteger("ADDONWEAPON2", "PlyrBodyMult", 100);
            Addon2LimbMult = settings.GetUInteger("ADDONWEAPON2", "PedLimbMult", 100);
            Addon2PlyrLimbMult = settings.GetUInteger("ADDONWEAPON2", "PlyrLimbMult", 100);
            Addon2HndFtMult = settings.GetUInteger("ADDONWEAPON2", "PedHandsAndFeetMult", 100);
            Addon2PlyrHndFtMult = settings.GetUInteger("ADDONWEAPON2", "PlyrHandsAndFeetMult", 100);
            Addon2ArmorMult = settings.GetUInteger("ADDONWEAPON2", "PedArmorMult", 100);
            Addon2PlyrArmorMult = settings.GetUInteger("ADDONWEAPON2", "PlyrArmorMult", 100);
            Addon2ArmrPntMult = settings.GetUInteger("ADDONWEAPON2", "PedArmorPenetMult", 100);
            Addon2PlyrArmrPntMult = settings.GetUInteger("ADDONWEAPON2", "PlyrArmorPenetMult", 0);

            Addon3HeadMult = settings.GetUInteger("ADDONWEAPON3", "PedHeadMult", 100);
            Addon3PlyrHeadMult = settings.GetUInteger("ADDONWEAPON3", "PlyrHeadMult", 100);
            Addon3BodyMult = settings.GetUInteger("ADDONWEAPON3", "PedBodyMult", 100);
            Addon3PlyrBodyMult = settings.GetUInteger("ADDONWEAPON3", "PlyrBodyMult", 100);
            Addon3LimbMult = settings.GetUInteger("ADDONWEAPON3", "PedLimbMult", 100);
            Addon3PlyrLimbMult = settings.GetUInteger("ADDONWEAPON3", "PlyrLimbMult", 100);
            Addon3HndFtMult = settings.GetUInteger("ADDONWEAPON3", "PedHandsAndFeetMult", 100);
            Addon3PlyrHndFtMult = settings.GetUInteger("ADDONWEAPON3", "PlyrHandsAndFeetMult", 100);
            Addon3ArmorMult = settings.GetUInteger("ADDONWEAPON3", "PedArmorMult", 100);
            Addon3PlyrArmorMult = settings.GetUInteger("ADDONWEAPON3", "PlyrArmorMult", 100);
            Addon3ArmrPntMult = settings.GetUInteger("ADDONWEAPON3", "PedArmorPenetMult", 100);
            Addon3PlyrArmrPntMult = settings.GetUInteger("ADDONWEAPON3", "PlyrArmorPenetMult", 0);

            Addon4HeadMult = settings.GetUInteger("ADDONWEAPON4", "PedHeadMult", 100);
            Addon4PlyrHeadMult = settings.GetUInteger("ADDONWEAPON4", "PlyrHeadMult", 100);
            Addon4BodyMult = settings.GetUInteger("ADDONWEAPON4", "PedBodyMult", 100);
            Addon4PlyrBodyMult = settings.GetUInteger("ADDONWEAPON4", "PlyrBodyMult", 100);
            Addon4LimbMult = settings.GetUInteger("ADDONWEAPON4", "PedLimbMult", 100);
            Addon4PlyrLimbMult = settings.GetUInteger("ADDONWEAPON4", "PlyrLimbMult", 100);
            Addon4HndFtMult = settings.GetUInteger("ADDONWEAPON4", "PedHandsAndFeetMult", 100);
            Addon4PlyrHndFtMult = settings.GetUInteger("ADDONWEAPON4", "PlyrHandsAndFeetMult", 100);
            Addon4ArmorMult = settings.GetUInteger("ADDONWEAPON4", "PedArmorMult", 100);
            Addon4PlyrArmorMult = settings.GetUInteger("ADDONWEAPON4", "PlyrArmorMult", 100);
            Addon4ArmrPntMult = settings.GetUInteger("ADDONWEAPON4", "PedArmorPenetMult", 100);
            Addon4PlyrArmrPntMult = settings.GetUInteger("ADDONWEAPON4", "PlyrArmorPenetMult", 0);

            Addon5HeadMult = settings.GetUInteger("ADDONWEAPON5", "PedHeadMult", 100);
            Addon5PlyrHeadMult = settings.GetUInteger("ADDONWEAPON5", "PlyrHeadMult", 100);
            Addon5BodyMult = settings.GetUInteger("ADDONWEAPON5", "PedBodyMult", 100);
            Addon5PlyrBodyMult = settings.GetUInteger("ADDONWEAPON5", "PlyrBodyMult", 100);
            Addon5LimbMult = settings.GetUInteger("ADDONWEAPON5", "PedLimbMult", 100);
            Addon5PlyrLimbMult = settings.GetUInteger("ADDONWEAPON5", "PlyrLimbMult", 100);
            Addon5HndFtMult = settings.GetUInteger("ADDONWEAPON5", "PedHandsAndFeetMult", 100);
            Addon5PlyrHndFtMult = settings.GetUInteger("ADDONWEAPON5", "PlyrHandsAndFeetMult", 100);
            Addon5ArmorMult = settings.GetUInteger("ADDONWEAPON5", "PedArmorMult", 100);
            Addon5PlyrArmorMult = settings.GetUInteger("ADDONWEAPON5", "PlyrArmorMult", 100);
            Addon5ArmrPntMult = settings.GetUInteger("ADDONWEAPON5", "PedArmorPenetMult", 100);
            Addon5PlyrArmrPntMult = settings.GetUInteger("ADDONWEAPON5", "PlyrArmorPenetMult", 0);

            Addon6HeadMult = settings.GetUInteger("ADDONWEAPON6", "PedHeadMult", 100);
            Addon6PlyrHeadMult = settings.GetUInteger("ADDONWEAPON6", "PlyrHeadMult", 100);
            Addon6BodyMult = settings.GetUInteger("ADDONWEAPON6", "PedBodyMult", 100);
            Addon6PlyrBodyMult = settings.GetUInteger("ADDONWEAPON6", "PlyrBodyMult", 100);
            Addon6LimbMult = settings.GetUInteger("ADDONWEAPON6", "PedLimbMult", 100);
            Addon6PlyrLimbMult = settings.GetUInteger("ADDONWEAPON6", "PlyrLimbMult", 100);
            Addon6HndFtMult = settings.GetUInteger("ADDONWEAPON6", "PedHandsAndFeetMult", 100);
            Addon6PlyrHndFtMult = settings.GetUInteger("ADDONWEAPON6", "PlyrHandsAndFeetMult", 100);
            Addon6ArmorMult = settings.GetUInteger("ADDONWEAPON6", "PedArmorMult", 100);
            Addon6PlyrArmorMult = settings.GetUInteger("ADDONWEAPON6", "PlyrArmorMult", 100);
            Addon6ArmrPntMult = settings.GetUInteger("ADDONWEAPON6", "PedArmorPenetMult", 100);
            Addon6PlyrArmrPntMult = settings.GetUInteger("ADDONWEAPON6", "PlyrArmorPenetMult", 0);

            Addon7HeadMult = settings.GetUInteger("ADDONWEAPON7", "PedHeadMult", 100);
            Addon7PlyrHeadMult = settings.GetUInteger("ADDONWEAPON7", "PlyrHeadMult", 100);
            Addon7BodyMult = settings.GetUInteger("ADDONWEAPON7", "PedBodyMult", 100);
            Addon7PlyrBodyMult = settings.GetUInteger("ADDONWEAPON7", "PlyrBodyMult", 100);
            Addon7LimbMult = settings.GetUInteger("ADDONWEAPON7", "PedLimbMult", 100);
            Addon7PlyrLimbMult = settings.GetUInteger("ADDONWEAPON7", "PlyrLimbMult", 100);
            Addon7HndFtMult = settings.GetUInteger("ADDONWEAPON7", "PedHandsAndFeetMult", 100);
            Addon7PlyrHndFtMult = settings.GetUInteger("ADDONWEAPON7", "PlyrHandsAndFeetMult", 100);
            Addon7ArmorMult = settings.GetUInteger("ADDONWEAPON7", "PedArmorMult", 100);
            Addon7PlyrArmorMult = settings.GetUInteger("ADDONWEAPON7", "PlyrArmorMult", 100);
            Addon7ArmrPntMult = settings.GetUInteger("ADDONWEAPON7", "PedArmorPenetMult", 100);
            Addon7PlyrArmrPntMult = settings.GetUInteger("ADDONWEAPON7", "PlyrArmorPenetMult", 0);

            Addon8HeadMult = settings.GetUInteger("ADDONWEAPON8", "PedHeadMult", 100);
            Addon8PlyrHeadMult = settings.GetUInteger("ADDONWEAPON8", "PlyrHeadMult", 100);
            Addon8BodyMult = settings.GetUInteger("ADDONWEAPON8", "PedBodyMult", 100);
            Addon8PlyrBodyMult = settings.GetUInteger("ADDONWEAPON8", "PlyrBodyMult", 100);
            Addon8LimbMult = settings.GetUInteger("ADDONWEAPON8", "PedLimbMult", 100);
            Addon8PlyrLimbMult = settings.GetUInteger("ADDONWEAPON8", "PlyrLimbMult", 100);
            Addon8HndFtMult = settings.GetUInteger("ADDONWEAPON8", "PedHandsAndFeetMult", 100);
            Addon8PlyrHndFtMult = settings.GetUInteger("ADDONWEAPON8", "PlyrHandsAndFeetMult", 100);
            Addon8ArmorMult = settings.GetUInteger("ADDONWEAPON8", "PedArmorMult", 100);
            Addon8PlyrArmorMult = settings.GetUInteger("ADDONWEAPON8", "PlyrArmorMult", 100);
            Addon8ArmrPntMult = settings.GetUInteger("ADDONWEAPON8", "PedArmorPenetMult", 100);
            Addon8PlyrArmrPntMult = settings.GetUInteger("ADDONWEAPON8", "PlyrArmorPenetMult", 0);

            Addon9HeadMult = settings.GetUInteger("ADDONWEAPON9", "PedHeadMult", 100);
            Addon9PlyrHeadMult = settings.GetUInteger("ADDONWEAPON9", "PlyrHeadMult", 100);
            Addon9BodyMult = settings.GetUInteger("ADDONWEAPON9", "PedBodyMult", 100);
            Addon9PlyrBodyMult = settings.GetUInteger("ADDONWEAPON9", "PlyrBodyMult", 100);
            Addon9LimbMult = settings.GetUInteger("ADDONWEAPON9", "PedLimbMult", 100);
            Addon9PlyrLimbMult = settings.GetUInteger("ADDONWEAPON9", "PlyrLimbMult", 100);
            Addon9HndFtMult = settings.GetUInteger("ADDONWEAPON9", "PedHandsAndFeetMult", 100);
            Addon9PlyrHndFtMult = settings.GetUInteger("ADDONWEAPON9", "PlyrHandsAndFeetMult", 100);
            Addon9ArmorMult = settings.GetUInteger("ADDONWEAPON9", "PedArmorMult", 100);
            Addon9PlyrArmorMult = settings.GetUInteger("ADDONWEAPON9", "PlyrArmorMult", 100);
            Addon9ArmrPntMult = settings.GetUInteger("ADDONWEAPON9", "PedArmorPenetMult", 100);
            Addon9PlyrArmrPntMult = settings.GetUInteger("ADDONWEAPON9", "PlyrArmorPenetMult", 0);

            Addon10HeadMult = settings.GetUInteger("ADDONWEAPON10", "PedHeadMult", 100);
            Addon10PlyrHeadMult = settings.GetUInteger("ADDONWEAPON10", "PlyrHeadMult", 100);
            Addon10BodyMult = settings.GetUInteger("ADDONWEAPON10", "PedBodyMult", 100);
            Addon10PlyrBodyMult = settings.GetUInteger("ADDONWEAPON10", "PlyrBodyMult", 100);
            Addon10LimbMult = settings.GetUInteger("ADDONWEAPON10", "PedLimbMult", 100);
            Addon10PlyrLimbMult = settings.GetUInteger("ADDONWEAPON10", "PlyrLimbMult", 100);
            Addon10HndFtMult = settings.GetUInteger("ADDONWEAPON10", "PedHandsAndFeetMult", 100);
            Addon10PlyrHndFtMult = settings.GetUInteger("ADDONWEAPON10", "PlyrHandsAndFeetMult", 100);
            Addon10ArmorMult = settings.GetUInteger("ADDONWEAPON10", "PedArmorMult", 100);
            Addon10PlyrArmorMult = settings.GetUInteger("ADDONWEAPON10", "PlyrArmorMult", 100);
            Addon10ArmrPntMult = settings.GetUInteger("ADDONWEAPON10", "PedArmorPenetMult", 100);
            Addon10PlyrArmrPntMult = settings.GetUInteger("ADDONWEAPON10", "PlyrArmorPenetMult", 0);

            Addon11HeadMult = settings.GetUInteger("ADDONWEAPON11", "PedHeadMult", 100);
            Addon11PlyrHeadMult = settings.GetUInteger("ADDONWEAPON11", "PlyrHeadMult", 100);
            Addon11BodyMult = settings.GetUInteger("ADDONWEAPON11", "PedBodyMult", 100);
            Addon11PlyrBodyMult = settings.GetUInteger("ADDONWEAPON11", "PlyrBodyMult", 100);
            Addon11LimbMult = settings.GetUInteger("ADDONWEAPON11", "PedLimbMult", 100);
            Addon11PlyrLimbMult = settings.GetUInteger("ADDONWEAPON11", "PlyrLimbMult", 100);
            Addon11HndFtMult = settings.GetUInteger("ADDONWEAPON11", "PedHandsAndFeetMult", 100);
            Addon11PlyrHndFtMult = settings.GetUInteger("ADDONWEAPON11", "PlyrHandsAndFeetMult", 100);
            Addon11ArmorMult = settings.GetUInteger("ADDONWEAPON11", "PedArmorMult", 100);
            Addon11PlyrArmorMult = settings.GetUInteger("ADDONWEAPON11", "PlyrArmorMult", 100);
            Addon11ArmrPntMult = settings.GetUInteger("ADDONWEAPON11", "PedArmorPenetMult", 100);
            Addon11PlyrArmrPntMult = settings.GetUInteger("ADDONWEAPON11", "PlyrArmorPenetMult", 0);

            Addon12HeadMult = settings.GetUInteger("ADDONWEAPON12", "PedHeadMult", 100);
            Addon12PlyrHeadMult = settings.GetUInteger("ADDONWEAPON12", "PlyrHeadMult", 100);
            Addon12BodyMult = settings.GetUInteger("ADDONWEAPON12", "PedBodyMult", 100);
            Addon12PlyrBodyMult = settings.GetUInteger("ADDONWEAPON12", "PlyrBodyMult", 100);
            Addon12LimbMult = settings.GetUInteger("ADDONWEAPON12", "PedLimbMult", 100);
            Addon12PlyrLimbMult = settings.GetUInteger("ADDONWEAPON12", "PlyrLimbMult", 100);
            Addon12HndFtMult = settings.GetUInteger("ADDONWEAPON12", "PedHandsAndFeetMult", 100);
            Addon12PlyrHndFtMult = settings.GetUInteger("ADDONWEAPON12", "PlyrHandsAndFeetMult", 100);
            Addon12ArmorMult = settings.GetUInteger("ADDONWEAPON12", "PedArmorMult", 100);
            Addon12PlyrArmorMult = settings.GetUInteger("ADDONWEAPON12", "PlyrArmorMult", 100);
            Addon12ArmrPntMult = settings.GetUInteger("ADDONWEAPON12", "PedArmorPenetMult", 100);
            Addon12PlyrArmrPntMult = settings.GetUInteger("ADDONWEAPON12", "PlyrArmorPenetMult", 0);

            Addon13HeadMult = settings.GetUInteger("ADDONWEAPON13", "PedHeadMult", 100);
            Addon13PlyrHeadMult = settings.GetUInteger("ADDONWEAPON13", "PlyrHeadMult", 100);
            Addon13BodyMult = settings.GetUInteger("ADDONWEAPON13", "PedBodyMult", 100);
            Addon13PlyrBodyMult = settings.GetUInteger("ADDONWEAPON13", "PlyrBodyMult", 100);
            Addon13LimbMult = settings.GetUInteger("ADDONWEAPON13", "PedLimbMult", 100);
            Addon13PlyrLimbMult = settings.GetUInteger("ADDONWEAPON13", "PlyrLimbMult", 100);
            Addon13HndFtMult = settings.GetUInteger("ADDONWEAPON13", "PedHandsAndFeetMult", 100);
            Addon13PlyrHndFtMult = settings.GetUInteger("ADDONWEAPON13", "PlyrHandsAndFeetMult", 100);
            Addon13ArmorMult = settings.GetUInteger("ADDONWEAPON13", "PedArmorMult", 100);
            Addon13PlyrArmorMult = settings.GetUInteger("ADDONWEAPON13", "PlyrArmorMult", 100);
            Addon13ArmrPntMult = settings.GetUInteger("ADDONWEAPON13", "PedArmorPenetMult", 100);
            Addon13PlyrArmrPntMult = settings.GetUInteger("ADDONWEAPON13", "PlyrArmorPenetMult", 0);

            Addon14HeadMult = settings.GetUInteger("ADDONWEAPON14", "PedHeadMult", 100);
            Addon14PlyrHeadMult = settings.GetUInteger("ADDONWEAPON14", "PlyrHeadMult", 100);
            Addon14BodyMult = settings.GetUInteger("ADDONWEAPON14", "PedBodyMult", 100);
            Addon14PlyrBodyMult = settings.GetUInteger("ADDONWEAPON14", "PlyrBodyMult", 100);
            Addon14LimbMult = settings.GetUInteger("ADDONWEAPON14", "PedLimbMult", 100);
            Addon14PlyrLimbMult = settings.GetUInteger("ADDONWEAPON14", "PlyrLimbMult", 100);
            Addon14HndFtMult = settings.GetUInteger("ADDONWEAPON14", "PedHandsAndFeetMult", 100);
            Addon14PlyrHndFtMult = settings.GetUInteger("ADDONWEAPON14", "PlyrHandsAndFeetMult", 100);
            Addon14ArmorMult = settings.GetUInteger("ADDONWEAPON14", "PedArmorMult", 100);
            Addon14PlyrArmorMult = settings.GetUInteger("ADDONWEAPON14", "PlyrArmorMult", 100);
            Addon14ArmrPntMult = settings.GetUInteger("ADDONWEAPON14", "PedArmorPenetMult", 100);
            Addon14PlyrArmrPntMult = settings.GetUInteger("ADDONWEAPON14", "PlyrArmorPenetMult", 0);

            Addon15HeadMult = settings.GetUInteger("ADDONWEAPON15", "PedHeadMult", 100);
            Addon15PlyrHeadMult = settings.GetUInteger("ADDONWEAPON15", "PlyrHeadMult", 100);
            Addon15BodyMult = settings.GetUInteger("ADDONWEAPON15", "PedBodyMult", 100);
            Addon15PlyrBodyMult = settings.GetUInteger("ADDONWEAPON15", "PlyrBodyMult", 100);
            Addon15LimbMult = settings.GetUInteger("ADDONWEAPON15", "PedLimbMult", 100);
            Addon15PlyrLimbMult = settings.GetUInteger("ADDONWEAPON15", "PlyrLimbMult", 100);
            Addon15HndFtMult = settings.GetUInteger("ADDONWEAPON15", "PedHandsAndFeetMult", 100);
            Addon15PlyrHndFtMult = settings.GetUInteger("ADDONWEAPON15", "PlyrHandsAndFeetMult", 100);
            Addon15ArmorMult = settings.GetUInteger("ADDONWEAPON15", "PedArmorMult", 100);
            Addon15PlyrArmorMult = settings.GetUInteger("ADDONWEAPON15", "PlyrArmorMult", 100);
            Addon15ArmrPntMult = settings.GetUInteger("ADDONWEAPON15", "PedArmorPenetMult", 100);
            Addon15PlyrArmrPntMult = settings.GetUInteger("ADDONWEAPON15", "PlyrArmorPenetMult", 0);

            Addon16HeadMult = settings.GetUInteger("ADDONWEAPON16", "PedHeadMult", 100);
            Addon16PlyrHeadMult = settings.GetUInteger("ADDONWEAPON16", "PlyrHeadMult", 100);
            Addon16BodyMult = settings.GetUInteger("ADDONWEAPON16", "PedBodyMult", 100);
            Addon16PlyrBodyMult = settings.GetUInteger("ADDONWEAPON16", "PlyrBodyMult", 100);
            Addon16LimbMult = settings.GetUInteger("ADDONWEAPON16", "PedLimbMult", 100);
            Addon16PlyrLimbMult = settings.GetUInteger("ADDONWEAPON16", "PlyrLimbMult", 100);
            Addon16HndFtMult = settings.GetUInteger("ADDONWEAPON16", "PedHandsAndFeetMult", 100);
            Addon16PlyrHndFtMult = settings.GetUInteger("ADDONWEAPON16", "PlyrHandsAndFeetMult", 100);
            Addon16ArmorMult = settings.GetUInteger("ADDONWEAPON16", "PedArmorMult", 100);
            Addon16PlyrArmorMult = settings.GetUInteger("ADDONWEAPON16", "PlyrArmorMult", 100);
            Addon16ArmrPntMult = settings.GetUInteger("ADDONWEAPON16", "PedArmorPenetMult", 100);
            Addon16PlyrArmrPntMult = settings.GetUInteger("ADDONWEAPON16", "PlyrArmorPenetMult", 0);

            Addon17HeadMult = settings.GetUInteger("ADDONWEAPON17", "PedHeadMult", 100);
            Addon17PlyrHeadMult = settings.GetUInteger("ADDONWEAPON17", "PlyrHeadMult", 100);
            Addon17BodyMult = settings.GetUInteger("ADDONWEAPON17", "PedBodyMult", 100);
            Addon17PlyrBodyMult = settings.GetUInteger("ADDONWEAPON17", "PlyrBodyMult", 100);
            Addon17LimbMult = settings.GetUInteger("ADDONWEAPON17", "PedLimbMult", 100);
            Addon17PlyrLimbMult = settings.GetUInteger("ADDONWEAPON17", "PlyrLimbMult", 100);
            Addon17HndFtMult = settings.GetUInteger("ADDONWEAPON17", "PedHandsAndFeetMult", 100);
            Addon17PlyrHndFtMult = settings.GetUInteger("ADDONWEAPON17", "PlyrHandsAndFeetMult", 100);
            Addon17ArmorMult = settings.GetUInteger("ADDONWEAPON17", "PedArmorMult", 100);
            Addon17PlyrArmorMult = settings.GetUInteger("ADDONWEAPON17", "PlyrArmorMult", 100);
            Addon17ArmrPntMult = settings.GetUInteger("ADDONWEAPON17", "PedArmorPenetMult", 100);
            Addon17PlyrArmrPntMult = settings.GetUInteger("ADDONWEAPON17", "PlyrArmorPenetMult", 0);

            Addon18HeadMult = settings.GetUInteger("ADDONWEAPON18", "PedHeadMult", 100);
            Addon18PlyrHeadMult = settings.GetUInteger("ADDONWEAPON18", "PlyrHeadMult", 100);
            Addon18BodyMult = settings.GetUInteger("ADDONWEAPON18", "PedBodyMult", 100);
            Addon18PlyrBodyMult = settings.GetUInteger("ADDONWEAPON18", "PlyrBodyMult", 100);
            Addon18LimbMult = settings.GetUInteger("ADDONWEAPON18", "PedLimbMult", 100);
            Addon18PlyrLimbMult = settings.GetUInteger("ADDONWEAPON18", "PlyrLimbMult", 100);
            Addon18HndFtMult = settings.GetUInteger("ADDONWEAPON18", "PedHandsAndFeetMult", 100);
            Addon18PlyrHndFtMult = settings.GetUInteger("ADDONWEAPON18", "PlyrHandsAndFeetMult", 100);
            Addon18ArmorMult = settings.GetUInteger("ADDONWEAPON18", "PedArmorMult", 100);
            Addon18PlyrArmorMult = settings.GetUInteger("ADDONWEAPON18", "PlyrArmorMult", 100);
            Addon18ArmrPntMult = settings.GetUInteger("ADDONWEAPON18", "PedArmorPenetMult", 100);
            Addon18PlyrArmrPntMult = settings.GetUInteger("ADDONWEAPON18", "PlyrArmorPenetMult", 0);

            Addon19HeadMult = settings.GetUInteger("ADDONWEAPON19", "PedHeadMult", 100);
            Addon19PlyrHeadMult = settings.GetUInteger("ADDONWEAPON19", "PlyrHeadMult", 100);
            Addon19BodyMult = settings.GetUInteger("ADDONWEAPON19", "PedBodyMult", 100);
            Addon19PlyrBodyMult = settings.GetUInteger("ADDONWEAPON19", "PlyrBodyMult", 100);
            Addon19LimbMult = settings.GetUInteger("ADDONWEAPON19", "PedLimbMult", 100);
            Addon19PlyrLimbMult = settings.GetUInteger("ADDONWEAPON19", "PlyrLimbMult", 100);
            Addon19HndFtMult = settings.GetUInteger("ADDONWEAPON19", "PedHandsAndFeetMult", 100);
            Addon19PlyrHndFtMult = settings.GetUInteger("ADDONWEAPON19", "PlyrHandsAndFeetMult", 100);
            Addon19ArmorMult = settings.GetUInteger("ADDONWEAPON19", "PedArmorMult", 100);
            Addon19PlyrArmorMult = settings.GetUInteger("ADDONWEAPON19", "PlyrArmorMult", 100);
            Addon19ArmrPntMult = settings.GetUInteger("ADDONWEAPON19", "PedArmorPenetMult", 100);
            Addon19PlyrArmrPntMult = settings.GetUInteger("ADDONWEAPON19", "PlyrArmorPenetMult", 0);

            Addon20HeadMult = settings.GetUInteger("ADDONWEAPON20", "PedHeadMult", 100);
            Addon20PlyrHeadMult = settings.GetUInteger("ADDONWEAPON20", "PlyrHeadMult", 100);
            Addon20BodyMult = settings.GetUInteger("ADDONWEAPON20", "PedBodyMult", 100);
            Addon20PlyrBodyMult = settings.GetUInteger("ADDONWEAPON20", "PlyrBodyMult", 100);
            Addon20LimbMult = settings.GetUInteger("ADDONWEAPON20", "PedLimbMult", 100);
            Addon20PlyrLimbMult = settings.GetUInteger("ADDONWEAPON20", "PlyrLimbMult", 100);
            Addon20HndFtMult = settings.GetUInteger("ADDONWEAPON20", "PedHandsAndFeetMult", 100);
            Addon20PlyrHndFtMult = settings.GetUInteger("ADDONWEAPON20", "PlyrHandsAndFeetMult", 100);
            Addon20ArmorMult = settings.GetUInteger("ADDONWEAPON20", "PedArmorMult", 100);
            Addon20PlyrArmorMult = settings.GetUInteger("ADDONWEAPON20", "PlyrArmorMult", 100);
            Addon20ArmrPntMult = settings.GetUInteger("ADDONWEAPON20", "PedArmorPenetMult", 100);
            Addon20PlyrArmrPntMult = settings.GetUInteger("ADDONWEAPON20", "PlyrArmorPenetMult", 0);
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
            foreach (IVPed myPed in pedList)
            {
                int pedHandle = myPed.GetHandle();

                //IVGame.ShowSubtitleMessage(initHealth.ToString() + "  " +newHealth.ToString());
                //bool hasDamaged = (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 57) && !HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 56) && !HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 54));
                bool hasDamaged = (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 57));

                if (hasDamaged)
                {
                    int weapDmg = 0;

                    uint weapHeadMult = 0;
                    uint weapPlyrHeadMult = 0;

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

                    //IVGame.ShowSubtitleMessage(pedHandle.ToString() + "  " + PlayerHandle.ToString() + "  " + PlayerIndex.ToString());
                    GET_CHAR_HEALTH(pedHandle, out newHealth);
                    GET_CHAR_ARMOUR(pedHandle, out newArmor);
                    GET_CHAR_LAST_DAMAGE_BONE(pedHandle, out Int32 iBone);
                    string boneHit = Values.GetBone(iBone);

                    //IVGame.ShowSubtitleMessage(initHealth.ToString() + "  " + newHealth.ToString() + "  " + initArmor + "  " + newArmor.ToString());
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

                    if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 0))
                        weapDmg = 0;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 1))
                        weapDmg = 1;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 2))
                        weapDmg = 2;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 3))
                        weapDmg = 3;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 4))
                        weapDmg = 4;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 5))
                        weapDmg = 5;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 6))
                        weapDmg = 6;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 7))
                        weapDmg = 7;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 8))
                        weapDmg = 8;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 9))
                        weapDmg = 9;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 10))
                        weapDmg = 10;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 11))
                        weapDmg = 11;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 12))
                        weapDmg = 12;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 13))
                        weapDmg = 13;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 14))
                        weapDmg = 14;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 15))
                        weapDmg = 15;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 16))
                        weapDmg = 16;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 17))
                        weapDmg = 17;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 18))
                        weapDmg = 18;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 19))
                        weapDmg = 19;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 20))
                        weapDmg = 20;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 21))
                        weapDmg = 21;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 22))
                        weapDmg = 22;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 23))
                        weapDmg = 23;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 24))
                        weapDmg = 24;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 25))
                        weapDmg = 25;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 26))
                        weapDmg = 26;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 27))
                        weapDmg = 27;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 28))
                        weapDmg = 28;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 29))
                        weapDmg = 29;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 30))
                        weapDmg = 30;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 31))
                        weapDmg = 31;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 32))
                        weapDmg = 32;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 33))
                        weapDmg = 33;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 34))
                        weapDmg = 34;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 35))
                        weapDmg = 35;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 36))
                        weapDmg = 36;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 37))
                        weapDmg = 37;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 38))
                        weapDmg = 38;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 39))
                        weapDmg = 39;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 40))
                        weapDmg = 40;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 41))
                        weapDmg = 41;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 42))
                        weapDmg = 42;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 43))
                        weapDmg = 43;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 44))
                        weapDmg = 44;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 45))
                        weapDmg = 45;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 46))
                        weapDmg = 46;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 48))
                        weapDmg = 48;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 51))
                        weapDmg = 51;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 58))
                        weapDmg = 58;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 59))
                        weapDmg = 59;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 60))
                        weapDmg = 60;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 61))
                        weapDmg = 61;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 62))
                        weapDmg = 62;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 63))
                        weapDmg = 63;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 64))
                        weapDmg = 64;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 65))
                        weapDmg = 65;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 66))
                        weapDmg = 66;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 67))
                        weapDmg = 67;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 68))
                        weapDmg = 68;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 69))
                        weapDmg = 69;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 70))
                        weapDmg = 70;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 71))
                        weapDmg = 71;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 72))
                        weapDmg = 72;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 73))
                        weapDmg = 73;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 74))
                        weapDmg = 74;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 75))
                        weapDmg = 75;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 76))
                        weapDmg = 76;
                    else if (HAS_CHAR_BEEN_DAMAGED_BY_WEAPON(pedHandle, 77))
                        weapDmg = 77;
                    else
                        weapDmg = 55;

                    switch (weapDmg)
                    {
                        case 1:
                            weapHeadMult = BatHeadMult;
                            weapPlyrHeadMult = BatPlyrHeadMult;

                            weapBodyMult = BatBodyMult;
                            weapPlyrBodyMult = BatPlyrBodyMult;
                            weapArmrMult = BatArmorMult;
                            weapPlyrArmrMult = BatPlyrArmorMult;
                            weapArmrPntMult = BatArmrPntMult;
                            weapPlyrArmrPntMult = BatPlyrArmrPntMult;

                            weapLimbMult = BatLimbMult;
                            weapPlyrLimbMult = BatPlyrLimbMult;
                            weapHandMult = BatHndFtMult;
                            weapPlyrHandMult = BatPlyrHndFtMult;
                            break;
                        case 2:
                            weapHeadMult = PoolcueHeadMult;
                            weapPlyrHeadMult = PoolcuePlyrHeadMult;

                            weapBodyMult = PoolcueBodyMult;
                            weapPlyrBodyMult = PoolcuePlyrBodyMult;
                            weapArmrMult = PoolcueArmorMult;
                            weapPlyrArmrMult = PoolcuePlyrArmorMult;
                            weapArmrPntMult = PoolcueArmrPntMult;
                            weapPlyrArmrPntMult = PoolcuePlyrArmrPntMult;

                            weapLimbMult = PoolcueLimbMult;
                            weapPlyrLimbMult = PoolcuePlyrLimbMult;
                            weapHandMult = PoolcueHndFtMult;
                            weapPlyrHandMult = PoolcuePlyrHndFtMult;
                            break;
                        case 3:
                            weapHeadMult = KnifeHeadMult;
                            weapPlyrHeadMult = KnifePlyrHeadMult;

                            weapBodyMult = KnifeBodyMult;
                            weapPlyrBodyMult = KnifePlyrBodyMult;
                            weapArmrMult = KnifeArmorMult;
                            weapPlyrArmrMult = KnifePlyrArmorMult;
                            weapArmrPntMult = KnifeArmrPntMult;
                            weapPlyrArmrPntMult = KnifePlyrArmrPntMult;

                            weapLimbMult = KnifeLimbMult;
                            weapPlyrLimbMult = KnifePlyrLimbMult;
                            weapHandMult = KnifeHndFtMult;
                            weapPlyrHandMult = KnifePlyrHndFtMult;
                            break;
                        case 4:
                            weapHeadMult = GrenadeHeadMult;
                            weapPlyrHeadMult = GrenadePlyrHeadMult;

                            weapBodyMult = GrenadeBodyMult;
                            weapPlyrBodyMult = GrenadePlyrBodyMult;
                            weapArmrMult = GrenadeArmorMult;
                            weapPlyrArmrMult = GrenadePlyrArmorMult;
                            weapArmrPntMult = GrenadeArmrPntMult;
                            weapPlyrArmrPntMult = GrenadePlyrArmrPntMult;

                            weapLimbMult = GrenadeLimbMult;
                            weapPlyrLimbMult = GrenadePlyrLimbMult;
                            weapHandMult = GrenadeHndFtMult;
                            weapPlyrHandMult = GrenadePlyrHndFtMult;
                            break;
                        case 5:
                            weapHeadMult = MolotovHeadMult;
                            weapPlyrHeadMult = MolotovPlyrHeadMult;

                            weapBodyMult = MolotovBodyMult;
                            weapPlyrBodyMult = MolotovPlyrBodyMult;
                            weapArmrMult = MolotovArmorMult;
                            weapPlyrArmrMult = MolotovPlyrArmorMult;
                            weapArmrPntMult = MolotovArmrPntMult;
                            weapPlyrArmrPntMult = MolotovPlyrArmrPntMult;

                            weapLimbMult = MolotovLimbMult;
                            weapPlyrLimbMult = MolotovPlyrLimbMult;
                            weapHandMult = MolotovHndFtMult;
                            weapPlyrHandMult = MolotovPlyrHndFtMult;
                            break;
                        case 6:
                            weapHeadMult = RocketHeadMult;
                            weapPlyrHeadMult = RocketPlyrHeadMult;

                            weapBodyMult = RocketBodyMult;
                            weapPlyrBodyMult = RocketPlyrBodyMult;
                            weapArmrMult = RocketArmorMult;
                            weapPlyrArmrMult = RocketPlyrArmorMult;
                            weapArmrPntMult = RocketArmrPntMult;
                            weapPlyrArmrPntMult = RocketPlyrArmrPntMult;

                            weapLimbMult = RocketLimbMult;
                            weapPlyrLimbMult = RocketPlyrLimbMult;
                            weapHandMult = RocketHndFtMult;
                            weapPlyrHandMult = RocketPlyrHndFtMult;
                            break;
                        case 7:
                            weapHeadMult = PistolHeadMult;
                            weapPlyrHeadMult = PistolPlyrHeadMult;

                            weapBodyMult = PistolBodyMult;
                            weapPlyrBodyMult = PistolPlyrBodyMult;
                            weapArmrMult = PistolArmorMult;
                            weapPlyrArmrMult = PistolPlyrArmorMult;
                            weapArmrPntMult = PistolArmrPntMult;
                            weapPlyrArmrPntMult = PistolPlyrArmrPntMult;

                            weapLimbMult = PistolLimbMult;
                            weapPlyrLimbMult = PistolPlyrLimbMult;
                            weapHandMult = PistolHndFtMult;
                            weapPlyrHandMult = PistolPlyrHndFtMult;
                            break;
                        case 8:
                            weapHeadMult = SilencedHeadMult;
                            weapPlyrHeadMult = SilencedPlyrHeadMult;

                            weapBodyMult = SilencedBodyMult;
                            weapPlyrBodyMult = SilencedPlyrBodyMult;
                            weapArmrMult = SilencedArmorMult;
                            weapPlyrArmrMult = SilencedPlyrArmorMult;
                            weapArmrPntMult = SilencedArmrPntMult;
                            weapPlyrArmrPntMult = SilencedPlyrArmrPntMult;

                            weapLimbMult = SilencedLimbMult;
                            weapPlyrLimbMult = SilencedPlyrLimbMult;
                            weapHandMult = SilencedHndFtMult;
                            weapPlyrHandMult = SilencedPlyrHndFtMult;
                            break;
                        case 9:
                            weapHeadMult = DeagleHeadMult;
                            weapPlyrHeadMult = DeaglePlyrHeadMult;

                            weapBodyMult = DeagleBodyMult;
                            weapPlyrBodyMult = DeaglePlyrBodyMult;
                            weapArmrMult = DeagleArmorMult;
                            weapPlyrArmrMult = DeaglePlyrArmorMult;
                            weapArmrPntMult = DeagleArmrPntMult;
                            weapPlyrArmrPntMult = DeaglePlyrArmrPntMult;

                            weapLimbMult = DeagleLimbMult;
                            weapPlyrLimbMult = DeaglePlyrLimbMult;
                            weapHandMult = DeagleHndFtMult;
                            weapPlyrHandMult = DeaglePlyrHndFtMult;
                            break;
                        case 10:
                            weapHeadMult = PumpShotHeadMult;
                            weapPlyrHeadMult = PumpShotPlyrHeadMult;

                            weapBodyMult = PumpShotBodyMult;
                            weapPlyrBodyMult = PumpShotPlyrBodyMult;
                            weapArmrMult = PumpShotArmorMult;
                            weapPlyrArmrMult = PumpShotPlyrArmorMult;
                            weapArmrPntMult = PumpShotArmrPntMult;
                            weapPlyrArmrPntMult = PumpShotPlyrArmrPntMult;

                            weapLimbMult = PumpShotLimbMult;
                            weapPlyrLimbMult = PumpShotPlyrLimbMult;
                            weapHandMult = PumpShotHndFtMult;
                            weapPlyrHandMult = PumpShotPlyrHndFtMult;
                            break;
                        case 11:
                            weapHeadMult = CombatShotHeadMult;
                            weapPlyrHeadMult = CombatShotPlyrHeadMult;

                            weapBodyMult = CombatShotBodyMult;
                            weapPlyrBodyMult = CombatShotPlyrBodyMult;
                            weapArmrMult = CombatShotArmorMult;
                            weapPlyrArmrMult = CombatShotPlyrArmorMult;
                            weapArmrPntMult = CombatShotArmrPntMult;
                            weapPlyrArmrPntMult = CombatShotPlyrArmrPntMult;

                            weapLimbMult = CombatShotLimbMult;
                            weapPlyrLimbMult = CombatShotPlyrLimbMult;
                            weapHandMult = CombatShotHndFtMult;
                            weapPlyrHandMult = CombatShotPlyrHndFtMult;
                            break;
                        case 12:
                            weapHeadMult = UziHeadMult;
                            weapPlyrHeadMult = UziPlyrHeadMult;

                            weapBodyMult = UziBodyMult;
                            weapPlyrBodyMult = UziPlyrBodyMult;
                            weapArmrMult = UziArmorMult;
                            weapPlyrArmrMult = UziPlyrArmorMult;
                            weapArmrPntMult = UziArmrPntMult;
                            weapPlyrArmrPntMult = UziPlyrArmrPntMult;

                            weapLimbMult = UziLimbMult;
                            weapPlyrLimbMult = UziPlyrLimbMult;
                            weapHandMult = UziHndFtMult;
                            weapPlyrHandMult = UziPlyrHndFtMult;
                            break;
                        case 13:
                            weapHeadMult = MP5HeadMult;
                            weapPlyrHeadMult = MP5PlyrHeadMult;

                            weapBodyMult = MP5BodyMult;
                            weapPlyrBodyMult = MP5PlyrBodyMult;
                            weapArmrMult = MP5ArmorMult;
                            weapPlyrArmrMult = MP5PlyrArmorMult;
                            weapArmrPntMult = MP5ArmrPntMult;
                            weapPlyrArmrPntMult = MP5PlyrArmrPntMult;

                            weapLimbMult = MP5LimbMult;
                            weapPlyrLimbMult = MP5PlyrLimbMult;
                            weapHandMult = MP5HndFtMult;
                            weapPlyrHandMult = MP5PlyrHndFtMult;
                            break;
                        case 14:
                            weapHeadMult = Ak47HeadMult;
                            weapPlyrHeadMult = Ak47PlyrHeadMult;

                            weapBodyMult = Ak47BodyMult;
                            weapPlyrBodyMult = Ak47PlyrBodyMult;
                            weapArmrMult = Ak47ArmorMult;
                            weapPlyrArmrMult = Ak47PlyrArmorMult;
                            weapArmrPntMult = Ak47ArmrPntMult;
                            weapPlyrArmrPntMult = Ak47PlyrArmrPntMult;

                            weapLimbMult = Ak47LimbMult;
                            weapPlyrLimbMult = Ak47PlyrLimbMult;
                            weapHandMult = Ak47HndFtMult;
                            weapPlyrHandMult = Ak47PlyrHndFtMult;
                            break;
                        case 15:
                            weapHeadMult = M4HeadMult;
                            weapPlyrHeadMult = M4PlyrHeadMult;

                            weapBodyMult = M4BodyMult;
                            weapPlyrBodyMult = M4PlyrBodyMult;
                            weapArmrMult = M4ArmorMult;
                            weapPlyrArmrMult = M4PlyrArmorMult;
                            weapArmrPntMult = M4ArmrPntMult;
                            weapPlyrArmrPntMult = M4PlyrArmrPntMult;

                            weapLimbMult = M4LimbMult;
                            weapPlyrLimbMult = M4PlyrLimbMult;
                            weapHandMult = M4HndFtMult;
                            weapPlyrHandMult = M4PlyrHndFtMult;
                            break;
                        case 16:
                            weapHeadMult = PsgHeadMult;
                            weapPlyrHeadMult = PsgPlyrHeadMult;

                            weapBodyMult = PsgBodyMult;
                            weapPlyrBodyMult = PsgPlyrBodyMult;
                            weapArmrMult = PsgArmorMult;
                            weapPlyrArmrMult = PsgPlyrArmorMult;
                            weapArmrPntMult = PsgArmrPntMult;
                            weapPlyrArmrPntMult = PsgPlyrArmrPntMult;

                            weapLimbMult = PsgLimbMult;
                            weapPlyrLimbMult = PsgPlyrLimbMult;
                            weapHandMult = PsgHndFtMult;
                            weapPlyrHandMult = PsgPlyrHndFtMult;
                            break;
                        case 17:
                            weapHeadMult = M40HeadMult;
                            weapPlyrHeadMult = M40PlyrHeadMult;

                            weapBodyMult = M40BodyMult;
                            weapPlyrBodyMult = M40PlyrBodyMult;
                            weapArmrMult = M40ArmorMult;
                            weapPlyrArmrMult = M40PlyrArmorMult;
                            weapArmrPntMult = M40ArmrPntMult;
                            weapPlyrArmrPntMult = M40PlyrArmrPntMult;

                            weapLimbMult = M40LimbMult;
                            weapPlyrLimbMult = M40PlyrLimbMult;
                            weapHandMult = M40HndFtMult;
                            weapPlyrHandMult = M40PlyrHndFtMult;
                            break;
                        case 18:
                            weapHeadMult = RLauncherHeadMult;
                            weapPlyrHeadMult = RLauncherPlyrHeadMult;

                            weapBodyMult = RLauncherBodyMult;
                            weapPlyrBodyMult = RLauncherPlyrBodyMult;
                            weapArmrMult = RLauncherArmorMult;
                            weapPlyrArmrMult = RLauncherPlyrArmorMult;
                            weapArmrPntMult = RLauncherArmrPntMult;
                            weapPlyrArmrPntMult = RLauncherPlyrArmrPntMult;

                            weapLimbMult = RLauncherLimbMult;
                            weapPlyrLimbMult = RLauncherPlyrLimbMult;
                            weapHandMult = RLauncherHndFtMult;
                            weapPlyrHandMult = RLauncherPlyrHndFtMult;
                            break;
                        case 19:
                            weapHeadMult = FThrowerHeadMult;
                            weapPlyrHeadMult = FThrowerPlyrHeadMult;

                            weapBodyMult = FThrowerBodyMult;
                            weapPlyrBodyMult = FThrowerPlyrBodyMult;
                            weapArmrMult = FThrowerArmorMult;
                            weapPlyrArmrMult = FThrowerPlyrArmorMult;
                            weapArmrPntMult = FThrowerArmrPntMult;
                            weapPlyrArmrPntMult = FThrowerPlyrArmrPntMult;

                            weapLimbMult = FThrowerLimbMult;
                            weapPlyrLimbMult = FThrowerPlyrLimbMult;
                            weapHandMult = FThrowerHndFtMult;
                            weapPlyrHandMult = FThrowerPlyrHndFtMult;
                            break;
                        case 20:
                            weapHeadMult = MinigunHeadMult;
                            weapPlyrHeadMult = MinigunPlyrHeadMult;

                            weapBodyMult = MinigunBodyMult;
                            weapPlyrBodyMult = MinigunPlyrBodyMult;
                            weapArmrMult = MinigunArmorMult;
                            weapPlyrArmrMult = MinigunPlyrArmorMult;
                            weapArmrPntMult = MinigunArmrPntMult;
                            weapPlyrArmrPntMult = MinigunPlyrArmrPntMult;

                            weapLimbMult = MinigunLimbMult;
                            weapPlyrLimbMult = MinigunPlyrLimbMult;
                            weapHandMult = MinigunHndFtMult;
                            weapPlyrHandMult = MinigunPlyrHndFtMult;
                            break;
                        case 21:
                            weapHeadMult = GLauncherHeadMult;
                            weapPlyrHeadMult = GLauncherPlyrHeadMult;

                            weapBodyMult = GLauncherBodyMult;
                            weapPlyrBodyMult = GLauncherPlyrBodyMult;
                            weapArmrMult = GLauncherArmorMult;
                            weapPlyrArmrMult = GLauncherPlyrArmorMult;
                            weapArmrPntMult = GLauncherArmrPntMult;
                            weapPlyrArmrPntMult = GLauncherPlyrArmrPntMult;

                            weapLimbMult = GLauncherLimbMult;
                            weapPlyrLimbMult = GLauncherPlyrLimbMult;
                            weapHandMult = GLauncherHndFtMult;
                            weapPlyrHandMult = GLauncherPlyrHndFtMult;
                            break;
                        case 22:
                            weapHeadMult = ArmselHeadMult;
                            weapPlyrHeadMult = ArmselPlyrHeadMult;

                            weapBodyMult = ArmselBodyMult;
                            weapPlyrBodyMult = ArmselPlyrBodyMult;
                            weapArmrMult = ArmselArmorMult;
                            weapPlyrArmrMult = ArmselPlyrArmorMult;
                            weapArmrPntMult = ArmselArmrPntMult;
                            weapPlyrArmrPntMult = ArmselPlyrArmrPntMult;

                            weapLimbMult = ArmselLimbMult;
                            weapPlyrLimbMult = ArmselPlyrLimbMult;
                            weapHandMult = ArmselHndFtMult;
                            weapPlyrHandMult = ArmselPlyrHndFtMult;
                            break;
                        case 23:
                            weapHeadMult = Episodic3HeadMult;
                            weapPlyrHeadMult = Episodic3PlyrHeadMult;

                            weapBodyMult = Episodic3BodyMult;
                            weapPlyrBodyMult = Episodic3PlyrBodyMult;
                            weapArmrMult = Episodic3ArmorMult;
                            weapPlyrArmrMult = Episodic3PlyrArmorMult;
                            weapArmrPntMult = Episodic3ArmrPntMult;
                            weapPlyrArmrPntMult = Episodic3PlyrArmrPntMult;

                            weapLimbMult = Episodic3LimbMult;
                            weapPlyrLimbMult = Episodic3PlyrLimbMult;
                            weapHandMult = Episodic3HndFtMult;
                            weapPlyrHandMult = Episodic3PlyrHndFtMult;
                            break;
                        case 24:
                            weapHeadMult = BrokenCueHeadMult;
                            weapPlyrHeadMult = BrokenCuePlyrHeadMult;

                            weapBodyMult = BrokenCueBodyMult;
                            weapPlyrBodyMult = BrokenCuePlyrBodyMult;
                            weapArmrMult = BrokenCueArmorMult;
                            weapPlyrArmrMult = BrokenCuePlyrArmorMult;
                            weapArmrPntMult = BrokenCueArmrPntMult;
                            weapPlyrArmrPntMult = BrokenCuePlyrArmrPntMult;

                            weapLimbMult = BrokenCueLimbMult;
                            weapPlyrLimbMult = BrokenCuePlyrLimbMult;
                            weapHandMult = BrokenCueHndFtMult;
                            weapPlyrHandMult = BrokenCuePlyrHndFtMult;
                            break;
                        case 25:
                            weapHeadMult = GLaunGrndHeadMult;
                            weapPlyrHeadMult = GLaunGrndPlyrHeadMult;

                            weapBodyMult = GLaunGrndBodyMult;
                            weapPlyrBodyMult = GLaunGrndPlyrBodyMult;
                            weapArmrMult = GLaunGrndArmorMult;
                            weapPlyrArmrMult = GLaunGrndPlyrArmorMult;
                            weapArmrPntMult = GLaunGrndArmrPntMult;
                            weapPlyrArmrPntMult = GLaunGrndPlyrArmrPntMult;

                            weapLimbMult = GLaunGrndLimbMult;
                            weapPlyrLimbMult = GLaunGrndPlyrLimbMult;
                            weapHandMult = GLaunGrndHndFtMult;
                            weapPlyrHandMult = GLaunGrndPlyrHndFtMult;
                            break;
                        case 26:
                            weapHeadMult = SawnOffHeadMult;
                            weapPlyrHeadMult = SawnOffPlyrHeadMult;

                            weapBodyMult = SawnOffBodyMult;
                            weapPlyrBodyMult = SawnOffPlyrBodyMult;
                            weapArmrMult = SawnOffArmorMult;
                            weapPlyrArmrMult = SawnOffPlyrArmorMult;
                            weapArmrPntMult = SawnOffArmrPntMult;
                            weapPlyrArmrPntMult = SawnOffPlyrArmrPntMult;

                            weapLimbMult = SawnOffLimbMult;
                            weapPlyrLimbMult = SawnOffPlyrLimbMult;
                            weapHandMult = SawnOffHndFtMult;
                            weapPlyrHandMult = SawnOffPlyrHndFtMult;
                            break;
                        case 27:
                            weapHeadMult = AutoPistHeadMult;
                            weapPlyrHeadMult = AutoPistPlyrHeadMult;

                            weapBodyMult = AutoPistBodyMult;
                            weapPlyrBodyMult = AutoPistPlyrBodyMult;
                            weapArmrMult = AutoPistArmorMult;
                            weapPlyrArmrMult = AutoPistPlyrArmorMult;
                            weapArmrPntMult = AutoPistArmrPntMult;
                            weapPlyrArmrPntMult = AutoPistPlyrArmrPntMult;

                            weapLimbMult = AutoPistLimbMult;
                            weapPlyrLimbMult = AutoPistPlyrLimbMult;
                            weapHandMult = AutoPistHndFtMult;
                            weapPlyrHandMult = AutoPistPlyrHndFtMult;
                            break;
                        case 28:
                            weapHeadMult = PipeBombHeadMult;
                            weapPlyrHeadMult = PipeBombPlyrHeadMult;

                            weapBodyMult = PipeBombBodyMult;
                            weapPlyrBodyMult = PipeBombPlyrBodyMult;
                            weapArmrMult = PipeBombArmorMult;
                            weapPlyrArmrMult = PipeBombPlyrArmorMult;
                            weapArmrPntMult = PipeBombArmrPntMult;
                            weapPlyrArmrPntMult = PipeBombPlyrArmrPntMult;

                            weapLimbMult = PipeBombLimbMult;
                            weapPlyrLimbMult = PipeBombPlyrLimbMult;
                            weapHandMult = PipeBombHndFtMult;
                            weapPlyrHandMult = PipeBombPlyrHndFtMult;
                            break;
                        case 29:
                            weapHeadMult = AutoMagHeadMult;
                            weapPlyrHeadMult = AutoMagPlyrHeadMult;

                            weapBodyMult = AutoMagBodyMult;
                            weapPlyrBodyMult = AutoMagPlyrBodyMult;
                            weapArmrMult = AutoMagArmorMult;
                            weapPlyrArmrMult = AutoMagPlyrArmorMult;
                            weapArmrPntMult = AutoMagArmrPntMult;
                            weapPlyrArmrPntMult = AutoMagPlyrArmrPntMult;

                            weapLimbMult = AutoMagLimbMult;
                            weapPlyrLimbMult = AutoMagPlyrLimbMult;
                            weapHandMult = AutoMagHndFtMult;
                            weapPlyrHandMult = AutoMagPlyrHndFtMult;
                            break;
                        case 30:
                            weapHeadMult = AA12ExpHeadMult;
                            weapPlyrHeadMult = AA12ExpPlyrHeadMult;

                            weapBodyMult = AA12ExpBodyMult;
                            weapPlyrBodyMult = AA12ExpPlyrBodyMult;
                            weapArmrMult = AA12ExpArmorMult;
                            weapPlyrArmrMult = AA12ExpPlyrArmorMult;
                            weapArmrPntMult = AA12ExpArmrPntMult;
                            weapPlyrArmrPntMult = AA12ExpPlyrArmrPntMult;

                            weapLimbMult = AA12ExpLimbMult;
                            weapPlyrLimbMult = AA12ExpPlyrLimbMult;
                            weapHandMult = AA12ExpHndFtMult;
                            weapPlyrHandMult = AA12ExpPlyrHndFtMult;
                            break;
                        case 31:
                            weapHeadMult = AA12HeadMult;
                            weapPlyrHeadMult = AA12PlyrHeadMult;

                            weapBodyMult = AA12BodyMult;
                            weapPlyrBodyMult = AA12PlyrBodyMult;
                            weapArmrMult = AA12ArmorMult;
                            weapPlyrArmrMult = AA12PlyrArmorMult;
                            weapArmrPntMult = AA12ArmrPntMult;
                            weapPlyrArmrPntMult = AA12PlyrArmrPntMult;

                            weapLimbMult = AA12LimbMult;
                            weapPlyrLimbMult = AA12PlyrLimbMult;
                            weapHandMult = AA12HndFtMult;
                            weapPlyrHandMult = AA12PlyrHndFtMult;
                            break;
                        case 32:
                            weapHeadMult = P90HeadMult;
                            weapPlyrHeadMult = P90PlyrHeadMult;

                            weapBodyMult = P90BodyMult;
                            weapPlyrBodyMult = P90PlyrBodyMult;
                            weapArmrMult = P90ArmorMult;
                            weapPlyrArmrMult = P90PlyrArmorMult;
                            weapArmrPntMult = P90ArmrPntMult;
                            weapPlyrArmrPntMult = P90PlyrArmrPntMult;

                            weapLimbMult = P90LimbMult;
                            weapPlyrLimbMult = P90PlyrLimbMult;
                            weapHandMult = P90HndFtMult;
                            weapPlyrHandMult = P90PlyrHndFtMult;
                            break;
                        case 33:
                            weapHeadMult = GoldUziHeadMult;
                            weapPlyrHeadMult = GoldUziPlyrHeadMult;

                            weapBodyMult = GoldUziBodyMult;
                            weapPlyrBodyMult = GoldUziPlyrBodyMult;
                            weapArmrMult = GoldUziArmorMult;
                            weapPlyrArmrMult = GoldUziPlyrArmorMult;
                            weapArmrPntMult = GoldUziArmrPntMult;
                            weapPlyrArmrPntMult = GoldUziPlyrArmrPntMult;

                            weapLimbMult = GoldUziLimbMult;
                            weapPlyrLimbMult = GoldUziPlyrLimbMult;
                            weapHandMult = GoldUziHndFtMult;
                            weapPlyrHandMult = GoldUziPlyrHndFtMult;
                            break;
                        case 34:
                            weapHeadMult = M249HeadMult;
                            weapPlyrHeadMult = M249PlyrHeadMult;

                            weapBodyMult = M249BodyMult;
                            weapPlyrBodyMult = M249PlyrBodyMult;
                            weapArmrMult = M249ArmorMult;
                            weapPlyrArmrMult = M249PlyrArmorMult;
                            weapArmrPntMult = M249ArmrPntMult;
                            weapPlyrArmrPntMult = M249PlyrArmrPntMult;

                            weapLimbMult = M249LimbMult;
                            weapPlyrLimbMult = M249PlyrLimbMult;
                            weapHandMult = M249HndFtMult;
                            weapPlyrHandMult = M249PlyrHndFtMult;
                            break;
                        case 35:
                            weapHeadMult = DsrHeadMult;
                            weapPlyrHeadMult = DsrPlyrHeadMult;

                            weapBodyMult = DsrBodyMult;
                            weapPlyrBodyMult = DsrPlyrBodyMult;
                            weapArmrMult = DsrArmorMult;
                            weapPlyrArmrMult = DsrPlyrArmorMult;
                            weapArmrPntMult = DsrArmrPntMult;
                            weapPlyrArmrPntMult = DsrPlyrArmrPntMult;

                            weapLimbMult = DsrLimbMult;
                            weapPlyrLimbMult = DsrPlyrLimbMult;
                            weapHandMult = DsrHndFtMult;
                            weapPlyrHandMult = DsrPlyrHndFtMult;
                            break;
                        case 36:
                            weapHeadMult = StickyBombHeadMult;
                            weapPlyrHeadMult = StickyBombPlyrHeadMult;

                            weapBodyMult = StickyBombBodyMult;
                            weapPlyrBodyMult = StickyBombPlyrBodyMult;
                            weapArmrMult = StickyBombArmorMult;
                            weapPlyrArmrMult = StickyBombPlyrArmorMult;
                            weapArmrPntMult = StickyBombArmrPntMult;
                            weapPlyrArmrPntMult = StickyBombPlyrArmrPntMult;

                            weapLimbMult = StickyBombLimbMult;
                            weapPlyrLimbMult = StickyBombPlyrLimbMult;
                            weapHandMult = StickyBombHndFtMult;
                            weapPlyrHandMult = StickyBombPlyrHndFtMult;
                            break;
                        case 37:
                            weapHeadMult = BuzzardRLHeadMult;
                            weapPlyrHeadMult = BuzzardRLPlyrHeadMult;

                            weapBodyMult = BuzzardRLBodyMult;
                            weapPlyrBodyMult = BuzzardRLPlyrBodyMult;
                            weapArmrMult = BuzzardRLArmorMult;
                            weapPlyrArmrMult = BuzzardRLPlyrArmorMult;
                            weapArmrPntMult = BuzzardRLArmrPntMult;
                            weapPlyrArmrPntMult = BuzzardRLPlyrArmrPntMult;

                            weapLimbMult = BuzzardRLLimbMult;
                            weapPlyrLimbMult = BuzzardRLPlyrLimbMult;
                            weapHandMult = BuzzardRLHndFtMult;
                            weapPlyrHandMult = BuzzardRLPlyrHndFtMult;
                            break;
                        case 38:
                            weapHeadMult = BuzzardRHeadMult;
                            weapPlyrHeadMult = BuzzardRPlyrHeadMult;

                            weapBodyMult = BuzzardRBodyMult;
                            weapPlyrBodyMult = BuzzardRPlyrBodyMult;
                            weapArmrMult = BuzzardRArmorMult;
                            weapPlyrArmrMult = BuzzardRPlyrArmorMult;
                            weapArmrPntMult = BuzzardRArmrPntMult;
                            weapPlyrArmrPntMult = BuzzardRPlyrArmrPntMult;

                            weapLimbMult = BuzzardRLimbMult;
                            weapPlyrLimbMult = BuzzardRPlyrLimbMult;
                            weapHandMult = BuzzardRHndFtMult;
                            weapPlyrHandMult = BuzzardRPlyrHndFtMult;
                            break;
                        case 39:
                            weapHeadMult = BuzzardGHeadMult;
                            weapPlyrHeadMult = BuzzardGPlyrHeadMult;

                            weapBodyMult = BuzzardGBodyMult;
                            weapPlyrBodyMult = BuzzardGPlyrBodyMult;
                            weapArmrMult = BuzzardGArmorMult;
                            weapPlyrArmrMult = BuzzardGPlyrArmorMult;
                            weapArmrPntMult = BuzzardGArmrPntMult;
                            weapPlyrArmrPntMult = BuzzardGPlyrArmrPntMult;

                            weapLimbMult = BuzzardGLimbMult;
                            weapPlyrLimbMult = BuzzardGPlyrLimbMult;
                            weapHandMult = BuzzardGHndFtMult;
                            weapPlyrHandMult = BuzzardGPlyrHndFtMult;
                            break;
                        case 40:
                            weapHeadMult = APCHeadMult;
                            weapPlyrHeadMult = APCPlyrHeadMult;

                            weapBodyMult = APCBodyMult;
                            weapPlyrBodyMult = APCPlyrBodyMult;
                            weapArmrMult = APCArmorMult;
                            weapPlyrArmrMult = APCPlyrArmorMult;
                            weapArmrPntMult = APCArmrPntMult;
                            weapPlyrArmrPntMult = APCPlyrArmrPntMult;

                            weapLimbMult = APCLimbMult;
                            weapPlyrLimbMult = APCPlyrLimbMult;
                            weapHandMult = APCHndFtMult;
                            weapPlyrHandMult = APCPlyrHndFtMult;
                            break;
                        case 41:
                            weapHeadMult = ParachuteHeadMult;
                            weapPlyrHeadMult = ParachutePlyrHeadMult;

                            weapBodyMult = ParachuteBodyMult;
                            weapPlyrBodyMult = ParachutePlyrBodyMult;
                            weapArmrMult = ParachuteArmorMult;
                            weapPlyrArmrMult = ParachutePlyrArmorMult;
                            weapArmrPntMult = ParachuteArmrPntMult;
                            weapPlyrArmrPntMult = ParachutePlyrArmrPntMult;

                            weapLimbMult = ParachuteLimbMult;
                            weapPlyrLimbMult = ParachutePlyrLimbMult;
                            weapHandMult = ParachuteHndFtMult;
                            weapPlyrHandMult = ParachutePlyrHndFtMult;
                            break;
                        case 42:
                            weapHeadMult = Episodic22HeadMult;
                            weapPlyrHeadMult = Episodic22PlyrHeadMult;

                            weapBodyMult = Episodic22BodyMult;
                            weapPlyrBodyMult = Episodic22PlyrBodyMult;
                            weapArmrMult = Episodic22ArmorMult;
                            weapPlyrArmrMult = Episodic22PlyrArmorMult;
                            weapArmrPntMult = Episodic22ArmrPntMult;
                            weapPlyrArmrPntMult = Episodic22PlyrArmrPntMult;

                            weapLimbMult = Episodic22LimbMult;
                            weapPlyrLimbMult = Episodic22PlyrLimbMult;
                            weapHandMult = Episodic22HndFtMult;
                            weapPlyrHandMult = Episodic22PlyrHndFtMult;
                            break;
                        case 43:
                            weapHeadMult = Episodic23HeadMult;
                            weapPlyrHeadMult = Episodic23PlyrHeadMult;

                            weapBodyMult = Episodic23BodyMult;
                            weapPlyrBodyMult = Episodic23PlyrBodyMult;
                            weapArmrMult = Episodic23ArmorMult;
                            weapPlyrArmrMult = Episodic23PlyrArmorMult;
                            weapArmrPntMult = Episodic23ArmrPntMult;
                            weapPlyrArmrPntMult = Episodic23PlyrArmrPntMult;

                            weapLimbMult = Episodic23LimbMult;
                            weapPlyrLimbMult = Episodic23PlyrLimbMult;
                            weapHandMult = Episodic23HndFtMult;
                            weapPlyrHandMult = Episodic23PlyrHndFtMult;
                            break;
                        case 44:
                            weapHeadMult = Episodic24HeadMult;
                            weapPlyrHeadMult = Episodic24PlyrHeadMult;

                            weapBodyMult = Episodic24BodyMult;
                            weapPlyrBodyMult = Episodic24PlyrBodyMult;
                            weapArmrMult = Episodic24ArmorMult;
                            weapPlyrArmrMult = Episodic24PlyrArmorMult;
                            weapArmrPntMult = Episodic24ArmrPntMult;
                            weapPlyrArmrPntMult = Episodic24PlyrArmrPntMult;

                            weapLimbMult = Episodic24LimbMult;
                            weapPlyrLimbMult = Episodic24PlyrLimbMult;
                            weapHandMult = Episodic24HndFtMult;
                            weapPlyrHandMult = Episodic24PlyrHndFtMult;
                            break;
                        case 45:
                            weapHeadMult = CameraHeadMult;
                            weapPlyrHeadMult = CameraPlyrHeadMult;

                            weapBodyMult = CameraBodyMult;
                            weapPlyrBodyMult = CameraPlyrBodyMult;
                            weapArmrMult = CameraArmorMult;
                            weapPlyrArmrMult = CameraPlyrArmorMult;
                            weapArmrPntMult = CameraArmrPntMult;
                            weapPlyrArmrPntMult = CameraPlyrArmrPntMult;

                            weapLimbMult = CameraLimbMult;
                            weapPlyrLimbMult = CameraPlyrLimbMult;
                            weapHandMult = CameraHndFtMult;
                            weapPlyrHandMult = CameraPlyrHndFtMult;
                            break;
                        case 46:
                            weapHeadMult = ObjectHeadMult;
                            weapPlyrHeadMult = ObjectPlyrHeadMult;

                            weapBodyMult = ObjectBodyMult;
                            weapPlyrBodyMult = ObjectPlyrBodyMult;
                            weapArmrMult = ObjectArmorMult;
                            weapPlyrArmrMult = ObjectPlyrArmorMult;
                            weapArmrPntMult = ObjectArmrPntMult;
                            weapPlyrArmrPntMult = ObjectPlyrArmrPntMult;

                            weapLimbMult = ObjectLimbMult;
                            weapPlyrLimbMult = ObjectPlyrLimbMult;
                            weapHandMult = ObjectHndFtMult;
                            weapPlyrHandMult = ObjectPlyrHndFtMult;
                            break;
                        case 48:
                            weapHeadMult = ArmorHeadMult;
                            weapPlyrHeadMult = ArmorPlyrHeadMult;

                            weapBodyMult = ArmorBodyMult;
                            weapPlyrBodyMult = ArmorPlyrBodyMult;
                            weapArmrMult = ArmorArmorMult;
                            weapPlyrArmrMult = ArmorPlyrArmorMult;
                            weapArmrPntMult = ArmorArmrPntMult;
                            weapPlyrArmrPntMult = ArmorPlyrArmrPntMult;

                            weapLimbMult = ArmorLimbMult;
                            weapPlyrLimbMult = ArmorPlyrLimbMult;
                            weapHandMult = ArmorHndFtMult;
                            weapPlyrHandMult = ArmorPlyrHndFtMult;
                            break;
                        case 51:
                            weapHeadMult = ExplosionHeadMult;
                            weapPlyrHeadMult = ExplosionPlyrHeadMult;

                            weapBodyMult = ExplosionBodyMult;
                            weapPlyrBodyMult = ExplosionPlyrBodyMult;
                            weapArmrMult = ExplosionArmorMult;
                            weapPlyrArmrMult = ExplosionPlyrArmorMult;
                            weapArmrPntMult = ExplosionArmrPntMult;
                            weapPlyrArmrPntMult = ExplosionPlyrArmrPntMult;

                            weapLimbMult = ExplosionLimbMult;
                            weapPlyrLimbMult = ExplosionPlyrLimbMult;
                            weapHandMult = ExplosionHndFtMult;
                            weapPlyrHandMult = ExplosionPlyrHndFtMult;
                            break;
                        case 58:
                            weapHeadMult = Addon1HeadMult;
                            weapPlyrHeadMult = Addon1PlyrHeadMult;

                            weapBodyMult = Addon1BodyMult;
                            weapPlyrBodyMult = Addon1PlyrBodyMult;
                            weapArmrMult = Addon1ArmorMult;
                            weapPlyrArmrMult = Addon1PlyrArmorMult;
                            weapArmrPntMult = Addon1ArmrPntMult;
                            weapPlyrArmrPntMult = Addon1PlyrArmrPntMult;

                            weapLimbMult = Addon1LimbMult;
                            weapPlyrLimbMult = Addon1PlyrLimbMult;
                            weapHandMult = Addon1HndFtMult;
                            weapPlyrHandMult = Addon1PlyrHndFtMult;
                            break;
                        case 59:
                            weapHeadMult = Addon2HeadMult;
                            weapPlyrHeadMult = Addon2PlyrHeadMult;

                            weapBodyMult = Addon2BodyMult;
                            weapPlyrBodyMult = Addon2PlyrBodyMult;
                            weapArmrMult = Addon2ArmorMult;
                            weapPlyrArmrMult = Addon2PlyrArmorMult;
                            weapArmrPntMult = Addon2ArmrPntMult;
                            weapPlyrArmrPntMult = Addon2PlyrArmrPntMult;

                            weapLimbMult = Addon2LimbMult;
                            weapPlyrLimbMult = Addon2PlyrLimbMult;
                            weapHandMult = Addon2HndFtMult;
                            weapPlyrHandMult = Addon2PlyrHndFtMult;
                            break;
                        case 60:
                            weapHeadMult = Addon3HeadMult;
                            weapPlyrHeadMult = Addon3PlyrHeadMult;

                            weapBodyMult = Addon3BodyMult;
                            weapPlyrBodyMult = Addon3PlyrBodyMult;
                            weapArmrMult = Addon3ArmorMult;
                            weapPlyrArmrMult = Addon3PlyrArmorMult;
                            weapArmrPntMult = Addon3ArmrPntMult;
                            weapPlyrArmrPntMult = Addon3PlyrArmrPntMult;

                            weapLimbMult = Addon3LimbMult;
                            weapPlyrLimbMult = Addon3PlyrLimbMult;
                            weapHandMult = Addon3HndFtMult;
                            weapPlyrHandMult = Addon3PlyrHndFtMult;
                            break;
                        case 61:
                            weapHeadMult = Addon4HeadMult;
                            weapPlyrHeadMult = Addon4PlyrHeadMult;

                            weapBodyMult = Addon4BodyMult;
                            weapPlyrBodyMult = Addon4PlyrBodyMult;
                            weapArmrMult = Addon4ArmorMult;
                            weapPlyrArmrMult = Addon4PlyrArmorMult;
                            weapArmrPntMult = Addon4ArmrPntMult;
                            weapPlyrArmrPntMult = Addon4PlyrArmrPntMult;

                            weapLimbMult = Addon4LimbMult;
                            weapPlyrLimbMult = Addon4PlyrLimbMult;
                            weapHandMult = Addon4HndFtMult;
                            weapPlyrHandMult = Addon4PlyrHndFtMult;
                            break;
                        case 62:
                            weapHeadMult = Addon5HeadMult;
                            weapPlyrHeadMult = Addon5PlyrHeadMult;

                            weapBodyMult = Addon5BodyMult;
                            weapPlyrBodyMult = Addon5PlyrBodyMult;
                            weapArmrMult = Addon5ArmorMult;
                            weapPlyrArmrMult = Addon5PlyrArmorMult;
                            weapArmrPntMult = Addon5ArmrPntMult;
                            weapPlyrArmrPntMult = Addon5PlyrArmrPntMult;

                            weapLimbMult = Addon5LimbMult;
                            weapPlyrLimbMult = Addon5PlyrLimbMult;
                            weapHandMult = Addon5HndFtMult;
                            weapPlyrHandMult = Addon5PlyrHndFtMult;
                            break;
                        case 63:
                            weapHeadMult = Addon6HeadMult;
                            weapPlyrHeadMult = Addon6PlyrHeadMult;

                            weapBodyMult = Addon6BodyMult;
                            weapPlyrBodyMult = Addon6PlyrBodyMult;
                            weapArmrMult = Addon6ArmorMult;
                            weapPlyrArmrMult = Addon6PlyrArmorMult;
                            weapArmrPntMult = Addon6ArmrPntMult;
                            weapPlyrArmrPntMult = Addon6PlyrArmrPntMult;

                            weapLimbMult = Addon6LimbMult;
                            weapPlyrLimbMult = Addon6PlyrLimbMult;
                            weapHandMult = Addon6HndFtMult;
                            weapPlyrHandMult = Addon6PlyrHndFtMult;
                            break;
                        case 64:
                            weapHeadMult = Addon7HeadMult;
                            weapPlyrHeadMult = Addon7PlyrHeadMult;

                            weapBodyMult = Addon7BodyMult;
                            weapPlyrBodyMult = Addon7PlyrBodyMult;
                            weapArmrMult = Addon7ArmorMult;
                            weapPlyrArmrMult = Addon7PlyrArmorMult;
                            weapArmrPntMult = Addon7ArmrPntMult;
                            weapPlyrArmrPntMult = Addon7PlyrArmrPntMult;

                            weapLimbMult = Addon7LimbMult;
                            weapPlyrLimbMult = Addon7PlyrLimbMult;
                            weapHandMult = Addon7HndFtMult;
                            weapPlyrHandMult = Addon7PlyrHndFtMult;
                            break;
                        case 65:
                            weapHeadMult = Addon8HeadMult;
                            weapPlyrHeadMult = Addon8PlyrHeadMult;

                            weapBodyMult = Addon8BodyMult;
                            weapPlyrBodyMult = Addon8PlyrBodyMult;
                            weapArmrMult = Addon8ArmorMult;
                            weapPlyrArmrMult = Addon8PlyrArmorMult;
                            weapArmrPntMult = Addon8ArmrPntMult;
                            weapPlyrArmrPntMult = Addon8PlyrArmrPntMult;

                            weapLimbMult = Addon8LimbMult;
                            weapPlyrLimbMult = Addon8PlyrLimbMult;
                            weapHandMult = Addon8HndFtMult;
                            weapPlyrHandMult = Addon8PlyrHndFtMult;
                            break;
                        case 66:
                            weapHeadMult = Addon9HeadMult;
                            weapPlyrHeadMult = Addon9PlyrHeadMult;

                            weapBodyMult = Addon9BodyMult;
                            weapPlyrBodyMult = Addon9PlyrBodyMult;
                            weapArmrMult = Addon9ArmorMult;
                            weapPlyrArmrMult = Addon9PlyrArmorMult;
                            weapArmrPntMult = Addon9ArmrPntMult;
                            weapPlyrArmrPntMult = Addon9PlyrArmrPntMult;

                            weapLimbMult = Addon9LimbMult;
                            weapPlyrLimbMult = Addon9PlyrLimbMult;
                            weapHandMult = Addon9HndFtMult;
                            weapPlyrHandMult = Addon9PlyrHndFtMult;
                            break;
                        case 67:
                            weapHeadMult = Addon10HeadMult;
                            weapPlyrHeadMult = Addon10PlyrHeadMult;

                            weapBodyMult = Addon10BodyMult;
                            weapPlyrBodyMult = Addon10PlyrBodyMult;
                            weapArmrMult = Addon10ArmorMult;
                            weapPlyrArmrMult = Addon10PlyrArmorMult;
                            weapArmrPntMult = Addon10ArmrPntMult;
                            weapPlyrArmrPntMult = Addon10PlyrArmrPntMult;

                            weapLimbMult = Addon10LimbMult;
                            weapPlyrLimbMult = Addon10PlyrLimbMult;
                            weapHandMult = Addon10HndFtMult;
                            weapPlyrHandMult = Addon10PlyrHndFtMult;
                            break;
                        case 68:
                            weapHeadMult = Addon11HeadMult;
                            weapPlyrHeadMult = Addon11PlyrHeadMult;

                            weapBodyMult = Addon11BodyMult;
                            weapPlyrBodyMult = Addon11PlyrBodyMult;
                            weapArmrMult = Addon11ArmorMult;
                            weapPlyrArmrMult = Addon11PlyrArmorMult;
                            weapArmrPntMult = Addon11ArmrPntMult;
                            weapPlyrArmrPntMult = Addon11PlyrArmrPntMult;

                            weapLimbMult = Addon11LimbMult;
                            weapPlyrLimbMult = Addon11PlyrLimbMult;
                            weapHandMult = Addon11HndFtMult;
                            weapPlyrHandMult = Addon11PlyrHndFtMult;
                            break;
                        case 69:
                            weapHeadMult = Addon12HeadMult;
                            weapPlyrHeadMult = Addon12PlyrHeadMult;

                            weapBodyMult = Addon12BodyMult;
                            weapPlyrBodyMult = Addon12PlyrBodyMult;
                            weapArmrMult = Addon12ArmorMult;
                            weapPlyrArmrMult = Addon12PlyrArmorMult;
                            weapArmrPntMult = Addon12ArmrPntMult;
                            weapPlyrArmrPntMult = Addon12PlyrArmrPntMult;

                            weapLimbMult = Addon12LimbMult;
                            weapPlyrLimbMult = Addon12PlyrLimbMult;
                            weapHandMult = Addon12HndFtMult;
                            weapPlyrHandMult = Addon12PlyrHndFtMult;
                            break;
                        case 70:
                            weapHeadMult = Addon13HeadMult;
                            weapPlyrHeadMult = Addon13PlyrHeadMult;

                            weapBodyMult = Addon13BodyMult;
                            weapPlyrBodyMult = Addon13PlyrBodyMult;
                            weapArmrMult = Addon13ArmorMult;
                            weapPlyrArmrMult = Addon13PlyrArmorMult;
                            weapArmrPntMult = Addon13ArmrPntMult;
                            weapPlyrArmrPntMult = Addon13PlyrArmrPntMult;

                            weapLimbMult = Addon13LimbMult;
                            weapPlyrLimbMult = Addon13PlyrLimbMult;
                            weapHandMult = Addon13HndFtMult;
                            weapPlyrHandMult = Addon13PlyrHndFtMult;
                            break;
                        case 71:
                            weapHeadMult = Addon14HeadMult;
                            weapPlyrHeadMult = Addon14PlyrHeadMult;

                            weapBodyMult = Addon14BodyMult;
                            weapPlyrBodyMult = Addon14PlyrBodyMult;
                            weapArmrMult = Addon14ArmorMult;
                            weapPlyrArmrMult = Addon14PlyrArmorMult;
                            weapArmrPntMult = Addon14ArmrPntMult;
                            weapPlyrArmrPntMult = Addon14PlyrArmrPntMult;

                            weapLimbMult = Addon14LimbMult;
                            weapPlyrLimbMult = Addon14PlyrLimbMult;
                            weapHandMult = Addon14HndFtMult;
                            weapPlyrHandMult = Addon14PlyrHndFtMult;
                            break;
                        case 72:
                            weapHeadMult = Addon15HeadMult;
                            weapPlyrHeadMult = Addon15PlyrHeadMult;

                            weapBodyMult = Addon15BodyMult;
                            weapPlyrBodyMult = Addon15PlyrBodyMult;
                            weapArmrMult = Addon15ArmorMult;
                            weapPlyrArmrMult = Addon15PlyrArmorMult;
                            weapArmrPntMult = Addon15ArmrPntMult;
                            weapPlyrArmrPntMult = Addon15PlyrArmrPntMult;

                            weapLimbMult = Addon15LimbMult;
                            weapPlyrLimbMult = Addon15PlyrLimbMult;
                            weapHandMult = Addon15HndFtMult;
                            weapPlyrHandMult = Addon15PlyrHndFtMult;
                            break;
                        case 73:
                            weapHeadMult = Addon16HeadMult;
                            weapPlyrHeadMult = Addon16PlyrHeadMult;

                            weapBodyMult = Addon16BodyMult;
                            weapPlyrBodyMult = Addon16PlyrBodyMult;
                            weapArmrMult = Addon16ArmorMult;
                            weapPlyrArmrMult = Addon16PlyrArmorMult;
                            weapArmrPntMult = Addon16ArmrPntMult;
                            weapPlyrArmrPntMult = Addon16PlyrArmrPntMult;

                            weapLimbMult = Addon16LimbMult;
                            weapPlyrLimbMult = Addon16PlyrLimbMult;
                            weapHandMult = Addon16HndFtMult;
                            weapPlyrHandMult = Addon16PlyrHndFtMult;
                            break;
                        case 74:
                            weapHeadMult = Addon17HeadMult;
                            weapPlyrHeadMult = Addon17PlyrHeadMult;

                            weapBodyMult = Addon17BodyMult;
                            weapPlyrBodyMult = Addon17PlyrBodyMult;
                            weapArmrMult = Addon17ArmorMult;
                            weapPlyrArmrMult = Addon17PlyrArmorMult;
                            weapArmrPntMult = Addon17ArmrPntMult;
                            weapPlyrArmrPntMult = Addon17PlyrArmrPntMult;

                            weapLimbMult = Addon17LimbMult;
                            weapPlyrLimbMult = Addon17PlyrLimbMult;
                            weapHandMult = Addon17HndFtMult;
                            weapPlyrHandMult = Addon17PlyrHndFtMult;
                            break;
                        case 75:
                            weapHeadMult = Addon18HeadMult;
                            weapPlyrHeadMult = Addon18PlyrHeadMult;

                            weapBodyMult = Addon18BodyMult;
                            weapPlyrBodyMult = Addon18PlyrBodyMult;
                            weapArmrMult = Addon18ArmorMult;
                            weapPlyrArmrMult = Addon18PlyrArmorMult;
                            weapArmrPntMult = Addon18ArmrPntMult;
                            weapPlyrArmrPntMult = Addon18PlyrArmrPntMult;

                            weapLimbMult = Addon18LimbMult;
                            weapPlyrLimbMult = Addon18PlyrLimbMult;
                            weapHandMult = Addon18HndFtMult;
                            weapPlyrHandMult = Addon18PlyrHndFtMult;
                            break;
                        case 76:
                            weapHeadMult = Addon19HeadMult;
                            weapPlyrHeadMult = Addon19PlyrHeadMult;

                            weapBodyMult = Addon19BodyMult;
                            weapPlyrBodyMult = Addon19PlyrBodyMult;
                            weapArmrMult = Addon19ArmorMult;
                            weapPlyrArmrMult = Addon19PlyrArmorMult;
                            weapArmrPntMult = Addon19ArmrPntMult;
                            weapPlyrArmrPntMult = Addon19PlyrArmrPntMult;

                            weapLimbMult = Addon19LimbMult;
                            weapPlyrLimbMult = Addon19PlyrLimbMult;
                            weapHandMult = Addon19HndFtMult;
                            weapPlyrHandMult = Addon19PlyrHndFtMult;
                            break;
                        case 77:
                            weapHeadMult = Addon20HeadMult;
                            weapPlyrHeadMult = Addon20PlyrHeadMult;

                            weapBodyMult = Addon20BodyMult;
                            weapPlyrBodyMult = Addon20PlyrBodyMult;
                            weapArmrMult = Addon20ArmorMult;
                            weapPlyrArmrMult = Addon20PlyrArmorMult;
                            weapArmrPntMult = Addon20ArmrPntMult;
                            weapPlyrArmrPntMult = Addon20PlyrArmrPntMult;

                            weapLimbMult = Addon20LimbMult;
                            weapPlyrLimbMult = Addon20PlyrLimbMult;
                            weapHandMult = Addon20HndFtMult;
                            weapPlyrHandMult = Addon20PlyrHndFtMult;
                            break;
                    }

                    uint dmgInit = (initHealth - newHealth);
                    uint armrDmgInit = (initArmor - newArmor);

                    uint initHeadDmg = (((200 - newHealth) * (weapHeadMult - 100)) / 100);
                    uint initHeadArmrDmg = (((100 - newArmor) * weapHeadMult) / 100);
                    uint plyrInitHeadDmg = (((200 - newHealth) * (weapPlyrHeadMult - 100)) / 100);
                    uint plyrInitHeadArmrDmg = (((100 - newArmor) * weapPlyrHeadMult) / 100);
                    uint headDmg = ((dmgInit * weapHeadMult) / 100);
                    uint plyrHeadDmg = ((dmgInit * weapPlyrHeadMult) / 100);
                    uint headArmrDmg = ((armrDmgInit * weapHeadMult) / 100);
                    uint plyrHeadArmrDmg = ((armrDmgInit * weapPlyrHeadMult) / 100);

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

                    uint HandDmg = ((armrDmgInit * weapArmrPntMult) / 100);
                    uint plyrHandPntDmg = ((armrDmgInit * weapPlyrArmrPntMult) / 100);

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
                            //IVGame.ShowSubtitleMessage("head");
                            if (weapPlyrHeadMult >= 0)
                            {
                                if (pedHandle == 2 && dmgInit > 1 && newArmor <= 0)
                                {
                                    SET_CHAR_HEALTH(pedHandle, newHealth + (dmgInit - plyrHeadDmg));
                                }
                                else if (pedHandle == 2 && dmgInit <= 1 && newArmor <= 0)
                                {
                                    SET_CHAR_HEALTH(pedHandle, (newHealth - plyrInitHeadDmg));
                                }
                            }
                            if (weapHeadMult >= 0)
                            {
                                if (pedHandle != 2 && dmgInit > 1 && newArmor <= 0)
                                {
                                    SET_CHAR_HEALTH(pedHandle, newHealth + (dmgInit - headDmg));
                                }
                                else if (pedHandle != 2 && dmgInit <= 1 && newArmor <= 0)
                                {
                                    SET_CHAR_HEALTH(pedHandle, (newHealth - initHeadDmg));
                                }
                            }
                            GET_CHAR_HEALTH(pedHandle, out newHealth);

                            if (weapPlyrHeadMult >= 0)
                            {
                                if (pedHandle == 2 && armrDmgInit > 1 && newArmor > 0)
                                {
                                    ADD_ARMOUR_TO_CHAR(pedHandle, (int)armrDmgInit);
                                    SET_CHAR_HEALTH(pedHandle, newHealth - plyrHeadArmrDmg);
                                }
                                else if (pedHandle == 2 && armrDmgInit > 1 && newArmor <= 0)
                                {
                                    ADD_ARMOUR_TO_CHAR(pedHandle, (int)armrDmgInit);
                                    SET_CHAR_HEALTH(pedHandle, newHealth - plyrHeadArmrDmg);
                                }
                                else if (pedHandle == 2 && armrDmgInit <= 1 && newArmor > 0)
                                {
                                    ADD_ARMOUR_TO_CHAR(pedHandle, (int)(100 - newArmor));
                                    SET_CHAR_HEALTH(pedHandle, newHealth - plyrInitHeadArmrDmg);
                                }
                            }
                            if (weapHeadMult >= 0)
                            {
                                if (pedHandle != 2 && armrDmgInit > 1 && newArmor > 0)
                                {
                                    ADD_ARMOUR_TO_CHAR(pedHandle, (int)armrDmgInit);
                                    SET_CHAR_HEALTH(pedHandle, newHealth - headArmrDmg);
                                }
                                else if (pedHandle != 2 && armrDmgInit > 1 && newArmor <= 0)
                                {
                                    ADD_ARMOUR_TO_CHAR(pedHandle, (int)armrDmgInit);
                                    SET_CHAR_HEALTH(pedHandle, newHealth - headArmrDmg);
                                }
                                else if (pedHandle != 2 && armrDmgInit <= 1 && newArmor > 0)
                                {
                                    ADD_ARMOUR_TO_CHAR(pedHandle, (int)(100 - newArmor));
                                    SET_CHAR_HEALTH(pedHandle, newHealth - initHeadArmrDmg);
                                }
                            }
                        }
                        else if (!IS_CHAR_DEAD(pedHandle) && (boneHit.Contains("SPINE") || boneHit.Contains("CLAVICLE") || boneHit == "ROOT"))
                        {
                            //IVGame.ShowSubtitleMessage("body");
                            if (pedHandle == 2 && dmgInit > 0 && newArmor <= 0)
                                SET_CHAR_HEALTH(pedHandle, newHealth + (dmgInit - plyrBodyDmg));

                            else if (pedHandle == 2 && dmgInit <= 0 && newArmor <= 0)
                                SET_CHAR_HEALTH(pedHandle, newHealth - plyrInitBodyDmg);

                            else if (pedHandle != 2 && dmgInit > 0 && newArmor <= 0)
                                SET_CHAR_HEALTH(pedHandle, newHealth + (dmgInit - bodyDmg));

                            else if (pedHandle != 2 && dmgInit <= 0 && newArmor <= 0)
                                SET_CHAR_HEALTH(pedHandle, newHealth - initBodyDmg);

                            GET_CHAR_HEALTH(pedHandle, out newHealth);

                            //IVGame.ShowSubtitleMessage(dmgInit.ToString() + "  " + initHealth.ToString() + "  " + newHealth.ToString() + "  " + armrDmgInit.ToString() + "  " + initArmor + "  " + newArmor.ToString());
                            if (initArmor > 0)
                            {
                                if (pedHandle == 2 && armrDmgInit > 0)
                                {
                                    ADD_ARMOUR_TO_CHAR(pedHandle, (int)(armrDmgInit - plyrArmrDmg));

                                    if ((plyrArmrDmg - armrDmgInit) > newArmor)
                                        SET_CHAR_HEALTH(pedHandle, newHealth - (((newArmor + armrDmgInit) * weapPlyrArmrPntMult) / 100) - (((plyrArmrDmg - armrDmgInit - newArmor) * weapPlyrBodyMult) / 300));
                                    else
                                        SET_CHAR_HEALTH(pedHandle, newHealth - ((plyrArmrDmg * weapPlyrArmrPntMult) / 100));

                                    GET_CHAR_HEALTH(pedHandle, out newHealth);

                                    /*if ((plyrArmrDmg - armrDmgInit) > newArmor)
                                        SET_CHAR_HEALTH(pedHandle, newHealth - (((plyrArmrDmg - armrDmgInit - newArmor) * weapPlyrBodyMult) / weapBodyMult));

                                    GET_CHAR_HEALTH(pedHandle, out newHealth);*/
                                }
                                else if (pedHandle == 2 && armrDmgInit < 1)
                                {
                                    ADD_ARMOUR_TO_CHAR(pedHandle, (int)(0 - (((100 - newArmor) * (weapPlyrArmrMult - 100)) / 100)));
                                    SET_CHAR_HEALTH(pedHandle, newHealth - (((100 - newArmor) * (weapPlyrArmrMult * weapPlyrArmrPntMult)) / 10000));
                                }
                                else if (pedHandle != 2 && armrDmgInit > 0)
                                {
                                    ADD_ARMOUR_TO_CHAR(pedHandle, (int)(armrDmgInit - ((armrDmgInit * PistolArmorMult) / 100)));

                                    if ((armrDmg - armrDmgInit) > newArmor)
                                        SET_CHAR_HEALTH(pedHandle, newHealth - (((newArmor + armrDmgInit) * weapArmrPntMult) / 100) - (((armrDmg - armrDmgInit - newArmor) * weapBodyMult) / 100));
                                    else
                                        SET_CHAR_HEALTH(pedHandle, newHealth - ((armrDmg * weapArmrPntMult) / 100));

                                    GET_CHAR_HEALTH(pedHandle, out newHealth);

                                    /*if ((armrDmg - armrDmgInit) > newArmor)
                                        SET_CHAR_HEALTH(pedHandle, newHealth - (((armrDmg - armrDmgInit - newArmor) * weapBodyMult) / 100));

                                    GET_CHAR_HEALTH(pedHandle, out newHealth);*/
                                }
                                else if (pedHandle != 2 && armrDmgInit < 1)
                                {
                                    ADD_ARMOUR_TO_CHAR(pedHandle, (int)(0 - (((100 - newArmor) * (weapArmrMult - 100)) / 100)));
                                    SET_CHAR_HEALTH(pedHandle, newHealth - (((100 - newArmor) * (weapArmrMult * weapArmrPntMult)) / 10000));
                                }
                            }
                        }
                        else if (!IS_CHAR_DEAD(pedHandle) && (boneHit.Contains("THIGH") || boneHit.Contains("CALF") || boneHit.Contains("ARM")))
                        {
                            //IVGame.ShowSubtitleMessage("limb");
                            if (pedHandle == 2 && dmgInit > 1 && newArmor <= 0)
                            {
                                SET_CHAR_HEALTH(pedHandle, newHealth + (dmgInit - plyrLimbDmg));
                            }
                            else if (pedHandle == 2 && dmgInit <= 1 && newArmor <= 0)
                            {
                                SET_CHAR_HEALTH(pedHandle, (newHealth - plyrInitLimbDmg));
                            }
                            else if (pedHandle != 2 && dmgInit > 1 && newArmor <= 0)
                            {
                                SET_CHAR_HEALTH(pedHandle, newHealth + (dmgInit - limbDmg));
                            }
                            else if (pedHandle != 2 && dmgInit <= 1 && newArmor <= 0)
                            {
                                SET_CHAR_HEALTH(pedHandle, (newHealth - initLimbDmg));
                            }
                            GET_CHAR_HEALTH(pedHandle, out newHealth);

                            if (pedHandle == 2 && armrDmgInit > 1 && newArmor > 0)
                            {
                                ADD_ARMOUR_TO_CHAR(pedHandle, (int)armrDmgInit);
                                SET_CHAR_HEALTH(pedHandle, newHealth - plyrLimbArmrDmg);
                            }
                            else if (pedHandle == 2 && armrDmgInit > 1 && newArmor <= 0)
                            {
                                ADD_ARMOUR_TO_CHAR(pedHandle, (int)armrDmgInit);
                                SET_CHAR_HEALTH(pedHandle, newHealth - plyrLimbArmrDmg);
                            }
                            else if (pedHandle == 2 && armrDmgInit <= 1 && newArmor > 0)
                            {
                                ADD_ARMOUR_TO_CHAR(pedHandle, (int)(100 - newArmor));
                                SET_CHAR_HEALTH(pedHandle, newHealth - plyrInitLimbArmrDmg);
                            }
                            else if (pedHandle != 2 && armrDmgInit > 1 && newArmor > 0)
                            {
                                ADD_ARMOUR_TO_CHAR(pedHandle, (int)armrDmgInit);
                                SET_CHAR_HEALTH(pedHandle, newHealth - limbArmrDmg);
                            }
                            else if (pedHandle != 2 && armrDmgInit > 1 && newArmor <= 0)
                            {
                                ADD_ARMOUR_TO_CHAR(pedHandle, (int)armrDmgInit);
                                SET_CHAR_HEALTH(pedHandle, newHealth - limbArmrDmg);
                            }
                            else if (pedHandle != 2 && armrDmgInit <= 1 && newArmor > 0)
                            {
                                ADD_ARMOUR_TO_CHAR(pedHandle, (int)(100 - newArmor));
                                SET_CHAR_HEALTH(pedHandle, newHealth - initLimbArmrDmg);
                            }
                        }
                        else if (!IS_CHAR_DEAD(pedHandle) && (boneHit.Contains("HAND") || boneHit.Contains("FOOT") || boneHit.Contains("TOE") || boneHit.Contains("FINGER")))
                        {
                            //IVGame.ShowSubtitleMessage("handfeet");
                            if (pedHandle == 2 && dmgInit > 1 && newArmor <= 0)
                            {
                                SET_CHAR_HEALTH(pedHandle, newHealth + (dmgInit - plyrHandDmg));
                            }
                            else if (pedHandle == 2 && dmgInit <= 1 && newArmor <= 0)
                            {
                                SET_CHAR_HEALTH(pedHandle, (newHealth - plyrInitHandDmg));
                            }
                            else if (pedHandle != 2 && dmgInit > 1 && newArmor <= 0)
                            {
                                SET_CHAR_HEALTH(pedHandle, newHealth + (dmgInit - handDmg));
                            }
                            else if (pedHandle != 2 && dmgInit <= 1 && newArmor <= 0)
                            {
                                SET_CHAR_HEALTH(pedHandle, (newHealth - initHandDmg));
                            }
                            GET_CHAR_HEALTH(pedHandle, out newHealth);

                            if (pedHandle == 2 && armrDmgInit > 1 && newArmor > 0)
                            {
                                ADD_ARMOUR_TO_CHAR(pedHandle, (int)armrDmgInit);
                                SET_CHAR_HEALTH(pedHandle, newHealth - plyrHandArmrDmg);
                            }
                            else if (pedHandle == 2 && armrDmgInit > 1 && newArmor <= 0)
                            {
                                ADD_ARMOUR_TO_CHAR(pedHandle, (int)armrDmgInit);
                                SET_CHAR_HEALTH(pedHandle, newHealth - plyrHandArmrDmg);
                            }
                            else if (pedHandle == 2 && armrDmgInit <= 1 && newArmor > 0)
                            {
                                ADD_ARMOUR_TO_CHAR(pedHandle, (int)(100 - newArmor));
                                SET_CHAR_HEALTH(pedHandle, newHealth - plyrInitHandArmrDmg);
                            }
                            else if (pedHandle != 2 && armrDmgInit > 1 && newArmor > 0)
                            {
                                ADD_ARMOUR_TO_CHAR(pedHandle, (int)armrDmgInit);
                                SET_CHAR_HEALTH(pedHandle, newHealth - handArmrDmg);
                            }
                            else if (pedHandle != 2 && armrDmgInit > 1 && newArmor <= 0)
                            {
                                ADD_ARMOUR_TO_CHAR(pedHandle, (int)armrDmgInit);
                                SET_CHAR_HEALTH(pedHandle, newHealth - handArmrDmg);
                            }
                            else if (pedHandle != 2 && armrDmgInit <= 1 && newArmor > 0)
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
