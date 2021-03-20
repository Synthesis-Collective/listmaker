using System;
using System.Collections.Generic;
using System.Linq;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Synthesis;
using Mutagen.Bethesda.Skyrim;
using System.Threading.Tasks;

namespace ListMaker
{
    public class Program
    {
        public static Task<int> Main(string[] args)
        {
            return SynthesisPipeline.Instance
                .SetTypicalOpen(GameRelease.SkyrimSE, "ListMaker.esp")
                .AddPatch<ISkyrimMod, ISkyrimModGetter>(RunPatch)
                .Run(args);
        }

        public static void RunPatch(IPatcherState<ISkyrimMod, ISkyrimModGetter> state)
        {
            var lvliMap = LVLIMap.CreateMap();

            foreach (var leveledList in state.LoadOrder.PriorityOrder.LeveledItem().WinningOverrides())
            {
                if (lvliMap.ContainsValue(leveledList.FormKey)) continue;

                if (leveledList.Entries == null) continue;

                for (var i = 0; i < leveledList.Entries.Count; i++)
                {
                    var entry = leveledList.Entries[i];
                    if (entry.Data == null) continue;
                    if (!lvliMap.ContainsKey(entry.Data.Reference.FormKey)) continue;

                    var modifiedList = state.PatchMod.LeveledItems.GetOrAddAsOverride(leveledList);
                    modifiedList.Entries![i].Data!.Reference.SetTo(lvliMap[entry.Data.Reference.FormKey]);
                }
            }

            foreach (var npc in state.LoadOrder.PriorityOrder.Npc().WinningOverrides())
            {
                if (npc.Items == null) continue;

                for (var i = 0; i < npc.Items.Count; i++)
                {
                    var entry = npc.Items[i];
                    if (!lvliMap.ContainsKey(entry.Item.Item.FormKey)) continue;
                    var modifiedNpc = state.PatchMod.Npcs.GetOrAddAsOverride(npc);
                    modifiedNpc.Items![i].Item.Item.SetTo(lvliMap[entry.Item.Item.FormKey]);
                }
            }
        }
    }
}
