using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParser
{
    //Contains the drone commands
    public class Command
    {
        private String Direction { get; set; }
        private int Distance { get; set; }

        public Command(String Direction, int Distance) {
            this.Direction = Direction;
            this.Distance = Distance;
        }

        public void toString() {
            Console.WriteLine(String.Format("Direction:{0}, Distance{1}", Direction, Distance));
        }
    }
}
