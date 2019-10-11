using Kindom.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kindom
{
    class King : ICharacter
    {
        
        public override void Fight()
        {
            Console.WriteLine("I will fight like a king");
        }
    }
}
