using Mutagen.Bethesda;
using System.Collections.Generic;

namespace ListMaker
{
    public static class LVLIMap
    {
        public static Dictionary<FormKey, FormKey> CreateMap()
        {
            var lists = new Dictionary<string, FormKey>()
            {
                { "VLItemBattleaxeDaedric", new FormKey("ListMakerTemplate.esp", 0x000800) },
                { "VLItemBattleaxeDragonbone", new FormKey("ListMakerTemplate.esp", 0x000808) },
                { "VLItemBattleaxeDwarven", new FormKey("ListMakerTemplate.esp", 0x000810) },
                { "VLItemBattleaxeEbony", new FormKey("ListMakerTemplate.esp", 0x000818) },
                { "VLItemBattleaxeElven", new FormKey("ListMakerTemplate.esp", 0x000820) },
                { "VLItemBattleaxeGlass", new FormKey("ListMakerTemplate.esp", 0x000828) },
                { "VLItemBattleaxeIron", new FormKey("ListMakerTemplate.esp", 0x000830) },
                { "VLItemBattleaxeNordic", new FormKey("ListMakerTemplate.esp", 0x000838) },
                { "VLItemBattleaxeOrcish", new FormKey("ListMakerTemplate.esp", 0x000840) },
                { "VLItemBattleaxeSilver", new FormKey("ListMakerTemplate.esp", 0x000848) },
                { "VLItemBattleaxeStalhrim", new FormKey("ListMakerTemplate.esp", 0x000850) },
                { "VLItemBattleaxeSteel", new FormKey("ListMakerTemplate.esp", 0x000858) },

                { "VLItemBowDaedric", new FormKey("ListMakerTemplate.esp", 0x000801) },
                { "VLItemBowDragonbone", new FormKey("ListMakerTemplate.esp", 0x000809) },
                { "VLItemBowDwarven", new FormKey("ListMakerTemplate.esp", 0x000811) },
                { "VLItemBowEbony", new FormKey("ListMakerTemplate.esp", 0x000819) },
                { "VLItemBowElven", new FormKey("ListMakerTemplate.esp", 0x000821) },
                { "VLItemBowGlass", new FormKey("ListMakerTemplate.esp", 0x000829) },
                { "VLItemBowIron", new FormKey("ListMakerTemplate.esp", 0x000831) },
                { "VLItemBowNordic", new FormKey("ListMakerTemplate.esp", 0x000839) },
                { "VLItemBowOrcish", new FormKey("ListMakerTemplate.esp", 0x000841) },
                { "VLItemBowSilver", new FormKey("ListMakerTemplate.esp", 0x000849) },
                { "VLItemBowStalhrim", new FormKey("ListMakerTemplate.esp", 0x000851) },
                { "VLItemBowSteel", new FormKey("ListMakerTemplate.esp", 0x000859) },

                { "VLItemDaggerDaedric", new FormKey("ListMakerTemplate.esp", 0x000802) },
                { "VLItemDaggerDragonbone", new FormKey("ListMakerTemplate.esp", 0x00080a) },
                { "VLItemDaggerDwarven", new FormKey("ListMakerTemplate.esp", 0x000812) },
                { "VLItemDaggerEbony", new FormKey("ListMakerTemplate.esp", 0x00081a) },
                { "VLItemDaggerElven", new FormKey("ListMakerTemplate.esp", 0x000822) },
                { "VLItemDaggerGlass", new FormKey("ListMakerTemplate.esp", 0x00082a) },
                { "VLItemDaggerIron", new FormKey("ListMakerTemplate.esp", 0x000832) },
                { "VLItemDaggerNordic", new FormKey("ListMakerTemplate.esp", 0x00083a) },
                { "VLItemDaggerOrcish", new FormKey("ListMakerTemplate.esp", 0x000842) },
                { "VLItemDaggerSilver", new FormKey("ListMakerTemplate.esp", 0x00084a) },
                { "VLItemDaggerStalhrim", new FormKey("ListMakerTemplate.esp", 0x000852) },
                { "VLItemDaggerSteel", new FormKey("ListMakerTemplate.esp", 0x00085a) },

                { "VLItemGreatswordDaedric", new FormKey("ListMakerTemplate.esp", 0x000803) },
                { "VLItemGreatswordDragonbone", new FormKey("ListMakerTemplate.esp", 0x00080b) },
                { "VLItemGreatswordDwarven", new FormKey("ListMakerTemplate.esp", 0x000813) },
                { "VLItemGreatswordEbony", new FormKey("ListMakerTemplate.esp", 0x00081b) },
                { "VLItemGreatswordElven", new FormKey("ListMakerTemplate.esp", 0x000823) },
                { "VLItemGreatswordGlass", new FormKey("ListMakerTemplate.esp", 0x00082b) },
                { "VLItemGreatswordIron", new FormKey("ListMakerTemplate.esp", 0x000833) },
                { "VLItemGreatswordNordic", new FormKey("ListMakerTemplate.esp", 0x00083b) },
                { "VLItemGreatswordOrcish", new FormKey("ListMakerTemplate.esp", 0x000843) },
                { "VLItemGreatswordSilver", new FormKey("ListMakerTemplate.esp", 0x00084b) },
                { "VLItemGreatswordStalhrim", new FormKey("ListMakerTemplate.esp", 0x000853) },
                { "VLItemGreatswordSteel", new FormKey("ListMakerTemplate.esp", 0x00085b) },

                { "VLItemMaceDaedric", new FormKey("ListMakerTemplate.esp", 0x000804) },
                { "VLItemMaceDragonbone", new FormKey("ListMakerTemplate.esp", 0x00080c) },
                { "VLItemMaceDwarven", new FormKey("ListMakerTemplate.esp", 0x000814) },
                { "VLItemMaceEbony", new FormKey("ListMakerTemplate.esp", 0x00081c) },
                { "VLItemMaceElven", new FormKey("ListMakerTemplate.esp", 0x000824) },
                { "VLItemMaceGlass", new FormKey("ListMakerTemplate.esp", 0x00082c) },
                { "VLItemMaceIron", new FormKey("ListMakerTemplate.esp", 0x000834) },
                { "VLItemMaceNordic", new FormKey("ListMakerTemplate.esp", 0x00083c) },
                { "VLItemMaceOrcish", new FormKey("ListMakerTemplate.esp", 0x000844) },
                { "VLItemMaceSilver", new FormKey("ListMakerTemplate.esp", 0x00084c) },
                { "VLItemMaceStalhrim", new FormKey("ListMakerTemplate.esp", 0x000854) },
                { "VLItemMaceSteel", new FormKey("ListMakerTemplate.esp", 0x00085c) },

                { "VLItemScimitarDaedric", new FormKey("ListMakerTemplate.esp", 0x000860) },
                { "VLItemScimitarDragonbone", new FormKey("ListMakerTemplate.esp", 0x000861) },
                { "VLItemScimitarDwarven", new FormKey("ListMakerTemplate.esp", 0x000862) },
                { "VLItemScimitarEbony", new FormKey("ListMakerTemplate.esp", 0x000863) },
                { "VLItemScimitarElven", new FormKey("ListMakerTemplate.esp", 0x000864) },
                { "VLItemScimitarGlass", new FormKey("ListMakerTemplate.esp", 0x000865) },
                { "VLItemScimitarIron", new FormKey("ListMakerTemplate.esp", 0x000866) },
                { "VLItemScimitarNordic", new FormKey("ListMakerTemplate.esp", 0x000867) },
                { "VLItemScimitarOrcish", new FormKey("ListMakerTemplate.esp", 0x000868) },
                { "VLItemScimitarSilver", new FormKey("ListMakerTemplate.esp", 0x000869) },
                { "VLItemScimitarStalhrim", new FormKey("ListMakerTemplate.esp", 0x00086a) },
                { "VLItemScimitarSteel", new FormKey("ListMakerTemplate.esp", 0x00086b) },

                { "VLItemSwordDaedric", new FormKey("ListMakerTemplate.esp", 0x000805) },
                { "VLItemSwordDragonbone", new FormKey("ListMakerTemplate.esp", 0x00080d) },
                { "VLItemSwordDwarven", new FormKey("ListMakerTemplate.esp", 0x000815) },
                { "VLItemSwordEbony", new FormKey("ListMakerTemplate.esp", 0x00081d) },
                { "VLItemSwordElven", new FormKey("ListMakerTemplate.esp", 0x000825) },
                { "VLItemSwordGlass", new FormKey("ListMakerTemplate.esp", 0x00082d) },
                { "VLItemSwordIron", new FormKey("ListMakerTemplate.esp", 0x000835) },
                { "VLItemSwordNordic", new FormKey("ListMakerTemplate.esp", 0x00083d) },
                { "VLItemSwordOrcish", new FormKey("ListMakerTemplate.esp", 0x000845) },
                { "VLItemSwordSilver", new FormKey("ListMakerTemplate.esp", 0x00084d) },
                { "VLItemSwordStalhrim", new FormKey("ListMakerTemplate.esp", 0x000855) },
                { "VLItemSwordSteel", new FormKey("ListMakerTemplate.esp", 0x00085d) },

                { "VLItemWarAxeDaedric", new FormKey("ListMakerTemplate.esp", 0x000806) },
                { "VLItemWarAxeDragonbone", new FormKey("ListMakerTemplate.esp", 0x00080e) },
                { "VLItemWarAxeDwarven", new FormKey("ListMakerTemplate.esp", 0x000816) },
                { "VLItemWarAxeEbony", new FormKey("ListMakerTemplate.esp", 0x00081e) },
                { "VLItemWarAxeElven", new FormKey("ListMakerTemplate.esp", 0x000826) },
                { "VLItemWarAxeGlass", new FormKey("ListMakerTemplate.esp", 0x00082e) },
                { "VLItemWarAxeIron", new FormKey("ListMakerTemplate.esp", 0x000836) },
                { "VLItemWarAxeNordic", new FormKey("ListMakerTemplate.esp", 0x00083e) },
                { "VLItemWarAxeOrcish", new FormKey("ListMakerTemplate.esp", 0x000846) },
                { "VLItemWarAxeSilver", new FormKey("ListMakerTemplate.esp", 0x00083e) },
                { "VLItemWarAxeStalhrim", new FormKey("ListMakerTemplate.esp", 0x000856) },
                { "VLItemWarAxeSteel", new FormKey("ListMakerTemplate.esp", 0x00085e) },

                { "VLItemWarhammerDaedric", new FormKey("ListMakerTemplate.esp", 0x000807) },
                { "VLItemWarhammerDragonbone", new FormKey("ListMakerTemplate.esp", 0x00080f) },
                { "VLItemWarhammerDwarven", new FormKey("ListMakerTemplate.esp", 0x000817) },
                { "VLItemWarhammerEbony", new FormKey("ListMakerTemplate.esp", 0x00081f) },
                { "VLItemWarhammerElven", new FormKey("ListMakerTemplate.esp", 0x000827) },
                { "VLItemWarhammerGlass", new FormKey("ListMakerTemplate.esp", 0x00082f) },
                { "VLItemWarhammerIron", new FormKey("ListMakerTemplate.esp", 0x000837) },
                { "VLItemWarhammerNordic", new FormKey("ListMakerTemplate.esp", 0x00083f) },
                { "VLItemWarhammerOrcish", new FormKey("ListMakerTemplate.esp", 0x000847) },
                { "VLItemWarhammerSilver", new FormKey("ListMakerTemplate.esp", 0x00084f) },
                { "VLItemWarhammerStalhrim", new FormKey("ListMakerTemplate.esp", 0x000857) },
                { "VLItemWarhammerSteel", new FormKey("ListMakerTemplate.esp", 0x00085f) },
            };

            var weaponMap = new Dictionary<string, Dictionary<string, FormKey>>()
            {
                ["Daedric"] = new Dictionary<string, FormKey>()
                {
                    { "Battleaxe",  new FormKey("Skyrim.esm", 0x0139b4) },
                    { "Bow",        new FormKey("Skyrim.esm", 0x0139b5) },
                    { "Dagger",     new FormKey("Skyrim.esm", 0x0139b6) },
                    { "Greatsword", new FormKey("Skyrim.esm", 0x0139b7) },
                    { "Mace",       new FormKey("Skyrim.esm", 0x0139b8) },
                    { "Scimitar",   FormKey.Null                        },
                    { "Sword",      new FormKey("Skyrim.esm", 0x0139b9) },
                    { "WarAxe",     new FormKey("Skyrim.esm", 0x0139b3) },
                    { "Warhammer",  new FormKey("Skyrim.esm", 0x0139ba) },
                },

                ["Dragonbone"] = new Dictionary<string, FormKey>()
                {
                    { "Battleaxe",  new FormKey("Dawnguard.esm", 0x014fc3) },
                    { "Bow",        new FormKey("Dawnguard.esm", 0x0176f1) },
                    { "Dagger",     new FormKey("Dawnguard.esm", 0x014fcb) },
                    { "Greatsword", new FormKey("Dawnguard.esm", 0x014fcc) },
                    { "Mace",       new FormKey("Dawnguard.esm", 0x014fcd) },
                    { "Scimitar",   FormKey.Null                           },
                    { "Sword",      new FormKey("Dawnguard.esm", 0x014fce) },
                    { "WarAxe",     new FormKey("Dawnguard.esm", 0x014fcf) },
                    { "Warhammer",  new FormKey("Dawnguard.esm", 0x014fd0) },
                },

                ["Dwarven"] = new Dictionary<string, FormKey>()
                {
                    { "Battleaxe",  new FormKey("Skyrim.esm", 0x013994) },
                    { "Bow",        new FormKey("Skyrim.esm", 0x013995) },
                    { "Dagger",     new FormKey("Skyrim.esm", 0x013996) },
                    { "Greatsword", new FormKey("Skyrim.esm", 0x013997) },
                    { "Mace",       new FormKey("Skyrim.esm", 0x013998) },
                    { "Scimitar",   FormKey.Null                        },
                    { "Sword",      new FormKey("Skyrim.esm", 0x013999) },
                    { "WarAxe",     new FormKey("Skyrim.esm", 0x013993) },
                    { "Warhammer",  new FormKey("Skyrim.esm", 0x01399a) },
                },

                ["Ebony"] = new Dictionary<string, FormKey>()
                {
                    { "Battleaxe",  new FormKey("Skyrim.esm", 0x0139ac) },
                    { "Bow",        new FormKey("Skyrim.esm", 0x0139ad) },
                    { "Dagger",     new FormKey("Skyrim.esm", 0x0139ae) },
                    { "Greatsword", new FormKey("Skyrim.esm", 0x0139af) },
                    { "Mace",       new FormKey("Skyrim.esm", 0x0139b0) },
                    { "Scimitar",   FormKey.Null                        },
                    { "Sword",      new FormKey("Skyrim.esm", 0x0139b1) },
                    { "WarAxe",     new FormKey("Skyrim.esm", 0x0139ab) },
                    { "Warhammer",  new FormKey("Skyrim.esm", 0x0139b2) },
                },

                ["Elven"] = new Dictionary<string, FormKey>()
                {
                    { "Battleaxe",  new FormKey("Skyrim.esm", 0x01399c) },
                    { "Bow",        new FormKey("Skyrim.esm", 0x01399d) },
                    { "Dagger",     new FormKey("Skyrim.esm", 0x01399e) },
                    { "Greatsword", new FormKey("Skyrim.esm", 0x01399f) },
                    { "Mace",       new FormKey("Skyrim.esm", 0x0139a0) },
                    { "Scimitar",   FormKey.Null                        },
                    { "Sword",      new FormKey("Skyrim.esm", 0x0139a1) },
                    { "WarAxe",     new FormKey("Skyrim.esm", 0x01399b) },
                    { "Warhammer",  new FormKey("Skyrim.esm", 0x0139a2) },
                },

                ["Glass"] = new Dictionary<string, FormKey>()
                {
                    { "Battleaxe",  new FormKey("Skyrim.esm", 0x0139a4) },
                    { "Bow",        new FormKey("Skyrim.esm", 0x0139a5) },
                    { "Dagger",     new FormKey("Skyrim.esm", 0x0139a6) },
                    { "Greatsword", new FormKey("Skyrim.esm", 0x0139a7) },
                    { "Mace",       new FormKey("Skyrim.esm", 0x0139a8) },
                    { "Scimitar",   FormKey.Null                        },
                    { "Sword",      new FormKey("Skyrim.esm", 0x0139a9) },
                    { "WarAxe",     new FormKey("Skyrim.esm", 0x0139a3) },
                    { "Warhammer",  new FormKey("Skyrim.esm", 0x0139aa) },
                },

                ["Iron"] = new Dictionary<string, FormKey>()
                {
                    { "Battleaxe",  new FormKey("Skyrim.esm", 0x013980) },
                    { "Bow",        new FormKey("Skyrim.esm", 0x03b562) },
                    { "Dagger",     new FormKey("Skyrim.esm", 0x01397e) },
                    { "Greatsword", new FormKey("Skyrim.esm", 0x01359d) },
                    { "Mace",       new FormKey("Skyrim.esm", 0x013982) },
                    { "Scimitar",   FormKey.Null                        },
                    { "Sword",      new FormKey("Skyrim.esm", 0x012eb7) },
                    { "WarAxe",     new FormKey("Skyrim.esm", 0x013790) },
                    { "Warhammer",  new FormKey("Skyrim.esm", 0x013981) },
                },

                ["Nordic"] = new Dictionary<string, FormKey>()
                {
                    { "Battleaxe",  new FormKey("Dragonborn.esm", 0x01cdad) },
                    { "Bow",        new FormKey("Dragonborn.esm", 0x026232) },
                    { "Dagger",     new FormKey("Dragonborn.esm", 0x01cdae) },
                    { "Greatsword", new FormKey("Dragonborn.esm", 0x01cdaf) },
                    { "Mace",       new FormKey("Dragonborn.esm", 0x01cdb0) },
                    { "Scimitar",   FormKey.Null                            },
                    { "Sword",      new FormKey("Dragonborn.esm", 0x01cdb1) },
                    { "WarAxe",     new FormKey("Dragonborn.esm", 0x01cdb2) },
                    { "Warhammer",  new FormKey("Dragonborn.esm", 0x01cdb3) },
                },

                ["Orcish"] = new Dictionary<string, FormKey>()
                {
                    { "Battleaxe",  new FormKey("Skyrim.esm", 0x01398c) },
                    { "Bow",        new FormKey("Skyrim.esm", 0x01398d) },
                    { "Dagger",     new FormKey("Skyrim.esm", 0x01398e) },
                    { "Greatsword", new FormKey("Skyrim.esm", 0x01398f) },
                    { "Mace",       new FormKey("Skyrim.esm", 0x013990) },
                    { "Scimitar",   FormKey.Null                        },
                    { "Sword",      new FormKey("Skyrim.esm", 0x013991) },
                    { "WarAxe",     new FormKey("Skyrim.esm", 0x01398b) },
                    { "Warhammer",  new FormKey("Skyrim.esm", 0x013992) },
                },

                ["Silver"] = new Dictionary<string, FormKey>()
                {
                    { "Battleaxe",  FormKey.Null                         },
                    { "Bow",        FormKey.Null                         },
                    { "Dagger",     FormKey.Null                         },
                    { "Greatsword", new FormKey("Skyrim.esm", 0x10c6fb)  },
                    { "Mace",       FormKey.Null                         },
                    { "Scimitar",   FormKey.Null                         },
                    { "Sword",      new FormKey("Skyrim.esm", 0x10aa19)  },
                    { "WarAxe",     FormKey.Null                         },
                    { "Warhammer",  FormKey.Null                         },
                },

                ["Stalhrim"] = new Dictionary<string, FormKey>()
                {
                    { "Battleaxe",  new FormKey("Dragonborn.esm", 0x01cdb4) },
                    { "Bow",        new FormKey("Dragonborn.esm", 0x026231) },
                    { "Dagger",     new FormKey("Dragonborn.esm", 0x01cdb5) },
                    { "Greatsword", new FormKey("Dragonborn.esm", 0x01cdb6) },
                    { "Mace",       new FormKey("Dragonborn.esm", 0x01cdb7) },
                    { "Scimitar",   FormKey.Null                            },
                    { "Sword",      new FormKey("Dragonborn.esm", 0x01cdb8) },
                    { "WarAxe",     new FormKey("Dragonborn.esm", 0x01cdb9) },
                    { "Warhammer",  new FormKey("Dragonborn.esm", 0x01cdba) },
                },

                ["Steel"] = new Dictionary<string, FormKey>()
                {
                    { "Battleaxe",  new FormKey("Skyrim.esm", 0x013984) },
                    { "Bow",        new FormKey("Skyrim.esm", 0x013985) },
                    { "Dagger",     new FormKey("Skyrim.esm", 0x013986) },
                    { "Greatsword", new FormKey("Skyrim.esm", 0x013987) },
                    { "Mace",       new FormKey("Skyrim.esm", 0x013988) },
                    { "Scimitar",   FormKey.Null                        },
                    { "Sword",      new FormKey("Skyrim.esm", 0x013989) },
                    { "WarAxe",     new FormKey("Skyrim.esm", 0x013983) },
                    { "Warhammer",  new FormKey("Skyrim.esm", 0x01398a) },
                }
            };

            string[] materials =
            {
                "Daedric",
                "Dragonbone",
                "Dwarven",
                "Ebony",
                "Elven",
                "Glass",
                "Iron",
                "Nordic",
                "Orcish",
                "Silver",
                "Stalhrim",
                "Steel"
            };

            string[] weaponTypes =
            {
                "Battleaxe",
                "Bow",
                "Dagger",
                "Greatsword",
                "Mace",
                "Scimitar",
                "Sword",
                "WarAxe",
                "Warhammer"
            };

            var lvliMap = new Dictionary<FormKey, FormKey>(); ;

            foreach (var material in materials)
            {
                foreach (var weaponType in weaponTypes)
                {
                    var key = weaponMap[material][weaponType];

                    if (key != FormKey.Null)
                    {
                        lvliMap[key] = lists["VLItem" + weaponType + material];
                    }
                }
            }

            return lvliMap;
        }
    }
}
