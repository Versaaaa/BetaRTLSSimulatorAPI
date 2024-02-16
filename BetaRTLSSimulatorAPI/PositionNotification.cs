namespace BetaRTLSSimulatorAPI
{
    public class PositionNotification
    {

        public int ForkliftId { get => _forkliftId; set => _forkliftId = value; }
        public string PartnerKeY { get => _partnerKeY; set => _partnerKeY = value; }
        public ForkliftPosition Position { get => _position; set => _position = value; }

        private int _forkliftId;
        private string _partnerKeY; 
        private ForkliftPosition _position;

        public PositionNotification() 
        {
            ForkliftId = 0;
            PartnerKeY = "lorem ipsum";
            Position = new ForkliftPosition();
        }

        public void Copy(PositionNotification target)
        {
            ForkliftId = target.ForkliftId;
            PartnerKeY = target.PartnerKeY;

            Position.Copy(target.Position);
        }

    }
}
