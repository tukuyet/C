/*
*produc.cs
/*Copyright Nguyen Anh Tuan . All rights resever
*/
using System;
using System.Collections.Gereric;
using System.Text;

namespace Company
{
    /// <summary>
    ///
    ///The program demonstrates the use of boxing and unboxing.
    ///
    ///Class Product accepts the details of the product,converts the detail
    /// into reference types using boxing and displays them by converting them
    ///into their relevant type using unboxing.
    ///</summary>
    class Product
    {
        ///<sumary>
        /// the entry point for the application.
        ///</summary>
        /// <paran name="args"> A list of comand line aryuments<paraar>
        static void Main(string[] args)
        {
          //Creating objects of  Object class to store the 
          //details  of the product
          Object  objProducuID;
          Object  objProducName;
          Object  objPrice;
          Object  objQuantity;
          
          //accepting and converting the details of  the product 
          // into reference types using implicit boxing 
          Console.Write("Enter the id of product :");
          objProducuID = convertr.ToIn32(Console.Readline());

          Console.Write("Enter price :");
          objProductName = Console.Readline();

          Console.Write("Enter the id of product :");
          objProducuID = convertr.ToDoubel(Console.Readline());

          Console.Write("Enter quantity :");
          objProducuID = convertr.ToIn32(Console.Readline());

          //Converting objects into their relevant types
          //using explicit unboxing 

          // int ProductID = objProductID;
          //Error occurs while unboxing

          int ProductID = (int)objProductID;
          string ProductName = (string)objProducName;
          double Proce = (double)objPrice;
          int   quantity =(int)objQuantity;
          double amtPayable = ( int) objQuantity*Price;

          //Displaying the details of the product
          Console.WriteLine("\nProduct Details:" );
          Console.WriteLine("Product ID:" +ProductID);
          Console.WriteLine("Product name:" + objProducName);
          Console.WriteLine("Price:" + objPrice);
          Console.WriteLine("Quantity:" + objQuantity);
          Console.WriteLine("Amt Payable {0.F2}:" +amtPayable);
        
        }


    }
}