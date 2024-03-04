using ArtistWorks.ArtInfos;
using ArtistWorks.Painters;
using ArtistWorks.Paintings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistWorks.ArtWorks
{
    internal class ArtWorksClub : IArtWorksAggregate
    {
        private Dictionary<string, List<ArtWork>> artWorks;

        public SimpleIterator<ArtWork> CreateIterator(string painterName)
        {
            return new ArtWorksIterator(artWorks, painterName);
        }

        public ArtWorksClub()
        {
            ArtWorksStock stock = new ArtWorksStock();
            artWorks = stock.ArtWorks;
        }
    }
}
