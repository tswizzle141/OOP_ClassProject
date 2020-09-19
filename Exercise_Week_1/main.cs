using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CSharp_Exercise_Week1;

namespace CSharp_Exercise_Week1{
  public class ReadNumber{

    /* Bai1: Nhap so nguyen 3 chu so, in ra cach doc */

    public void num_to_words(){
      int num;
      string words = "";
      int count = 0;

      do{
        if(count>0) Console.WriteLine("Incorrect! Enter number again!");
        Console.WriteLine("Enter number: ");
        words = Console.ReadLine();
        count++;
      }while(!int.TryParse(words, out num) || num<100 || num>999);

      string[] units = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
      string[] tens = {"zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};  

      words += "\n" + units[num/100] + "-hundred";
      num %= 100;

      if(num>0){
        if(words != "") words += "-and-";
        if(num<20) words += units[num];
        else{
          words += tens[num/10];
          if ((num%10)>0) words += "-" + units[num%10];
        }
      }
      Console.Write("{0}", words);
    }
  }

  public class QuadraticEquation{

    /* Bai2: Giai phuong trinh bac 2 voi cac he so nhap tu ban phim */

    public void quad_equa(){
      double a, b, c;
      string words;

      do{
        Console.WriteLine("Enter a: ");
        words = Console.ReadLine();
      }while(!double.TryParse(words, out a) || a==0);
      do{
        Console.WriteLine("Enter b: ");
        words = Console.ReadLine();
      }while(!double.TryParse(words, out b));
      do{
        Console.WriteLine("Enter c: ");
        words = Console.ReadLine();
      }while(!double.TryParse(words, out c));

      double delta = (b/2)*(b/2) - a*c;

      switch (delta <0){
        case true:
          double realPart = -b/(2*a);
          double imaginaryPart = Math.Sqrt(-delta)/(2*a);
          Console.WriteLine("x1 = {0} + {1}.i", realPart, imaginaryPart);
          Console.WriteLine("x2 = {0} - {1}.i", realPart, imaginaryPart);
          break;
        case false:
          switch (delta == 0){
            case true:
              double x = (-b/2)/a;
              Console.WriteLine("Twin solutions: x1 = x2 = {0}", x);
              break;
            default:
              double x1 = 0, x2 = 0;
              x1 = ((-b/2) - Math.Sqrt(delta))/a;
              x2 = ((-b/2) + Math.Sqrt(delta))/a;

              Console.WriteLine("Solutions: ");
              Console.WriteLine("x1 = {0}", x1);
              Console.WriteLine("x2 = {0}", x2);
              break;
          }
        break;
      }
    }
  } 

  public class PrimeFactorization{

    /* Bai3: Nhap vao 1 so nguyen duong, xuat ra dang phan tich thua so nguyen to cua so do */

    public void prime_factor(){
	    List<int> factors = new List<int>();
      int num;
      string str, words;

      do{
        Console.WriteLine("Enter number: ");
        words = Console.ReadLine();
      }while(!int.TryParse(words, out num) || num<1);

	    while (num%2==0){
		    factors.Add(2); num/=2;
	    }

	    for (int i=3; i<=Math.Sqrt(num); i+=2){
		    while (num%i==0){
			  factors.Add(i); num/=i;
		    }
	    }

	    if(num>2) factors.Add(num);
      int factors_size = factors.Count;
      str = String.Join("*", factors);
      Console.WriteLine("{0}",str);
    }
  }

  public class BinomialFactor{

    /* Bai4: Nhap so nguyen duong n va k, in ra gia tri C(n,k) cua to hop n lay k */

    public void binom_coeff_infor(){
      int n, k;
      string words;

      do{
        Console.WriteLine("Enter number n: ");
        words = Console.ReadLine();
      }while(!int.TryParse(words, out n) || n<1);
      do{
        Console.WriteLine("Enter number k: ");
        words = Console.ReadLine();
      }while(!int.TryParse(words, out k) || k<0 || k>n);

      Console.WriteLine("C(n,k) = {0}", binom_coeff_calc(n,k));
    }

    static long binom_coeff_calc(int n,int k){  
      if(k==0 || k==n) return 1; 
      else if(n==1) return 0;
      else return binom_coeff_calc(n-1,k-1) + binom_coeff_calc(n-1,k);
    }
  }

  public class MatrixOperation{

    /* Bai5: Thao tac tren ma tran */

