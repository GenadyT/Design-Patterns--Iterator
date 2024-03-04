using ArtistWorks.ArtInfos;
using ArtistWorks.Painters;
using ArtistWorks.Paintings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ArtistWorks.ArtWorks
{
    internal class ArtWorksIterator : SimpleIterator<ArtWork>
    {
        List<ArtWork> artWorks;
        //private ArtisticMovement artMovement;

        public ArtWorksIterator(Dictionary<string, List<ArtWork>> artWorks, string painterName)
        {
            if (artWorks == null) throw new ArgumentNullException();

            SelectArtWorks(artWorks, painterName);

            //this.artMovement = artMovement != null ? artMovement : ArtisticMovement.Modernism;
            //this.artMovement = artMovement;

            //index = -1;
            index = 0;
            //count = painters.Count;
        }

        private void SelectArtWorks(Dictionary<string, List<ArtWork>> artWorks, string painterName)
        {
            Dictionary<string, List<ArtWork>> dic = artWorks.Where(s => s.Key == painterName)
                        .ToDictionary(dict => dict.Key, dict => dict.Value);

            //this.artWorks.Clear();
            this.artWorks = dic[painterName];
        }

        public override ArtWork Current
        {
            get { return artWorks[index]; }
        }
        public override bool MoveNext()
        {
            if (index == artWorks.Count - 1)
            {
                return false;
            }
            else
            {
                index++;
                return true;
            }
        }
    }
}
