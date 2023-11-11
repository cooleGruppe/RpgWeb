using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Interfaces
{
    public interface ICharacter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Attack { get; set; }
        public int HP { get; set; }

    }
}
