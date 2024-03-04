using ArtistWorks.ArtInfos;
using ArtistWorks.Painters;
using System.Diagnostics;
using System.Reflection;
using ArtistWorks.Paintings;
using ArtistWorks.ArtWorks;
using Microsoft.VisualBasic.Devices;

namespace ArtistWorks
{
    public partial class frmPaintingsViewer : Form
    {
        PaintersClub? pClub;
        ArtWorksClub? awClub;
        SimpleIterator<ArtWork>? artWorks;
        //string currentPainterName;

        public frmPaintingsViewer()
        {
            InitializeComponent();
            MyInit();
        }

        private void MyInit()
        {
            pClub = new PaintersClub();
            awClub = new ArtWorksClub();

            artisticMovementsLoad();
            paintersLoad(cbxArtMovements.SelectedIndex);
        }

        private void artisticMovementsLoad()
        {
            cbxArtMovements.Items.Add("Romanticism");
            cbxArtMovements.Items.Add("Impressionism");
            cbxArtMovements.Items.Add("Modernism");

            cbxArtMovements.SelectedIndex = 0;
        }

        private void cbxArtMovements_SelectedIndexChanged(object sender, EventArgs e)
        {
            int artMovementId = cbxArtMovements.SelectedIndex;
            paintersLoad(artMovementId);
        }

        private void paintersLoad(int artMovementId)
        {
            ArtisticMovement artMovement = (ArtisticMovement)artMovementId;
            var iterator = pClub.CreateIterator(artMovement);

            cbxPainters.Items.Clear();
            while (iterator.MoveNext())
            {
                cbxPainters.Items.Add(iterator.Current.ToString());
            }

            cbxPainters.SelectedIndex = 0;
        }

        private void artWorksLoad(string painterName)
        {
            PaintersClub pClub = new PaintersClub();
            var iterator = pClub.CreateIterator(ArtisticMovement.Romanticism);

            while (iterator.MoveNext())
            {
                cbxPainters.Items.Add(iterator.Current);
            }
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            artWorks.MoveNext();
            ArtWork artWork = artWorks.Current;
            LoadArtWork(artWork);
        }

        private void LoadArtWork(ArtWork artWork)
        {
            if (artWork == null) return;

            string projFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location).Split("bin")[0];
            string artWorkUrl = projFolder + "/ArtWorksStock/" + artWork.FileName;
            if (!File.Exists(artWorkUrl)) return;

            pbxArtWork.Load(artWorkUrl);
            tbxPaintingTitle.Text = artWork.PaintName;
        }

        private void cbxPainters_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ((System.Windows.Forms.ComboBox)sender).SelectedIndex;
            string painterData = cbxPainters.Items[selectedIndex].ToString();
            string painterName = painterData.Split(',')[0];
            artWorks = awClub.CreateIterator(painterName);
            LoadArtWork(artWorks.Current);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The reset button functionality is up to you :-))");
            artWorks.Reset();
        }
    }
}