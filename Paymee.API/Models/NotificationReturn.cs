using System;
using System.Collections.Generic;
using System.Text;

namespace Paymee.API.Models
{
    public partial class NotificationReturn
    {
        public RefundNotification RefundNotification { get; set; }
        public PaymentNotification PaymentNotification { get; set; }
    }
}
