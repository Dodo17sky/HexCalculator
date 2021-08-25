using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexCalculator
{
    public enum NumberField { NumberA, NumberB, Result };

    public struct NumberDataType
    {
        public UInt64 DecimalValue;
        public string LastValidNumber;
    }

    public partial class Form1 : Form
    {
        private NumberDataType NumberA;
        private NumberDataType NumberB;
        private NumberDataType Result;

        public Form1()
        {
            InitializeComponent();

            labelA1.Text = labelA2.Text = labelA3.Text = "";
            labelB1.Text = labelB2.Text = labelB3.Text = "";
            labelR1.Text = labelR2.Text = labelR3.Text = "";

            NumberA.DecimalValue = 0;
            NumberA.LastValidNumber = "";

            NumberB.DecimalValue = 0;
            NumberB.LastValidNumber = "";

            Result.DecimalValue = 0;
            Result.LastValidNumber = "";
        }

        private UInt64 ConvertToUInt64(string strNumber)
        {
            UInt64 u64Value = 0;

            if (strNumber.StartsWith("0x"))
            {
                strNumber = strNumber.Substring(2);
                strNumber = strNumber.Replace(" ", "");
                if (strNumber != "")
                    u64Value = Convert.ToUInt64(strNumber, 16);
            }
            else
            {
                strNumber = strNumber.Replace(",", "");
                if (UInt64.TryParse(strNumber, out u64Value))
                    u64Value = Convert.ToUInt64(strNumber, 10);
            }

            return u64Value;
        }

        private void UpdateNumberSummary(NumberField nmb)
        {
            UInt64 uint64Value = 0;
            ref Label labelDec = ref labelA1;
            ref Label labelHex = ref labelA2;
            ref Label labelBin = ref labelA3;
            ref NumberDataType number = ref NumberA;

            if (nmb == NumberField.NumberB)
            {
                labelDec = ref labelB1;
                labelHex = ref labelB2;
                labelBin = ref labelB3;
                number = ref NumberB;
            }
            else if (nmb == NumberField.Result)
            {
                labelDec = ref labelR1;
                labelHex = ref labelR2;
                labelBin = ref labelR3;
                number = ref Result;
            }

            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");

            if (number.LastValidNumber != "")
            {
                uint64Value = ConvertToUInt64(number.LastValidNumber);
                if (nmb != NumberField.Result)
                {
                    number.DecimalValue = uint64Value;
                }

                labelDec.Text = "DEC: " + String.Format(culture, "{0:N0}", uint64Value);
                labelHex.Text = "HEX: " + FormatHexNumber(uint64Value.ToString("X")).Replace("0x ", "").Replace("0x", "");
                labelBin.Text = "BIN:" + FormatBinaryNumber(uint64Value);
            }
        }

        private bool IsDecHex64bitsNumber(string number)
        {
            bool isValid = false;

            if (number.StartsWith("0x"))
            {
                number = number.Substring(2);
                number = number.Replace(" ", ""); // replace hexadecimal number separator - space ' '
                if (number.Length > 0)
                {
                    number = number.TrimStart(new char[] { '0' });
                    if (number == "")
                        isValid = true;
                    else if (number.Length > 0 && number.Length <= 16)
                        isValid = System.Text.RegularExpressions.Regex.IsMatch(number, @"\A\b[0-9a-fA-F]+\b\Z");
                }
            }
            else
            {
                number = number.Replace(",", ""); // replace decimal number separator - comma ','
                try
                {
                    isValid = System.Text.RegularExpressions.Regex.IsMatch(number, @"\A\b[0-9]+\b\Z");
                    if (isValid) // check also for 64 bits overflow
                        UInt64.Parse(number);
                }
                catch (OverflowException)
                {
                    isValid = false;
                    Console.WriteLine("Integer number too big");
                }
            }

            return isValid;
        }

        private string FormatHexNumber(string strNumber)
        {
            string hexNumberFormated = "0x0";

            Console.WriteLine("\t2. Hex not formated: {0}", strNumber);

            // replace hexadecimal number separator - space ' '
            strNumber = strNumber.Replace(" ", "");
            strNumber = strNumber.TrimStart(new char[] { '0' });

            if (strNumber.Length > 0 && strNumber.Length <= 16)
            {
                var intNumber = Convert.ToInt64(strNumber, 16);
                string tmp = "";

                if (strNumber.Length % 4 > 0)
                    tmp = new String('0', (4 - (strNumber.Length % 4)));

                tmp += intNumber.ToString("X");

                var nibbleList = Enumerable.Range(0, tmp.Length / 4).Select(i => tmp.Substring(i * 4, 4));

                hexNumberFormated = "0x " + String.Join(" ", nibbleList);
            }

            Console.WriteLine("\t3. Hex formated: {0}", hexNumberFormated);

            return hexNumberFormated;
        }

        private string FormatDecimalNumber(string strNumber)
        {
            string decNumberFormated = "0";

            Console.WriteLine("\t2. Dec not formated: {0}", strNumber);

            // replace decimal number separator - comma ','
            strNumber = strNumber.Replace(",", "");

            if (System.Text.RegularExpressions.Regex.IsMatch(strNumber, @"\A\b[0-9]+\b\Z"))
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                var valueBefore = UInt64.Parse(strNumber, System.Globalization.NumberStyles.AllowThousands);
                decNumberFormated = String.Format(culture, "{0:N0}", valueBefore);
            }

            Console.WriteLine("\t3. Dec formated: {0}", decNumberFormated);

            return decNumberFormated;
        }

        private string FormatBinaryNumber(UInt64 value)
        {
            var strBin = Convert.ToString((long)value, 2);
            string tmp = "";

            if (strBin.Length % 8 > 0)
                tmp = new String('0', (8 - (strBin.Length % 8)));

            tmp += strBin;

            var nibbleList = Enumerable.Range(0, tmp.Length / 8).Select(i => tmp.Substring(i * 8, 8));

            string formatedBin = "";
            uint nIdx = 0;
            foreach (var nibble in nibbleList)
            {
                if (nIdx++ == 4)
                    formatedBin += "\n    ";
                formatedBin += " " + nibble;
            }

            return formatedBin;
        }

        private string FormatNumber(string strNumber)
        {
            string formatedNumber = "0x";

            Console.WriteLine("------  New validation ------");
            Console.WriteLine("\t1. Input: {0}", strNumber);

            //--------------------------------------------------------
            //      This is a HEX number
            //--------------------------------------------------------
            if (strNumber.StartsWith("0x"))
            {
                formatedNumber = FormatHexNumber(strNumber.Substring(2));
            }

            //--------------------------------------------------------
            //      This is a DECIMAL number
            //--------------------------------------------------------
            else
            {
                formatedNumber = FormatDecimalNumber(strNumber);
            }

            return formatedNumber;
        }

        private void CheckUserInput(string input, NumberField number)
        {
            NumberField numberLabels = NumberField.NumberA;
            var isHex = input.StartsWith("0x");
            ref TextBox tb = ref textBox1;
            ref NumberDataType tbData = ref NumberA;

            if (number == NumberField.NumberB)
            {
                tb = ref textBox2;
                tbData = ref NumberB;
                numberLabels = NumberField.NumberB;
            }

            if (IsDecHex64bitsNumber(input))
            {
                var formatedNumber = FormatNumber(input);

                if (formatedNumber != "")
                {
                    tb.Text = tbData.LastValidNumber = formatedNumber;
                }
                else
                {
                    tb.Text = tbData.LastValidNumber;
                    Console.WriteLine("\t2. Invalid {0}, re-apply {1}", input, tbData.LastValidNumber);
                }
            }
            else
            {
                tb.Text = tbData.LastValidNumber;
                Console.WriteLine("\t2. Invalid {0}, re-apply {1}", input, tbData.LastValidNumber);
            }

            UpdateNumberSummary(numberLabels);

            tb.SelectionStart = tb.Text.Length;
            tb.SelectionLength = 0;
        }

        private void NumberA_TextChanged(object sender, EventArgs e)
        {
            var input = (sender as TextBox).Text;

            if (input == "")
            {
                NumberA.LastValidNumber = "";
                NumberA.DecimalValue = 0;
                labelA1.Text = labelA2.Text = labelA3.Text = "";
            }
            if (input == "" || input == "0x") return;

            textBox1.TextChanged -= NumberA_TextChanged;

            CheckUserInput(input, NumberField.NumberA);

            textBox1.TextChanged += NumberA_TextChanged;
        }

        private void NumberB_TextChanged(object sender, EventArgs e)
        {
            var input = (sender as TextBox).Text;

            if (input == "")
            {
                NumberB.LastValidNumber = "";
                NumberB.DecimalValue = 0;
                labelB1.Text = labelB2.Text = labelB3.Text = "";
            }
            if (input == "" || input == "0x") return;

            textBox2.TextChanged -= NumberB_TextChanged;

            CheckUserInput(input, NumberField.NumberB);

            textBox2.TextChanged += NumberB_TextChanged;
        }

        private void OpAddition_Click(object sender, EventArgs e)
        {
            Result.DecimalValue = NumberA.DecimalValue + NumberB.DecimalValue;
            Result.LastValidNumber = Result.DecimalValue.ToString();

            UpdateNumberSummary(NumberField.Result);
        }

        private void OpMultiplication_Click(object sender, EventArgs e)
        {
            Result.DecimalValue = NumberA.DecimalValue * NumberB.DecimalValue;
            Result.LastValidNumber = Result.DecimalValue.ToString();

            UpdateNumberSummary(NumberField.Result);
        }

        private void OpSubtractB_Click(object sender, EventArgs e)
        {
            Result.DecimalValue = NumberA.DecimalValue - NumberB.DecimalValue;
            Result.LastValidNumber = Result.DecimalValue.ToString();

            UpdateNumberSummary(NumberField.Result);
        }

        private void OpSubtractA_Click(object sender, EventArgs e)
        {
            Result.DecimalValue = NumberB.DecimalValue - NumberA.DecimalValue;
            Result.LastValidNumber = Result.DecimalValue.ToString();

            UpdateNumberSummary(NumberField.Result);
        }
    }
}
