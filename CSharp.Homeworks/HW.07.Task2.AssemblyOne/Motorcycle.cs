//Необходимо показать все возможные комбинации модификаторов доступа для данного 
//типа(класса) и его элементов (вот этих: константы, поля, свойства, методы). Пожалуй, здесь Вы 
//можете размножать поля и методы, добавив к имени слова модификаторов доступа – к примеру,
//MaxSpeedPrivate, MaxSpeedInternal, etc

namespace HW._07.Task2.AssemblyOne
{
   internal class Motorcycle
    {
        const int maxSpeed = 350;
        readonly string vinNumber = "HGD57Kij8987";
        const string model = "Kawasaki ZX-14R";
        string plateNumber = "LT KZ 345";
        string color = "purple";
        readonly int year = 2022;

        // Элемент доступен без ограничений         
        public void StartEngine() { }

        // Элемент доступен только в том типе, в котором определен.
        private void StartEngine(String text) { }

        // Элемент доступен без ограничений, но только в той сборке, где описан. (private)
        void StartEngine(int speed) { }
        
        protected string ChangeColor(string color) { return color; }

        public void FixBike() { }

        // Элемент доступен в типе, в котором определен, и в наследниках этого типа
        protected void BrokeBike() { }

        internal void FixBikeCheap() { }

        // Элемент виден в содержащей его сборке без ограничений, а вне сборки – только в наследниках типа.
        protected internal void CheckFixes() { }

        // Доступ ограничен содержащим классом или типами, которые являются производными (наследниками) от содержащего класса в текущей сборке.
        private protected bool IsFixed() { return true; }
    }
}