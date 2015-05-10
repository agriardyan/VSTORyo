using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSTORyo.src.com.vstoryo.helper
{
    class DateTimeHandler
    {
        private static readonly char[] splitter = { ',', ' ', ':', '-', '.' };
        private static readonly char[] splitterNonTanggalAkta = { ',', ' ', ':', '-', '.' };

        public static string[] split(string rawDateTime, bool isTanggalAkta)
        {
            string[] rawDateTimeArray = null;

            if (isTanggalAkta)
            {
                rawDateTime = rawDateTime.Trim();
                rawDateTime = rawDateTime.Replace(" ", string.Empty);
                rawDateTimeArray = rawDateTime.Split(splitter);
            }
            else
            {
                rawDateTime = rawDateTime.Trim();
                rawDateTime = rawDateTime.Replace(" ", string.Empty);
                rawDateTimeArray = rawDateTime.Split(splitterNonTanggalAkta);
            }

            return rawDateTimeArray;
        }

        public static string getDayFromDateTimeHandler(DateTimePicker dt, bool isTanggalAkta)
        {
            if(isTanggalAkta)
            {
                return split(dt.Text, isTanggalAkta)[0];
            }
            else
            {
                return "";
            }
            
        }

        public static string getTanggalFromDateTimeHandler(DateTimePicker dt, bool isTanggalAkta)
        {
            string[] tglArray = split(dt.Text, isTanggalAkta);
            if (isTanggalAkta)
            {
                return tglArray[1] + "-" + tglArray[2] + "-" + tglArray[3];
            }
            else
            {
                return tglArray[0] + "-" + tglArray[1] + "-" + tglArray[2];
            }
            
        }

        public static string getHourFromDateTimeHandler(DateTimePicker dt, bool isTanggalAkta)
        {
            string[] jamArray = split(dt.Text, isTanggalAkta);
            if (isTanggalAkta)
            {
                return jamArray[4] + "." + jamArray[5];
            }
            else
            {
                return "";
            }
            
        }

        public static string readDayInIndonesia(string abrev)
        {
            return null;
        }

        public static string readTanggalInIndonesia(DateTimePicker dt, bool isTanggalAkta)
        {
            string pembacaanTanggal = null;
            string tgl = null;
            string bulan = null;
            string tahun = null;

            string[] tanggalArray = split(dt.Text, isTanggalAkta);

            // Debugging purpose
            foreach (string a in tanggalArray)
            {
                MessageBox.Show(a);
            }

            // Panggil method baca bilangan
            if (isTanggalAkta)
            {
                tgl = BacaBilangan.PembacaanBilangan(tanggalArray[1]);
                bulan = readMonthInIndonesia(tanggalArray[2]);
                tahun = BacaBilangan.PembacaanBilangan(tanggalArray[3]);
            }
            else
            {
                tgl = BacaBilangan.PembacaanBilangan(tanggalArray[0]);
                bulan = readMonthInIndonesia(tanggalArray[1]);
                tahun = BacaBilangan.PembacaanBilangan(tanggalArray[2]);
            }
            
            pembacaanTanggal = "tanggal " + tgl + " bulan " + bulan + " tahun " + tahun;

            return pembacaanTanggal;
        }

        private static string readMonthInIndonesia(string month)
        {
            switch (month)
            {
                case "01" :
                    return "Januari";
                case "02" :
                    return "Februari";
                case "03" :
                    return "Maret";
                case "04" :
                    return "April";
                case "05" :
                    return "Mei";
                case "06" :
                    return "Juni";
                case "07" :
                    return "Juli";
                case "08" :
                    return "Agustus";
                case "09" :
                    return "September";
                case "10" :
                    return "Oktober";
                case "11" :
                    return "November";
                case "12" :
                    return "Desember";
                default :
                    return "";
            }
        }

        public static string readHourInIndonesia(DateTimePicker dt, bool isTanggalAkta)
        {
            string pembacaanJam = null;

            string[] jamArray = split(dt.Text, isTanggalAkta);

            if (isTanggalAkta)
            {
                string jam = BacaBilangan.PembacaanBilangan(jamArray[4]);
                string menit = BacaBilangan.PembacaanBilangan(jamArray[5]);
                pembacaanJam = "pukul " + jam + " lewat " + menit + " menit";
                return pembacaanJam;
            }
            else
            {
                return "";
            }
            
        }
    }
}
