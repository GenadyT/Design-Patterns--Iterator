using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistWorks.Paintings
{
    internal class ArtWork
    {
        private string artistName;
        public string ArtistName
        {
            get { return artistName; }
        }

        private string paintName;
        public string PaintName
        {
            get { return paintName; }
        }

        private string fileName;
        public string FileName
        {
            get { return fileName; }
        }

        public ArtWork(string artistName, string paintName, string fileName)
        {
            this.artistName = artistName;
            this.paintName = paintName;
            this.fileName = fileName;
        }
    }
}
