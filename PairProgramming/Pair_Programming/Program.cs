using Pair_Programming.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair_Programming
{

    public class DungeonGame
    {
        public class Game
        {
            static void Main(string[] args)
            {
                DungeonGame gameClass = new DungeonGame();
                gameClass.Intro();
            }
        }

        //which room player is in
        bool roomOne = true;
        bool roomTwo = false;
        bool roomThree = false;
        bool roomFour = false;
        bool roomFive = false;
        bool roomSix = false;

        //if the player has item or not
        bool hasKey = false;
        bool hasBroom = false;
        bool hasPlate = false;
        bool hasButterKnife = false;
        bool hasMug = false;
        bool hasMask = false;
        bool hasSword = false;
        bool hasLightsaber = false;

        public void Intro()
        {
            Console.WriteLine("insert game name here\n" +
                "\n" +
                "Press any key to begin");

            Console.ReadKey();

            NavRoomOne();
        }
        //PlayerStats player = new PlayerStats();
        //SubBoss boss = new SubBoss();

        //roomNavigations
        public void NavRoomOne()
        {
            Console.Clear();
            RoomOne firstRoom = new RoomOne();
            while (roomOne)
            {
                Console.WriteLine(firstRoom.RoomDescription);
                Console.WriteLine("1. Go to door on left.\n" +
                "2. Go to door on right\n" +
                "3. Go to door straight ahead\n" +
                "4. Search Room");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        roomOne = false;
                        roomTwo = true;
                        NavRoomTwo();
                        break;
                    case "2":
                        roomOne = false;
                        roomThree = true;
                        NavRoomThree();
                        break;
                    case "3":
                        Exit();
                        break;
                    case "4":
                        roomOneSearch();
                        break;
                    default:
                        Console.WriteLine("Not a valid input");
                        break;
                }
            }
        }

        public void NavRoomTwo()
        {
            Console.Clear();
            RoomTwo secondRoom = new RoomTwo();
            while (roomTwo)
            {
                Console.WriteLine(secondRoom.RoomDescription);
                Console.WriteLine("1. Go to door.\n" +
                "2. search room \n" +
                "3. Go back to entrance.");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("You open the door");
                        roomTwo = false;
                        roomFour = true;
                        NavRoomFour();
                        break;
                    case "2":
                        roomTwoSearch();
                        break;
                    case "3":
                        roomTwo = false;
                        roomOne = true;
                        NavRoomOne();
                        break;
                    default:
                        Console.WriteLine("Not a valid input");
                        break;
                }
            }
        }

        public void NavRoomThree()
        {
            Console.Clear();
            RoomThree thirdRoom = new RoomThree();
            while (roomThree)
            {
                Console.WriteLine(thirdRoom.RoomDescription);
                Console.WriteLine("1. Go to door.\n" +
                    "2. Move shelf and enter wall opening\n" +
                    "3. search room \n" +
                    "4. Go back.");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("You open the door");
                        roomThree = false;
                        roomFive = true;
                        NavRoomFive();
                        break;
                    case "2":
                        roomThree = false;
                        roomSix = true;
                        NavRoomSix();
                        break;
                    case "3":
                        roomThreeSearch();
                        break;
                    case "4":
                        roomThree = false;
                        roomOne = true;
                        NavRoomOne();
                        break;
                    default:
                        Console.WriteLine("Not a valid input");
                        break;
                }
            }
        }

        public void NavRoomFour()
        {
            Console.Clear();
            RoomFour fourthRoom = new RoomFour();
            if (hasMask == true)
            {
                while (roomFour)
                {
                    Console.WriteLine("Once you enter the room you put on your mask.\n" +
                        "You can now explore the room\n" +
                        " \n" +
                        "1. search room\n" +
                        "2. Go back");
                    string input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            findingLightsaber();
                            break;
                        case "2":
                            roomFour = false;
                            roomTwo = true;
                            NavRoomTwo();
                            break;
                        default:
                            Console.WriteLine("Not a valid input");
                            break;
                    }
                }
            }
            else
            {
                while (roomFour)
                {
                    Console.WriteLine(fourthRoom.RoomDescription);
                    Console.WriteLine("1. Stay.\n" +
                    "2. Leave");

                    string input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("if there was a health stat coded in.. youd probably be dead\n" +
                                "AND HAVE TO START ALL OVER....\n" +
                                "...\n" +
                                "lucky you");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "2":
                            roomFour = false;
                            roomTwo = true;
                            NavRoomTwo();
                            break;
                        default:
                            Console.WriteLine("Not a valid input");
                            break;
                    }
                }
            }
        }

        public void NavRoomFive()
        {
            Console.Clear();
            RoomFive fifthRoom = new RoomFive();
            while (roomFive)
            {
                Console.WriteLine(fifthRoom.RoomDescription);
                Console.WriteLine("1. Stay and fight.\n" +
                "2. Come back when you're ready");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        WeaponChoice();
                        //BattleSequence();
                        break;
                    case "2":
                        roomFive = false;
                        roomThree = true;
                        NavRoomThree();
                        break;
                    default:
                        Console.WriteLine("Not a valid input");
                        break;
                }
            }
        }

        public void NavRoomSix()
        {
            Console.Clear();
            RoomSix sixthRoom = new RoomSix();
            while (roomSix)
            {
                Console.WriteLine(sixthRoom.RoomDescription);
                Console.WriteLine("1. Approach fountain\n" +
                    "2. Search room\n" +
                    "3. Go back");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Fountain();
                        break;
                    case "2":
                        roomSixSearch();
                        break;
                    case "3":
                        roomSix = false;
                        roomThree = true;
                        NavRoomThree();
                        break;
                    default:
                        Console.WriteLine("Not a valid input");
                        break;
                }
            }
        }


        //other needed methods
        public void Fountain()
        {
            if (hasMug == true)
            {
                Console.WriteLine("Oh wow! if there was a health stat coded in, it would surely be maxed right now.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Refreshing.\n" +
                    "\n" +
                    "Press any key to continue..");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void findingLightsaber()
        {
            Console.Clear();
            Console.WriteLine("You notice a brightly glowing stick on the floor.\n" +
                "You notice it cut whatever surface it was originally laying on cleanly in half..\n" +
                "...\n" +
                "is..is that a lightsaber?!\n" +
                "\n" +
                "Take the lightsaber? (y/n)");

            string input = Console.ReadLine();

            switch (input)
            {
                case "y":
                    Console.Clear();
                    hasLightsaber = true;
                    Console.WriteLine("Hell yeah, you got a lightsaber!**woosh woosh**\n" +
                        " \n" +
                        "Press any key to continue..");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "n":
                    Console.Clear();
                    Console.WriteLine("...\n" +
                        "...\n" +
                        "...\n" +
                        "Seriously?..\n" +
                        "Okay then.\n" +
                        "\n" +
                        "Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Not a valid input");
                    break;
            }

        }

        public void rustySword()
        {
            Console.Clear();
            Console.WriteLine("There's a large flimsy crest on the wall. Behind it are two crossed swords.\n" +
                "They look real. One is broken, and the other is pretty rusty.\n" +
                "\n" +
                "Take the rusty sword? (y/n)");

            string input = Console.ReadLine();

            switch (input)
            {
                case "y":
                    Console.Clear();
                    hasSword = true;
                    Console.WriteLine("You now have a Sword!");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "n":
                    Console.Clear();
                    Console.WriteLine("You decide not to take it. It looks too heavy anyway.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Not a valid input");
                    break;
            }

        }
    



        //RoomSearchOptions
        public void roomOneSearch()
        {
            Console.Clear();
            Console.WriteLine("You don't really find anything of interest\n" +
                "But you did see a heafty broom sitting in the corner.\n" +
                "It might be useful should you need to protect yourself.\n" +
                "\n" +
                "Take the broom? (y/n)");

            string yninput = Console.ReadLine();

            switch (yninput.ToLower())
            {
                case "y":
                    Console.WriteLine("You take the broom.\n" +
                        "\n" +
                        "Press any key to continue.");
                    hasBroom = true;
                    Console.ReadKey();
                    break;
                case "n":
                    Console.WriteLine("You leave the broom. You don't think you'll need it.\n" +
                        " \n" +
                        "Press any key to continue.");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Not a valid input");
                    break;
            }
            Console.Clear();
        }

        public void roomTwoSearch()
        {
            Console.Clear();
            Console.WriteLine("You see an open journal sitting on the desk, \n" +
                "and a faded sign on the door at the end of room.\n" +
                "There's also some cool decor hanging on the wall.\n" +
                "\n" +
                "Which would you like to look at?\n" +
                "1. Journal\n" +
                "2. Sign\n" +
                "3. Decor\n" +
                "4. Nothing\n" +
                " ");

            string roomTwoInput = Console.ReadLine();

            switch (roomTwoInput)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("You read the journal.\n" +
                        " \n" +
                        "My experiments have failed. Unfortunately the lab is completely unusable and has filled with a toxic gas. \n" +
                        "Fortunately there isn't anything important in there. \n" +
                        "I've put up a sign for now, in case a random adventurer should attempt to enter.\n" +
                        " \n" +
                        "press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("You notice a faded sign on the door. You can barely make the word BEWARE out.\n" +
                        " \n" +
                        "Press any key to continue..");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "3":
                    rustySword();
                    Console.Clear();
                    break;
                case "4":
                    NavRoomTwo();
                    break;
                default:
                    Console.WriteLine("not a valid input");
                    break;
            }
        }

        public void roomThreeSearch()
        {
            Console.Clear();
            Console.WriteLine("You see a bunch of dishes and utensils on the table.\n" +
                "\n" +
                "Would you like to take one?\n" +
                "1. Take Plate\n" +
                "2. Take butter knife\n" +
                "3. Take mug");
            string utensilInput = Console.ReadLine();
            switch (utensilInput)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("You take the Plate.. You dont know how useful this will be.\n" +
                        "\n" +
                        "Press any key to continue..");

                    hasPlate = true;
                    hasButterKnife = false;
                    hasMug = false;

                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("You take the butter knife.. You dont know how useful this will be.\n" +
                        "\n" +
                        "Press any key to continue..");

                    hasPlate = false;
                    hasButterKnife = true;
                    hasMug = false;

                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("You take the mug.. You could really use a drink right now.\n" +
                        "\n" +
                        "Press any key to continue..");

                    hasPlate = false;
                    hasButterKnife = false;
                    hasMug = true;

                    Console.ReadKey();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Not a valid input");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }

        public void roomSixSearch()
        {
            Console.Clear();
            Console.WriteLine("You notice something on the ground near the edge of the fountain.\n" +
                "When you pick it up, it feels kind of heavy, and looks like its used as a face covering.\n" +
                "Maybe it can protect you from strong fumes?\n" +
                "\n" +
                "Take the mask? (y/n)");

            string yninput = Console.ReadLine();

            switch (yninput.ToLower())
            {
                case "y":
                    Console.WriteLine("You take the mask.\n" +
                        "\n" +
                        "Press any key to continue.");
                    hasMask = true;
                    Console.ReadKey();
                    break;
                case "n":
                    Console.WriteLine("You leave the mask. You don't think you'll need it.\n" +
                        " \n" +
                        "Press any key to continue.");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Not a valid input");
                    break;
            }
            Console.Clear();
        }


        //public void BattleSequence()
        //{
        //    while (player.Health > 0)
        //    {
        //        if(boss.Health <= 0)
        //        {


        //        }
        //        else
        //        {

        //        }
        //    }

        //}

        public void Winning()
        {
            Console.Clear();
            Console.WriteLine("You defeated **boss name here** \n" +
                "\n" +
                "You notice a key attached to his belt.\n" +
                "Take the key? (y/n)\n" +
                "");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "y":
                    Console.Clear();
                    Console.WriteLine("You now have a key! I wonder what it unlocks." +
                        "\n" +
                        "Press any key to continue.. (you will be directed back to the previous room)");
                    hasKey = true;
                    Console.Clear();
                    NavRoomThree();
                    break;
                case "n":
                    Console.Clear();
                    Console.WriteLine("Okay.. well, good luck with doing all of that again");
                    Console.ReadKey();
                    NavRoomThree();
                    break;
                default:
                    Console.WriteLine("Not a valid input");
                    Console.Clear();
                    break;
            }
        }

        public void WeaponChoice()
        {
            Console.Clear();
            Console.WriteLine("What would you like to use as your weapon?");
            if (hasBroom == true)
            {
                Console.WriteLine("Broom");
            }
            if (hasSword == true)
            {
                Console.WriteLine("Rusty Sword");
            }
            if (hasLightsaber == true)
            {
                Console.WriteLine("Lightsaber");
            }
            if (hasBroom == false && hasSword == false && hasLightsaber == false)
            {
                Console.WriteLine("Uh, you dont have a weapon...\n" +
                    "Good luck.");
            }

            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "broom":
                    Console.WriteLine("You fight valiently, buuut unfortunately you weren't able to beat him\n" +
                        "you barely manage to get out before his final blow");
                    Console.ReadKey();
                    break;
                case "rusty sword":
                case "sword":
                    Console.Clear();
                    Console.WriteLine("It took a while, but you managed to take him down!");
                    Console.ReadKey();
                    Winning();
                    break;
                case "lightsaber":
                    Console.Clear();
                    Console.WriteLine("Oh wow.. you destroyed him.. Poor guy");
                    Console.ReadKey();
                    Winning();
                    break;
                default:
                    Console.WriteLine("not a valid input");
                    break;
            }
        }


        public void Exit()
        {
            Console.Clear();
            if (hasKey == true)
            {
                Console.Clear();
                Console.WriteLine("You managed to escape the dungeon!\n" +
                    "...What took you so long?");
                Console.Clear();
                Console.ReadKey();
                Intro();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("The door is locked.. You might be able to find a key somewhere \n" +
                    " \n" +
                    "Press any key to continue.");
                Console.ReadKey();
                NavRoomOne();
            }
        }



    }
}
