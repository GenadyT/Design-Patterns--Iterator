using ArtistWorks.ArtInfos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ArtistWorks.Painters
{
    internal class PaintersIterator : SimpleIterator<Painter>
    {
        private List<Painter> painters;
        //private ArtisticMovement artMovement;

        public PaintersIterator(List<Painter> painters, ArtisticMovement artMovement)
        {
            if (painters == null) throw new ArgumentNullException();

            SelectPainters(painters, artMovement);

            //this.artMovement = artMovement != null ? artMovement : ArtisticMovement.Modernism;
            //this.artMovement = artMovement;

            index = -1;
            //count = painters.Count;
        }

        private void SelectPainters(List<Painter> painters, ArtisticMovement artMovement)
        {
            this.painters = painters.Where(painter => painter.ArtMovement == artMovement).ToList();
        }

        public override Painter Current {
            get { return painters[index]; } 
        }
        public override bool MoveNext()
        {
            if (index == painters.Count - 1)
            {
                return false;
            }
            else
            {
                index++;
                return true;
            }
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
