using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Memory.Properties;

namespace Memory
{
    public class Spiel
    {
        public static void Spielzug(Button buttonA,Button buttonB)
        {
            {
                if (GlobalVariables.gedreht)
                {
                   if (GlobalVariables.paarnummer1 != GlobalVariables.paarnummer2)
                   {
                     LoadRueckseite(buttonA,buttonB);
                   }
                   else
                   {
                       buttonA.Enabled = buttonB.Enabled = false;
                   }

                   GlobalVariables.paarnummer1 = 42;
                   GlobalVariables.paarnummer2 = 43;
                   GlobalVariables.Teil1Zug = null;
                   GlobalVariables.gedreht = false; 
                }
                
            }
            
        }

        public static void LoadBild(Button nummer, Card name)
        {
            nummer.BackgroundImageLayout = ImageLayout.Zoom;
            nummer.BackgroundImage = name.Bildseite;
        }
        public static void LoadRueckseite(Button buttonA, Button buttonB)
        {
            buttonA.BackgroundImage = buttonB.BackgroundImage = Resources.RueckseiteBild;
        }
        
    }
}