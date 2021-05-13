  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair_Programming.Rooms
{
    public class RoomOne : IRooms
    {
        public string RoomName => "Start/Storage";

        public string RoomDescription => "You wake up in a strange dark room. \n" +
            "There are various boxes and barrels stacked on top of eachother, \n" +
            "as well as random supplies scattered about. \n" +
            "You see a door to your left, a door to your right, and a door \n" +
            "straight in front of you\n" +
            " ";
    }

    public class RoomTwo : IRooms
    {
        public string RoomName => "Office";

        public string RoomDescription => "You enter a room filled with shelves cluttered with books,\n" +
            "and a writing desk in the center. \n" +
            "There is a door at the back of the room\n" +
            " ";
    }

    public class RoomThree : IRooms
    {
        public string RoomName => "Kitchen";

        public string RoomDescription => "This room seems to be a kitchen of some sort. \n" +
            "There is a stove in the corner, and \n" +
            "various tables with utensils on them. \n" +
            "There seems to be a wall opening behind a shelf.\n" +
            "You see a door to your left.\n" +
            " ";
    }

    public class RoomFour : IRooms
    {
        public string RoomName => "PoisonRoom";

        public string RoomDescription => "The second you enter the room you notice a foul stench.\n" +
            "You start to feel weak. \n" +
            "You probably shouldn't be here.\n" +
            " ";

    }

    public class RoomFive : IRooms
    {
        public string RoomName => "BossRoom";

        public string RoomDescription => "You enter a large stone room. \n" +
            "In the center of a room stands **boss description here**. \n" +
            "He looks ready to fight!\n" +
            " ";
    }

    public class RoomSix : IRooms
    {
        public string RoomName => "Fountain";

        public string RoomDescription => "A large glowing fountain sits in the middle of the room\n" +
            " ";
    }

    public class RoomSeven : IRooms
    {
        public string RoomName => "Level of perception";
        public string RoomDescription => "Made you look. There's nothing in here. Go back and search the other rooms.";
    }

}