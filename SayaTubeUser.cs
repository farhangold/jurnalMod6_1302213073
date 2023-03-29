using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213073.jurnalMod6_1302213073
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubesVideo> uploadVideos;
        private String Username;

        public SayaTubeUser(String Username)
        {
            this.Username = Username;
            id = new Random().Next(10000, 99999);

        }

        public void GetTotalVideoPlayCount(int id)
        {
            int total = 0;
            for(int i = 0; i< uploadVideos.Length; i++)
            {
                total += uploadVideos.Length;
            }
            return total;
        }
        public void AddVideo(SayaTubeUser video)
        {
            AddVideo.uploadVideos(video);
        }
        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User"+ Username);
            for (int i = 0; i < uploadVideos.Count || i<8; i++)
            {
                Console.WriteLine("Video ");
            }
        }
    }
}
