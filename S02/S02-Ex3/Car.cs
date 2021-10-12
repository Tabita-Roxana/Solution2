
using System.Drawing;

namespace S02_Ex3
{
    public class Car
    {
        public string Color { get; set; }
        public double EngineSize { get; set; }
        public double FuelEconomy { get; set; }
        
        public bool IsManualShift { get; set; }

        public Car(string color, double engineSize, double fuelEconomy, bool isManualShift)
        {
            Color = color;
            EngineSize = engineSize;
            FuelEconomy = fuelEconomy;
            IsManualShift = isManualShift;
        }

        public override string ToString()
        {
            return Color +" "+ EngineSize + " "+ FuelEconomy +" "+ IsManualShift;
        }
        
        
    }
}