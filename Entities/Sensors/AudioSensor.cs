using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation.Models
{
    public class AudioSensor : Sensor
    {
        public AudioSensor() : base()
        {
            Name = "Audio sensor";
            TypeSensor = "Audio sensor";
        }       
    }
}
