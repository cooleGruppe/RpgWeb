using RPG.Classes;
using RPG.Interfaces;

namespace RPG
{
    public class Game
    {
        public Game(Player player)
        {
            Player = player;
        }
        public Player Player { get; set; }

        public void Attack(ICharacter enemy)
        {
            Player.AttackEnemy(enemy);
        }
    }
}