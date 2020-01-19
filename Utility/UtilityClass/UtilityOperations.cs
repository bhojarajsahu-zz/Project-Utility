using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities.UtilityClass
{
    static class UtilityOperations
    {
        public static int GetInputLength(string displayFormat)
        {
            try
            {
                string firstChar = displayFormat.Substring(0, 1);
                int len = 0;
                string lenChar = "";

                #region SWITCH Appproach
                switch (firstChar)
                {
                    case "X":
                    case "9":
                        if (displayFormat.Contains("("))
                        {
                            lenChar = displayFormat.Substring(displayFormat.IndexOf("("), displayFormat.Length - 1);
                            lenChar = lenChar.Substring(1, lenChar.IndexOf(")") - 1);
                            len = Convert.ToInt32(lenChar);
                        }
                        else
                            len = displayFormat.Length;
                        break;
                    default:
                        len = 10;
                        break;
                }
                #endregion

                return len;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
