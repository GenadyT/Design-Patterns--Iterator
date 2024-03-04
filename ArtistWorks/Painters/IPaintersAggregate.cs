using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtistWorks.ArtInfos;

namespace ArtistWorks.Painters
{
    internal interface IPaintersAggregate
    {
        public SimpleIterator<Painter> CreateIterator(ArtisticMovement artMovement);
    }
}
