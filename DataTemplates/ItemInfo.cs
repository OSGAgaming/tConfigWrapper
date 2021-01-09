﻿using Microsoft.Xna.Framework;
using Terraria.Audio;
using Terraria.UI;

namespace tConfigWrapper.DataTemplates
{
	// All the public instanced fields of the Item class
	// They are nullable so that the value of the item is only changed when a field is not null
	// All the fields were extracted via typeof(Item).GetFields()
	public struct ItemInfo
	{
		public bool? questItem;
		public bool? flame;
		public bool? mech;
		public int? noGrabDelay;
		public bool? beingGrabbed;
		public bool? isBeingGrabbed;
		public int? spawnTime;
		public int? tileWand;
		public bool? wornArmor;
		public byte? dye;
		public int? fishingPole;
		public int? bait;
		public short? makeNPC;
		public bool? expertOnly;
		public bool? expert;
		public short? hairDye;
		public byte? paint;
		public bool? instanced;
		public int? ownIgnore;
		public int? ownTime;
		public int? keepTime;
		public int? type;
		public bool? favorited;
		public int? holdStyle;
		public int? useStyle;
		public bool? channel;
		public bool? accessory;
		public int? useAnimation;
		public int? useTime;
		public int? stack;
		public int? maxStack;
		public int? pick;
		public int? axe;
		public int? hammer;
		public int? tileBoost;
		public int? createTile;
		public int? createWall;
		public int? placeStyle;
		public int? damage;
		public float? knockBack;
		public int? healLife;
		public int? healMana;
		public bool? potion;
		public bool? consumable;
		public bool? autoReuse;
		public bool? useTurn;
		public Color? color;
		public int? alpha;
		public short? glowMask;
		public float? scale;
		public LegacySoundStyle UseSound;
		public int? defense;
		public int? headSlot;
		public int? bodySlot;
		public int? legSlot;
		public sbyte? handOnSlot;
		public sbyte? handOffSlot;
		public sbyte? backSlot;
		public sbyte? frontSlot;
		public sbyte? shoeSlot;
		public sbyte? waistSlot;
		public sbyte? wingSlot;
		public sbyte? shieldSlot;
		public sbyte? neckSlot;
		public sbyte? faceSlot;
		public sbyte? balloonSlot;
		public int? stringColor;
		public ItemTooltip ToolTip;
		public int? owner;
		public int? rare;
		public int? shoot;
		public float? shootSpeed;
		public int? ammo;
		public bool? notAmmo;
		public int? useAmmo;
		public int? lifeRegen;
		public int? manaIncrease;
		public bool? buyOnce;
		public int? mana;
		public bool? noUseGraphic;
		public bool? noMelee;
		public int? release;
		public int? value;
		public bool? buy;
		public bool? social;
		public bool? vanity;
		public bool? material;
		public bool? noWet;
		public int? buffType;
		public int? buffTime;
		public int? mountType;
		public bool? cartTrack;
		public bool? uniqueStack;
		public int? shopSpecialCurrency;
		public int? shopCustomPrice;
		public bool? DD2Summon;
		public int? netID;
		public int? crit;
		public byte? prefix;
		public bool? melee;
		public bool? magic;
		public bool? ranged;
		public bool? thrown;
		public bool? summon;
		public bool? sentry;
		public int? reuseDelay;
		public bool? newAndShiny;
		public int[] itemCaches;
		public int? potionDelay;
		public int? restorationDelay;
		public int[] headType;
		public int[] bodyType;
		public int[] legType;
		public bool[] staff;
		public bool[] claw;
		public int? coinGrabRange;
		public int? manaGrabRange;
		public int? lifeGrabRange;
		public int? flaskTime;
		public int? copper;
		public int? silver;
		public int? gold;
		public int? platinum;
		public int? whoAmI;
		public bool? active;
		public Vector2? position;
		public Vector2? velocity;
		public Vector2? oldPosition;
		public Vector2? oldVelocity;
		public int? oldDirection;
		public int? direction;
		public int? width;
		public int? height;
		public bool? wet;
		public bool? honeyWet;
		public byte? wetCount;
		public bool? lavaWet;
	}
}
