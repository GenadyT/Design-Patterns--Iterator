using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtistWorks.ArtInfos;
namespace ArtistWorks.Painters
{
    internal class Painter
    {
        private string name;
        public string Name
        {
            get { return name; }
        }

        private int bornYear;
        public int BornYear
        {
            get { return bornYear; }
        }

        private int deathYear;
        public int DeathYear
        {
            get { return deathYear; }
        }
        
        public string LifeYears {
            get { return $"{bornYear} - {deathYear}"; } 
        }

        private ArtisticMovement artMovement;
        public ArtisticMovement ArtMovement
        {
            get { return artMovement; }
        }

        public Painter(string name, int bornYear, int deathYear, ArtisticMovement artMovement)
        {
            this.name = name;
            this.bornYear = bornYear;
            this.deathYear = deathYear;
            this.artMovement = artMovement;
        }

        public override string ToString()
        {
            return $"{name}, years({bornYear} - {deathYear})";
        }
    }
}
