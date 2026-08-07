namespace OOP03_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            // a) What is the difference between a class and a struct?

            //  1.Class                                 2.Struct
            //   1-Reference Tybe                         1-Value Tybe
            //   2-Stored in Heap                         2-Stored in Stack  
            //   3-used for complex program               3-used for simple program
            //   4-support inhertance                     4-doesn’t support inhertance




            //b) Why are classes more suitable than structs for large applications?

            //Because The Previous reasons and easy to maintain

            #endregion
            #region Question02
            //a) Which class is the parent class?
            //Shipment

            //b) Which class is the child class?
            //ExpressShipment

            //c) What members are inherited by ExpressShipment?
            //properity of trackingCode

            //d) Why is inheritance better than duplicating the same code in multiple classes?
            // No duplicate code and easy to maintain
            #endregion
            #region Practical



            DeliveryCenter center = new DeliveryCenter();
            Console.Write("Enter Delivery Center Name: ");
            string CenterName = Console.ReadLine()!;

            //StandardShipment standard = new StandardShipment("Sh-150", "Laptop", 50, 100, new DeliveryAddress("Cairo", "Tahrir Street", 15));
            //ExpressShipment express = new ExpressShipment("Sh-150", "Laptop", 50, 100, new DeliveryAddress("Giza", "Makram Ebid Street", 25), 150);
            //InternationalShipment international = new InternationalShipment("Sh-150", "Laptop", 50, 100, new DeliveryAddress("Elsodan", "Halp Street", 35), 200, "Moroco");

            #region Standard


            Console.WriteLine("\nEnter Standard Shipment Data");

            Console.Write("Tracking Code: ");
            string trackingCode01 = Console.ReadLine()!;

            Console.Write("Description: ");
            string description01 = Console.ReadLine()!;

            Console.Write("Weight: ");
            double weight01 = double.Parse(Console.ReadLine()!);

            Console.Write("Delivery Fee: ");
            decimal deliveryFee01 = decimal.Parse(Console.ReadLine()!);

            Console.Write("City: ");
            string city01 = Console.ReadLine()!;

            Console.Write("Street: ");
            string street01 = Console.ReadLine()!;

            Console.Write("Building Number: ");
            int buildingNumber01 = int.Parse(Console.ReadLine()!);

            DeliveryAddress address01 = new DeliveryAddress(city01, street01, buildingNumber01);

            StandardShipment standard = new StandardShipment(
                trackingCode01,
                description01,
                weight01,
                deliveryFee01,
                address01);

            if (center.AddShipment(standard))
            {
                Console.WriteLine("Shipment Added Successfully.");
            }
            else
            {
                Console.WriteLine("Delivery Center is Full.");
            }


            #endregion
            #region Express 
            Console.WriteLine("\nEnter Express Shipment Data");

            Console.Write("Tracking Code: ");
            string trackingCode02 = Console.ReadLine()!;

            Console.Write("Description: ");
            string description02 = Console.ReadLine()!;

            Console.Write("Weight: ");
            double weight02 = double.Parse(Console.ReadLine()!);

            Console.Write("Delivery Fee: ");
            decimal deliveryFee02 = decimal.Parse(Console.ReadLine()!);

            Console.Write("City: ");
            string city02 = Console.ReadLine()!;

            Console.Write("Street: ");
            string street02 = Console.ReadLine()!;

            Console.Write("Building Number: ");
            int buildingNumber02 = int.Parse(Console.ReadLine()!);

            Console.Write("Extra Fee: ");
            decimal extraFee = decimal.Parse(Console.ReadLine()!);

            DeliveryAddress address02 = new DeliveryAddress(city02, street02, buildingNumber02);

            ExpressShipment express = new ExpressShipment(trackingCode02, description02, weight02, deliveryFee02,
                address02, extraFee);

            if (center.AddShipment(express))
            {
                Console.WriteLine("Shipment Added Successfully.");
            }
            else
            {
                Console.WriteLine("Delivery Center is Full.");
            }
            #endregion
            #region International
            Console.WriteLine("\nEnter International Shipment Data");

            Console.Write("Tracking Code: ");
            string trackingCode03 = Console.ReadLine()!;

            Console.Write("Description: ");
            string description03 = Console.ReadLine()!;

            Console.Write("Weight: ");
            double weight03 = double.Parse(Console.ReadLine()!);

            Console.Write("Delivery Fee: ");
            decimal deliveryFee03 = decimal.Parse(Console.ReadLine()!);

            Console.Write("City: ");
            string city03 = Console.ReadLine()!;

            Console.Write("Street: ");
            string street03 = Console.ReadLine()!;

            Console.Write("Building Number: ");
            int buildingNumber03 = int.Parse(Console.ReadLine()!);

            Console.Write("Customs Fee: ");
            decimal customsFee = decimal.Parse(Console.ReadLine()!);

            Console.Write("Destination Country: ");
            string destinationCountry = Console.ReadLine()!;

            DeliveryAddress address03 = new DeliveryAddress(city02, street02, buildingNumber02);

            InternationalShipment International = new InternationalShipment(trackingCode03, description03, weight03, deliveryFee03,
                address03, customsFee, destinationCountry);

            if (center.AddShipment(International))
            {
                Console.WriteLine("Shipment Added Successfully.");
            }
            else
            {
                Console.WriteLine("Delivery Center is Full.");
            }
            #endregion
            Console.WriteLine("\n======================================");
            Console.WriteLine($"Delivery Center : {CenterName}");
            Console.WriteLine("======================================");


            center.PrintAllShipments();


            Console.Write("\nEnter Tracking Code to Remove: ");
            string trackingCode = Console.ReadLine()!;

            if (center.RemoveShipment(trackingCode))
            {
                Console.WriteLine("\nShipment Removed Successfully.");
            }
            else
            {
                Console.WriteLine("\nShipment Not Found.");
            }



            Console.WriteLine("\n======================================");
            Console.WriteLine("Remaining Shipments");
            Console.WriteLine("======================================");

            center.PrintAllShipments();
            #endregion
        }
    }
}
