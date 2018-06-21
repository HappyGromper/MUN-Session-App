using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolfinV._1
{
    public class Information
    {


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

        //Charcter's names as data
        private string c1name;
        private string c2name;
        private string c3name;
        private string c4name;
        private string c5name;
        private string c6name;
        private string c7name;
        private string c8name;
        private string c9name;
        private string c10name;
        private string c11name;
        private string c12name;
        private string c13name;
        private string c14name;
        private string c15name;
        private string c16name;
        private string c17name;
        private string c18name;
        private string c19name;
        private string c20name;

        //session one data
        private string c1sess1;
        private string c2sess1;
        private string c3sess1;
        private string c4sess1;
        private string c5sess1;
        private string c6sess1;
        private string c7sess1;
        private string c8sess1;
        private string c9sess1;
        private string c10sess1;
        private string c11sess1;
        private string c12sess1;
        private string c13sess1;
        private string c14sess1;
        private string c15sess1;
        private string c16sess1;
        private string c17sess1;
        private string c18sess1;
        private string c19sess1;
        private string c20sess1;

        //session two data
        private string c1sess2;
        private string c2sess2;
        private string c3sess2;
        private string c4sess2;
        private string c5sess2;
        private string c6sess2;
        private string c7sess2;
        private string c8sess2;
        private string c9sess2;
        private string c10sess2;
        private string c11sess2;
        private string c12sess2;
        private string c13sess2;
        private string c14sess2;
        private string c15sess2;
        private string c16sess2;
        private string c17sess2;
        private string c18sess2;
        private string c19sess2;
        private string c20sess2;


        //session three data
        private string c1sess3;
        private string c2sess3;
        private string c3sess3;
        private string c4sess3;
        private string c5sess3;
        private string c6sess3;
        private string c7sess3;
        private string c8sess3;
        private string c9sess3;
        private string c10sess3;
        private string c11sess3;
        private string c12sess3;
        private string c13sess3;
        private string c14sess3;
        private string c15sess3;
        private string c16sess3;
        private string c17sess3;
        private string c18sess3;
        private string c19sess3;
        private string c20sess3;



        //session four data
        private string c1sess4;
        private string c2sess4;
        private string c3sess4;
        private string c4sess4;
        private string c5sess4;
        private string c6sess4;
        private string c7sess4;
        private string c8sess4;
        private string c9sess4;
        private string c10sess4;
        private string c11sess4;
        private string c12sess4;
        private string c13sess4;
        private string c14sess4;
        private string c15sess4;
        private string c16sess4;
        private string c17sess4;
        private string c18sess4;
        private string c19sess4;
        private string c20sess4;


        //total points
        private string totalc1;
        private string totalc2;
        private string totalc3;
        private string totalc4;
        private string totalc5;
        private string totalc6;
        private string totalc7;
        private string totalc8;
        private string totalc9;
        private string totalc10;
        private string totalc11;
        private string totalc12;
        private string totalc13;
        private string totalc14;
        private string totalc15;
        private string totalc16;
        private string totalc17;
        private string totalc18;
        private string totalc19;
        private string totalc20;

        private string notes;

        //Character 1's Data
        public string C1Name
        {
            get { return c1name; }
            set { c1name = value; }
        }
        public string C1sess1
        {
            get { return c1sess1; }
            set { c1sess1 = value; }
        }
        public string C1sess2
        {
            get { return c1sess2; }
            set { c1sess2 = value; }
        }
        public string C1sess3
        {
            get { return c1sess3; }
            set { c1sess3 = value; }
        }
        public string C1sess4
        {
            get { return c1sess4; }
            set { c1sess4 = value; }
        }
        public string C1Total
        {
            get { return totalc1; }
            set { totalc1 = value; }
        }


        //Character 2's Data
        public string C2Name
        {
            get { return c2name; }
            set { c2name = value; }
        }
        public string C2sess1
        {
            get { return c2sess1; }
            set { c2sess1 = value; }
        }
        public string C2sess2
        {
            get { return c2sess2; }
            set { c2sess2 = value; }
        }
        public string C2sess3
        {
            get { return c2sess3; }
            set { c2sess3 = value; }
        }
        public string C2sess4
        {
            get { return c2sess4; }
            set { c2sess4 = value; }
        }

        public string C2Total
        {
            get { return totalc2; }
            set { totalc2 = value; }
        }

        //Character 3's Data
        public string C3Name
        {
            get { return c3name; }
            set { c3name = value; }
        }
        public string C3sess1
        {
            get { return c3sess1; }
            set { c3sess1 = value; }
        }
        public string C3sess2
        {
            get { return c3sess2; }
            set { c3sess2 = value; }
        }
        public string C3sess3
        {
            get { return c3sess3; }
            set { c3sess3 = value; }
        }
        public string C3sess4
        {
            get { return c3sess4; }
            set { c3sess4 = value; }
        }

        public string C3Total
        {
            get { return totalc3; }
            set { totalc3 = value; }
        }
        //Character 4's Data
        public string C4Name
        {
            get { return c4name; }
            set { c4name = value; }
        }
        public string C4sess1
        {
            get { return c4sess1; }
            set { c4sess1 = value; }
        }
        public string C4sess2
        {
            get { return c4sess2; }
            set { c4sess2 = value; }
        }
        public string C4sess3
        {
            get { return c4sess3; }
            set { c4sess3 = value; }
        }
        public string C4sess4
        {
            get { return c4sess4; }
            set { c4sess4 = value; }
        }

        public string C4Total
        {
            get { return totalc4; }
            set { totalc4 = value; }
        }

        //Character 5's Data
        public string C5Name
        {
            get { return c5name; }
            set { c5name = value; }
        }
        public string C5sess1
        {
            get { return c5sess1; }
            set { c5sess1 = value; }
        }
        public string C5sess2
        {
            get { return c5sess2; }
            set { c5sess2 = value; }
        }
        public string C5sess3
        {
            get { return c5sess3; }
            set { c5sess3 = value; }
        }
        public string C5sess4
        {
            get { return c5sess4; }
            set { c5sess4 = value; }
        }

        public string C5Total
        {
            get { return totalc5; }
            set { totalc5 = value; }
        }

        //Character 6's Data
        public string C6Name
        {
            get { return c6name; }
            set { c6name = value; }
        }
        public string C6sess1
        {
            get { return c6sess1; }
            set { c6sess1 = value; }
        }
        public string C6sess2
        {
            get { return c6sess2; }
            set { c6sess2 = value; }
        }
        public string C6sess3
        {
            get { return c6sess3; }
            set { c6sess3 = value; }
        }
        public string C6sess4
        {
            get { return c6sess4; }
            set { c6sess4 = value; }
        }

        public string C6Total
        {
            get { return totalc6; }
            set { totalc6 = value; }
        }

        //Character 7's Data
        public string C7Name
        {
            get { return c7name; }
            set { c7name = value; }
        }
        public string C7sess1
        {
            get { return c7sess1; }
            set { c7sess1 = value; }
        }
        public string C7sess2
        {
            get { return c7sess2; }
            set { c7sess2 = value; }
        }
        public string C7sess3
        {
            get { return c7sess3; }
            set { c7sess3 = value; }
        }
        public string C7sess4
        {
            get { return c7sess4; }
            set { c7sess4 = value; }
        }

        public string C7Total
        {
            get { return totalc7; }
            set { totalc7 = value; }
        }

        //Character 8's Data
        public string C8Name
        {
            get { return c8name; }
            set { c8name = value; }
        }
        public string C8sess1
        {
            get { return c8sess1; }
            set { c8sess1 = value; }
        }
        public string C8sess2
        {
            get { return c8sess2; }
            set { c8sess2 = value; }
        }
        public string C8sess3
        {
            get { return c8sess3; }
            set { c8sess3 = value; }
        }
        public string C8sess4
        {
            get { return c8sess4; }
            set { c8sess4 = value; }
        }

        public string C8Total
        {
            get { return totalc8; }
            set { totalc8 = value; }
        }

        //Character 9's Data
        public string C9Name
        {
            get { return c9name; }
            set { c9name = value; }
        }
        public string C9sess1
        {
            get { return c9sess1; }
            set { c9sess1 = value; }
        }
        public string C9sess2
        {
            get { return c9sess2; }
            set { c9sess2 = value; }
        }
        public string C9sess3
        {
            get { return c9sess3; }
            set { c9sess3 = value; }
        }
        public string C9sess4
        {
            get { return c9sess4; }
            set { c9sess4 = value; }
        }

        public string C9Total
        {
            get { return totalc9; }
            set { totalc9 = value; }
        }

        //Character 10's Data
        public string C10Name
        {
            get { return c10name; }
            set { c10name = value; }
        }
        public string C10sess1
        {
            get { return c10sess1; }
            set { c10sess1 = value; }
        }
        public string C10sess2
        {
            get { return c10sess2; }
            set { c10sess2 = value; }
        }
        public string C10sess3
        {
            get { return c10sess3; }
            set { c10sess3 = value; }
        }
        public string C10sess4
        {
            get { return c10sess4; }
            set { c10sess4 = value; }
        }

        public string C10Total
        {
            get { return totalc10; }
            set { totalc10 = value; }
        }

        //Character 11's Data
        public string C11Name
        {
            get { return c11name; }
            set { c11name = value; }
        }
        public string C11sess1
        {
            get { return c11sess1; }
            set { c11sess1 = value; }
        }
        public string C11sess2
        {
            get { return c11sess2; }
            set { c11sess2 = value; }
        }
        public string C11sess3
        {
            get { return c11sess3; }
            set { c11sess3 = value; }
        }
        public string C11sess4
        {
            get { return c11sess4; }
            set { c11sess4 = value; }
        }

        public string C11Total
        {
            get { return totalc11; }
            set { totalc11 = value; }
        }

        //Character 12's Data
        public string C12Name
        {
            get { return c12name; }
            set { c12name = value; }
        }
        public string C12sess1
        {
            get { return c12sess1; }
            set { c12sess1 = value; }
        }
        public string C12sess2
        {
            get { return c12sess2; }
            set { c12sess2 = value; }
        }
        public string C12sess3
        {
            get { return c12sess3; }
            set { c12sess3 = value; }
        }
        public string C12sess4
        {
            get { return c12sess4; }
            set { c12sess4 = value; }
        }
        public string C12Total
        {
            get { return totalc12; }
            set { totalc12 = value; }
        }

        //Character 13's Data
        public string C13Name
        {
            get { return c13name; }
            set { c13name = value; }
        }
        public string C13sess1
        {
            get { return c13sess1; }
            set { c13sess1 = value; }
        }
        public string C13sess2
        {
            get { return c13sess2; }
            set { c13sess2 = value; }
        }
        public string C13sess3
        {
            get { return c13sess3; }
            set { c13sess3 = value; }
        }
        public string C13sess4
        {
            get { return c13sess4; }
            set { c13sess4 = value; }
        }
        public string C13Total
        {
            get { return totalc13; }
            set { totalc13 = value; }
        }

        //Character 14's Data
        public string C14Name
        {
            get { return c14name; }
            set { c14name = value; }
        }
        public string C14sess1
        {
            get { return c14sess1; }
            set { c14sess1 = value; }
        }
        public string C14sess2
        {
            get { return c14sess2; }
            set { c14sess2 = value; }
        }
        public string C14sess3
        {
            get { return c14sess3; }
            set { c14sess3 = value; }
        }
        public string C14sess4
        {
            get { return c14sess4; }
            set { c14sess4 = value; }
        }
        public string C14Total
        {
            get { return totalc14; }
            set { totalc14 = value; }
        }

        //Character 15's Data
        public string C15Name
        {
            get { return c15name; }
            set { c15name = value; }
        }
        public string C15sess1
        {
            get { return c15sess1; }
            set { c15sess1 = value; }
        }
        public string C15sess2
        {
            get { return c15sess2; }
            set { c15sess2 = value; }
        }
        public string C15sess3
        {
            get { return c15sess3; }
            set { c15sess3 = value; }
        }
        public string C15sess4
        {
            get { return c15sess4; }
            set { c15sess4 = value; }
        }
        public string C15Total
        {
            get { return totalc15; }
            set { totalc15 = value; }
        }

        //Character 16's Data
        public string C16Name
        {
            get { return c16name; }
            set { c16name = value; }
        }
        public string C16sess1
        {
            get { return c16sess1; }
            set { c16sess1 = value; }
        }
        public string C16sess2
        {
            get { return c16sess2; }
            set { c16sess2 = value; }
        }
        public string C16sess3
        {
            get { return c16sess3; }
            set { c16sess3 = value; }
        }
        public string C16sess4
        {
            get { return c16sess4; }
            set { c16sess4 = value; }
        }
        public string C16Total
        {
            get { return totalc16; }
            set { totalc16 = value; }
        }

        //Character 17's Data
        public string C17Name
        {
            get { return c17name; }
            set { c17name = value; }
        }
        public string C17sess1
        {
            get { return c17sess1; }
            set { c17sess1 = value; }
        }
        public string C17sess2
        {
            get { return c17sess2; }
            set { c17sess2 = value; }
        }
        public string C17sess3
        {
            get { return c17sess3; }
            set { c17sess3 = value; }
        }
        public string C17sess4
        {
            get { return c17sess4; }
            set { c17sess4 = value; }
        }
        public string C17Total
        {
            get { return totalc17; }
            set { totalc17 = value; }
        }


        //Character 18's Data
        public string C18Name
        {
            get { return c18name; }
            set { c18name = value; }
        }
        public string C18sess1
        {
            get { return c18sess1; }
            set { c18sess1 = value; }
        }
        public string C18sess2
        {
            get { return c18sess2; }
            set { c18sess2 = value; }
        }
        public string C18sess3
        {
            get { return c18sess3; }
            set { c18sess3 = value; }
        }
        public string C18sess4
        {
            get { return c18sess4; }
            set { c18sess4 = value; }
        }
        public string C18Total
        {
            get { return totalc18; }
            set { totalc18 = value; }
        }

        //Character 19's Data
        public string C19Name
        {
            get { return c19name; }
            set { c19name = value; }
        }
        public string C19sess1
        {
            get { return c19sess1; }
            set { c19sess1 = value; }
        }
        public string C19sess2
        {
            get { return c19sess2; }
            set { c19sess2 = value; }
        }
        public string C19sess3
        {
            get { return c19sess3; }
            set { c19sess3 = value; }
        }
        public string C19sess4
        {
            get { return c19sess4; }
            set { c19sess4 = value; }
        }
        public string C19Total
        {
            get { return totalc19; }
            set { totalc19 = value; }
        }
        //Character 20's Data
        public string C20Name
        {
            get { return c20name; }
            set { c20name = value; }
        }
        public string C20sess1
        {
            get { return c20sess1; }
            set { c20sess1 = value; }
        }
        public string C20sess2
        {
            get { return c20sess2; }
            set { c20sess2 = value; }
        }
        public string C20sess3
        {
            get { return c20sess3; }
            set { c20sess3 = value; }
        }
        public string C20sess4
        {
            get { return c20sess4; }
            set { c20sess4 = value; }
        }
        public string C20Total
        {
            get { return totalc20; }
            set { totalc20 = value; }
        }




        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }
    }
}
