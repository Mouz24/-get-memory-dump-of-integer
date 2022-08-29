using System;
using System.Text;

namespace BinaryRepresentation
{
    public static class BitsManipulation
    {
        /// <summary>
        /// Get binary memory representation of signed long integer.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>Binary memory representation of signed long integer.</returns>
        public static string GetMemoryDumpOf(long number)
        {
            var sb = new StringBuilder();
            int length = 0;
            if (number < 0)
            {
                return Convert.ToString(number, 2);
            }
            else
            {
                while (length != 64)
                {
                    if ((number & 1) == 1)
                    {
                        sb.Insert(0, '1');
                        length++;
                    }
                    else
                    {
                        sb.Insert(0, '0');
                        length++;
                    }

                    number >>= 1;
                }
            }

            return sb.ToString();
        }
    }
}
