using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtistWorks.ArtInfos;
using ArtistWorks.ArtWorks;

namespace ArtistWorks.Painters
{
    internal class PaintersClub : IPaintersAggregate
    {
        private List<Painter> painters;

        public SimpleIterator<Painter> CreateIterator(ArtisticMovement artMovement)
        {
            return new PaintersIterator(painters, artMovement);
        }

        //public PaintersClub(List<Painter> painters)
        public PaintersClub()
        {
            //painters = SelectPaintersFromDB(artMovement);
            painters = PaintersTable();
        }

        /*private List<Painter> SelectPaintersFromDB(ArtisticMovement artMovement)
        {
            List<Painter> allPainters = PaintersTable();
            return allPainters.Where(painter => painter.ArtMovement == artMovement).ToList();
        }*/

        private List<Painter> PaintersTable()
        {
            painters = new List<Painter>() {
                // -- Romanticism ------------------------------
                new Painter("Caspar David Friedrich", 1774, 1840, ArtisticMovement.Romanticism),
                new Painter("J. M. W. Turner", 1775, 1851, ArtisticMovement.Romanticism),
                new Painter("John Constable", 1776, 1837, ArtisticMovement.Romanticism),
                // -- Impressionism ----------------------------                
                new Painter("Claude Monet", 1840, 1926, ArtisticMovement.Impressionism),
                new Painter("Edgar Degas", 1834, 1917, ArtisticMovement.Impressionism),
                new Painter("Renoir", 1841, 1919, ArtisticMovement.Impressionism),
                // -- Modernism --------------------------------
                new Painter("Jackson Pollock", 1912, 1956, ArtisticMovement.Modernism),
                new Painter("Salvador Dalí", 1904, 1989, ArtisticMovement.Modernism),
                new Painter("Henri Matisse", 1869, 1954, ArtisticMovement.Modernism)
            };

            return painters;
        }
    }
}
