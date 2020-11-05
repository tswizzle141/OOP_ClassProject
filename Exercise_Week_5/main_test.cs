using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Program;

namespace Program{
  public interface IBook{
    string this[int index]{
      set; get;
    }
        
    string Title{
      get; set;
    }

    string Author{
      get; set;
    }

    string Publisher{
      get; set;
    }

    string ISBN{
      get; set;
    }

    int Year{
      get; set;
    }

    void Show();
  }

  public class Book : IBook, IComparable<Book>{
    private string isbn;
    private string title;
    private string author;
    private string publisher;
    private int year;
    private ArrayList chapter = new ArrayList();
    
    public string this [int index]{
      get{
        if (index>=0 && index <chapter.Count) return (string) chapter[index];
        else throw new IndexOutOfRangeException();
      }
            
      set{
        if (index>=0 && index <chapter.Count) chapter[index]=value;
        else if (index==chapter.Count) chapter.Add(value);
        else throw new IndexOutOfRangeException();
      }
    }

    public string Title{
      get {return title;}
      set {title = value;}
    }

    public string Author{
      get{return author;}
      set{author=value;}
    }

    public string Publisher{
      get {return publisher;}
      set {publisher=value;}
    }

    public string ISBN{
      get {return isbn;}
      set {isbn=value;}
    }

    public int Year{
      get {return year;}
      set {year=value;}
    }

    public void Show(){
      Console.WriteLine("---------------------------");
      Console.WriteLine("Title: " + title);
      Console.WriteLine("Author: " + author);
      Console.WriteLine("Publisher: " + publisher);
      Console.WriteLine("Year: " + year);
      Console.WriteLine("ISBN: " + isbn);
      Console.WriteLine("Chapter: ");
      for (int i=0; i<chapter.Count; i++)
        Console.WriteLine("\t{0}: {1}", i+1, chapter[i]);
      Console.WriteLine("---------------------------");
    }

    public void Input(){
      Console.Write("Title: "); title = Console.ReadLine();
      Console.Write("Author: "); author = Console.ReadLine();
      Console.Write("Publisher: "); publisher = Console.ReadLine();
      Console.Write("ISBN: "); isbn = Console.ReadLine();
      Console.Write("Year : "); year = int.Parse(Console.ReadLine());
      Console.WriteLine("Input chapter (finished with empty string)");
      string str;
      do{
        str=Console.ReadLine();
        if (str.Length > 0) chapter.Add(str);   
      }while (str.Length>0);
    }

    public int YearCompareTo(Book _b)
      return this.Year.CompareTo(_b.Year);
    }

    public int AuthorCompareTo(Book _b){
      return this.Author.CompareTo(_b.Author);
    }

    public int PublisherCompareTo(Book _b){
      return this.Publisher.CompareTo(_b.Publisher);
    }

    public int ISBNCompareTo(Book _b){
      return this.ISBN.CompareTo(_b.ISBN);
    }
  }

  public class BookList{
    private ArrayList list = new ArrayList();
    public void AddBook(){
      Book book= new Book();
      b.Input(); list.Add(b);
    }

    public void ShowList(){
      foreach (Book b in list)
        b.Show();
    }

    public void InputList(){
      int n;
      Console.Write("Amount of book: ");
      n = int.Parse(Console.ReadLine());
      while (n>0){
        AddBook(); n--;           
      }
    }

    internal static void Sort(AuthorComparer authorComparer){
      throw new NotImplementedException();
    }
  }
    
  public class AuthorComparer : IComparer<Book>{
    public int Compare(Book x, Book y){
      return x.Author.CompareTo(y.Author);
    }
  }

  public class YearComparer : IComparer<Book>{
    public int Compare(Book x, Book y){
      return x.Year.CompareTo(y.Year);
    }
  }

  public class PublisherComparer : IComparer<Book>{
    public int Compare(Book x, Book y){
      return x.Publisher.CompareTo(y.Publisher);
    }
  }

  public class MAIN{
    public static void Main(){   
      BookList b1 = new BookList();
      b1.InputList();
      b1.ShowList();

      BookList.Sort(new AuthorComparer());
      BookList.Sort(new YearComparer());
      BookList.Sort(new PublishComparer());
    }
  }
}