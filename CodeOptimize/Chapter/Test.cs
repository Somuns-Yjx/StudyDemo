using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Chapter
{
    class Test
    {
        public class ImplictConvert
        {
            public class Ip
            {
                IPAddress value;
                public Ip(string ip)
                {
                    value = IPAddress.Parse(ip);
                }
                public static implicit operator Ip(string ip)
                {
                    Ip iptemp = new Ip(ip);
                    return iptemp;
                }
                public override string ToString()
                {
                    return value.ToString();
                }
            }
        }

        public class ImplictConvert2
        {
            public class Ip
            {
                IPAddress value;
                public Ip(string ip)
                {
                    value = IPAddress.Parse(ip);
                }
                public static implicit operator Ip(string ip)
                {
                    Ip iptemp = new Ip(ip);
                    return iptemp;
                }
            }
            class Ip : IConvertible
            {
                public bool ToBoolean(IFormatProvider provider)
                {
                    throw new InvalidCastException("Ip-to-Boolean conversion is not supported.");
                }
                public string ToString(IFormatProvider provider)
                {
                    return value.ToString();
                }
            }
        }
    }
}