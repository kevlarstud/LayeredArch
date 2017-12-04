using System;
using BankBEntities;
using BankClassLiB;
using System.Collections.Generic;
using System.IO;
namespace BankConsoleUI
{
    class Program
    {
        static void EmailAlert(CAccountsEnt entobj)
        {
            Console.WriteLine("Your Balance has been changed");
        }
        static void Main(string[] args)
        {
            List<CAccountsEnt> listobj = new List<CAccountsEnt>();
            CAccountsEnt[] accentobj = new CAccountsEnt[1];
            for (int counter = 0; counter < accentobj.Length; counter++)
            {
                accentobj[counter] = new CAccountsEnt();
            }
            for (int counter = 0; counter < accentobj.Length; counter++)
            {
                Console.WriteLine("Enter Account No");
                accentobj[counter].ACCOUNTNO = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Account Holder Name");
                accentobj[counter].ACC_HOLD_NAME = Console.ReadLine();
                Console.WriteLine("Enter Account Type");
                accentobj[counter].ACC_TYPE = Console.ReadLine();
                Console.WriteLine("Enter Transaction Type");
                accentobj[counter].TRANS_TYPE = Console.ReadLine();
                Console.WriteLine("Enter Amount");
                accentobj[counter].AMOUNT = Convert.ToDecimal(Console.ReadLine());
                
            }
            listobj.AddRange(accentobj);
            foreach (var item in listobj)
            {
                Console.WriteLine("Account No is {0} ",item.ACCOUNTNO);
                Console.WriteLine("Account Name is {0} ", item.ACC_HOLD_NAME);
                Console.WriteLine("Account Type is {0} ", item.ACC_TYPE);
                Console.WriteLine("Transaction Type is {0} ", item.TRANS_TYPE);
                Console.WriteLine("Amount is {0} ", item.AMOUNT);
                //Console.WriteLine("Your Balance  is {0} ", item.BALANCE);
            }
            CSavingAccounts accobj = new CSavingAccounts(accentobj[0]);
            //Registring the Listners
            accobj.onbalchange += new Onbalancechange(EmailAlert);
            Console.WriteLine(accobj.BALANCE);
            Console.WriteLine("Enter the Amount to Withdraw");
            accentobj[0].AMOUNT = decimal.Parse(Console.ReadLine());
            FileStream fileStream01 = new FileStream("E:\\test.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream01);
            foreach (var item in accentobj)
            {
                streamWriter.Write(item.ACCOUNTNO);
                streamWriter.Write(item.ACC_HOLD_NAME);
                streamWriter.Write(item.ACC_TYPE);
                streamWriter.Write(item.TRANS_TYPE);
                streamWriter.Write(item.AMOUNT);
                streamWriter.Write(streamWriter.NewLine);
            }
            
            
            streamWriter.Flush();
            streamWriter.Close();
            fileStream01.Close();


            FileStream fileStream02 = new FileStream("e:\\test.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream02);
           // CAccountsEnt accentobj1 = streamReader.;
            //while (ch > 0)
            //{
            //    Console.Write((char)ch);
            //    ch = streamReader.Read();
            //}
            //streamReader.Read();
            //streamReader.Close();
            //fileStream02.Close();
            try
            {
                accobj.mWithdraw(accentobj[0]);
            }
            catch(InSufficientFundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(accobj.BALANCE);
            
        }
    }
}
