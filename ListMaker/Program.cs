using System;
using System.Collections.Generic;
using System.Linq;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Synthesis;
using Mutagen.Bethesda.Skyrim;

namespace ListMaker
{
    public static class MyExtensions
    {
        public static bool ContainsInsensitive(this string str, string rhs)
        {
            return str.Contains(rhs, StringComparison.OrdinalIgnoreCase);
        }

        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T>? e)
        {
            if (e == null) return Enumerable.Empty<T>();
            return e;
        }
    }

    public class Program
    {
        public static int Main(string[] args)
        {
            return SynthesisPipeline.Instance.Patch<ISkyrimMod, ISkyrimModGetter>(
                args: args,
                patcher: RunPatch,
                new UserPreferences()
                {
                    ActionsForEmptyArgs = new RunDefaultPatcher()
                    {
                        IdentifyingModKey = "ListMaker.esp",
                        TargetRelease = GameRelease.SkyrimSE
                    }
                }
            );
        }

        public static void RunPatch(SynthesisState<ISkyrimMod, ISkyrimModGetter> state)
        {
            var lvliMap = LVLIMap.CreateMap();

            foreach (var leveledList in state.LoadOrder.PriorityOrder.WinningOverrides<ILeveledItemGetter>())
            {
                if (lvliMap.ContainsValue(leveledList.FormKey)) continue;

                if (leveledList.Entries == null) continue;

                var modifiedList = state.PatchMod.LeveledItems.GetOrAddAsOverride(leveledList);

                foreach (var entry in modifiedList.Entries.EmptyIfNull())
                {
                    if (entry.Data == null) continue;
                    if (!lvliMap.ContainsKey(entry.Data.Reference.FormKey)) continue;
                    entry.Data.Reference = lvliMap[entry.Data.Reference.FormKey];
                }
            }

            foreach (var npc in state.LoadOrder.PriorityOrder.WinningOverrides<INpcGetter>())
            {
                if (npc.Items == null) continue;

                var modifiedNpc = state.PatchMod.Npcs.GetOrAddAsOverride(npc);

                foreach (var entry in modifiedNpc.Items.EmptyIfNull())
                {
                    if (!lvliMap.ContainsKey(entry.Item.Item.FormKey)) continue;
                    entry.Item.Item = lvliMap[entry.Item.Item.FormKey];
                }
            }
        }
    }
}
