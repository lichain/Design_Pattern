using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    public class WaterBall : Skill
    {
        /// <summary>
        /// 水球攻擊，所受傷害為 智力*2
        /// </summary>
        /// <param name="attackingHero"></param>
        /// <param name="attackedHero"></param>
        /// <returns>傷害值</returns>
        public int Attack(Hero attackingHero, Hero attackedHero)
        {
            attackingHero.LoseMP(5);
            var injury = attackingHero.Wisdom * 2;
            attackedHero.LoseHP(injury);
            return injury;
        }

        public string ToPrintOut()
        {
            return "水球攻擊";
        }
    }
}