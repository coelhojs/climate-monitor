using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.Hosting;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using System.Text.Unicode;

namespace ClimateMonitor.Services
{
    public class DeviceFirmwareValidatorService
    {
        public bool ValidateDeviceFirmware(string deviceFirmware)
        => Regex.IsMatch(deviceFirmware, "^(0|[1-9]\\d*)\\.(0|[1-9]\\d*)\\.(0|[1-9]\\d*)(?:-((?:0|[1-9]\\d*|\\d*[a-zA-Z-][0-9a-zA-Z-]*)(?:\\.(?:0|[1-9]\\d*|\\d*[a-zA-Z-][0-9a-zA-Z-]*))*))?(?:\\+([0-9a-zA-Z-]+(?:\\.[0-9a-zA-Z-]+)*))?$");
    }
}



