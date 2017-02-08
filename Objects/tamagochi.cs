using System.Collections.Generic;

namespace TamagochiFarm.Objects
{
    public class Tamagochi
    {
        private static List<Tamagochi> TamagochiList = new List<Tamagochi> {};

        private static int _counter = 0;
        private int _id;
        private string _name;
        private int _food;
        private int _happiness;
        private int _wakefullness;
        private bool _dead = false;

        public Tamagochi(string name, int startFood, int startHappiness, int startWakefullness)
        {
          SetName(name);
          SetFood(startFood);
          SetHappiness(startHappiness);
          SetWakefullness(startWakefullness);
          SetId(GetCounter());
          UpCounter();
          TamagochiList.Add(this);

        }
        public bool GetDead()

        {
          return _dead;
        }
        public void SetDead(bool living)

        {
          _dead = living;
        }

        public int GetCounter()
        {
          return _counter;
        }

        public void UpCounter()
        {
          _counter += 1;
        }

        public string GetName()
        {
          return _name;
        }

        public void SetName(string newName)
        {
          _name = newName;
        }

        public int GetId()
        {
          return _id;
        }

        public void SetId(int newId)
        {
          _id = newId;
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

        public void Decrement()
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
          SetDead(dead);
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

        public static List<Tamagochi> GetTamagochis()
        {
          return TamagochiList;
        }

        public static void ClearTamagochiList()
        {
          TamagochiList.Clear();
        }
    }
}
