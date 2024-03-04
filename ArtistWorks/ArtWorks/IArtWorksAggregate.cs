using ArtistWorks.ArtInfos;
using ArtistWorks.Painters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtistWorks.Paintings;

namespace ArtistWorks.ArtWorks
{
    internal interface IArtWorksAggregate
    {
        SimpleIterator<ArtWork> CreateIterator(string painterName);
    }
}
