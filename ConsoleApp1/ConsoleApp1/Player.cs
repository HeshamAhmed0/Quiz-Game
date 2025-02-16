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
        private string Name;
        private int Score;
        private int i;
        public Player[] players=new Player[5];
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
        public void SetPlayer()
        {
            players[i] = this;
            i++;
        }
    }
}
