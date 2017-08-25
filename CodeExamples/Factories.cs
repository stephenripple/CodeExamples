
namespace CodeExamples
{

    //
    public class Factories
    {
        public enum VehicleProcessorType { Boat, Car, Truck };
        private static CodeExamples.Factory.GenericFactory<VehicleProcessorType, IVehicleProcessor> _vehicleFactory = null;

        #region "Constructors"
        private Factories(VehicleProcessorType vehicleType)
        {
            Create(vehicleType);
        }
        #endregion

        public static IVehicleProcessor Create(VehicleProcessorType vehicleType)
        {
            if (_vehicleFactory == null)
                InitializeVehicleFactory();

            return _vehicleFactory.Create(vehicleType);
        }

        private static void InitializeVehicleFactory()
        {
            _vehicleFactory = new Factory.GenericFactory<VehicleProcessorType, IVehicleProcessor>();

            _vehicleFactory.Add<BoatVehicleProcessor>(VehicleProcessorType.Boat);
            _vehicleFactory.Add<CarVehicleProcessor>(VehicleProcessorType.Car);
            _vehicleFactory.Add<TruckVehicleProcessor>(VehicleProcessorType.Truck);
        }
    }

    #region "Vehicle Processors
    //Interface that all vehicle processor classes will inherit from
    public interface IVehicleProcessor
    {
        bool StartVehicle(string key);
    }
    public class BoatVehicleProcessor : IVehicleProcessor
    {
        public bool StartVehicle(string ignitionKey)
        {
            return ignitionKey.ToLower().Contains("boat") ? true : false;
        }
    }

    public class CarVehicleProcessor : IVehicleProcessor
    {
        public bool StartVehicle(string ignitionKey)
        {
            return ignitionKey.ToLower().Contains("car") ? true : false;
        }
    }

    public class TruckVehicleProcessor : IVehicleProcessor
    {
        public bool StartVehicle(string ignitionKey)
        {
            return ignitionKey.ToLower().Contains("truck") ? true : false;
        }
    }
    #endregion
}
