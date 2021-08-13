﻿using System;
using _01_Framework.Domain;

namespace DiscountManagement.Domain.CustomerDiscountAgg
{
    public class CustomerDiscount : EntityBase
    {
        public long BookId { get; private set; }
        public int DiscountRate { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public string Reason { get; private set; }

        public CustomerDiscount(long bookId, int discountRate, DateTime startDate,
            DateTime endDate, string reason)
        {
            BookId = bookId;
            DiscountRate = discountRate;
            StartDate = startDate;
            EndDate = endDate;
            Reason = reason;
        }

        public void Edit(long bookId, int discountRate, DateTime startDate,
            DateTime endDate, string reason)
        {
            BookId = bookId;
            DiscountRate = discountRate;
            StartDate = startDate;
            EndDate = endDate;
            Reason = reason;
        }
    }
}
