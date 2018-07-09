using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Waiter_QR.Service
{
    public interface IQRScanner
    {
        Task<string> ScanAsync();
    }
}
