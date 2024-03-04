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
    internal class ArtWorksStock
    {
        private Dictionary<string, List<ArtWork>> artWorks;
        public Dictionary<string, List<ArtWork>> ArtWorks
        {
            get { return artWorks; }
            //set { myVar = value; }
        }


        public ArtWorksStock()
        {
            artWorks = new Dictionary<string, List<ArtWork>> ();
            LoadTable();
        }

        //public Dictionary<string, ArtWork> PaintersTable()
        private void LoadTable()
        {
            string artistName;
            List<ArtWork> artistWorksList;

            artistName = "Caspar David Friedrich";
            //------------------------------------
            artistWorksList = new List<ArtWork>();
            artistWorksList.Add(new ArtWork(artistName, "A Mountain Lake in the Morning", "A_Mountain_Lake_in_the_Morning.jpg"));
            artistWorksList.Add(new ArtWork(artistName, "Moonlit Landscape", "Moonlit_Landscape.jpg"));
            artistWorksList.Add(new ArtWork(artistName, "The Abbey in the Oakwood", "The_Abbey_in_the_Oakwood.jpg"));
            artWorks.Add(artistName, artistWorksList);

            artistName = "J. M. W. Turner";
            //------------------------------------
            artistWorksList = new List<ArtWork>();
            artistWorksList.Add(new ArtWork(artistName, "Chepstow Castle", "Chepstow_Castle.jpg"));
            artistWorksList.Add(new ArtWork(artistName, "Frosty Morning", "Frosty_Morning.jpg"));
            artistWorksList.Add(new ArtWork(artistName, "Rouen Cathedral", "Rouen_Cathedral.jpg"));
            artWorks.Add(artistName, artistWorksList);

            artistName = "John Constable";
            //------------------------------------
            artistWorksList = new List<ArtWork>();
            artistWorksList.Add(new ArtWork(artistName, "Golding Constables Flower Garden", "Golding_Constables_Flower_Garden.jpg"));
            artistWorksList.Add(new ArtWork(artistName, "Harnham bridge", "Harnham_bridge.jpg"));
            artistWorksList.Add(new ArtWork(artistName, "Malvern Hall, Warwickshire", "Malvern Hall, Warwickshire.jpg"));
            artWorks.Add(artistName, artistWorksList);

            artistName = "Claude Monet";
            //------------------------------------
            artistWorksList = new List<ArtWork>();
            artistWorksList.Add(new ArtWork(artistName, "Impression Sunrise", "Impression_Sunrise.jpg"));
            artistWorksList.Add(new ArtWork(artistName, "The Apple Tree", "The_Apple_Tree.jpg"));
            artWorks.Add(artistName, artistWorksList);

            artistName = "Edgar Degas";
            //------------------------------------
            artistWorksList = new List<ArtWork>();
            artistWorksList.Add(new ArtWork(artistName, "Dancers_in_blue", "Dancers in blue.jpg"));
            artistWorksList.Add(new ArtWork(artistName, "Kim Field", "Kim_Field.jpg"));
            artWorks.Add(artistName, artistWorksList);

            artistName = "Renoir";
            //------------------------------------
            artistWorksList = new List<ArtWork>();
            artistWorksList.Add(new ArtWork(artistName, "The Umbrellas", "The_Umbrellas.jpg"));
            artistWorksList.Add(new ArtWork(artistName, "La Promenade", "La_Promenade.jpg"));
            artWorks.Add(artistName, artistWorksList);

            artistName = "Jackson Pollock";
            //------------------------------------
            artistWorksList = new List<ArtWork>();
            artistWorksList.Add(new ArtWork(artistName, "Convergence", "Convergence.jpg"));
            artistWorksList.Add(new ArtWork(artistName, "Convergence2", "Convergence2.jpg"));
            artWorks.Add(artistName, artistWorksList);

            artistName = "Salvador Dalí";
            //------------------------------------
            artistWorksList = new List<ArtWork>();
            artistWorksList.Add(new ArtWork(artistName, "Time and Change", "Time_and_Change.jpg"));
            artistWorksList.Add(new ArtWork(artistName, "Soft Construction with Boiled Beans", "Soft_Construction_with_Boiled_Beans.jpg"));
            artWorks.Add(artistName, artistWorksList);

            artistName = "Henri Matisse";
            //------------------------------------                
            artistWorksList = new List<ArtWork>();
            artistWorksList.Add(new ArtWork(artistName, "Self Portrait Henri Matisse", "Self-Portrait-Henri Matisse.jpg"));
            artistWorksList.Add(new ArtWork(artistName, "Woman with a Hat", "Woman_with_a_Hat.jpg"));
            artWorks.Add(artistName, artistWorksList);
        }
    }
}
