public class Vehicle : IGasVehicle
{
    public int gas { get; set; }

    public Vehicle(int initialGas)
    {
        gas = initialGas;
    }
}