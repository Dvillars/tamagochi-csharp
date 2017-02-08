using System.Collections.Generic;

namespace Tamagochi.Objects
{
    public class Tamagochi
    {
        private string _name;
        private int _food;
        private int _happiness;
        private int _wakefullness;

        public Tamagochi(string name, int startFood, int startHappiness, int startWakefullness)
        {
          SetName(name);
          SetFood(startFood);
          SetHappiness(startHappiness);
          SetWakefullness(startWakefullness);
        }

        public string GetName()
        {
          return _name;
        }

        public void SetName(string newName)
        {
          _name = newName;
        }

        public int GetFood()
        {
          return _food;
        }

        public void SetFood(int newFood)
        {
          _food = newFood;
        }

        public int GetHappiness()
        {
          return _happiness;
        }

        public void SetHappiness(int newHappiness)
        {
          _happiness = newHappiness;
        }

        public int GetWakefullness()
        {
          return _wakefullness;
        }

        public void SetWakefullness(int newWakefullness)
        {
          _wakefullness = newWakefullness;
        }

        public void IncrementFood()
        {
          int food = GetFood();
          food += 10;
          SetFood(food);
        }

        public void IncrementHappiness()
        {
          int happiness = GetHappiness();
          happiness += 10;
          SetHappiness(happiness);
        }

        public void IncrementWakefullness()
        {
          int wakefullness = GetWakefullness();
          wakefullness += 10;
          SetWakefullness(wakefullness);
        }

        public bool Decrement()
        {
          bool dead = false;
          int food = GetFood();
          food -= 3;
          if (CheckForDeath(food))
          {
            dead = true;
          }
          SetFood(food);
          int happiness = GetHappiness();
          happiness -= 3;
          if (CheckForDeath(happiness))
          {
            dead = true;
          }
          SetHappiness(happiness);
          int wakefullness = GetWakefullness();
          wakefullness -= 3;
          if (CheckForDeath(wakefullness))
          {
            dead = true;
          }
          SetWakefullness(wakefullness);
          return dead;
        }

        public bool CheckForDeath(int value)
        {
          if (value <= 0)
          {
            return true;
          }
          else
          {
            return false;
          }
        }
    }
}
