using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Battle
    {
        private Hero[] heros = new Hero[2];

        public Battle(Hero hero1, Hero hero2)
        {
            heros[0] = hero1;
            heros[1] = hero2;
        }

        public void Start()
        {
            Console.WriteLine("==============================================================================================================");
            Array.ForEach(heros, (hero) =>
            {
                Console.WriteLine($"英雄資訊:{hero.Name}, HP={hero.HP}, MP={hero.MP}, STR={hero.Strength}, DEF={hero.Defense}, WIS={hero.Wisdom}");
            });
            Console.WriteLine("==============================================================================================================");


            int turn = 1;
            int round = 1;
            while (!IsGameOver())
            {
                turn = turn == 0 ? 1 : 0;
                ProcessHeroTurn(turn, round);
                round++;
            }            
        }

        private bool IsGameOver()
        {
            return !heros[0].IsAlive() || !heros[1].IsAlive();
        }

        private void ProcessHeroTurn(int heroIndex, int round)
        {
            Hero attackingHero = heros[heroIndex];
            Hero attackedHero = heros[heroIndex == 0 ? 1 : 0];

            Console.WriteLine($"第{round}回合) 輪到 {attackingHero.Name} 攻擊，招式：{attackingHero.Skill.ToPrintOut()}");
            attackingHero.Attack(attackedHero);
        }
    }
}
