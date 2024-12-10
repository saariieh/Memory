using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Memory.Properties;

namespace Memory
{
    public partial class Form1 : MaterialForm
    {
        private Card einsA;
        private Card einsB;
        private Card zweiA;
        private Card zweiB;
        private Card dreiA;
        private Card dreiB;
        private static Label labelD;
        

        public Form1()
        {
            InitializeComponent();
           
            einsA = new Card(1, 1, Resources.Fuchs);
            einsB = new Card(2, 1, Resources.Fuchs);
            zweiA = new Card(3, 2, Resources.Reh);
            zweiB = new Card(4, 2, Resources.Reh);
            dreiA = new Card(5, 3, Resources.Baer);
            dreiB = new Card(6, 3, Resources.Baer);

            labelD = label1;
            

        }
        //debuggen
        public static void DebugLabel()
        {
            
            labelD.Text = "Paarnummer1: " + GlobalVariables.paarnummer1 + "\nPaarnummer2: " +
                          GlobalVariables.paarnummer2 +
                          "\nErste Karte: " + GlobalVariables.Teil1Zug.Name + "\nSchon ersten Zug gemacht: " +
                          GlobalVariables.gedreht; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Spiel.LoadBild(button1, einsA);
            
            if (!GlobalVariables.gedreht)
            {
                GlobalVariables.Teil1Zug = button1;
                GlobalVariables.gedreht = true;
                GlobalVariables.paarnummer1 = einsA.Paarnummer;
            }
            else
            {
                Spiel.Spielzug(button1, GlobalVariables.Teil1Zug);
                GlobalVariables.paarnummer2 = einsA.Paarnummer;
            }

            DebugLabel();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Spiel.LoadBild(button2, einsB);

            if (!GlobalVariables.gedreht)
            {
                GlobalVariables.Teil1Zug = button2;
                GlobalVariables.gedreht = true;
                GlobalVariables.paarnummer1 = einsB.Paarnummer;
            }
            else
            {
                Spiel.Spielzug(button2, GlobalVariables.Teil1Zug);
                GlobalVariables.paarnummer2 = einsB.Paarnummer;
            }
            DebugLabel();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Spiel.LoadBild(button3, zweiA);
            
            if (!GlobalVariables.gedreht)
            {
                GlobalVariables.Teil1Zug = button3;
                GlobalVariables.gedreht = true;
                GlobalVariables.paarnummer1 = zweiA.Paarnummer;
            }
            else
            {
                Spiel.Spielzug(button3, GlobalVariables.Teil1Zug);
                GlobalVariables.paarnummer2 = zweiA.Paarnummer;
            }
            DebugLabel();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            Spiel.LoadBild(button4, zweiB);
            
            if (!GlobalVariables.gedreht)
            {
                GlobalVariables.Teil1Zug = button4;
                GlobalVariables.gedreht = true;
                GlobalVariables.paarnummer1 = zweiB.Paarnummer;
            }
            else
            {
                Spiel.Spielzug(button4, GlobalVariables.Teil1Zug);
                GlobalVariables.paarnummer2 = zweiB.Paarnummer;
            }
            DebugLabel();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Spiel.LoadBild(button5, dreiA);
            
            if (!GlobalVariables.gedreht)
            {
                GlobalVariables.Teil1Zug = button5;
                GlobalVariables.gedreht = true;
                GlobalVariables.paarnummer1 = dreiA.Paarnummer;
            }
            else
            {
                Spiel.Spielzug(button5, GlobalVariables.Teil1Zug);
                GlobalVariables.paarnummer2 = dreiA.Paarnummer;
            }
            DebugLabel();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Spiel.LoadBild(button6, dreiB);
             
            if (!GlobalVariables.gedreht)
            {
                GlobalVariables.Teil1Zug = button6;
                GlobalVariables.gedreht = true;
                GlobalVariables.paarnummer1 = dreiB.Paarnummer;
            }
            else
            {
                Spiel.Spielzug(button6, GlobalVariables.Teil1Zug);
                GlobalVariables.paarnummer2 = dreiB.Paarnummer;
            }
            DebugLabel();
        }
        
             
        
    }
}    