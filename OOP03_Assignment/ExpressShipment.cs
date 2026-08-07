using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03_Assignment
{
    internal class ExpressShipment : Shipment
    {

        private decimal extraFee;

        public decimal ExtraFee
        {
            get
            {
                return extraFee;
            }
            set
            {
                if (value >= 0)
                {
                    extraFee = value;
                }
            }
        }

        public decimal EstimatedCost => DeliveryFee + (decimal)(Weight * 5) + ExtraFee;



        public ExpressShipment(string trackingCode, string description, double weight,
            decimal deliveryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight,
               deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }


        public override string ToString()
        {
            return $"Tracking Code: {TrackingCode}\n" +
                   $"Description: {Description}\n" +
                   $"Weight: {Weight} KG\n" +
                   $"Delivery Fee: {DeliveryFee} EGP\n" +
                   $"Destination: {Destination}\n" +
                   $"Estimated Cost: {EstimatedCost} EGP\n" +
                   $"Extra Fee: {ExtraFee} EGP\n";
        }
    }
}
