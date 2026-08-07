using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03_Assignment
{
    internal class InternationalShipment : Shipment
    {

        private string destinationCountry;

        public string DestinationCountry
        {
            get { return destinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(destinationCountry))
                {
                    destinationCountry = value;
                }
            }
        }



        private decimal customsFee;

        public decimal CustomsFee
        {
            get { return customsFee; }
            set
            {
                if (value >= 0)
                {
                    customsFee = value;
                }
            }
        }

        public decimal EstimatedCost => DeliveryFee + (decimal)(Weight * 5) + CustomsFee;


        public InternationalShipment(string trackingCode, string description, double weight,
           decimal deliveryFee, DeliveryAddress destination, decimal customsFee, string destinationCountry) : base(trackingCode, description, weight,
              deliveryFee, destination)
        {
            CustomsFee = customsFee;
            DestinationCountry = destinationCountry;
        }


        public override string ToString()
        {
            return $"Tracking Code: {TrackingCode}\n" +
                   $"Description: {Description}\n" +
                   $"Weight: {Weight} KG\n" +
                   $"Delivery Fee: {DeliveryFee} EGP\n" +
                   $"Destination: {Destination}\n" +
                   $"Estimated Cost: {EstimatedCost} EGP\n" +
                   $"Customs Fee: {CustomsFee} EGP\n" +
                   $"DestinationCountry: {DestinationCountry} \n";
        }
    }
}
