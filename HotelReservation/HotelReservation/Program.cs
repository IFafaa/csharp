using HotelReservation.Entities;
using HotelReservation.Entities.Exceptions;
using System;
using System.Transactions;

namespace HotelReservation
{
    internal class Program {
        static void Main(string[] args) {
            Reservation reservation = new Reservation();

            try {
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                reservation = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine(reservation.ToString());

                Console.WriteLine("\n\n----------------------------------------------------------------------\n\n");

                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());
                DateTime now = DateTime.Now;

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine(reservation.ToString());
            }
            catch (DomainException ex) {
                Console.WriteLine("-------------------------------------------------------------------------------------------------\nERROR IN RESERVATION: " + ex.Message);
            }
            catch(FormatException ex) {
                Console.WriteLine("-------------------------------------------------------------------------------------------------\nFORMAT ERROR: " + ex.Message);
            }
            catch(Exception ex) {
                Console.WriteLine("-------------------------------------------------------------------------------------------------\nUNEXPECTED ERROR: " + ex.Message);
            }

        }
    }
}