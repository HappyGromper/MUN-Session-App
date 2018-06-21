using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Xml.Serialization;
using Timer = System.Timers.Timer;

namespace DolfinV._1


{


    public partial class MUNCharterSheet : Form
    {



        public MUNCharterSheet()
        {

            InitializeComponent();

        }




        public void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("data.xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Information));
                FileStream read = new FileStream("data.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Information info = (Information)xs.Deserialize(read);


                character1.Text = info.C1Name;
                c1Session1.Text = info.C1sess1;
                c1Session2.Text = info.C1sess2;
                c1Session3.Text = info.C1sess3;
                c1Session4.Text = info.C1sess4;
                c1Total.Text = info.C1Total;


                character2.Text = info.C2Name;
                c2Session1.Text = info.C2sess1;
                c2Session2.Text = info.C2sess2;
                c2Session3.Text = info.C2sess3;
                c2Session4.Text = info.C2sess4;
                c2Total.Text = info.C2Total;

                character3.Text = info.C3Name;
                c3Session1.Text = info.C3sess1;
                c3Session2.Text = info.C3sess2;
                c3Session3.Text = info.C3sess3;
                c3Session4.Text = info.C3sess4;
                c3Total.Text = info.C3Total;

                character4.Text = info.C4Name;
                c4Session1.Text = info.C4sess1;
                c4Session2.Text = info.C4sess2;
                c4Session3.Text = info.C4sess3;
                c4Session4.Text = info.C4sess4;
                c4Total.Text = info.C4Total;

                character5.Text = info.C5Name;
                c5Session1.Text = info.C5sess1;
                c5Session2.Text = info.C5sess2;
                c5Session3.Text = info.C5sess3;
                c5Session4.Text = info.C5sess4;
                c5Total.Text = info.C1Total;

                character6.Text = info.C6Name;
                c6Session1.Text = info.C6sess1;
                c6Session2.Text = info.C6sess2;
                c6Session3.Text = info.C6sess3;
                c6Session4.Text = info.C6sess4;
                c6Total.Text = info.C6Total;


                character7.Text = info.C7Name;
                c7Session1.Text = info.C7sess1;
                c7Session2.Text = info.C7sess2;
                c7Session3.Text = info.C7sess3;
                c7Session4.Text = info.C7sess4;
                c7Total.Text = info.C7Total;

                character8.Text = info.C8Name;
                c8Session1.Text = info.C8sess1;
                c8Session2.Text = info.C8sess2;
                c8Session3.Text = info.C8sess3;
                c8Session4.Text = info.C8sess4;
                c8Total.Text = info.C8Total;

                character9.Text = info.C9Name;
                c9Session1.Text = info.C9sess1;
                c9Session2.Text = info.C9sess2;
                c9Session3.Text = info.C9sess3;
                c9Session4.Text = info.C9sess4;
                c9Total.Text = info.C9Total;

                character10.Text = info.C10Name;
                c10Session1.Text = info.C10sess1;
                c10Session2.Text = info.C10sess2;
                c10Session3.Text = info.C10sess3;
                c10Session4.Text = info.C10sess4;
                c10Total.Text = info.C10Total;

                character11.Text = info.C11Name;
                c11Session1.Text = info.C11sess1;
                c11Session2.Text = info.C11sess2;
                c11Session3.Text = info.C11sess3;
                c11Session4.Text = info.C11sess4;
                c11Total.Text = info.C11Total;

                character12.Text = info.C12Name;
                c12Session1.Text = info.C12sess1;
                c12Session2.Text = info.C12sess2;
                c12Session3.Text = info.C12sess3;
                c12Session4.Text = info.C12sess4;
                c12Total.Text = info.C12Total;

                character13.Text = info.C13Name;
                c13Session1.Text = info.C13sess1;
                c13Session2.Text = info.C13sess2;
                c13Session3.Text = info.C13sess3;
                c13Session4.Text = info.C13sess4;
                c13Total.Text = info.C13Total;

                character14.Text = info.C14Name;
                c14Session1.Text = info.C14sess1;
                c14Session2.Text = info.C14sess2;
                c14Session3.Text = info.C14sess3;
                c14Session4.Text = info.C14sess4;
                c14Total.Text = info.C14Total;


                character15.Text = info.C15Name;
                c15Session1.Text = info.C15sess1;
                c15Session2.Text = info.C15sess2;
                c15Session3.Text = info.C15sess3;
                c15Session4.Text = info.C15sess4;
                c15Total.Text = info.C15Total;

                character16.Text = info.C16Name;
                c16Session1.Text = info.C16sess1;
                c16Session2.Text = info.C16sess2;
                c16Session3.Text = info.C16sess3;
                c16Session4.Text = info.C16sess4;
                c16Total.Text = info.C16Total;

                character17.Text = info.C17Name;
                c17Session1.Text = info.C17sess1;
                c17Session2.Text = info.C17sess2;
                c17Session3.Text = info.C17sess3;
                c17Session4.Text = info.C17sess4;
                c17Total.Text = info.C17Total;

                character18.Text = info.C18Name;
                c18Session1.Text = info.C18sess1;
                c18Session2.Text = info.C18sess2;
                c18Session3.Text = info.C18sess3;
                c18Session4.Text = info.C18sess4;
                c18Total.Text = info.C18Total;

                character19.Text = info.C19Name;
                c19Session1.Text = info.C19sess1;
                c19Session2.Text = info.C19sess2;
                c19Session3.Text = info.C19sess3;
                c19Session4.Text = info.C19sess4;
                c19Total.Text = info.C19Total;

                character20.Text = info.C20Name;
                c20Session1.Text = info.C20sess1;
                c20Session2.Text = info.C20sess2;
                c20Session3.Text = info.C20sess3;
                c20Session4.Text = info.C20sess4;
                c20Total.Text = info.C20Total;

                munNotes.Text = info.Notes;

            }
        }




