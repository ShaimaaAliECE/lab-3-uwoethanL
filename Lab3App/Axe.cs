using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Axe : Tool
    {
        public Axe(string desc)
        {
            base.Description = desc;
        }

        public override void AddMe(List<Collectable> collectables)
        {
            DoAction();
        }

        public override void Display()
        {
           Console.WriteLine($"Axe {base.Description} is displayed");
        }

        public override void DoAction()
        {
            base.DoAction();
            Console.WriteLine("Axe is used");
        }
    }
}
