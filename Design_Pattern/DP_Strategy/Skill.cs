using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    public interface Skill
    {

        /// <summary>
        /// 攻擊
        /// </summary>
        int Attack(Hero attackingHero, Hero attackedHero);

        string ToPrintOut();
    }
}