    public void matrix_element_all(){ 
      int matrix_size, count=0;
      string words;

      do{
        if(count>0) Console.WriteLine("Incorrect matrix format! Enter again!");
        Console.WriteLine("Enter the matrix size: ");
        words = Console.ReadLine();
      }while(!int.TryParse(words, out matrix_size));

      int[,] matrix = new int[matrix_size,matrix_size];
      for(int i=0; i<matrix_size; i++){
        for(int j=0; j<matrix_size; j++){
          Console.WriteLine("mat[{0}][{1}] = ", i+1, j+1);
          matrix[i,j] = Convert.ToInt32(Console.ReadLine());
        }
      }

      Console.WriteLine("--------------------------");
      Console.WriteLine("Print matrix elements on the main diagonal:");
      Console.WriteLine("--------------------------");
      main_diagonal_element(matrix,matrix_size);

      Console.WriteLine("--------------------------");
      Console.WriteLine("Print matrix elements above the main diagonal:");
      Console.WriteLine("--------------------------");
      above_triangle_element(matrix,matrix_size);

      Console.WriteLine("--------------------------");
      Console.WriteLine("Print matrix elements below the main diagonal:");
      Console.WriteLine("--------------------------");
      below_triangle_element(matrix,matrix_size);

      Console.WriteLine("--------------------------");
      Console.WriteLine("Print matrix elements on the secondary diagonal:");
      Console.WriteLine("--------------------------");
      secondary_diagonal_element(matrix,matrix_size);

      Console.WriteLine("--------------------------");
      Console.WriteLine("Print matrix elements above the secondary diagonal:");
      Console.WriteLine("--------------------------");
      above_triangle_secondary_diagonal_element(matrix,matrix_size);

      Console.WriteLine("--------------------------");
      Console.WriteLine("Print matrix elements below the secondary diagonal:");
      Console.WriteLine("--------------------------");
      below_triangle_secondary_diagonal_element(matrix,matrix_size);
    }

    public void main_diagonal_element(int[,] matrix,int matrix_size){
    //Duyet cac phan tu tren duong cheo chinh
      for(int i=0; i<matrix_size; i++){
        for(int j=0; j<matrix_size; j++){
          if(i==j) Console.WriteLine("mat[{0}][{1}] = {2}", i+1, j+1, matrix[i,j]);
        }
      }
    }

    public void above_triangle_element(int[,] matrix, int matrix_size){
    //Duyet cac phan tu thuoc tam giac tren duong cheo chinh
      for(int i=0; i<matrix_size; i++){
        for(int j=0; j<matrix_size; j++){
          if(i<=j) Console.WriteLine("mat[{0}][{1}] = {2}", i+1, j+1, matrix[i,j]);
        }
      }
    }

    public void below_triangle_element(int[,] matrix, int matrix_size){
    //Duyet cac phan tu thuoc tam giac duoi duong cheo chinh
      for(int i=0; i<matrix_size; i++){
        for(int j=0; j<matrix_size; j++){
          if(i>=j) Console.WriteLine("mat[{0}][{1}] = {2}", i+1, j+1, matrix[i,j]);
        }
      }
    }

    public void secondary_diagonal_element(int[,] matrix, int matrix_size){
    //Duyet cac phan tu tren duong cheo phu
      for(int i=0; i<matrix_size; i++){
        for(int j=0; j<matrix_size; j++){
          if(i+j == matrix_size-1) Console.WriteLine("mat[{0}][{1}] = {2}", i+1, j+1, matrix[i,j]);
        }
      }
    }   

    public void above_triangle_secondary_diagonal_element(int[,] matrix, int matrix_size){
    //Duyet cac phan tu thuoc tam giac tren duong cheo phu
      for(int i=0; i<matrix_size; i++){
        for(int j=0; j<matrix_size; j++){
          if(i+j <= matrix_size-1) Console.WriteLine("mat[{0}][{1}] = {2}", i+1, j+1, matrix[i,j]);
        }
      }
    }
        
    public void below_triangle_secondary_diagonal_element(int[,] matrix, int matrix_size){
    //Duyet cac phan tu thuoc tam giac duoi duong cheo phu
      for(int i=0; i<matrix_size; i++){
        for(int j=0; j<matrix_size; j++){
          if(i+j >= matrix_size-1) Console.WriteLine("mat[{0}][{1}] = {2}", i+1, j+1, matrix[i,j]);
        }
      }
    }
  }

  public class BellmanFord{

    /* Bai6-7: Viet thuat toan Bellman-Ford tim duong di ngan nhat */

