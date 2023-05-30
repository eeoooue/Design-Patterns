using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Animal
    {
        private string _name;
        private double _height;
        private int _weight;
        private string _favfood;
        private double _speed;
        private string _sound;

        public void SetName(string name)
        {
            _name = name;
        }

        public void SetHeight(double height)
        {
            _height = height;
        }

        public void SetWeight(int weight)
        {
            _weight = weight;
        }

        public void SetFavFood(string favfood)
        {
            _favfood = favfood;
        }

        public void SetSpeed(double speed)
        {
            _speed = speed;
        }

        public void SetSound(string sound)
        {
            _sound = sound;
        }

        public string GetName()
        {
            return _name;
        }

        public double GetHeight()
        {
            return _height;
        }

        public int GetWeight()
        {
            return _weight;
        }

        public string GetFavFood()
        {
            return _favfood;
        }

        public double GetSpeed()
        {
            return _speed;
        }

        public string GetSound()
        {
            return _sound;
        }
    }
}
