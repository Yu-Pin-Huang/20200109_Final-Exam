using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MilitaryTimeConversion
{
    public class Conv : IConvert
    {
        public string MilitaryTimeToRegularTime(string Time)
        {
            string militaryTime = Time;

            bool result = false;
            try
            {
                Regex pattern = new Regex(@"^(([0-1][0-9])|2[0-3]):([0-5][0-9])$");
                result = pattern.IsMatch(militaryTime);
            }
            catch (Exception exp)
            {
                //Console.WriteLine(exp.ToString());
                //return ("error");
                return (exp.ToString());
            }

            if (result == true)
            {
                string[] sArray = militaryTime.Split(':');
                if (sArray[0] == "00" || sArray[0] == "01" || sArray[0] == "02" || sArray[0] == "03" || sArray[0] == "04" || sArray[0] == "05" || sArray[0] == "06" || sArray[0] == "07" || sArray[0] == "08" || sArray[0] == "09" || sArray[0] == "10" || sArray[0] == "11")
                {
                    if (sArray[0] == "00")
                    {
                        sArray[0] = "12";
                    }
                    else if (sArray[0] == "01")
                    {
                        sArray[0] = "1";
                    }
                    else if (sArray[0] == "02")
                    {
                        sArray[0] = "2";
                    }
                    else if (sArray[0] == "03")
                    {
                        sArray[0] = "3";
                    }
                    else if (sArray[0] == "04")
                    {
                        sArray[0] = "4";
                    }
                    else if (sArray[0] == "05")
                    {
                        sArray[0] = "5";
                    }
                    else if (sArray[0] == "06")
                    {
                        sArray[0] = "6";
                    }
                    else if (sArray[0] == "07")
                    {
                        sArray[0] = "7";
                    }
                    else if (sArray[0] == "08")
                    {
                        sArray[0] = "8";
                    }
                    else if (sArray[0] == "09")
                    {
                        sArray[0] = "9";
                    }
                    return (sArray[0] + ":" + sArray[1] + " AM");
                }
                else if (sArray[0] == "12" || sArray[0] == "13" || sArray[0] == "14" || sArray[0] == "15" || sArray[0] == "16" || sArray[0] == "17" || sArray[0] == "18" || sArray[0] == "19" || sArray[0] == "20" || sArray[0] == "21" || sArray[0] == "22" || sArray[0] == "23")
                {
                    if (sArray[0] == "13")
                    {
                        sArray[0] = "1";
                    }
                    else if (sArray[0] == "14")
                    {
                        sArray[0] = "2";
                    }
                    else if (sArray[0] == "15")
                    {
                        sArray[0] = "3";
                    }
                    else if (sArray[0] == "16")
                    {
                        sArray[0] = "4";
                    }
                    else if (sArray[0] == "17")
                    {
                        sArray[0] = "5";
                    }
                    else if (sArray[0] == "18")
                    {
                        sArray[0] = "6";
                    }
                    else if (sArray[0] == "19")
                    {
                        sArray[0] = "7";
                    }
                    else if (sArray[0] == "20")
                    {
                        sArray[0] = "8";
                    }
                    else if (sArray[0] == "21")
                    {
                        sArray[0] = "9";
                    }
                    else if (sArray[0] == "22")
                    {
                        sArray[0] = "10";
                    }
                    else if (sArray[0] == "23")
                    {
                        sArray[0] = "11";
                    }
                    return (sArray[0] + ":" + sArray[1] + " PM");
                }
                else
                {
                    return ("error");
                }
            }
            else
            {
                return ("error");
            }
        }
    }
}
