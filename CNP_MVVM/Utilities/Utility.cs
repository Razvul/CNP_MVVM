using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNP_MVVM.Utilities
{
    public static class Utility
    {
        public static int GetMaxDays(int selectedIndex) // primeste ca argument SelectedItemLuni
        {
            switch (selectedIndex)
            {
                case 1: return 28;
                case 3:
                case 5:
                case 8:
                case 10: return 30;
                default: return 31;
            }
        } // returneaza numarul maxim de zile dintr-o luna

        public static string GetSex(string sex, string an)
        {
            string result = "";
            var an_numar = int.Parse(an);

            if (an_numar >= 1900 && an_numar < 2000)
            {
                if (sex.ToLower() == "masculin")
                {
                    result = "1";
                }
                else
                {
                    result = "2";
                }
            }
            if (an_numar >= 2000)
            {
                if (sex.ToLower() == "masculin")
                {
                    result = "5";
                }
                else
                {
                    result = "6";
                }
            }
            return result;
        }

        public static string GetYear(string an)
        {
            return an.Substring(2, 2);
        }

        public static string GetMonth(string luna)
        {
            string result;
            switch (luna.ToLower())
            {
                case "ianuarie":
                    result = "01";
                    break;
                case "februarie":
                    result = "02";
                    break;
                case "martie":
                    result = "03";
                    break;
                case "aprilie":
                    result = "04";
                    break;
                case "mai":
                    result = "05";
                    break;
                case "iunie":
                    result = "06";
                    break;
                case "iulie":
                    result = "07";
                    break;
                case "august":
                    result = "08";
                    break;
                case "septembrie":
                    result = "09";
                    break;
                case "octombrie":
                    result = "10";
                    break;
                case "noiembrie":
                    result = "11";
                    break;
                case "decembrie":
                    result = "12";
                    break;
                default:
                    result = "Wrong imput";
                    break;
            }
            return result;
        }

        public static string GetZi(string zi)
        {
            var numar = int.Parse(zi);
            string result;

            if (numar > 0 && numar < 10)
            {
                result = $"0{zi}";
            }
            else
            {
                result = zi;
            }
            return result;
        }

        public static string GetJudet(string judet)
        {
            string result;
            switch (judet.ToLower())
            {
                case "alba":
                    result = "01";
                    break;
                case "arad":
                    result = "02";
                    break;
                case "arges":
                    result = "03";
                    break;
                case "bacau":
                    result = "04";
                    break;
                case "bihor":
                    result = "05";
                    break;
                case "bistrita":
                    result = "06";
                    break;
                case "botosani":
                    result = "07";
                    break;
                case "brasov":
                    result = "08";
                    break;
                case "braila":
                    result = "09";
                    break;
                case "buzau":
                    result = "10";
                    break;
                case "caras":
                    result = "11";
                    break;
                case "cluj":
                    result = "12";
                    break;
                case "constanta":
                    result = "13";
                    break;
                case "covasna":
                    result = "14";
                    break;
                case "dambovita":
                    result = "15";
                    break;
                case "dolj":
                    result = "16";
                    break;
                case "galati":
                    result = "17";
                    break;
                case "gorj":
                    result = "18";
                    break;
                case "harghita":
                    result = "19";
                    break;
                case "hunedoara":
                    result = "20";
                    break;
                case "ialomita":
                    result = "21";
                    break;
                case "iasi":
                    result = "22";
                    break;
                case "ilfov":
                    result = "23";
                    break;
                case "maramures":
                    result = "24";
                    break;
                case "mehedinti":
                    result = "25";
                    break;
                case "mures":
                    result = "26";
                    break;
                case "neamt":
                    result = "27";
                    break;
                case "olt":
                    result = "28";
                    break;
                case "prahova":
                    result = "29";
                    break;
                case "satu mare":
                    result = "30";
                    break;
                case "salaj":
                    result = "31";
                    break;
                case "sibiu":
                    result = "32";
                    break;
                case "suceava":
                    result = "33";
                    break;
                case "teleorman":
                    result = "34";
                    break;
                case "timis":
                    result = "35";
                    break;
                case "tulcea":
                    result = "36";
                    break;
                case "vaslui":
                    result = "37";
                    break;
                case "valcea":
                    result = "38";
                    break;
                case "vrancea":
                    result = "39";
                    break;
                case "bucuresti":
                    result = "40";
                    break;
                case "bucuresti1":
                    result = "41";
                    break;
                case "bucuresti2":
                    result = "42";
                    break;
                case "bucuresti3":
                    result = "43";
                    break;
                case "bucuresti4":
                    result = "44";
                    break;
                case "bucuresti5":
                    result = "45";
                    break;
                case "bucuresti6":
                    result = "46";
                    break;
                case "calarasi":
                    result = "51";
                    break;
                case "giurgiu":
                    result = "52";
                    break;
                default:
                    result = "Wrong input";
                    break;
            }

            return result;
        }

        public static string GetNNN()
        {
            string nnn;
            var rnd = new Random();
            var x = rnd.Next(1, 1000);

            if (x < 10)
            {
                nnn = $"00{x}";
            }
            else if (x < 100)
            {
                nnn = $"0{x}";
            }
            else
            {
                nnn = x.ToString();
            }
            return nnn;
        }

        public static string GetCC(string sex, string an, string luna, string zi, string judet, string nnn)
        {
            var constanta = new int[12] { 2, 7, 9, 1, 4, 6, 3, 5, 8, 2, 7, 9 };
            var temp = $"{sex}{an}{luna}{zi}{judet}{nnn}";

            string cifraControl;
            var suma = 0;

            for (int i = 0; i < constanta.Length; i++)
            {
                var cifra = int.Parse(temp.Substring(i, 1));
                suma += cifra * constanta[i];
            }

            if (suma % 11 == 10)
            {
                cifraControl = "1";
            }
            else
            {
                cifraControl = (suma % 11).ToString();
            }
            return cifraControl;
        }

        public static string GetCNP(string SEX, string AN, string LUNA, string ZI, string JUDET, string NNN, string CC)
        {
            return $"{SEX}{AN}{LUNA}{ZI}{JUDET}{NNN}{CC}";
        }

        public static Guid GetNewId()
        {
            return Guid.NewGuid();
        }
    }
}