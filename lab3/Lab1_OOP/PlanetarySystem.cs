using System;
using System.Collections;
using System.Collections.Generic;


namespace Lab1_OOP
{
    public class PlanetarySystem<T> : IEnumerable<T>, IEnumerator<T> where T : AstronomicalBody
    {
        private readonly List<T> astBodies;
        Star star;
        private int position = -1;

        public List<T> Bodies
        {
            get { return astBodies; }
        }

        public Star SystemStar
        {
            get
            {
                return this.star;
            }
            set
            {
                this.star = value;
            }
        }
        public int Count
        {
            get
            {
                return astBodies.Count;
            }
        }

        public PlanetarySystem()
        {
            astBodies = new List<T>();
        }

        public PlanetarySystem(Star star)
        {
            this.SystemStar = star;
            astBodies = new List<T>();
        }

        public T this[int index]
        {
            get { return astBodies[index]; }
            set { astBodies[index] = value; }
        }

        public T this[string name]
        {
            get { return astBodies.Find(b => b.Name.Equals(name)); }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return astBodies.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Dispose() { }

        public bool MoveNext()
        {
            position++;
            return (position < astBodies.Count);
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public T Current
        {
            get { return astBodies[position]; }
        }

        public void Reset()
        {
            position = -1;
        }

        public void Add(T member)
        {
            astBodies.Add(member);
        }

        public static string GetInfo(PlanetarySystem<AstronomicalBody> bodies)
        {
            string info = "";
            for(int i = 0;  i < bodies.Count; i++)
            {
                String.Concat(info, bodies[i].Name, " ");
            }
            return info;
        }
    }
}
