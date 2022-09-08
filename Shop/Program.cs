using System;

public class Program {
    public static Shop NewShop(string shopname, string ownername, ulong serialnumber, ulong value){
        return new Shop(shopname, ownername, serialnumber, value);
    }

    static void Main(string[] args){
        Shop newshop = NewShop("มีเดียการค้า", "นาย เจมส์ทองดี", 7124574235102, 1000000);
        PrintInfomation(newshop);
    }
    public static void PrintInfomation(Shop shop){
        Console.WriteLine("---------------Shop Information---------------");
        Console.WriteLine("Name : {0}", shop.shopname);
        Console.WriteLine("Number : {0}", shop.serialnumber);
        Console.WriteLine("Owner name : {0}", shop.ownername);
        Console.WriteLine("Registered Value : {0}", shop.value);
        Console.WriteLine("----------------------------------------------");
    }
}