    public int INF = 1000000;
    public void graph_shortest_path(){
      string filein_path = "input.txt";

      string[] lines;
      lines = System.IO.File.ReadAllLines(filein_path);

      int vertices = 0, edges = 0, src_point = 0, dest_point = 0;
      if (System.IO.File.Exists(filein_path)){
        for (int j=0; j<lines[0].Length; j++){
          string[] arr = lines[0].Split(' ');
          vertices = Convert.ToInt32(arr[0]);
          edges = Convert.ToInt32(arr[1]);
          src_point = Convert.ToInt32(arr[2])-1;
          dest_point = Convert.ToInt32(arr[3])-1;
        }

        int[,] adj_matrix = new int[vertices,vertices];
        for(int i=0; i<vertices; i++){
          for(int j=0; j<vertices; j++){
            if(i==j) adj_matrix[j,j] = 0;
            else adj_matrix[i,j] = INF;
          }
        }
                
        for(int i=1; i<=edges; i++){
          string[] arr1 = lines[i].Split(' ');
          adj_matrix[Convert.ToInt32(arr1[0])-1,Convert.ToInt32(arr1[1])-1] = Convert.ToInt32(arr1[2]);
        }

        int[] trace = new int[vertices];
        int[] distance = new int[vertices];
        for(int i=0; i<vertices; i++){
          distance[i] = INF;
          trace[i] = 0;
        }
        distance[src_point] = 0;
                
        for(int k=0; k<vertices-1; k++){
          for(int i=0; i<vertices; i++){
            for(int j=0; j<vertices; j++){ 
              if(adj_matrix[i,j]<INF){
                if (distance[i] + adj_matrix[i,j] < distance[j]){
                  distance[j] = distance[i] + adj_matrix[i,j];
                  trace[j] = i;
                }
              }
            }
          }     
        }

        string fileout_path = "output.txt";
        string distance_str = "Distance from "+(src_point+1)+" to "+(dest_point+1)+" : "+distance[dest_point]+"\n";
        string graph_path = (dest_point+1)+"<-";
                
        do{
          dest_point = trace[dest_point];
          graph_path += (dest_point+1)+"<-"; 
        }while(dest_point>src_point+1);

        System.IO.File.WriteAllText(fileout_path, distance_str + graph_path + (dest_point+1));
      }

      else{
        Console.WriteLine("File does not exist!");
      }
    } 
  }

  public class MAIN{
          
    public static void Main(){
      Console.WriteLine("My exercises are ordered such that each solution is in a/some fucntions, all put in a public class.\n Teacher Thang, you shoud choose to type one in keywords: 'Exercise 1', 'Exercise 2', 'Exercise 3', 'Exercise 4', 'Exercise 5', 'Exercise 6-7'.\n If you type incorrect keywords, the code system will warn and block you.\n ");

      Console.WriteLine("Teacher Thang, type the exercises you want to check: ");
      string exercise_string = Console.ReadLine();

      if(exercise_string == "Exercise 1"){
        Console.WriteLine("Given a 3-digit number, read the number.");
        ReadNumber n = new ReadNumber();
        n.num_to_words();
        Console.WriteLine("\nDone!");
      }

      else if (exercise_string == "Exercise 2"){
        Console.WriteLine("Given coefficients a,b,c; solve the quadratic equation.");
        QuadraticEquation q = new QuadraticEquation();
        q.quad_equa();
        Console.WriteLine("\nDone!");
      } 

      else if (exercise_string == "Exercise 3"){
        Console.WriteLine("Given a number, give out its prime-factorization form.");
        PrimeFactorization n = new PrimeFactorization();
        n.prime_factor();
        Console.WriteLine("\nDone!");
      }

      else if (exercise_string == "Exercise 4"){
        Console.WriteLine("Given n and k, calculate combination C(n,k) recursively.");
        BinomialFactor b = new BinomialFactor();
        b.binom_coeff_infor();
        Console.WriteLine("\nDone!");
      }

      else if (exercise_string == "Exercise 5"){
        Console.WriteLine("Matrix Operations");
        MatrixOperation mat = new MatrixOperation();
        mat.matrix_element_all();
        Console.WriteLine("\nDone!");
      }

      else if (exercise_string == "Exercise 6-7"){
        Console.WriteLine("Applying Bellman-Ford algorithm to find the graph's shortest path.\n Please see result in the output.txt file.");
        BellmanFord bf = new BellmanFord();
        bf.graph_shortest_path();
        Console.WriteLine("\nDone!");
      }

      else Console.WriteLine("Incorrect exercise! Please execute again and type the exercise correctly!");
    }
  }
}