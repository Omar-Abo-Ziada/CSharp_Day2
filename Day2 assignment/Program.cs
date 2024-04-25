namespace Day2_assignment
{
  
    internal class Program
    {
        static void Main(string[] args)
        {
            //Role emp1Role = Role.Admin | Role.Accountant;
            //Employee emp1 = new Employee("Ahmed", 20000m, emp1Role);

            //emp1.AssignRole(Role.Reception);

            //emp1.DisplayEmployeeData();

            //===============================

            _3DPoint p1 = new _3DPoint(1, 2, 3);
            _3DPoint p2 = new _3DPoint(4, 5, 6);

            p1.Display();

            if (p1 == p2)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }

            p1.ChangeCoordinates(11, 33, 44);

            p1.Display();

            //===================================







        }
    }
}