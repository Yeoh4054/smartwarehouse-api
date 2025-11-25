namespace SmartWarehouse.Api.Models
{
    public class DeviceStatus
    {
        public string DeviceId { get; set; }
        public string Status { get; set; } // Running / Idle / Error
        public DateTime LastUpdated { get; set; }
    }
}
