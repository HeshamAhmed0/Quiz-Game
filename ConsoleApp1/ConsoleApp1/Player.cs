using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Player
    {
        private int Id;
        private string? Name;
        private int Score;
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public void SetId(int Id) 
        {
            this.Id = Id;

        }
        public void SetScore(int Score)
        {
            this.Score = Score;
        }


        public override string ToString()
        {
            return $"Name : {Name} ,Id : {Id} , Score : {Score}";
        }
    }
}
