using HotelReservation.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Entities {
    internal class Reservation {
        public int RoomNumber  { get; private set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }
        public Reservation(int roomNumber,  DateTime checkin, DateTime checkout) {
            DateTime now = DateTime.Now;
            if (checkout <= checkin) {
                throw new DomainException("check-out date must be after check-in date");
            }
            if (checkin < now || checkout < now) {
                throw new DomainException("reservation dates for update must be after today");
            }

            RoomNumber = roomNumber;
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public int Duration() {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout) { 
            DateTime now = DateTime.Now;
            if (CheckIn < now || CheckOut < now) {
                throw new DomainException("reservation dates for update must be after today");
            }
            if(CheckOut <= CheckIn) {
                throw new DomainException("check-out date must be after check-in date");
            }

            CheckIn = checkin;
            CheckOut = checkout;
        }

        /*public void CheckInCheckOutIsValidation(DateTime checkIn, DateTime checkOut) {
            DateTime now = DateTime.Now;
            if (CheckIn < now || CheckOut < now) {
                throw new DomainException("reservation dates for update must be after today");
            }
            if (CheckOut <= CheckIn) {
                throw new DomainException("check-out date must be after check-in date");
            }
        }*/

        public override string ToString() {
            return $"" +
                $"Reservation: Room {RoomNumber}, " +
                $"check-in: {CheckIn.ToString("dd/MM/yyyy")}, " +
                $"check-out: {CheckOut.ToString("dd/MM/yyyy")}, " +
                $"{Duration()} nights";
        }

    }
}
