using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class MagicWand : Tool
    {
        public MagicWand(string desc) { 
            base.Description = desc;
        }

        public override void Display()
        {
            Console.WriteLine($"MagicWand {base.Description} is displayed");
        }

        public override void DoAction()
        {
            base.DoAction();
            Console.WriteLine("MagicWand is used");
        }

        public override void AddMe(List<Collectable> collectables)
        {
            DoAction();
        }
    }
}
