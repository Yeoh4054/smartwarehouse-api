using Microsoft.AspNetCore.Mvc;
using SmartWarehouse.Api.Models;

namespace SmartWarehouse.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatusController : ControllerBase
    {
        private static readonly List<DeviceStatus> _devices = new()
        {
            new DeviceStatus { DeviceId = "ASRS-01", Status = "Running", LastUpdated = DateTime.UtcNow },
            new DeviceStatus { DeviceId = "CONV-02", Status = "Idle", LastUpdated = DateTime.UtcNow }
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_devices);
        }

        [HttpPost]
        public IActionResult Update(DeviceStatus update)
        {
            var device = _devices.FirstOrDefault(d => d.DeviceId == update.DeviceId);

            if (device == null)
            {
                _devices.Add(update);
            }
            else
            {
                device.Status = update.Status;
                device.LastUpdated = DateTime.UtcNow;
            }

            return Ok(update);
        }
    }
}
