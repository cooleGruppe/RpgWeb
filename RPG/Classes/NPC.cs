using RPG.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public class NPC : ICharacter
    {
        public NPC(string name) 
        {
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Attack { get; set; } = 500;
        public int HP { get; set; } = 1000;

        public void AttackEnemy(ICharacter enemy)
        {
            enemy.HP -= Attack;
        }
    }
}
