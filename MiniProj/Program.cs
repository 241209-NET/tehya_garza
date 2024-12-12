namespace MiniProj;
using System;

public class Program
{
    // This program is going to simulate my typical Starbucks experience. Enjoy!
    public static void Main(string[] args)
    {
        // intro message and menu
        Console.WriteLine("Hi, welcome to Starbucks! Here's our menu, what can I get for you?\n(type in the number of your choice)\n)");
        Console.WriteLine("1.20 syrup pump Caramel Frappacino Java Chip Supreme\n2.Sad Bitter Black Coffee\n3.Soy milk with a shot of water :/");

        try{
            int orderNum = int.Parse(Console.ReadLine());
            string order = "";

            switch(orderNum){
                case 1:
                    order = "20 syrup pump Caramel Frappacino Java Chip Supreme";
                    break;
                case 2:
                    order = "Sad Bitter Black Coffee";
                    break;
                case 3:
                    order = "Soy milk with a shot of water";
                    break;
                default:
                    order = "That's not on the menu...";
                    break;
            }

            // get name
            Console.WriteLine("And the order is for?:\n");
            string name = Console.ReadLine();
            string wrong = WrongName(name);

            // text and respond
            Console.WriteLine("\nAlright! We'll call you when your order's ready!\n\n.....10 minutes later.....\n");
            Console.WriteLine("A " + order + " for " + wrong + "!");

        }
        catch(Exception e){
            Console.WriteLine("That's not a valid choice!");
        }
    }
    public static String WrongName(String name){
        string newName = "";

        // random chance to be named Josh
        Random jFlag = new Random();
        if(jFlag.Next(0, 100) == 63){
            newName = "Josh";
            return newName;
        }

        // else, replace every vowel in their name with another one
        char[] vowels = {'a', 'e', 'i', 'o', 'u', 'y'};
        Random rnd = new Random();
        int randV = rnd.Next(0, vowels.Length - 1);

        for(int i = 0; i < name.Length; i++){
            for(int j = 0; j < vowels.Length; j++){
                if(name[i] == vowels[j] && i != name.Length - 1){
                    newName = newName + vowels[randV];
                    i++;
                }
            }
            newName = newName + name[i];
        }
        return newName;
    }
}
