using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin : Treasure
    {
        public int Value { get; private set; }

        public void UpdateTotalValue()
        {
            base.Board.TotalValue += Value;
            Console.WriteLine($"Total value is updated to: {base.Board.TotalValue}");

        }

        public override void AddMe(List<Collectable> collectables) {
            base.AddMe(collectables);
            UpdateTotalValue();
        }

        public override void Display()
        {
            Console.WriteLine($"Coin {base.Description} is displayed");
        }


        public Coin(string desc, int score, int value) {
            this.Value = value;
            base.Score = score;
            base.Description = desc;
        }


    }
}
