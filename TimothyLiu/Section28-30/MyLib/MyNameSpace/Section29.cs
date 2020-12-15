using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.MyNameSpace
{
    // 接口
    public interface IPhone
    {
        void Dail();
        void PickUp();
        void SendMsg();
        void RecvMsg();
    }
    public class PhoneUser
    {
        private IPhone _phone;
        public PhoneUser(IPhone phone)
        {
            _phone = phone;
        }
        public void UsePhone()
        {
            _phone.Dail();
            _phone.PickUp();
            _phone.SendMsg();
            _phone.RecvMsg();
        }
    }

    public class NokiaPhone : IPhone
    {
        public void Dail()
        {
            Console.WriteLine("Nokia dails .");
        }
        public void PickUp()
        {
            Console.WriteLine("Nokia picks up .");
        }
        public void SendMsg()
        {
            Console.WriteLine("Nokia Sends messages .");
        }
        public void RecvMsg()
        {
            Console.WriteLine("Nokia receives messages .");
        }
    }
    public class Huawei : IPhone
    {
        public void Dail()
        {
            Console.WriteLine("Huawei dails .");
        }
        public void PickUp()
        {
            Console.WriteLine("Huawei picks up .");
        }
        public void SendMsg()
        {
            Console.WriteLine("Huawei Sends messages .");
        }
        public void RecvMsg()
        {
            Console.WriteLine("Huawei receives messages .");
        }
    }

    //-------------------------------依赖反转-----------------------------//
    public interface IPowerSuply
    {
         int GetPower();
    }
    public class PowerSuply : IPowerSuply
    {
        public int GetPower() { return 200; }
    }
    public class DeskFan
    {
        private IPowerSuply _powerSuply;
        public DeskFan(IPowerSuply powerSuply)
        {
            _powerSuply = powerSuply;
        }

        public string Work()
        {
            int power = _powerSuply.GetPower();
            if (power <= 0)
                return "Doesn't work ";
            else if (power <= 100)
                return "Work slowly";
            else if (power <= 200)
                return "Work Fine";
            else
                return "Work Out !";
        }
    }

}
