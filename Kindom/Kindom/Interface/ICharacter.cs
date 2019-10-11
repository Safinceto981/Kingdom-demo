using System;
using System.Collections.Generic;
using System.Text;

namespace Kindom.Interface
{
    public abstract class ICharacter
    {
        public abstract void Fight();

        public void WashMySocks()
        {
            Console.WriteLine("I wash them");
        }
    }
}
