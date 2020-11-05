using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Linq.Expressions;
using Program;

namespace Program{
  public class Account{
    private string _AccountID;
    private string _FirstName;
    private string _LastName;
    private int _Balance;

    public Account(){
      this._AccountID = null; this._FirstName = null; this._LastName = null; this._Balance = 0;
    }

    public Account(string ID, string first_name, string last_name, int balance){
      this._AccountID = ID; this._FirstName = first_name; this._LastName = last_name; this._Balance = balance;
    }

    public string AccountID{
      get{return _AccountID;}
      set{_AccountID = value;}
    }

    public string FirstName{
      get{return _FirstName;}
      set{_FirstName = value;}
    }

    public string LastName{
      get{return _LastName;}
      set{_LastName = value;}
    }

    public int Balance{
      get{return _Balance;}
      set{_Balance = value;}
    }

    public void AccountInput(){
      Console.WriteLine("Account ID: "); _AccountID = Console.ReadLine();
      Console.WriteLine("First Name: "); _FirstName = Console.ReadLine();
      Console.WriteLine("Last Name: "); _LastName = Console.ReadLine();
      Console.WriteLine("Balance: "); _Balance = int.Parse(Console.ReadLine());
    }

    public void AccountOutput(){
      Console.WriteLine(); Console.WriteLine("Account ID: " + _AccountID);
      Console.WriteLine("First Name: " + _FirstName); Console.WriteLine("Last Name: " + _LastName);
      Console.WriteLine("Balance: " + _Balance);
    }
  }

  public class AccountList{
    List<Account> list = new List<Account>();
        
    public void addAccount(){
      Account a = new Account();
      a.AccountInput(); list.Add(a);
    }

    public void SaveFile(){
      Console.WriteLine("Enter the file name: ");
      string filename = Console.ReadLine();
      try{
        FileStream output = new FileStream(filename, FileMode.CreateNew, FileAccess.Write);
        StreamWriter sw = new StreamWriter(output);
        foreach (Account acc in list){
          sw.WriteLine("{0}, {1}, {2}, {3}", acc.AccountID, acc.FirstName, acc.LastName, acc.Balance);
        }
        sw.Close(); output.Close();
      }
      catch (IOException e){ 
        Console.WriteLine(e.Message); 
      }
    }
        
    public void LoadFile(){
      Console.Write("Enter the filename: ");
      string filename = Console.ReadLine();
      list.Clear();
      try{
        FileStream input = new FileStream(filename, FileMode.Open, FileAccess.Read);
        StreamReader sr = new StreamReader(input);
        string str;
        while ((str = sr.ReadLine()) != null){
          string[] l = str.Split(',');
          Account a = new Account(l[0], l[1], l[2], int.Parse(l[3]));
          list.Add(a);
        }
        input.Close(); sr.Close();
      }
      catch (IOException e){
        Console.WriteLine(e.Message); 
      }
    }

    public void report(){
      foreach (Account a in list)
        a.AccountOutput();
        Console.ReadLine();
    }

    public void Remove(Account acc){
      if (list.Count == 0) return;
      list.Remove(acc);
      Console.WriteLine("\n Account removed");
    }

    public void Remove(Account acc, IComparer comparer){
      int index = Binary_Find(acc, comparer);
      if (index<0 || index>=acc.Count){
        Console.WriteLine("\n Account not found");
        return;
      }
      acc.RemoveAt(index);
      Console.WriteLine("\n Account removed");
    }

    public int Binary_Find(Account acc, IComparer comparer){
      return list.BinarySearch(acc, comparer);
    }

    public void Clear(){
      if (list.Count==0) return;
      list.Clear();
      Console.WriteLine("\n List clear");
    }
  }

  public class ID : IComparer{
    public static ID instance = new ID();

    public int Compare(object x, object y){
      Account _x = (Account) x;
      Account _y = (Account) y;
      return _x.ID.CompareTo(_y.ID);
    }
  }

  public class First_Name : IComparer{
    public static First_Name instance = new First_Name();

    public int Compare(object x, object y){
      Account _x = (Account) x;
      Account _y = (Account) y;
      return _x.FirstName.CompareTo(_y.FirstName);
    }
  }

  public class LastName : IComparer{
    public static Last_Name instance = new Last_Name();

    public int Compare(object x, object y){
      Account _x = (Account) x;
      Account _y = (Account) y;
      return _x.Last_Name.CompareTo(_y.Last_Name);
    }
  }

  public class Balance_ : IComparer {
    public static Balance_ instance = new Balance_();

    public int Compare(object x, object y){
      Account _x = (Account) x;
      Account _y = (Account) y;
      return _x.Balance_.CompareTo(_y.Balance_);
    }
  }

  public class MAIN{
    public static void Main(){
      string c;
      AccountList list = new AccountList();
      do{
        Console.WriteLine("---------------------------");
        Console.WriteLine("1.Add\n2.Load\n3.Save\n4.Report\n5.Exit");
        Console.WriteLine("Enter your choice: ");
        c = Console.ReadLine();
        switch (c){
          case "1": list.addAccount(); break;
          case "2": list.LoadFile(); break;
          case "3": list.SaveFile(); break;
          case "4": list.report(); break;
        }
      }while(c!="5");
    }
  }
}
