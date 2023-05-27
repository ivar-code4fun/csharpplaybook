using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodProps
{
    public class BusinessRules
    {
        public static bool EligibleForVoucher(int nPurchases, in decimal biggestPurchase) => nPurchases > 5 &&
            biggestPurchase > 100m;
    }
}
