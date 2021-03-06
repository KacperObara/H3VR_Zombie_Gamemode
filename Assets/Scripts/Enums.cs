using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FistVR
{
    public enum SosigEnemyID
    {
        None = -1, // 0xFFFFFFFF
        Misc_Dummy = 0,
        Misc_Elf = 1,
        M_Swat_Scout = 100, // 0x00000064
        M_Swat_Ranger = 101, // 0x00000065
        M_Swat_Sniper = 102, // 0x00000066
        M_Swat_Riflewiener = 103, // 0x00000067
        M_Swat_Officer = 104, // 0x00000068
        M_Swat_SpecOps = 105, // 0x00000069
        M_Swat_Markswiener = 106, // 0x0000006A
        M_Swat_Shield = 107, // 0x0000006B
        M_Swat_Heavy = 108, // 0x0000006C
        M_Swat_Breacher = 109, // 0x0000006D
        M_Swat_Guard = 110, // 0x0000006E
        M_MercWiener_Scout = 120, // 0x00000078
        M_MercWiener_Ranger = 121, // 0x00000079
        M_MercWiener_Sniper = 122, // 0x0000007A
        M_MercWiener_Riflewiener = 123, // 0x0000007B
        M_MercWiener_Officer = 124, // 0x0000007C
        M_MercWiener_SpecOps = 125, // 0x0000007D
        M_MercWiener_Markswiener = 126, // 0x0000007E
        M_MercWiener_Shield = 127, // 0x0000007F
        M_MercWiener_Heavy = 128, // 0x00000080
        M_MercWiener_Breacher = 129, // 0x00000081
        M_MercWiener_Guard = 130, // 0x00000082
        M_GreaseGremlins_Scout = 140, // 0x0000008C
        M_GreaseGremlins_Ranger = 141, // 0x0000008D
        M_GreaseGremlins_Sniper = 142, // 0x0000008E
        M_GreaseGremlins_Riflewiener = 143, // 0x0000008F
        M_GreaseGremlins_Officer = 144, // 0x00000090
        M_GreaseGremlins_SpecOps = 145, // 0x00000091
        M_GreaseGremlins_Markswiener = 146, // 0x00000092
        M_GreaseGremlins_Shield = 147, // 0x00000093
        M_GreaseGremlins_Heavy = 148, // 0x00000094
        M_GreaseGremlins_Breacher = 149, // 0x00000095
        M_GreaseGremlins_Guard = 150, // 0x00000096
        M_Popsicles_Scout = 160, // 0x000000A0
        M_Popsicles_Ranger = 161, // 0x000000A1
        M_Popsicles_Sniper = 162, // 0x000000A2
        M_Popsicles_Riflewiener = 163, // 0x000000A3
        M_Popsicles_Officer = 164, // 0x000000A4
        M_Popsicles_SpecOps = 165, // 0x000000A5
        M_Popsicles_Markswiener = 166, // 0x000000A6
        M_Popsicles_Shield = 167, // 0x000000A7
        M_Popsicles_Heavy = 168, // 0x000000A8
        M_Popsicles_Breacher = 169, // 0x000000A9
        M_Popsicles_Guard = 170, // 0x000000AA
        M_VeggieDawgs_Scout = 180, // 0x000000B4
        M_VeggieDawgs_Ranger = 181, // 0x000000B5
        M_VeggieDawgs_Sniper = 182, // 0x000000B6
        M_VeggieDawgs_Riflewiener = 183, // 0x000000B7
        M_VeggieDawgs_Officer = 184, // 0x000000B8
        M_VeggieDawgs_SpecOps = 185, // 0x000000B9
        M_VeggieDawgs_Markswiener = 186, // 0x000000BA
        M_VeggieDawgs_Shield = 187, // 0x000000BB
        M_VeggieDawgs_Heavy = 188, // 0x000000BC
        M_VeggieDawgs_Breacher = 189, // 0x000000BD
        M_VeggieDawgs_Guard = 190, // 0x000000BE
        W_Green_Guard = 200, // 0x000000C8
        W_Green_Patrol = 201, // 0x000000C9
        W_Green_Officer = 202, // 0x000000CA
        W_Green_Riflewiener = 203, // 0x000000CB
        W_Green_Grenadier = 204, // 0x000000CC
        W_Green_HeavyRiflewiener = 205, // 0x000000CD
        W_Green_Machinegunner = 206, // 0x000000CE
        W_Green_Flamewiener = 207, // 0x000000CF
        W_Green_Antitank = 208, // 0x000000D0
        W_Tan_Guard = 210, // 0x000000D2
        W_Tan_Patrol = 211, // 0x000000D3
        W_Tan_Officer = 212, // 0x000000D4
        W_Tan_Riflewiener = 213, // 0x000000D5
        W_Tan_Grenadier = 214, // 0x000000D6
        W_Tan_HeavyRiflewiener = 215, // 0x000000D7
        W_Tan_Machinegunner = 216, // 0x000000D8
        W_Tan_Flamewiener = 217, // 0x000000D9
        W_Tan_Antitank = 218, // 0x000000DA
        W_Brown_Guard = 220, // 0x000000DC
        W_Brown_Patrol = 221, // 0x000000DD
        W_Brown_Officer = 222, // 0x000000DE
        W_Brown_Riflewiener = 223, // 0x000000DF
        W_Brown_Grenadier = 224, // 0x000000E0
        W_Brown_HeavyRiflewiener = 225, // 0x000000E1
        W_Brown_Machinegunner = 226, // 0x000000E2
        W_Brown_Flamewiener = 227, // 0x000000E3
        W_Brown_Antitank = 228, // 0x000000E4
        W_Grey_Guard = 230, // 0x000000E6
        W_Grey_Patrol = 231, // 0x000000E7
        W_Grey_Officer = 232, // 0x000000E8
        W_Grey_Riflewiener = 233, // 0x000000E9
        W_Grey_Grenadier = 234, // 0x000000EA
        W_Grey_HeavyRiflewiener = 235, // 0x000000EB
        W_Grey_Machinegunner = 236, // 0x000000EC
        W_Grey_Flamewiener = 237, // 0x000000ED
        W_Grey_Antitank = 238, // 0x000000EE
        D_Gambler = 300, // 0x0000012C
        D_Bandito = 301, // 0x0000012D
        D_Gunfighter = 302, // 0x0000012E
        D_BountyHunter = 303, // 0x0000012F
        D_Sheriff = 304, // 0x00000130
        D_Boss = 305, // 0x00000131
        D_Sniper = 306, // 0x00000132
        D_BountyHunterBoss = 307, // 0x00000133
        J_Guard = 400, // 0x00000190
        J_Patrol = 401, // 0x00000191
        J_Grenadier = 402, // 0x00000192
        J_Officer = 403, // 0x00000193
        J_Commando = 404, // 0x00000194
        J_Riflewiener = 405, // 0x00000195
        J_Flamewiener = 406, // 0x00000196
        J_Machinegunner = 407, // 0x00000197
        J_Sniper = 408, // 0x00000198
        H_BreadCrabZombie_Fast = 500, // 0x000001F4
        H_BreadCrabZombie_HEV = 501, // 0x000001F5
        H_BreadCrabZombie_Poison = 502, // 0x000001F6
        H_BreadCrabZombie_Standard = 503, // 0x000001F7
        H_BreadCrabZombie_Zombie = 504, // 0x000001F8
        H_CivicErection_Meathack = 505, // 0x000001F9
        H_CivicErection_Melee = 506, // 0x000001FA
        H_CivicErection_Pistol = 507, // 0x000001FB
        H_CivicErection_SMG = 508, // 0x000001FC
        H_OberwurstElite_AR2 = 509, // 0x000001FD
        H_OberwurstSoldier_Shotgun = 510, // 0x000001FE
        H_OberwurstSoldier_SMG = 511, // 0x000001FF
        H_OberwurstSoldier_SMGNade = 512, // 0x00000200
        H_OberwurstSoldier_Sniper = 513, // 0x00000201
        MF_RedHots_Demo = 600, // 0x00000258
        MF_RedHots_Engineer = 601, // 0x00000259
        MF_RedHots_Heavy = 602, // 0x0000025A
        MF_RedHots_Medic = 603, // 0x0000025B
        MF_RedHots_Pyro = 604, // 0x0000025C
        MF_RedHots_Scout = 605, // 0x0000025D
        MF_RedHots_Sniper = 606, // 0x0000025E
        MF_RedHots_Soldier = 607, // 0x0000025F
        MF_RedHots_Spy = 608, // 0x00000260
        MF_BlueFranks_Demo = 610, // 0x00000262
        MF_BlueFranks_Engineer = 611, // 0x00000263
        MF_BlueFranks_Heavy = 612, // 0x00000264
        MF_BlueFranks_Medic = 613, // 0x00000265
        MF_BlueFranks_Pyro = 614, // 0x00000266
        MF_BlueFranks_Scout = 615, // 0x00000267
        MF_BlueFranks_Sniper = 616, // 0x00000268
        MF_BlueFranks_Soldier = 617, // 0x00000269
        MF_BlueFranks_Spy = 618, // 0x0000026A
        Gladiator_Hoplite = 700, // 0x000002BC
        Gladiator_Maximus = 701, // 0x000002BD
        Gladiator_Murmillo = 702, // 0x000002BE
        Gladiator_Porcus = 703, // 0x000002BF
        Gladiator_Secutor = 704, // 0x000002C0
        Gladiator_Thraex = 705, // 0x000002C1
        MountainMeat_Melee = 800, // 0x00000320
        MountainMeat_Pistol = 801, // 0x00000321
        MountainMeat_Rifle = 802, // 0x00000322
        MountainMeat_Shotgun = 803, // 0x00000323
        MountainMeat_SMG = 804, // 0x00000324
        RW_Beefkicker = 900, // 0x00000384
        RW_Boner = 901, // 0x00000385
        RW_Driller = 902, // 0x00000386
        RW_Floater = 903, // 0x00000387
        RW_FunGuy = 904, // 0x00000388
        RW_HamFister = 905, // 0x00000389
        RW_Lemonhead = 906, // 0x0000038A
        RW_OldSmokey = 907, // 0x0000038B
        RW_Pig = 908, // 0x0000038C
        RW_Prick = 909, // 0x0000038D
        RW_RedLumberjack = 910, // 0x0000038E
        RW_Rot = 911, // 0x0000038F
        RW_Spurter = 912, // 0x00000390
        RW_TheHung = 913, // 0x00000391
        RWP_Cultist = 1000, // 0x000003E8
        RWP_PacSquad_Commander = 1001, // 0x000003E9
        RWP_PacSquad_Flanker = 1002, // 0x000003EA
        RWP_PacSquad_Sniper = 1003, // 0x000003EB
        RWP_PacSquad_Trooper = 1004, // 0x000003EC
        RWP_Prospector_Bar = 1005, // 0x000003ED
        RWP_Prospector_Pistol = 1006, // 0x000003EE
        RWP_Prospector_Rifle = 1007, // 0x000003EF
        RWP_Prospector_Shotgun = 1008, // 0x000003F0
        RWP_Skulker_Pistol = 1009, // 0x000003F1
        RWP_Skulker_Rifler = 1010, // 0x000003F2
        RWP_Skulker_Shotgun = 1011, // 0x000003F3
        RWNPC_00 = 1100, // 0x0000044C
        RWNPC_01 = 1101, // 0x0000044D
        RWNPC_02 = 1102, // 0x0000044E
        RWNPC_03 = 1103, // 0x0000044F
        RWNPC_04 = 1104, // 0x00000450
        RWNPC_05 = 1105, // 0x00000451
        RWNPC_06 = 1106, // 0x00000452
        RWNPC_07 = 1107, // 0x00000453
        RWNPC_08 = 1108, // 0x00000454
        RWNPC_09 = 1109, // 0x00000455
        RWNPC_10 = 1110, // 0x00000456
        RWNPC_11 = 1111, // 0x00000457
        RWNPC_12 = 1112, // 0x00000458
        RWNPC_13 = 1113, // 0x00000459
        RWNPC_14 = 1114, // 0x0000045A
        RWNPC_15 = 1115, // 0x0000045B
        RWNPC_16 = 1116, // 0x0000045C
        RWNPC_17 = 1117, // 0x0000045D
        RWNPC_18 = 1118, // 0x0000045E
        RWNPC_19 = 1119, // 0x0000045F
        RWNPC_20 = 1120, // 0x00000460
        RWNPC_21 = 1121, // 0x00000461
        Junkbot_Broken = 1200, // 0x000004B0
        Junkbot_Patrol = 1201, // 0x000004B1
        Junkbot_Sniper = 1202, // 0x000004B2
        Junkbot_Rocket = 1203, // 0x000004B3
        Junkbot_Pistoler = 1204, // 0x000004B4
        Junkbot_Soldier = 1205, // 0x000004B5
        Junkbot_Flamer = 1206, // 0x000004B6
        Junkbot_Heavy = 1207, // 0x000004B7
        Junkbot_ElfBroken = 1210, // 0x000004BA
    }
}