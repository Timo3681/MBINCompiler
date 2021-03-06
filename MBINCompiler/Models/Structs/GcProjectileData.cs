﻿using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcProjectileData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Id;
        /* 0x010 */ public GcResourceElement Model;
        /* 0x2B8 */ public GcAudioWwiseEvents AkEvent;
        /* 0x2BC */ public float Scale;
        //Updated Insert
        //Offsets should be fix
        /* 0x2C4 */ public bool isAutonomous;
        /* 0x2C4 */ public float Radius;
        /* 0x2C8 */ public float Speed;
        /* 0x2CC */ public float Gravity;
        /* 0x2D0 */ public float Life;
        /* 0x2D4 */ public float Offset;
        /* 0x2D8 */ public float RagdollPush;
        /* 0x2DC */ public int Damage;
        /* 0x2E0 */ public int MiningDamage;
        /* 0x2E4 */ public int Bounces;
        /* 0x2E8 */ public bool HitOnBounce;
        [NMS(Size = 7, Ignore = true)]
        /* 0x2E9 */ public byte[] Padding2E9;

        [NMS(Size = 0x10)]
        /* 0x2F0 */ public string PlayerDamage;
        /* 0x300 */ public Colour Colour;

        public int BehaviourFlags;
        //* 0x310 */ public string[] BehaviourFlagsValues()
        /*{
            return new[] { "None", "DestroyTerrain", "DestroyAsteroids", "None", "GatherResources", "None", "None", "None", "Homing",
                 "None", "None", "None", "None", "None", "None", "None","HomingLaser",
                 "None", "None", "None", "None", "None", "None", "None", "None",
                 "None", "None", "None", "None", "None", "None", "None", "ScareCreatures",
                 "None", "None", "None", "None", "None", "None", "None", "None",
                 "None", "None", "None", "None", "None", "None", "None", "None",
                 "None", "None", "None", "None", "None", "None", "None", "None",
                 "None", "None", "None", "None", "None", "None", "None", "ExplosionForce" , "None", };
        }*/

        public int Class;
        /* 0x314 */ public string[] ClassValues()
        {
            return new[] { "Player", "PlayerShip", "Ship", "Robot"};
        }

        

        [NMS(Size = 0x10)]
        /* 0x318 */ public string DefaultImpact;
        /* 0x328 */ public List<GcProjectileImpactData> Impacts;
        [NMS(Size = 8, Ignore = true)]
        /* 0x338 */ public byte[] Padding338;

        //[NMS(Size = 4, Ignore = true)]
        ///* 0x310 */
        //public byte[] Padding310;
    }
}
