namespace BatteryChecker
{
    public class BatteryDisplayBiz
    {
        private readonly IBatteryService _service;

        public BatteryDisplayBiz(IBatteryService service)
        {
            _service = service;
        }

        public string Message
        {
            get
            {
                int batteryPercent = _service.GetBatteryPercent();
                return
                    batteryPercent < 0 ? "Simulator" :
                    batteryPercent <= 10 ? "Low" :
                    batteryPercent >= 80 ? "High" :
                    "Normal";
            }
        }
    }
}

