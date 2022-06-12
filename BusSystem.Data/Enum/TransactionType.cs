using System;
using System.Collections.Generic;
using System.Text;

namespace BusSystem.Data.Enum
{
    public enum TransactionType
    {
        ADMIN_SEND,
        BUY,
        REFUND,
        ADMIN_ROLLBACK
    }
    public enum TransactionStatus
    {
        PLUS,
        SUB
    }
}
