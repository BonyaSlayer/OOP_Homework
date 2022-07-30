using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework
{
    public class Building
    {
        private int _id;
        private double _height;
        private double _floors;
        private double _rooms;
        private double _entrance;
        private static int count;


        public int Id { get { return _id; } set { _id = value; } }
        public double Height { get { return _height; } set { _height = value; } }
        public double Floors { get { return _floors; } set { _floors = value; } }
        public double Rooms { get { return _rooms; } set { _rooms = value; } }
        public double Entrance { get { return _entrance; } set { _entrance = value; } }
        /// <summary>
        /// Конуструктор
        /// </summary>       
        /// <param name="height">Высота</param>
        /// <param name="floors">Этажность</param>
        /// <param name="rooms">колл-во квартир в доме</param>
        /// <param name="entrance">колл-во подъездов</param>
        public Building( double height, double floors, double rooms, double entrance)
        {            
            Height = height;
            Floors = floors;
            Rooms = rooms;
            Entrance = entrance;
            GenerateId();
        }
        /// <summary>
        /// генератор номера дома
        /// </summary>
        private void GenerateId()
        {
            count = count + 1;
            this._id = count;

        }
        /// <summary>
        /// Метод вычисления высоты этажа.
        /// </summary>
        /// <param name="building"></param>
        /// <returns></returns>
        public static double GetFloorHeight(Building building)
        {
            double floorHeight = building.Height / building.Floors;
            return floorHeight;
        }
        /// <summary>
        /// Метод вычисления колл-ва квартир в подъезде
        /// </summary>
        /// <param name="building"></param>
        /// <returns></returns>
        public static double GetEntarnceRooms (Building building)
        {
            double entarnceRooms = building.Rooms / building.Entrance;
            return entarnceRooms;
        }
        /// <summary>
        /// Метод вычисления колл-ва квартир на этаже.
        /// </summary>
        /// <param name="building"></param>
        /// <returns></returns>
        public static double GetFloorRooms(Building building)
        {
            double floorRooms = GetEntarnceRooms(building) / building.Floors;
            return floorRooms;
        }
    }
}
