using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Diamond : Treasure
    {
        public Diamond(string desc, int score)
        {
            base.Description = desc;
            base.Score = score;
        }

        public override void Display()
        {
          Console.WriteLine($"Diamond {base.Description} is displayed");
        }
    }
}
