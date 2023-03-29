using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213073.jurnalMod6_1302213073
{
    internal class SayaTubeVideo
    {
        private int id;
        public String title;
        public int playCount;


    }
    
    public SayaTubeVideo(String title)
    {
        if (title == null || title.Length;title++)

        
    }
    public void IncreasePlayCount(int count)
    {
        if(count> 100000)
        {

        }
    }
    public void PrintVideoDetail()
    {
        Console.WriteLine("Video ID: {0}", this.id);
        Console.WriteLine("Title : {0}", this.title);
        Console.WriteLine("Playcount : {0}", this.playCount);
    }
}
