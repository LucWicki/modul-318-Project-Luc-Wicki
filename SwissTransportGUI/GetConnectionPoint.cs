using SwissTransport.Models;

namespace SwissTransportGUI
{
    internal class GetConnectionPoint : ConnectionPoint
    {
        private DateTime dateTime;

        public GetConnectionPoint(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }
    }
}