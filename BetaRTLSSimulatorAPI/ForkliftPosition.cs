namespace BetaRTLSSimulatorAPI
{
    public class ForkliftPosition
    {

        public bool Valid { get => _valid; set => _valid = value; }

        public double X { get => _x; set => _x = value; }
        public double Y { get => _y; set => _y = value; }

        public double Orientation { get => _orientation; set => _orientation = value; }

        public bool Loaded { get => _loaded; set => _loaded = value; }
        public double ForkHeight { get => _forkHeight; set => _forkHeight = value; }
        public double Distance { get => _distance; set => _distance = value; }

        
        private bool _valid;
        
        private double _x;
        private double _y;
        
        private double _orientation;
        
        private bool _loaded;
        private double _forkHeight;
        private double _distance;
        

        public ForkliftPosition()
        {
            Valid = true;

            X = 0;
            Y = 0;
            
            Orientation = 0;
            
            Loaded = false;
            ForkHeight = 0;
            Distance = 0;
        }

        public void Copy(ForkliftPosition target)
        {
            Valid = target.Valid;
            
            X = target.X;
            Y = target.Y;
            
            Orientation = target.Orientation;

            Loaded = target.Loaded;
            ForkHeight = target.ForkHeight;
            Distance = target.Distance;

        }
    }
}
