using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Treasure : Collectable
    {
        public int Score { get; set; }

        public override void AddMe(List<Collectable> collectables) {
            collectables.Add(this);
            UpdateTotalScore();
        }

        public virtual void UpdateTotalScore() {
            base.Board.TotalScore += Score;
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
            Console.WriteLine($"Total score is updated to: {base.Board.TotalScore}");
        }

        public override void Display() {  }
    }
}
