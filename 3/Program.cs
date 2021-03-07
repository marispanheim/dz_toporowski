using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            IRecodable recorder = player;
            IPlayable player1 = player;
            recorder.Record();
            recorder.Pause();
            recorder.Stop();
            player1.Play();
            player1.Pause();
            player1.Stop();
        }
    }
}