        //Character's names are converted to their Char+(number) into a string
        //    String c1Input = character1 + ":" + c1Session1.Text + ":" + c1Session2.Text + ":" + c1Session3.Text + ":" + c1Session4.Text + ":" + c1Total;
        //    String c2Input = character2 + ":" + c2Session1.Text + ":" + c2Session2.Text + ":" + c2Session3.Text + ":" + c2Session4.Text + ":" + c2Total;
        //    String c3Input = character3 + ":" + c3Session1.Text + ":" + c3Session2.Text + ":" + c3Session3.Text + ":" + c3Session4.Text + ":" + c3Total;
        //    String c4Input = character4 + ":" + c4Session1.Text + ":" + c4Session2.Text + ":" + c4Session3.Text + ":" + c4Session4.Text + ":" + c4Total;
        //    String c5Input = character5 + ":" + c5Session1.Text + ":" + c5Session2.Text + ":" + c5Session3.Text + ":" + c5Session4.Text + ":" + c5Total;
        //    String c6Input = character6 + ":" + c6Session1.Text + ":" + c6Session2.Text + ":" + c6Session3.Text + ":" + c6Session4.Text + ":" + c6Total;
        //    String c7Input = character7 + ":" + c7Session1.Text + ":" + c7Session2.Text + ":" + c7Session3.Text + ":" + c7Session4.Text + ":" + c7Total;
        //    String c8Input = character8 + ":" + c8Session1.Text + ":" + c8Session2.Text + ":" + c8Session3.Text + ":" + c8Session4.Text + ":" + c8Total;
        //    String c9Input = character9 + ":" + c9Session1.Text + ":" + c9Session2.Text + ":" + c9Session3.Text + ":" + c9Session4.Text + ":" + c9Total;
        //    String c10Input = character10 + ":" + c10Session1.Text + ":" + c10Session2.Text + ":" + c10Session3.Text + ":" + c10Session4.Text + ":" + c10Total;
        //    String c11Input = character11 + ":" + c11Session1.Text + ":" + c11Session2.Text + ":" + c11Session3.Text + ":" + c11Session4.Text + ":" + c11Total;
        //    String c12Input = character12 + ":" + c12Session1.Text + ":" + c12Session2.Text + ":" + c12Session3.Text + ":" + c12Session4.Text + ":" + c12Total;
        //    String c13Input = character13 + ":" + c13Session1.Text + ":" + c13Session2.Text + ":" + c13Session3.Text + ":" + c13Session4.Text + ":" + c13Total;
        //    String c14Input = character14 + ":" + c14Session1.Text + ":" + c14Session2.Text + ":" + c14Session3.Text + ":" + c14Session4.Text + ":" + c14Total;
        //    String c15Input = character15 + ":" + c15Session1.Text + ":" + c15Session2.Text + ":" + c15Session3.Text + ":" + c15Session4.Text + ":" + c15Total;
        //    String c16Input = character16 + ":" + c16Session1.Text + ":" + c16Session2.Text + ":" + c16Session3.Text + ":" + c16Session4.Text + ":" + c16Total;
        //    String c17Input = character17 + ":" + c17Session1.Text + ":" + c17Session2.Text + ":" + c17Session3.Text + ":" + c17Session4.Text + ":" + c17Total;
        //    String c18Input = character18 + ":" + c18Session1.Text + ":" + c18Session2.Text + ":" + c18Session3.Text + ":" + c18Session4.Text + ":" + c18Total;



