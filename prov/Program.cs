﻿using System;

namespace prov
{
    class Program
    {
        static void Main(string[] args)
        {
             Printinfo()

             Evaluate()
        
            public class Book {
                //Olika klasserna för book// 
                Random generator = new Random();
                private int  price; 
                private string name;
                private int rarity; 
                private string category; 
                private int actualValue; 
                private bool cursed; 

            
                public Book() {
                    //slumpad generator för pris, rarity och cursed //
                    actualValue = generator.Next(0,501);
                    rarity = generator.Next(0,11);
                    cursed = generator.Next(0, 2) > 2; 
                }

                 public void Printinfo() 
                {
                    Console.WriteLine("Name: " + name);
                    Console.WriteLine("Rarity " + rarity);
                    Console.WriteLine("Price " + price);
                }

                public int Evaluate()
                {
                    //Riktiga priset gånger rarity som blir nya priset// 
                   actualValue * rarity == actualValue
                   

                }

                public bool IsCursed() 
                {
                
                }


            }

            public class customer 
            {
                //olika klasserna för kunden //
                private int money;
                private bool interested;
                private bool IfCursed; 
                
                public int money {

                }


            }
               
        }
    }
}


