﻿using System.Threading.Tasks;
using AEAssist.Define;
using AEAssist.Helper;
using ff14bot;
using ff14bot.Managers;

namespace AEAssist.AI.Scholar.Ability
{
    public class ScholarAbility_Aetherflow : IAIHandler
    {
        uint spell;
        static public uint GetSpell()
        {
            if (SpellsDefine.Aetherflow.IsReady() && ActionResourceManager.Scholar.Aetherflow == 0)//以太超流判定
                if (SpellsDefine.Aetherflow.IsUnlock())
                    return SpellsDefine.Aetherflow;
            return 0;
        }
        public int Check(SpellEntity lastSpell)
        {
            spell = GetSpell();
            
            if (!spell.IsReady())
                return -1;
            //LogHelper.Debug("NO10:" + spell.ToString());
            return 0;
        }

        public async Task<SpellEntity> Run()
        {
            if (await spell.DoAbility()) return spell.GetSpellEntity();

            return null;
        }
    }

}