namespace BetaRTLSSimulatorAPI
{
    public class PositionInformation
    {

        public double x 
        { 
            get { return _x; }
            set { _x = value; }
        }
        public double y
        {
            get { return _y; }
            set { _y = value; }
        }
        public double rotation
        {
            get { return _rotation; }
            set { _rotation = value; }
        }
        public double forkHeight
        {
            get { return _forkHeight; }
            set { _forkHeight = value; }
        }

        double _x;
        double _y;
        double _rotation;
        double _forkHeight;

        public PositionInformation()
        {
            _x = 0;
            _y = 0;
            _rotation = 0;
            _forkHeight = 0;
        }

        public void Copy(PositionInformation target)
        {
            _x = target._x;
            _y = target._y;
            _rotation = target._rotation;
            _forkHeight = target._forkHeight;
        }
    }
}
