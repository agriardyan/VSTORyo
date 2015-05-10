using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSTORyo.src.com.vstoryo.helper
{
    class BacaBilangan
    {
        public static string PembacaanBilangan(string value)
        {
            AbstractProcessor processor = new DefaultProcessor();
            string name = processor.getName(value);
            return refinement(name);
        }

        private static string refinement(string value)
        {
            string indoRefinement = null;
            if (!value.Contains("-satu ratus"))
            {
                indoRefinement = value.Replace("satu ratus", "seratus");
            }


            if (!value.Contains("-satu ribu"))
            {
                indoRefinement = indoRefinement.Replace("satu ribu", "seribu");
            }

            indoRefinement = indoRefinement.Replace("-", "");

            return indoRefinement;
        }

        public static Scale SCALE = Scale.SHORT;

        public class ScaleUnit
        {
            private int mExponent;
            private string[] mNames;

            public ScaleUnit(int pExponent, string pName1, string pName2)
            {
                this.mExponent = pExponent;
                int a = 0;
                this.mNames = new string[2];
                this.mNames[0] = pName1;
                this.mNames[1] = pName2;
            }

            public int getExponent()
            {
                return mExponent;
            }

            public string getName(int pIndex)
            {
                return mNames[pIndex];
            }
        }

        public static ScaleUnit[] SCALE_UNITS = new ScaleUnit[] {
            new ScaleUnit(63, "vigintillion", "decilliard"),
            new ScaleUnit(60, "novemdecillion", "decillion"),
            new ScaleUnit(57, "octodecillion", "nonilliard"),
            new ScaleUnit(54, "septendecillion", "nonillion"),
            new ScaleUnit(51, "sexdecillion", "octilliard"),
            new ScaleUnit(48, "quindecillion", "octillion"),
            new ScaleUnit(45, "quattuordecillion", "septilliard"),
            new ScaleUnit(42, "tredecillion", "septillion"),
            new ScaleUnit(39, "duodecillion", "sextilliard"),
            new ScaleUnit(36, "undecillion", "sextillion"),
            new ScaleUnit(33, "decillion", "quintilliard"),
            new ScaleUnit(30, "nonillion", "quintillion"),
            new ScaleUnit(27, "octillion", "quadriliard"),
            new ScaleUnit(24, "septillion", "quadriliun"),
            new ScaleUnit(21, "sextiliun", "triliard"),
            new ScaleUnit(18, "quintiliun", "triliun"),
            new ScaleUnit(15, "quadriliun", "billiard"),
            new ScaleUnit(12, "triliun", "triliun"),
            new ScaleUnit(9, "miliar", "miliar"),
            new ScaleUnit(6, "juta", "juta"),
            new ScaleUnit(3, "ribu", "ribu"),
            new ScaleUnit(2, "ratus", "ratus"),
            //new ScaleUnit(1, "ten", "ten"),
            //new ScaleUnit(0, "one", "one"),
            new ScaleUnit(-1, "puluh", "puluh"),
            new ScaleUnit(-2, "ratus", "ratus"),
            new ScaleUnit(-3, "ribu", "ribu"),
            new ScaleUnit(-4, "ten-ribu", "sepuluh-ribu"),
            new ScaleUnit(-5, "ratus-ributh", "ratus-ribu"),
            new ScaleUnit(-6, "juta", "juta"),
            new ScaleUnit(-7, "sepuluh-juta", "sepuluh-juta"),
            new ScaleUnit(-8, "ratus-juta", "ratus-juta"),
            new ScaleUnit(-9, "miliar", "miliar"),
            new ScaleUnit(-10, "sepuluh-miliar", "sepuluh-miliar"),
            new ScaleUnit(-11, "ratus-miliar", "ratus-miliar"),
            new ScaleUnit(-12, "triliun", "triliun"),
            new ScaleUnit(-13, "sepuluh-triliun", "sepuluh-triliun"),
            new ScaleUnit(-14, "ratus-triliunth", "ratus-miliarth"),
            new ScaleUnit(-15, "quadrillionth", "billiardth"),
            new ScaleUnit(-16, "ten-quadrillionth", "ten-billiardth"),
            new ScaleUnit(-17, "ratus-quadrillionth", "ratus-billiardth"),
            new ScaleUnit(-18, "quintillionth", "triliunth"),
            new ScaleUnit(-19, "ten-quintillionth", "ten-triliunth"),
            new ScaleUnit(-20, "ratus-quintillionth", "ratus-triliunth"),
            new ScaleUnit(-21, "sextillionth", "trilliardth"),
            new ScaleUnit(-22, "ten-sextillionth", "ten-trilliardth"),
            new ScaleUnit(-23, "ratus-sextillionth", "ratus-trilliardth"),
            new ScaleUnit(-24, "septillionth", "quadrillionth"),
            new ScaleUnit(-25, "ten-septillionth", "ten-quadrillionth"),
            new ScaleUnit(-26, "ratus-septillionth", "ratus-quadrillionth"),
        };

        public class Scale
        {
            public static readonly Scale SHORT = new Scale();
            public static readonly Scale LONG = new Scale();

            public static IEnumerable<Scale> Values
            {
                get
                {
                    yield return SHORT;
                    yield return LONG;
                }
            }

            public string getName(int exponent)
            {
                foreach (ScaleUnit unit in SCALE_UNITS)
                {
                    if (unit.getExponent() == exponent)
                    {
                        return unit.getName(0);
                    }
                }
                return "";
            }
        }


        //public enum Scale {

        //    SHORT,
        //    LONG;

        //    public string getName(int exponent) {
        //        foreach (ScaleUnit unit in SCALE_UNITS) {
        //            if (unit.getExponent() == exponent) {
        //                return unit.getName(this.ordinal());
        //            }
        //        }
        //        return "";
        //    }
        //}


        public abstract class AbstractProcessor
        {

            static protected readonly string SEPARATOR = " ";
            static protected readonly int NO_VALUE = -1;

            protected List<int> getDigits(long value)
            {
                List<int> digits = new List<int>();
                if (value == 0)
                {
                    digits.Add(0);
                }
                else
                {
                    while (value > 0)
                    {
                        digits.Insert(0, (int)value % 10);
                        value /= 10;
                    }
                }
                return digits;
            }

            public string getName(long value)
            {
                return getName(Convert.ToString(value));
            }

            public string getName(double value)
            {
                return getName(Convert.ToString(value));
            }

            abstract public string getName(string value);
        }


        public class UnitProcessor : AbstractProcessor
        {

            static private readonly string[] TOKENS = new string[]{
                "satu", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan",
                "sepuluh", "sebelas", "duabelas", "tigabelas", "empatbelas", "limabelas", "enambelas",
                "tujuhbelas", "delapanbelas", "sembilanbelas"
            };



            override
            public string getName(string value)
            {
                StringBuilder buffer = new StringBuilder();

                int offset = NO_VALUE;
                int number;
                if (value.Length > 3)
                {
                    number = Convert.ToInt32(value.Substring(value.Length - 3), 10);
                }
                else
                {
                    number = Convert.ToInt32(value, 10);
                }
                number %= 100;
                if (number < 10)
                {
                    offset = (number % 10) - 1;
                    //number /= 10;
                }
                else if (number < 20)
                {
                    offset = (number % 20) - 1;
                    //number /= 100;
                }

                if (offset != NO_VALUE && offset < TOKENS.Length)
                {
                    buffer.Append(TOKENS[offset]);
                }

                return buffer.ToString();
            }

        }


        public class TensProcessor : AbstractProcessor
        {

            static private readonly string[] TOKENS = new string[]{
                "duapuluh", "tigapuluh", "empatpuluh", "limapuluh", "enampuluh", "tujuhpuluh", "delapanpuluh", "sembilanpuluh"
            };

            static private readonly string UNION_SEPARATOR = "-";

            private UnitProcessor unitProcessor = new UnitProcessor();

            override
            public string getName(string value)
            {
                StringBuilder buffer = new StringBuilder();
                bool tensFound = false;

                int number;
                if (value.Length > 3)
                {
                    number = Convert.ToInt32(value.Substring(value.Length - 3), 10);
                }
                else
                {
                    number = Convert.ToInt32(value, 10);
                }
                number %= 100;   // keep only two digits
                if (number >= 20)
                {
                    buffer.Append(TOKENS[(number / 10) - 2]);
                    number %= 10;
                    tensFound = true;
                }
                else
                {
                    number %= 20;
                }

                if (number != 0)
                {
                    if (tensFound)
                    {
                        buffer.Append(UNION_SEPARATOR);
                    }
                    buffer.Append(unitProcessor.getName(number));
                }

                return buffer.ToString();
            }
        }

        public class HundredProcessor : AbstractProcessor
        {

            private int EXPONENT = 2;

            private UnitProcessor unitProcessor = new UnitProcessor();
            private TensProcessor tensProcessor = new TensProcessor();

            override
            public string getName(string value)
            {
                StringBuilder buffer = new StringBuilder();

                int number;
                if (String.IsNullOrEmpty(value))
                {
                    number = 0;
                }
                else if (value.Length > 4)
                {
                    number = Convert.ToInt32(value.Substring(value.Length - 4), 10);
                }
                else
                {
                    number = Convert.ToInt32(value, 10);
                }
                number %= 1000;  // keep at least three digits

                if (number >= 100)
                {
                    buffer.Append(unitProcessor.getName(number / 100));
                    buffer.Append(SEPARATOR);
                    buffer.Append(SCALE.getName(EXPONENT));
                }

                string tensName = tensProcessor.getName(number % 100);

                if (!String.IsNullOrEmpty(tensName) && (number >= 100))
                {
                    buffer.Append(SEPARATOR);
                }
                buffer.Append(tensName);

                return buffer.ToString();
            }
        }

        public class CompositeBigProcessor : AbstractProcessor
        {

            private HundredProcessor ratusProcessor = new HundredProcessor();
            private AbstractProcessor lowProcessor;
            private int exponent;

            public CompositeBigProcessor(int exponent)
            {
                if (exponent <= 3)
                {
                    lowProcessor = ratusProcessor;
                }
                else
                {
                    lowProcessor = new CompositeBigProcessor(exponent - 3);
                }
                this.exponent = exponent;
            }

            public string getToken()
            {
                return SCALE.getName(getPartDivider());
            }

            protected AbstractProcessor getHighProcessor()
            {
                return ratusProcessor;
            }

            protected AbstractProcessor getLowProcessor()
            {
                return lowProcessor;
            }

            public int getPartDivider()
            {
                return exponent;
            }

            override
            public string getName(string value)
            {
                StringBuilder buffer = new StringBuilder();

                string high, low;
                if (value.Length < getPartDivider())
                {
                    high = "";
                    low = value;
                }
                else
                {
                    int index = value.Length - getPartDivider();
                    high = value.Substring(0, index);
                    low = value.Substring(index);
                }

                string highName = getHighProcessor().getName(high);
                string lowName = getLowProcessor().getName(low);

                if (!String.IsNullOrEmpty(highName))
                {
                    buffer.Append(highName);
                    buffer.Append(SEPARATOR);
                    buffer.Append(getToken());

                    if (!String.IsNullOrEmpty(lowName))
                    {
                        buffer.Append(SEPARATOR);
                    }
                }

                if (!String.IsNullOrEmpty(lowName))
                {
                    buffer.Append(lowName);
                }

                return buffer.ToString();
            }
        }

        public class DefaultProcessor : AbstractProcessor
        {

            static private string MINUS = "minus";
            static private string UNION_AND = "koma";

            static private string ZERO_TOKEN = "nol";

            private AbstractProcessor processor = new CompositeBigProcessor(63);

            override
            public string getName(string value)
            {
                bool negative = false;
                if (value.StartsWith("-"))
                {
                    negative = true;
                    value = value.Substring(1);
                }

                int decimals = value.IndexOf(".");
                string decimalValue = null;
                if (0 <= decimals)
                {
                    decimalValue = value.Substring(decimals + 1);
                    value = value.Substring(0, decimals);
                }

                string name = processor.getName(value);
                string[] separatorarray = { SEPARATOR };
                string[] namearray = { name };

                if (String.IsNullOrEmpty(name))
                {
                    name = ZERO_TOKEN;
                }
                else if (negative)
                {
                    name = MINUS + SEPARATOR + name;
                }

                if (!(null == decimalValue || String.IsNullOrEmpty(decimalValue)))
                {
                    name = name + SEPARATOR + UNION_AND + SEPARATOR + processor.getName(decimalValue) +
                        SEPARATOR + SCALE.getName(-decimalValue.Length);
                }

                return name;
            }

        }
        
    
    }
}
