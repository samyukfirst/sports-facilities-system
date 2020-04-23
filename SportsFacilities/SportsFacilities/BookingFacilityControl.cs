using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Text;

namespace SportsFacilities
{
    class BookingFacilityControl
    {
        SportsAllEntities sports;
        booking book;
        slotvsFacility svf;
        public string display()
        {
            sports = new SportsAllEntities();
            var selectId = from x in sports.bookings orderby x.BookingId descending select x;
            int recordCount = selectId.Count<booking>();

            if (recordCount == 0)
            {
                return "1";
            }
            else
            {
                book = selectId.First<booking>();
                return (book.BookingId + 1).ToString();
            }

        }

        public List<facility> getFacilities()
        {
            var facilityN_Query = from y in sports.facilities orderby y.FacilityId select y;
            return facilityN_Query.ToList<facility>();
        }

        public void saveBooking(booking book)
        {
            sports = new SportsAllEntities();
            svf = new slotvsFacility();
            int facId = book.FacilityId;
            int slotId = book.SlotID;
            var updateSlotVsFacility = from x in sports.slotvsFacilities
                                       where x.FacilityId == facId &&
                                       x.SlotId == slotId
                                       select x;
            svf = updateSlotVsFacility.First<slotvsFacility>();
            svf.Available = "N";
            using (TransactionScope ts = new TransactionScope())
            {
                sports.SaveChanges();
                sports.bookings.AddObject(book);
                sports.SaveChanges();
                ts.Complete();
            }

        }

        public void showBookingReceipt(int bookId)
        {
            BookingReceipt br = new BookingReceipt();
            br.GetSetBookingId = Convert.ToInt32(bookId);
            br.Show();
        }
    }
}
