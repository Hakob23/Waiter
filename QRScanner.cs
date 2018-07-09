using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Waiter_QR.Service;
using ZXing.Mobile;
using Xamarin.Forms;
using Waiter_QR;

[assembly: Dependency(typeof(Waiter_QR.Droid.Service.QRScanner))]

namespace Waiter_QR.Droid.Service
{
    public class QRScanner : IQRScanner
    {
        public async Task<string> ScanAsync()
        {
            var optionsDefault = new MobileBarcodeScanningOptions();
            var optionsCustom = new MobileBarcodeScanningOptions();

            var scanner = new MobileBarcodeScanner();

            scanner.TopText = "Scan the QR Code";
            scanner.BottomText = "Processing ... ";
            

            

            try
            {
                var scanResult = await scanner.Scan(optionsCustom);
                return scanResult.Text;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return null;
            
        }
    }
}