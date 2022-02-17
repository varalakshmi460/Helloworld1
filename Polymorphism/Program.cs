using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public interface HDFCBank
    {
        void GetBranchinfo();
        void displayinfo();
    }
    public interface SBIBank
    {
        void GetBranchinfo();
        void displayinfo();
    }
    public class emp1 : HDFCBank, SBIBank
    {
        string branchcode;
        string branchname, BranchAddress;
        public emp1()
        {
            branchcode = "101";
            branchname = "SBI";
        }
        public void GetBranchinfo()
        {

        }
        public void displayinfo()
        {
            Console.WriteLine("branch details" + branchcode + " " + branchname + " " + BranchAddress);
        }
        public virtual void Empdata()
        {
            Console.WriteLine("HDFCBank data");
        }
        void HDFCBank.displayinfo()
        {

        }
        void SBIBank.displayinfo()
        {

        }
        public class ATM : emp1
        {
            int empid;
            string empname;
           
            public override void Empdata()
            {
                Console.WriteLine("enter employee details");
                empid = Convert.ToInt32(Console.ReadLine());
                empname = Console.ReadLine();
                base.Empdata();
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                emp1 e = new emp1();
                e.Empdata();
                e.GetBranchinfo();
                e.displayinfo();
            }
        }
    }
}
