
namespace HW._07.Task2.AssemblyOne
{
    internal class SportBike : Motorcycle
    {
        SportBike bike = new SportBike();
        public void StartEngines()
        {

            bike.FixBike();

            // protected
            bike.ChangeColor("red");

            // protected internal
            bike.CheckFixes();

            // private method
            // bike.StartEngine("300");

            // private protected
            bike.IsFixed();
        }
    }
}