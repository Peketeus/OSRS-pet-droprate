using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

/// @author Jari-Pekka Riihinen
/// @version 16.11.2022
/// <summary>
/// RuneScape pet drop simulator
/// </summary>
public class DropRates
{
    /// <summary>
    /// 
    /// </summary>
    public static void Main()
    {
        Console.Write("What is your woodcutting level? ");  //Input between 75-99
        int level = Convert.ToInt32(Console.ReadLine());
        int chance = 72321;                                 //Magic trees
        int rate = chance - (level * 25);                   //Beaver droprate
        int kc = 0;                                         //Amount of logs chopped
        Random rnd = new Random();

        bool pet = false;

        while (pet == false)
        {
            int roll = rnd.Next(1, rate);

            if (roll == 1)
            {
                Console.WriteLine(kc);                      //Tells the amount of logs chopped after recieving the pet
                pet = true;
            }
            kc++;                                           //Failed roll increases the chopped logs count
        }
    }

}
