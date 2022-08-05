using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework
{
    public class Building
    {
        private int _Id;
        private double _Height;
        private int _Floors;
        private int _Rooms;
        private int _Entrance;
        private static int count;


        public int Id { get { return _Id; } set { _Id = value; } }
        public double Height { get { return _Height; } set { _Height = value; } }
        public int Floors { get { return _Floors; } set { _Floors = value; } }
        public int Rooms { get { return _Rooms; } set { _Rooms = value; } }
        public int Entrance { get { return _Entrance; } set { _Entrance = value; } }
        
        /// <summary>
        /// Конуструктор
        /// </summary>       
        /// <param name="height">Высота</param>
        /// <param name="floors">Этажность</param>
        /// <param name="rooms">колл-во квартир в доме</param>
        /// <param name="entrance">колл-во подъездов</param>
        public Building( double height, int floors, int rooms, int entrance)
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
            this._Id = count;

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
        public static int GetEntarnceRooms (Building building)
        {
            int entarnceRooms = building.Rooms / building.Entrance;
            return entarnceRooms;
        }
        
        /// <summary>
        /// Метод вычисления колл-ва квартир на этаже.
        /// </summary>
        /// <param name="building"></param>
        /// <returns></returns>
        public static int GetFloorRooms(Building building)
        {
            int floorRooms = GetEntarnceRooms(building) / building.Floors;
            return floorRooms;
        }
    }
}
