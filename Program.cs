using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class info
    {
        public void choose()
        {
           
                Console.WriteLine("Welcome to BANK");
                Console.WriteLine("*************************");
                Console.WriteLine("The type of accounts available are listed below");
                Console.WriteLine("press 1------------> savings account");
                Console.WriteLine("press 2------------>current account");
                Console.WriteLine("press 3------------> childcare account");
                Console.WriteLine("presss any number------------> invalid account");
                Console.WriteLine("enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("you are going  to choose a saving account");
                        Console.WriteLine("enter your details");
                        customerdetails cd1 = new customerdetails();
                        cd1.details();
                        cd1.display();
                        Console.WriteLine("enter your  amount to deposit");

                        int amount0 = Convert.ToInt32(Console.ReadLine());

                        if (amount0 <= 100000)
                        {
                            Console.WriteLine("Your amount gets deposited");

                        }
                        else
                        {
                            try
                            {
                                if (amount0 > 100000)
                                {
                                    Console.WriteLine("your amount limit is gets exceded");
                                    throw new Exception();
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("issues araises during deposited" + e);
                            }
                            finally
                            {
                                Console.WriteLine("Try after some time....");
                            }
                        }
                        cd1.atm();
                        break;
                    case 2:
                        Console.WriteLine("you going to choose a cuurrent account");
                        customerdetails cd2 = new customerdetails();
                        cd2.details();
                        cd2.display();
                        Console.WriteLine("your account limit is  200000");
                        Console.WriteLine("enter your  amount1 ");
                        int amount1 = Convert.ToInt32(Console.ReadLine());
                        if (amount1 <= 200000)
                        {
                            Console.WriteLine("Yor amount deposited");
                        }
                        else
                        {
                            try
                            {
                                if (amount1 > 200000)
                                {
                                    Console.WriteLine("your amount limit is gets exceded");
                                    throw new Exception();
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("issues araises during deposited" + e);
                            }
                            finally
                            {
                                Console.WriteLine("Try after some time....");
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("you are going to choose child care account");
                        customerdetails cd3 = new customerdetails();
                        cd3.details();
                        cd3.display();
                        Console.WriteLine("your account limit is  500000");
                        Console.WriteLine("enter your  amount ");
                        int amount2 = Convert.ToInt32(Console.ReadLine());
                        if (amount2 <= 500000)
                        {
                            Console.WriteLine("Your amount is deposited");
                        }
                        else
                        {
                            try
                            {
                                if (amount2 > 500000)
                                {
                                    Console.WriteLine("your amount limit is gets exceded");
                                    throw new Exception();
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("issues araises during deposited" + e);
                            }
                            finally
                            {
                                Console.WriteLine("Try after some time....");
                            }
                        }
                        break;
                default:
                        Console.WriteLine("entered number is invalid");
                        break;
                }

            }
        
        public class AgeException : Exception
        {
            public AgeException() : base()
            {
                Console.WriteLine("exception occured...please enter correct age");
            }
        }
        public class customerdetails
        {
            string name;
            int age;
            string address;
            //int mobileno;
            public void details()
            {
                Console.WriteLine("enter your name");
                name = Console.ReadLine();
                Console.WriteLine("enter your age");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter your address");
                address = Console.ReadLine();
                //Console.WriteLine("enter your mobileno");
                //mobileno = Convert.ToInt32(Console.ReadLine());
            }
            public void display()
            {
                Console.WriteLine("entered details are");
                Console.WriteLine("******************************");
                Console.WriteLine(name + " " + age + " " + address);
            }
            public void atm()
            {
                Console.WriteLine("How much money you want to credit---");
                int available = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("the available balance is:" + available);
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine("enter  1.-->to withdrawmoney  2--->checking balance    3--->exit");
                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            //Console.WriteLine("do you want to withdraw money");
                            Console.WriteLine("how much amount do you want to withdraw");
                            int wd = Convert.ToInt32(Console.ReadLine());
                            if (available >= wd)
                            {
                                Console.WriteLine("you has withdraw successfully");
                                //money = available - money;
                                Console.WriteLine("you are withdraw" + wd + "money");
                                available = available - wd;
                                Console.WriteLine("your balance is" + available);
                            }
                            else
                            {
                                Console.WriteLine("insufficient amount to withdraw");
                            }
                            if (i >= 3)
                            {
                                Console.WriteLine("limit exceeded");
                                //Console.WriteLine("your available  amount is deducted ");
                                //int deduct = available - 500;
                                //Console.WriteLine(" deducted from available amount" + deduct);
                            }
                            break;
                        //if (option == 2)
                        case 2:
                            Console.WriteLine("your availabele balance is" + available);
                            break;

                        //if(option == 3)
                        case 3:

                            Console.WriteLine("Thanks for visiting our branch");
                            Environment.Exit(0);
                            Console.ReadKey();

                            break;
                        default:
                            Console.WriteLine("invalid option");
                            break;

                    }
                }
            }

            class sample
            {
                public void displaycustdetails()
                {

                    customer cust0 = new customer()
                    {

                        name = "mouni",
                        age = 21,
                        accountno = 101345,
                        deposited = 1000
                    };
                    customer cust1 = new customer()
                    {

                        name = "depti",
                        age = 22,
                        accountno = 101346,
                        deposited = 2000
                    };
                    customer cust2 = new customer()
                    {
                        name = "pavan",
                        age = 22,
                        accountno = 101347,
                        deposited = 2000
                    };
                    customer cust3 = new customer()
                    {

                        name = "lasya",
                        age = 32,
                        accountno = 101348,
                        deposited = 3000
                    };
                    customer cust4 = new customer()
                    {

                        name = "manju",
                        age = 23,
                        accountno = 101349,
                        deposited = 4000
                    };
                    List<customer> cu = new List<customer>();
                    cu.Add(cust0);
                    cu.Add(cust1);
                    cu.Add(cust2);
                    cu.Add(cust3);
                    cu.Add(cust4);
                    Console.WriteLine(" || name || age || accountno || deposited ||");
                    Console.WriteLine("***********************************************");
                    string filepath = "c:\\cutomer";
                    StreamWriter sw = new StreamWriter(filepath);
                    foreach (customer c in cu)
                    {
                        sw.WriteLine(c.name + "\t");
                        sw.WriteLine(c.age + "\t");
                        sw.WriteLine(c.accountno + "\t");
                        sw.WriteLine(c.deposited + "\t");
                        sw.WriteLine("--------------------");
                    }
                    sw.Close();
                    foreach (customer c in cu)
                    {
                        Console.WriteLine(" || {0} || {1} || {2} || {3} ||", c.name, c.age, c.accountno, c.deposited);
                    }
                    Console.WriteLine("************************************************");
                }
            }


            //class mean
            //{
            //    int amount, trans;
            //    public delegate  void transaction();
            //    public void amt()
            //    {
            //        Console.WriteLine("enter amount to transfer ");
            //        amount = Convert.ToInt32(Console.ReadLine());
            //        trans = trans + amount;
            //        Console.WriteLine("the transaction amount is  " + trans);

            //    }
            public class customer
            {
                public string name
                {
                    get; set;
                }
                public int age
                {
                    get;
                    set;
                }

                public int accountno
                {
                    get;
                    set;
                }
                public int  deposited
                {
                    get;
                    set;
                }

            }


            class Program
            {
                static void Main(string[] args)
                {
                    info i = new info();
                    i.choose();
                    customerdetails cd = new customerdetails();
                    sample s = new sample();
                    s.displaycustdetails();
                    //customer cust = new customer();
                    //cust.displaycustdetails();
                    // Console.WriteLine("name" + cust0.name + "||" + cust1.name + "||" + cust2.name + "||" + cust3.name + "||" + cust4.name
                    //customer cust0 = new customer()
                    //{

                    //    name = "amar",
                    //    age = 21,
                    //    accountno = 101345,
                    //    transaction = 1000
                    //};
                    //    customer cust1 = new customer()
                    //    {

                    //        name = "deepti",
                    //        age = 22,
                    //        accountno = 101346,
                    //        transaction = 2000
                    //    };
                    //    customer cust2 = new customer()
                    //    {
                    //        name = "pavani",
                    //        age = 22,
                    //        accountno = 101347,
                    //        transaction = 2000
                    //    };
                    //    customer cust3 = new customer()
                    //    {

                    //        name = "bhagya",
                    //        age = 32,
                    //        accountno = 101348,
                    //        transaction = 3000
                    //    };
                    //    customer cust4 = new customer()
                    //    {

                    //        name = "deepti",
                    //        age = 23,
                    //        accountno = 101349,
                    //        transaction = 4000
                    //    };
                    //    List<customer> cu = new List<customer>();
                    //    cu.Add(cust0);
                    //    cu.Add(cust1);
                    //    cu.Add(cust2);
                    //    cu.Add(cust3);
                    //    cu.Add(cust4);
                    //    foreach (customer c in cu)
                    //    {
                    //        Console.WriteLine("retrieving the data ");
                    //        Console.WriteLine("name={0},age={1},accountno={2},transaction={3}", c.name, c.age, c.accountno, c.transaction + "||"););
                    //Console.WriteLine("name" + cust0.age + "||" + cust1.age + "||" + cust2.age+ "||" + cust3.age+ "||" + cust4.age);
                    //Console.WriteLine("name" + cust0.accountno + "||" + cust1.accountno + "||" + cust2.accountno + "||" + cust3.accountno + "||" + cust4.accountno);
                    //Console.WriteLine("name" + cust0.transaction+ "||" + cust1.transaction + "||" + cust2.transaction + "||" + cust3.transaction + "||" + cust4.transaction);
                    //Console.ReadKey();
                    //}
                    Console.ReadKey();
                }

                // mean m = new mean();
                //transaction de = new transaction(m.amt);
                //de();
                //Console.ReadKey();
            }
        }
    }
}







