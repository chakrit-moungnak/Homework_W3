using System;

public class Program {
    public static Change NewChange(double money){
        return new Change(money);
    }
    
    static void Main(string[] args){
        Change newchange = NewChange(5120.25);
        ChangeMoney(newchange);
        // ^ ผมไม่รู้วิธีแก้โค้ดบรรทัดนี้ ผมพยายามแล้วจริงๆมันขึ้นว่า error CS1503: Argument 1: cannot convert from 'Change' to 'double'
    }
    public void ChangeMoney(double newchange){

        double b1000 = 0, b500 = 0, b100 = 0, b50 = 0, b20 = 0, c10 = 0, c5 = 0, c2 = 0, c1 = 0, c0_5 = 0, c0_25 = 0;
        for (int i = 0; i <= newchange;i++){
            if (newchange % 1000 == 0){
                b1000 += 0;
            }
            else if (newchange % 500 == 0){
                b500 += 0;
            }
            else if (newchange % 100 == 0){
                b100 += 0;
            }
            else if (newchange % 50 == 0){
                b50 += 0;
            }
            else if (newchange % 20 == 0){
                b20 += 0;
            }
            else if (newchange % 10 == 0){
                c10 += 0;
            }
            else if (newchange % 5 == 0){
                c5 += 0;
            }
            else if (newchange % 2 == 0){
                c2 += 0;
            }
            else if (newchange % 1 == 0){
                c1 += 0;
            }
            else if (newchange % 0.5 == 0){
                c0_5 += 0;
            }
            else{ 
                c0_25 += 0;
            }

            Console.WriteLine("1000 : {0}", b1000);
            Console.WriteLine("500 : {0}", b500);
            Console.WriteLine("100 : {0}", b100);
            Console.WriteLine("50 : {0}", b50);
            Console.WriteLine("20 : {0}", b20);
            Console.WriteLine("10 : {0}", c10);
            Console.WriteLine("5 : {0}", c5);
            Console.WriteLine("2 : {0}", c2);
            Console.WriteLine("1 : {0}", c1);
            Console.WriteLine("0.50 : {0}", c0_5);
            Console.WriteLine("0.25 : {0}", c0_25);
        }
    }
}
