using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Collectable : Displayable // class Collectable implements Displayable
    {

        // Property of type CollectionBoard
        public CollectionBoard Board { get; set; }

        public string Description { get; set; }

        public virtual void Display() { }

        public virtual void AddMe(List<Collectable> collectables) {}
    }
}
