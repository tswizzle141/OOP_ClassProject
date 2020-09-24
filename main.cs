using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Fraction;

namespace Fraction{
  public class frac{
    int numer; // mau so
    int denom; // tu so

    public frac(){
      this.denom = 0; 
      this.numer = 1;
    }

    public frac(int x,int y){
      this.denom = x;
      this.numer = y;
    }

    public frac addition(frac x,frac y){
      frac z = new frac();
      z.denom = x.denom*y.numer + y.denom*x.numer;
      z.numer = x.numer*y.numer;
      return z;
    }

    public static frac frac_add_int(frac x,int y){
      frac z = new frac();
      z.denom = x.denom*1 + y*x.numer;
      z.numer = x.numer;
      return z;
    }

    public frac subtraction(frac x,frac y){
      frac z = new frac();
      z.denom = x.denom*y.numer - y.denom*x.numer;
      z.numer = x.numer*y.numer;
      return z;
    }   

    public frac frac_subt_int(frac x,int y){
      frac z = new frac();
      z.denom = x.denom*1 - y*x.numer;
      z.numer = x.numer;
      return z;
    } 

    public frac multiplication(frac x,frac y){
      frac z = new frac();
      z.denom = x.denom*y.denom;
      z.numer = x.numer*y.numer;
      return z;
    } 

    public frac multiplication_int(frac x,int y){
      frac z = new frac();
      z.denom = x.denom*y;
      z.numer = x.numer;
      return z;
    } 

    public static frac operator * (frac x,frac y){
      return new frac(x.denom*y.denom,y.numer*x.numer);
    }

    public frac pow (int n){
      frac z = new frac();
      z = this;
      if(n==0) return new frac(1,1);
      if(n==1) return z;
      for(int i=1; i<n; i++){
        z*=this;
      }
	    return z;
    }

    public void print(){
      Console.WriteLine("Fraction Value: {0}/{1}", this.denom, this.numer);
    }
  }
}

namespace test{
  public class MAIN{
    public static void Main(){
      frac c1 = new frac(4,5);
      frac c2 = new frac(1,2);
      frac c3 = new frac(1,2);
      int c4 = 1;
      frac c5 = new frac(1,5);

      frac S = new frac(0,1);
      frac S1 = new frac(0,1);
      frac S2 = new frac(0,1);
		  frac S20 = new frac(0,1);
      frac S3 = new frac(0,1);
		  frac S4 = new frac(0,1);
      
      S1 = S1.addition(c2,c3);
      S1.print();
      S2 = S2.frac_subt_int(c5,c4);
      S20 = S20.multiplication_int(S2,-1);
		  S20.print();
      S3 = S3.multiplication(S1,S20);
		  S3.print();
		  S4 = c1.pow(2);
		  S4.print();
      S = S.multiplication(S3,c1.pow(2));
		  S.print();
    }
  }
}