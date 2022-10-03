using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    /// <summary>
    /// 英雄類別
    /// </summary>
    public class Hero
    {
        /// <summary>
        /// 血量值
        /// </summary>
        public int HP = 50;
        /// <summary>
        /// 魔力值
        /// </summary>
        public int MP = 50;
        /// <summary>
        /// 力量值
        /// </summary>
        public int Strength = 10;
        /// <summary>
        /// 智慧值
        /// </summary>
        public int Wisdom = 15;
        /// <summary>
        /// 防禦值
        /// </summary>
        public int Defense = 5;
        /// <summary>
        /// 技能
        /// </summary>
        public Skill Skill;
        /// <summary>
        /// 名字
        /// </summary>
        public string Name;

        public Hero(string name, Skill skill)
        {
            this.Name = name;
            this.Skill = skill;
        }

        /// <summary>
        /// 攻擊
        /// </summary>
        public void Attack(Hero targetHero)
        {
            int injury = targetHero.Skill.Attack(this, targetHero);
        }

        public void LoseHP(int value)
        {
            this.HP -= value;
        }

        public void LoseMP(int value)
        {
            this.MP -= value;
        }

        public bool IsAlive()
        {
            var isAlive = HP > 0;

            if (!isAlive)
                Console.WriteLine($"{this.Name} HP = 0，已死亡!");

            return HP > 0;
        }
    }
}