﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SberemPay.Sdk.Models.Payments
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public string PaymentMethodId { get; set; }
        public string ExternalId1 { get; set; }
        public string ExternalId2 { get; set; }
        public string ExternalId3 { get; set; }
        public bool IsVoucher { get; set; }
        public long Amount { get; set; }
        public long ConfirmedAmount { get; set; }
        public long RefundedAmount { get; set; }
        public string Status { get; set; }
    }
}
