using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_OOP
{
    public static class PlanetSysExt
    {
        public static Func<PlanetarySystem<AstronomicalBody>, string> GetInfoFunc = PlanetarySystem<AstronomicalBody>.GetInfo;
        public static Action<AstronomicalBody> GetTitle = AstronomicalBody.Info;
        public static AstronomicalBody getBiggestBody(this PlanetarySystem<AstronomicalBody> body)
        {
            AstronomicalBody biggestBody = body[0];
            for (int i = 0; i < body.Count; i++)
            {
                if (body[i].Weight > biggestBody.Weight)
                    biggestBody = body[i];
            }
            return biggestBody;
        }

        public static AstronomicalBody getSmallestBody(this PlanetarySystem<AstronomicalBody> body)
        {
            AstronomicalBody smallestBody = body[0];
            for (int i = 0; i < body.Count; i++)
            {
                if (body[i].Weight < smallestBody.Weight)
                    smallestBody = body[i];
            }
            return smallestBody;
        }

        public static float GetGeneralWeight(this PlanetarySystem<AstronomicalBody> body)
        {
            float sumWeight = 0;
            for(int i = 0; i < body.Count; i++)
            {
                sumWeight += body[i].Weight;
            }
            return sumWeight;
        }
    }
}
