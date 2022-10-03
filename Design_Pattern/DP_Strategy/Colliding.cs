using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    public class Colliding : Skill
    {

        /// <summary>
        /// 衝撞攻擊，所受攻擊為 力量 - 防禦
        /// </summary>
        /// <param name="attackingHero"></param>
        /// <param name="attackedHero"></param>
        /// <returns>傷害值</returns>
        public int Attack(Hero attackingHero, Hero attackedHero)
        {
            var injury = attackingHero.Strength - attackedHero.Defense;
            attackedHero.LoseHP(injury);
            return injury;
        }

        public string ToPrintOut()
        {
            return "衝撞攻擊";
        }
    }
}