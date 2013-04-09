using System.Collections.Generic;

namespace Manicomio.SwosPlayerFinder.Core
{
    public class Criteria
    {
        public Criteria()
        {
            Name = string.Empty;
            PassingFrom = 1;
            PassingTo = 8;
            ShootingFrom = 1;
            ShootingTo = 8;
            HeadingFrom = 1;
            HeadingTo = 8;
            TacklingFrom = 1;
            TacklingTo = 8;
            ControlFrom = 1;
            ControlTo = 8;
            SpeedFrom = 1;
            SpeedTo = 8;
            FinishingFrom = 1;
            FinishingTo = 8;

            ValueFrom = 0;
            ValueTo = 16000;

            Positions = new List<Position>();
        }

        public string Name { get; set; }

        public string TeamName { get; set; }

        public int? Passing { get; set; }

        public int PassingFrom { get; set; }
        public int PassingTo { get; set; }

        public int ShootingFrom { get; set; }
        public int ShootingTo { get; set; }

        public int HeadingFrom { get; set; }
        public int HeadingTo { get; set; }

        public int TacklingFrom { get; set; }
        public int TacklingTo { get; set; }

        public int ControlFrom { get; set; }
        public int ControlTo { get; set; }

        public int SpeedFrom { get; set; }
        public int SpeedTo { get; set; }

        public int FinishingFrom { get; set; }
        public int FinishingTo { get; set; }

        public int ValueFrom { get; set; }
        public int ValueTo { get; set; }

        public List<Position> Positions { get; set; }
    }
}