        private void button1_Click(object sender, EventArgs e)
        {
            //Charter 1
            int c1s1, c1s2, c1s3, c1s4;
            int.TryParse(c1Session1.Text, out c1s1);
            int.TryParse(c1Session2.Text, out c1s2);
            int.TryParse(c1Session3.Text, out c1s3);
            int.TryParse(c1Session4.Text, out c1s4);

            c1Total.ResetText();
            c1Total.Text = (c1s1 + c1s2 + c1s3 + c1s4).ToString();
            int c1TotalPoints = (c1s1 + c1s2 + c1s3 + c1s4);


            //Character 2
            int c2s1, c2s2, c2s3, c2s4;
            int.TryParse(c2Session1.Text, out c2s1);
            int.TryParse(c2Session2.Text, out c2s2);
            int.TryParse(c2Session3.Text, out c2s3);
            int.TryParse(c2Session4.Text, out c2s4);

            c2Total.ResetText();
            c2Total.Text = (c2s1 + c2s2 + c2s3 + c2s4).ToString();
            int c2TotalPoints = (c2s1 + c2s2 + c2s3 + c2s4);


            //Character 3
            int c3s1, c3s2, c3s3, c3s4;
            int.TryParse(c3Session1.Text, out c3s1);
            int.TryParse(c3Session2.Text, out c3s2);
            int.TryParse(c3Session3.Text, out c3s3);
            int.TryParse(c3Session4.Text, out c3s4);

            c3Total.ResetText();
            c3Total.Text = (c3s1 + c3s2 + c3s3 + c3s4).ToString();
            int c3TotalPoints = (c3s1 + c3s2 + c3s3 + c3s4);


            //Character 4
            int c4s1, c4s2, c4s3, c4s4;
            int.TryParse(c4Session1.Text, out c4s1);
            int.TryParse(c4Session2.Text, out c4s2);
            int.TryParse(c4Session3.Text, out c4s3);
            int.TryParse(c4Session4.Text, out c4s4);


            c4Total.ResetText();
            c4Total.Text = (c4s1 + c4s2 + c4s3 + c4s4).ToString();
            int c4TotalPoints = (c4s1 + c4s2 + c4s3 + c4s4);


            //Charaacter 5
            int c5s1, c5s2, c5s3, c5s4;
            int.TryParse(c5Session1.Text, out c5s1);
            int.TryParse(c5Session2.Text, out c5s2);
            int.TryParse(c5Session3.Text, out c5s3);
            int.TryParse(c5Session4.Text, out c5s4);

            c5Total.ResetText();
            c5Total.Text = (c5s1 + c5s2 + c5s3 + c5s4).ToString();
            int c5TotalPoints = (c5s1 + c5s2 + c5s3 + c5s4);


            //Charcter 6
            int c6s1, c6s2, c6s3, c6s4;
            int.TryParse(c6Session1.Text, out c6s1);
            int.TryParse(c6Session2.Text, out c6s2);
            int.TryParse(c6Session3.Text, out c6s3);
            int.TryParse(c6Session4.Text, out c6s4);

            c6Total.ResetText();
            c6Total.Text = (c6s1 + c6s2 + c6s3 + c6s4).ToString();
            int c6TotalPoints = (c6s1 + c6s2 + c6s3 + c6s4);


            //Charcter 7
            int c7s1, c7s2, c7s3, c7s4;
            int.TryParse(c7Session1.Text, out c7s1);
            int.TryParse(c7Session2.Text, out c7s2);
            int.TryParse(c7Session3.Text, out c7s3);
            int.TryParse(c7Session4.Text, out c7s4);

            c7Total.ResetText();
            c7Total.Text = (c7s1 + c7s2 + c7s3 + c7s4).ToString();
            int c7TotalPoints = (c7s1 + c7s2 + c7s3 + c7s4);


            //Character 8
            int c8s1, c8s2, c8s3, c8s4;
            int.TryParse(c8Session1.Text, out c8s1);
            int.TryParse(c8Session2.Text, out c8s2);
            int.TryParse(c8Session3.Text, out c8s3);
            int.TryParse(c8Session4.Text, out c8s4);

            c8Total.ResetText();
            c8Total.Text = (c8s1 + c8s2 + c8s3 + c8s4).ToString();
            int c8TotalPoints = (c8s1 + c8s2 + c8s3 + c8s4);


            //Charcter 9
            int c9s1, c9s2, c9s3, c9s4;
            int.TryParse(c9Session1.Text, out c9s1);
            int.TryParse(c9Session2.Text, out c9s2);
            int.TryParse(c9Session3.Text, out c9s3);
            int.TryParse(c9Session4.Text, out c9s4);

            c9Total.ResetText();
            c9Total.Text = (c9s1 + c9s2 + c9s3 + c9s4).ToString();
            int c9TotalPoints = (c9s1 + c9s2 + c9s3 + c9s4);


            //Charcter 10
            int c10s1, c10s2, c10s3, c10s4;
            int.TryParse(c10Session1.Text, out c10s1);
            int.TryParse(c10Session2.Text, out c10s2);
            int.TryParse(c10Session3.Text, out c10s3);
            int.TryParse(c10Session4.Text, out c10s4);

            c10Total.ResetText();
            c10Total.Text = (c10s1 + c10s2 + c10s3 + c10s4).ToString();
            int c10TotalPoints = (c10s1 + c10s2 + c10s3 + c10s4);



            //Character 11
            int c11s1, c11s2, c11s3, c11s4;
            int.TryParse(c11Session1.Text, out c11s1);
            int.TryParse(c11Session2.Text, out c11s2);
            int.TryParse(c11Session3.Text, out c11s3);
            int.TryParse(c11Session4.Text, out c11s4);

            c11Total.ResetText();
            c11Total.Text = (c11s1 + c11s2 + c11s3 + c11s4).ToString();
            int c11TotalPoints = (c11s1 + c11s2 + c11s3 + c11s4);


            //Character 12
            int c12s1, c12s2, c12s3, c12s4;
            int.TryParse(c12Session1.Text, out c12s1);
            int.TryParse(c12Session2.Text, out c12s2);
            int.TryParse(c12Session3.Text, out c12s3);
            int.TryParse(c12Session4.Text, out c12s4);

            c12Total.ResetText();
            c12Total.Text = (c12s1 + c12s2 + c12s3 + c12s4).ToString();
            int c12TotalPoints = (c12s1 + c12s2 + c12s3 + c12s4);


            //Charcter 13
            int c13s1, c13s2, c13s3, c13s4;
            int.TryParse(c13Session1.Text, out c13s1);
            int.TryParse(c13Session2.Text, out c13s2);
            int.TryParse(c13Session3.Text, out c13s3);
            int.TryParse(c13Session4.Text, out c13s4);

            c13Total.ResetText();
            c13Total.Text = (c13s1 + c13s2 + c13s3 + c13s4).ToString();
            int c13TotalPoints = (c13s1 + c13s2 + c13s3 + c13s4);


            //Character 14
            int c14s1, c14s2, c14s3, c14s4;
            int.TryParse(c14Session1.Text, out c14s1);
            int.TryParse(c14Session2.Text, out c14s2);
            int.TryParse(c14Session3.Text, out c14s3);
            int.TryParse(c14Session4.Text, out c14s4);

            c14Total.ResetText();
            c14Total.Text = (c14s1 + c14s2 + c14s3 + c14s4).ToString();
            int c14TotalPoints = (c14s1 + c14s2 + c14s3 + c14s4);


            //Character 15
            int c15s1, c15s2, c15s3, c15s4;
            int.TryParse(c15Session1.Text, out c15s1);
            int.TryParse(c15Session2.Text, out c15s2);
            int.TryParse(c15Session3.Text, out c15s3);
            int.TryParse(c15Session4.Text, out c15s4);

            c15Total.ResetText();
            c15Total.Text = (c15s1 + c15s2 + c15s3 + c15s4).ToString();
            int c15TotalPoints = (c15s1 + c15s2 + c15s3 + c15s4);


            //Charcter 16
            int c16s1, c16s2, c16s3, c16s4;
            int.TryParse(c16Session1.Text, out c16s1);
            int.TryParse(c16Session2.Text, out c16s2);
            int.TryParse(c16Session3.Text, out c16s3);
            int.TryParse(c16Session4.Text, out c16s4);

            c16Total.ResetText();
            c16Total.Text = (c16s1 + c16s2 + c16s3 + c16s4).ToString();
            int c16TotalPoints = (c16s1 + c16s2 + c16s3 + c16s4);


            //Charcter 17
            int c17s1, c17s2, c17s3, c17s4;
            int.TryParse(c17Session1.Text, out c17s1);
            int.TryParse(c17Session2.Text, out c17s2);
            int.TryParse(c17Session3.Text, out c17s3);
            int.TryParse(c17Session4.Text, out c17s4);

            c17Total.ResetText();
            c17Total.Text = (c17s1 + c17s2 + c17s3 + c17s4).ToString();
            int c17TotalPoints = (c17s1 + c17s2 + c17s3 + c17s4);


            //Character 18
            int c18s1, c18s2, c18s3, c18s4;
            int.TryParse(c18Session1.Text, out c18s1);
            int.TryParse(c18Session2.Text, out c18s2);
            int.TryParse(c18Session3.Text, out c18s3);
            int.TryParse(c18Session4.Text, out c18s4);

            c18Total.ResetText();
            c18Total.Text = (c18s1 + c18s2 + c18s3 + c18s4).ToString();
            int c18TotalPoints = (c18s1 + c18s2 + c18s3 + c18s4);

            //Charter 19
            int c19s1, c19s2, c19s3, c19s4;
            int.TryParse(c19Session1.Text, out c19s1);
            int.TryParse(c19Session2.Text, out c19s2);
            int.TryParse(c19Session3.Text, out c19s3);
            int.TryParse(c19Session4.Text, out c19s4);

            c19Total.ResetText();
            c19Total.Text = (c19s1 + c19s2 + c19s3 + c19s4).ToString();
            int c19TotalPoints = (c19s1 + c19s2 + c19s3 + c19s4);

            //Charter 20
            int c20s1, c20s2, c20s3, c20s4;
            int.TryParse(c20Session1.Text, out c20s1);
            int.TryParse(c20Session2.Text, out c20s2);
            int.TryParse(c20Session3.Text, out c20s3);
            int.TryParse(c20Session4.Text, out c20s4);

            c20Total.ResetText();
            c20Total.Text = (c20s1 + c20s2 + c20s3 + c20s4).ToString();
            int c20TotalPoints = (c20s1 + c20s2 + c20s3 + c20s4);

        }





