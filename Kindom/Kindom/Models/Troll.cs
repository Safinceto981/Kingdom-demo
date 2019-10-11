using Kindom.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kindom.Models
{
    class Troll : ICharacter

    {
        public override void Fight()
        {
            Console.WriteLine("I will fight like a troll");
        }

        
    }
}
