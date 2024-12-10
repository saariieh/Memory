using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Properties;

namespace Memory
{
    public class Card
    {
        private int kartennummer;
        private int paarnummer;
        private Image bildseite;
        

        public Card(int kartennummer, int paarnummer, Image bildseite)
        {
            this.kartennummer = kartennummer;
            this.paarnummer = paarnummer;
            this.bildseite = bildseite;
        }

        public int Kartennummer
        {
            get => kartennummer;
            set => kartennummer = value;
        }

        public int Paarnummer
        {
            get => paarnummer;
            set => paarnummer = value;
        }

        public Image Bildseite
        {
            get => bildseite;
            set => bildseite = value;
        }
    }
}