        private void button2_Click(object sender, System.EventArgs e)
        {
            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRng;

            String char1 = character1.Text.ToString();
            String char2 = character2.Text.ToString();
            String char3 = character3.Text.ToString();
            String char4 = character4.Text.ToString();
            String char5 = character5.Text.ToString();
            String char6 = character6.Text.ToString();
            String char7 = character7.Text.ToString();
            String char8 = character8.Text.ToString();
            String char9 = character9.Text.ToString();
            String char10 = character10.Text.ToString();
            String char11 = character11.Text.ToString();
            String char12 = character12.Text.ToString();
            String char13 = character13.Text.ToString();
            String char14 = character14.Text.ToString();
            String char15 = character15.Text.ToString();
            String char16 = character16.Text.ToString();
            String char17 = character17.Text.ToString();
            String char18 = character18.Text.ToString();
            String char19 = character19.Text.ToString();
            String char20 = character20.Text.ToString();

            try
            {
                //Start Excel and get Application object.
                oXL = new Excel.Application();
                oXL.Visible = true;

                //Get a new workbook.
                oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
                oSheet = (Excel._Worksheet)oWB.ActiveSheet;

                //Add table headers going cell by cell.
                oSheet.Cells[1, 1] = "Character Name";
                oSheet.Cells[1, 2] = "Session I";
                oSheet.Cells[1, 3] = "Session II";
                oSheet.Cells[1, 4] = "Session III";
                oSheet.Cells[1, 5] = "Session IV";
                oSheet.Cells[1, 6] = "Total";
                oSheet.Cells[1, 7] = "Awards";

                //Format A1:D1 as bold, vertical alignment = center.
                oSheet.get_Range("A1", "G1").Font.Bold = true;
                oSheet.get_Range("A1", "G1").VerticalAlignment =
                Excel.XlVAlign.xlVAlignCenter;


                //Charater names
                oSheet.Cells[2, 1] = char1;
                oSheet.Cells[3, 1] = char2;
                oSheet.Cells[4, 1] = char3;
                oSheet.Cells[5, 1] = char4;
                oSheet.Cells[6, 1] = char5;
                oSheet.Cells[7, 1] = char6;
                oSheet.Cells[8, 1] = char7;
                oSheet.Cells[9, 1] = char8;
                oSheet.Cells[10, 1] = char9;
                oSheet.Cells[11, 1] = char10;
                oSheet.Cells[12, 1] = char11;
                oSheet.Cells[13, 1] = char12;
                oSheet.Cells[14, 1] = char13;
                oSheet.Cells[15, 1] = char14;
                oSheet.Cells[16, 1] = char15;
                oSheet.Cells[17, 1] = char16;
                oSheet.Cells[18, 1] = char17;
                oSheet.Cells[19, 1] = char18;
                oSheet.Cells[20, 1] = char19;
                oSheet.Cells[21, 1] = char20;




                //session 1 for characters
                oSheet.Cells[2, 2] = c1Session1.Text;
                oSheet.Cells[3, 2] = c2Session1.Text;
                oSheet.Cells[4, 2] = c3Session1.Text;
                oSheet.Cells[5, 2] = c4Session1.Text;
                oSheet.Cells[6, 2] = c5Session1.Text;
                oSheet.Cells[7, 2] = c6Session1.Text;
                oSheet.Cells[8, 2] = c7Session1.Text;
                oSheet.Cells[9, 2] = c8Session1.Text;
                oSheet.Cells[10, 2] = c9Session1.Text;
                oSheet.Cells[11, 2] = c10Session1.Text;
                oSheet.Cells[12, 2] = c11Session1.Text;
                oSheet.Cells[13, 2] = c12Session1.Text;
                oSheet.Cells[14, 2] = c13Session1.Text;
                oSheet.Cells[15, 2] = c14Session1.Text;
                oSheet.Cells[16, 2] = c15Session1.Text;
                oSheet.Cells[17, 2] = c16Session1.Text;
                oSheet.Cells[18, 2] = c17Session1.Text;
                oSheet.Cells[19, 2] = c18Session1.Text;
                oSheet.Cells[20, 2] = c19Session1.Text;
                oSheet.Cells[21, 2] = c20Session1.Text;


                //Session 2 for characters
                oSheet.Cells[2, 3] = c1Session2.Text;
                oSheet.Cells[3, 3] = c2Session2.Text;
                oSheet.Cells[4, 3] = c3Session2.Text;
                oSheet.Cells[5, 3] = c4Session2.Text;
                oSheet.Cells[6, 3] = c5Session2.Text;
                oSheet.Cells[7, 3] = c6Session2.Text;
                oSheet.Cells[8, 3] = c7Session2.Text;
                oSheet.Cells[9, 3] = c8Session2.Text;
                oSheet.Cells[10, 3] = c9Session2.Text;
                oSheet.Cells[11, 3] = c10Session2.Text;
                oSheet.Cells[12, 3] = c11Session2.Text;
                oSheet.Cells[13, 3] = c12Session2.Text;
                oSheet.Cells[14, 3] = c13Session2.Text;
                oSheet.Cells[15, 3] = c14Session2.Text;
                oSheet.Cells[16, 3] = c15Session2.Text;
                oSheet.Cells[17, 3] = c16Session2.Text;
                oSheet.Cells[18, 3] = c17Session2.Text;
                oSheet.Cells[19, 3] = c18Session2.Text;
                oSheet.Cells[20, 3] = c19Session2.Text;
                oSheet.Cells[21, 3] = c20Session2.Text;



                //session 3 for characters
                oSheet.Cells[2, 4] = c1Session3.Text;
                oSheet.Cells[3, 4] = c2Session3.Text;
                oSheet.Cells[4, 4] = c3Session3.Text;
                oSheet.Cells[5, 4] = c4Session3.Text;
                oSheet.Cells[6, 4] = c5Session3.Text;
                oSheet.Cells[7, 4] = c6Session3.Text;
                oSheet.Cells[8, 4] = c7Session3.Text;
                oSheet.Cells[9, 4] = c8Session3.Text;
                oSheet.Cells[10, 4] = c9Session3.Text;
                oSheet.Cells[11, 4] = c10Session3.Text;
                oSheet.Cells[12, 4] = c11Session3.Text;
                oSheet.Cells[13, 4] = c12Session3.Text;
                oSheet.Cells[14, 4] = c13Session3.Text;
                oSheet.Cells[15, 4] = c14Session3.Text;
                oSheet.Cells[16, 4] = c15Session3.Text;
                oSheet.Cells[17, 4] = c16Session3.Text;
                oSheet.Cells[18, 4] = c17Session3.Text;
                oSheet.Cells[19, 4] = c18Session3.Text;
                oSheet.Cells[20, 4] = c19Session3.Text;
                oSheet.Cells[21, 4] = c20Session3.Text;



                //session 4 for characters
                oSheet.Cells[2, 5] = c1Session4.Text;
                oSheet.Cells[3, 5] = c2Session4.Text;
                oSheet.Cells[4, 5] = c3Session4.Text;
                oSheet.Cells[5, 5] = c4Session4.Text;
                oSheet.Cells[6, 5] = c5Session4.Text;
                oSheet.Cells[7, 5] = c6Session4.Text;
                oSheet.Cells[8, 5] = c7Session4.Text;
                oSheet.Cells[9, 5] = c8Session4.Text;
                oSheet.Cells[10, 5] = c9Session4.Text;
                oSheet.Cells[11, 5] = c10Session4.Text;
                oSheet.Cells[12, 5] = c11Session4.Text;
                oSheet.Cells[13, 5] = c12Session4.Text;
                oSheet.Cells[14, 5] = c13Session4.Text;
                oSheet.Cells[15, 5] = c14Session4.Text;
                oSheet.Cells[16, 5] = c15Session4.Text;
                oSheet.Cells[17, 5] = c16Session4.Text;
                oSheet.Cells[18, 5] = c17Session4.Text;
                oSheet.Cells[19, 5] = c18Session4.Text;
                oSheet.Cells[20, 5] = c19Session4.Text;
                oSheet.Cells[21, 5] = c20Session4.Text;



                //total points for characters
                oSheet.Cells[2, 6] = c1Total.Text;
                oSheet.Cells[3, 6] = c2Total.Text;
                oSheet.Cells[4, 6] = c3Total.Text;
                oSheet.Cells[5, 6] = c4Total.Text;
                oSheet.Cells[6, 6] = c5Total.Text;
                oSheet.Cells[7, 6] = c6Total.Text;
                oSheet.Cells[8, 6] = c7Total.Text;
                oSheet.Cells[9, 6] = c8Total.Text;
                oSheet.Cells[10, 6] = c9Total.Text;
                oSheet.Cells[11, 6] = c10Total.Text;
                oSheet.Cells[12, 6] = c11Total.Text;
                oSheet.Cells[13, 6] = c12Total.Text;
                oSheet.Cells[14, 6] = c13Total.Text;
                oSheet.Cells[15, 6] = c14Total.Text;
                oSheet.Cells[16, 6] = c15Total.Text;
                oSheet.Cells[17, 6] = c16Total.Text;
                oSheet.Cells[18, 6] = c17Total.Text;
                oSheet.Cells[19, 6] = c18Total.Text;
                oSheet.Cells[20, 6] = c19Total.Text;
                oSheet.Cells[21, 6] = c20Total.Text;


                oSheet.Cells[2, 8] = munNotes.Text;


                //Fill A2:B6 with an array of values (First and Last Names).
                //oSheet.get_Range("A2", "A19").Value2 = saNames;

                ////Fill C2:C6 with a relative formula (=A2 & " " & B2).
                //oRng = oSheet.get_Range("C2", "C6");
                //oRng.Formula = "=A2 & \" \" & B2";

                //Fill D2:D6 with a formula(=RAND()*100000) and apply format.
                //oRng = oSheet.get_Range("D2", "D6");
                //oRng.Formula = "=RAND()*100000";
                //oRng.NumberFormat = "$0.00";

                //AutoFit columns A:D.


                oRng = oSheet.get_Range("A1", "A19");
                oRng.EntireColumn.AutoFit();

                //Manipulate a variable number of columns for Quarterly Sales Data.
                //DisplayQuarterlySales(oSheet);

                //Make sure Excel is visible and give the user control
                //of Microsoft Excel's lifetime.
                oXL.Visible = true;
                oXL.UserControl = true;
            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }

            saveData();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void saveData()
        {

            try
            {
                Information info = new Information();
                info.C1Name = character1.Text;
                info.C1sess1 = c1Session1.Text;
                info.C1sess2 = c1Session2.Text;
                info.C1sess3 = c1Session3.Text;
                info.C1sess4 = c1Session4.Text;
                info.C1Total = c1Total.Text;

                info.C2Name = character2.Text;
                info.C2sess1 = c2Session1.Text;
                info.C2sess2 = c2Session2.Text;
                info.C2sess3 = c2Session3.Text;
                info.C2sess4 = c2Session4.Text;
                info.C2Total = c2Total.Text;

                info.C3Name = character3.Text;
                info.C3sess1 = c3Session1.Text;
                info.C3sess2 = c3Session2.Text;
                info.C3sess3 = c3Session3.Text;
                info.C3sess4 = c3Session4.Text;
                info.C3Total = c3Total.Text;

                info.C4Name = character4.Text;
                info.C4sess1 = c4Session1.Text;
                info.C4sess2 = c4Session2.Text;
                info.C4sess3 = c4Session3.Text;
                info.C4sess4 = c4Session4.Text;
                info.C4Total = c4Total.Text;

                info.C5Name = character5.Text;
                info.C5sess1 = c5Session1.Text;
                info.C5sess2 = c5Session2.Text;
                info.C5sess3 = c5Session3.Text;
                info.C5sess4 = c5Session4.Text;
                info.C5Total = c5Total.Text;

                info.C6Name = character6.Text;
                info.C6sess1 = c6Session1.Text;
                info.C6sess2 = c6Session2.Text;
                info.C6sess3 = c6Session3.Text;
                info.C6sess4 = c6Session4.Text;
                info.C6Total = c6Total.Text;

                info.C7Name = character7.Text;
                info.C7sess1 = c7Session1.Text;
                info.C7sess2 = c7Session2.Text;
                info.C7sess3 = c7Session3.Text;
                info.C7sess4 = c7Session4.Text;
                info.C7Total = c7Total.Text;

                info.C8Name = character8.Text;
                info.C8sess1 = c8Session1.Text;
                info.C8sess2 = c8Session2.Text;
                info.C8sess3 = c8Session3.Text;
                info.C8sess4 = c8Session4.Text;
                info.C8Total = c8Total.Text;

                info.C9Name = character9.Text;
                info.C9sess1 = c9Session1.Text;
                info.C9sess2 = c9Session2.Text;
                info.C9sess3 = c9Session3.Text;
                info.C9sess4 = c9Session4.Text;
                info.C9Total = c9Total.Text;

                info.C10Name = character10.Text;
                info.C10sess1 = c10Session1.Text;
                info.C10sess2 = c10Session2.Text;
                info.C10sess3 = c10Session3.Text;
                info.C10sess4 = c10Session4.Text;
                info.C10Total = c10Total.Text;

                info.C11Name = character11.Text;
                info.C11sess1 = c11Session1.Text;
                info.C11sess2 = c11Session2.Text;
                info.C11sess3 = c11Session3.Text;
                info.C11sess4 = c11Session4.Text;
                info.C11Total = c11Total.Text;

                info.C12Name = character12.Text;
                info.C12sess1 = c12Session1.Text;
                info.C12sess2 = c12Session2.Text;
                info.C12sess3 = c12Session3.Text;
                info.C12sess4 = c12Session4.Text;
                info.C12Total = c12Total.Text;

                info.C13Name = character13.Text;
                info.C13sess1 = c13Session1.Text;
                info.C13sess2 = c13Session2.Text;
                info.C13sess3 = c13Session3.Text;
                info.C13sess4 = c13Session4.Text;
                info.C13Total = c13Total.Text;

                info.C14Name = character14.Text;
                info.C14sess1 = c14Session1.Text;
                info.C14sess2 = c14Session2.Text;
                info.C14sess3 = c14Session3.Text;
                info.C14sess4 = c14Session4.Text;
                info.C14Total = c14Total.Text;

                info.C15Name = character15.Text;
                info.C15sess1 = c15Session1.Text;
                info.C15sess2 = c15Session2.Text;
                info.C15sess3 = c15Session3.Text;
                info.C15sess4 = c15Session4.Text;
                info.C15Total = c15Total.Text;

                info.C16Name = character16.Text;
                info.C16sess1 = c16Session1.Text;
                info.C16sess2 = c16Session2.Text;
                info.C16sess3 = c16Session3.Text;
                info.C16sess4 = c16Session4.Text;
                info.C16Total = c16Total.Text;

                info.C17Name = character17.Text;
                info.C17sess1 = c17Session1.Text;
                info.C17sess2 = c17Session2.Text;
                info.C17sess3 = c17Session3.Text;
                info.C17sess4 = c17Session4.Text;
                info.C17Total = c17Total.Text;

                info.C18Name = character18.Text;
                info.C18sess1 = c18Session1.Text;
                info.C18sess2 = c18Session2.Text;
                info.C18sess3 = c18Session3.Text;
                info.C18sess4 = c18Session4.Text;
                info.C18Total = c18Total.Text;

                info.C19Name = character19.Text;
                info.C19sess1 = c19Session1.Text;
                info.C19sess2 = c19Session2.Text;
                info.C19sess3 = c19Session3.Text;
                info.C19sess4 = c19Session4.Text;
                info.C19Total = c19Total.Text;

                info.C20Name = character20.Text;
                info.C20sess1 = c20Session1.Text;
                info.C20sess2 = c20Session2.Text;
                info.C20sess3 = c20Session3.Text;
                info.C20sess4 = c20Session4.Text;
                info.C20Total = c20Total.Text;


                info.Notes = munNotes.Text;


                saveXML.SaveData(info, "data.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            saveData();
        }

        private void downloadExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Program? Any Unsaved Data Will Be Deleted", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                System.Windows.Forms.Application.Exit();
            }
        }


        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;


    }
}
