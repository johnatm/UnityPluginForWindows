using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityPluginForWindowsPhone
{
    public class SensorValuesHelp
    {

        

        public static void Start()
        {
            //sensor = SensorTag.SelectedSensor;
            //StartSenser();
        }

        private static void StartSenser()
        {
            //ShowMessage("Connecting...");
            //try
            //{
            //    if (sensor.Version == 1)
            //    {
            //        await sensor.Accelerometer.StartReading();
            //        sensor.Accelerometer.AccelerometerMeasurementValueChanged += OnAccelerometerMeasurementValueChanged;
            //        period = await sensor.Accelerometer.GetPeriod();
            //    }
            //    else if (sensor.Version == 2)
            //    {
            //        await sensor.Movement.StartReading(MovementFlags.Accel2G | MovementFlags.AccelX | MovementFlags.AccelY | MovementFlags.AccelZ);
            //        sensor.Movement.MovementMeasurementValueChanged += OnMovementMeasurementValueChanged;
            //        period = await sensor.Movement.GetPeriod();
            //    }
            //    //SetSensitivity(period.Value);
            //    ShowMessage("");
            //}
            //catch (Exception ex)
            //{
            //    ShowMessage(ex.Message);
            //}
        }

        private static void ShowMessage(string v)
        {
           // status = v;
        }

        double GetSensitivity()
        {
            // Slider goes from 100 to 2550 for the "period" where 2550 is the slowest and therefore the least sensitive.
            // Therefore we need to reverse the slider values in order for the slider to control sensitivity.
            //return 2250;
            return 0;

        }

        void SetSensitivity(double value)
        {
            // Slider is reversed.  See GetSensitivity.

        }



        public static void StopSensor()
        {

            //if (sensor.Accelerometer != null)
            //{
            //    sensor.Accelerometer.AccelerometerMeasurementValueChanged -= OnAccelerometerMeasurementValueChanged;
            //}
            //else if (sensor.Movement != null)
            //{
            //    sensor.Movement.MovementMeasurementValueChanged -= OnMovementMeasurementValueChanged;
            //}
            //await sensor.Accelerometer.StopReading();
        }

        

       

        public static double GetX()
        {
            //if (measurement != null)
            //{
            //    return measurement.X;
            //}
            return 0;
        }

        public static double GetY()
        {
            //if (measurement != null)
            //{
            //    return measurement.Y;
            //}
            return 0;
        }

        public static double GetZ()
        {
        //    if (measurement != null)
        //    {
        //        return measurement.Y;
        //    }
            return 0;
        }
    }
}
