using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Text;

namespace SportsFacilities
{
    class CancelControl
    {
        SportsAllEntities sports;
        booking bookFacId;
        booking bookSlotId;
        facility fac;
        slot slotTimings;
        booking book;
        slotvsFacility svf;
        CancelledBooking cancelledBook;
        BookedMember bookMem;
        member mem;
        public List<booking> GetBookingIds(int membId)
        {
            sports = new SportsAllEntities();

            List<booking> bookingIdList = new List<booking>();
            var facilityBooked = from x in sports.bookings
                                 where x.MemberId == membId && x.confirmed == "Y"
                                 select x;
            foreach (booking boo in facilityBooked.ToList<booking>())
            {
                booking book = new booking();
                book.BookingId = boo.BookingId;
                bookingIdList.Add(book);
            }
            return bookingIdList;
        }



        public string getFacilityIdAndName(int bookId)
        {
            sports = new SportsAllEntities();
            bookFacId = new booking();
            var SelfacilityId = from x in sports.bookings
                                where x.BookingId == bookId
                                select x;
            bookFacId = SelfacilityId.First<booking>();
            string facName = getFacilityName(bookFacId.FacilityId);
            return facName;
        }

        public string getFacilityName(int facID)
        {
            sports = new SportsAllEntities();
            fac = new facility();
            var SelfacilityName = from x in sports.facilities
                                  where x.FacilityId == facID
                                  select x;
            fac = SelfacilityName.First<facility>();
            return fac.FacilityName.ToString();
        }

        public slot getSlotIdAndTime(int bookId)
        {
            sports = new SportsAllEntities();
            bookSlotId = new booking();
            var SelSlotId = from x in sports.bookings
                            where x.BookingId == bookId
                            select x;
            bookSlotId = SelSlotId.First<booking>();
            slot slotTime = getSlotTime(bookSlotId.SlotID);
            return slotTime;
        }

        public slot getSlotTime(int slotId)
        {
            sports = new SportsAllEntities();
            slotTimings = new slot();
            var SelSlotTime = from x in sports.slots
                              where x.SlotId == slotId
                              select x;
            slotTimings = SelSlotTime.First<slot>();
            return slotTimings;
        }

        public bool processCancelBooking(booking bookObj)
        {
            sports = new SportsAllEntities();
            book = new booking();
            svf = new slotvsFacility();
            var bookingRec = from y in sports.bookings
                             where y.BookingId == bookObj.BookingId
                             select y;
            book = bookingRec.First<booking>();
            var slotFacId = from z in sports.slotvsFacilities
                            where z.FacilityId == book.FacilityId && z.SlotId == book.SlotID
                            select z;
            svf = slotFacId.First<slotvsFacility>();
            svf.Available = "Y";
            book.confirmed = "N";
            using (TransactionScope ts = new TransactionScope())
            {
                sports.SaveChanges();
                sports.SaveChanges();
                ts.Complete();
                return true;
            }
            //return false;
        }

        public void viewCancelledBooking()
        {
            sports = new SportsAllEntities();
            cancelledBook = new CancelledBooking();
            var cancelledBooking = from y in sports.CancelledBookings
                                   select y;
            ViewBooking vb = new ViewBooking("Cancel");
            vb.collectList = cancelledBooking.ToList<CancelledBooking>();
            vb.ShowDialog();
        }

        public List<member> getBookedMembers()
        {
            sports = new SportsAllEntities();
            bookMem = new BookedMember();
            List<member> BookedMems = new List<member>();
            var selectBookedMem = from x in sports.BookedMembers select x;
            foreach (BookedMember boo in selectBookedMem.ToList<BookedMember>())
            {
                member mem = new member();
                mem.MemberId = boo.MemberId;
                mem.MemberName = boo.MemberName;
                BookedMems.Add(mem);
            }

            return BookedMems.ToList<member>();
        }


    }
}
