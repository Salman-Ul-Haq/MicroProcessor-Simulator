using System.Collections;

namespace PROJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int res = 0;

        int row = 0;
        int column = 0;
        int prow = 0;
        List<string> ALUvalues = new List<string>();
        Boolean stepbystep = true;
        Boolean resume = true;
        int step = 0;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ADDRESS.rows[0].Value = "XYZ";
            //DATA.rows[1].Value = 50.2;
            //dataGridView1.Rows.Add(ADDRESS);

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //int w = Screen.PrimaryScreen.Bounds.Width;
            //int h = Screen.PrimaryScreen.Bounds.Height;
            //this.Location = new Point(0, 0);
            //this.Size = new Size(w, h); 


            //if (cbmp.SelectedIndex == 0)
            //{
            //    Dec8();
            //}
            //if (cbmp.SelectedIndex == 1)
            //{
            //    Dec16();
            //}
            //if (cbmp.SelectedIndex == 2)
            //{
            //    Dec32();
            //}
            //if (cbmp.SelectedIndex == 3)
            //{
            //    Dec64();
            //}
        }

        public void add2no()
        {

            MainMem.ColumnCount = 3;
            MainMem.Columns[0].Name = "ADDRESS";
            MainMem.Columns[1].Name = "DATA";
            MainMem.Columns[2].Name = "MNEMONIC";

            ArrayList row = new ArrayList();
            row.Add("0");
            row.Add("0001 0100");
            row.Add("LOAD 4");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1");
            row.Add("0010 0101");
            row.Add("ADD 5");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("2");
            row.Add("0110 0110");
            row.Add("STORE 6");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("3");
            row.Add("  ");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("4");
            row.Add("0100");
            row.Add("4");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("5");
            row.Add("1000");
            row.Add("8");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("6");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("7");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("8");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());


        }
        public void Loadv()
        {
            for (int i = 0; i < MainMem.Rows.Count; i++)
            {

                MainMem.Rows[i].Cells[1].Value = txtal.Text;
                txtal.Clear();
                decoder.Rows.Clear();
                txtALU.Clear();


            }
            MainMem.ColumnCount = 3;
            MainMem.Columns[0].Name = "ADDRESS";
            MainMem.Columns[1].Name = "DATA";
            MainMem.Columns[1].Name = "MNEMONIC";

            ArrayList row = new ArrayList();
            row.Add("1 ");
            row.Add("0001 0010");
            row.Add("LOAD 2");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("2");
            row.Add("1010");
            row.Add("10");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("3");
            row.Add(" ");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("4");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());


        }
        public void sub2no()
        {


            MainMem.ColumnCount = 3;
            MainMem.Columns[0].Name = "ADDRESS";
            MainMem.Columns[1].Name = "DATA";
            MainMem.Columns[2].Name = "MNEMONIC";


            ArrayList row = new ArrayList();
            row.Add("1");
            row.Add("0001 0101");
            row.Add("LOAD 5");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("2");
            row.Add("0011 0110");
            row.Add("SUB 6");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("3");
            row.Add("0110 1000");
            row.Add("STORE 8");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("4");
            row.Add("  ");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("5");
            row.Add("0101");
            row.Add("5");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("6");
            row.Add("0101");
            row.Add("5");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("7");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("8");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("9");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());


        }
        public void mul2no()
        {


            MainMem.ColumnCount = 3;
            MainMem.Columns[0].Name = "ADDRESS";
            MainMem.Columns[1].Name = "DATA";
            MainMem.Columns[2].Name = "MNEMONIC";


            ArrayList row = new ArrayList();
            row.Add("1");
            row.Add("0001 0100");
            row.Add("LOAD 5");


            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("2");
            row.Add("0001 0101");
            row.Add("MUL 6");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("3");
            row.Add("0001 0101");
            row.Add("STORE 7");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("4");
            row.Add("  ");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("5");
            row.Add("0011");
            row.Add("3");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("6");
            row.Add("0010");
            row.Add("2");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("7");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("8");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("9");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());


        }
        public void div2no()
        {


            MainMem.ColumnCount = 3;
            MainMem.Columns[0].Name = "ADDRESS";
            MainMem.Columns[1].Name = "DATA";
            MainMem.Columns[2].Name = "MNEMONIC";


            ArrayList row = new ArrayList();
            row.Add("1");
            row.Add("0001 0101");
            row.Add("LOAD 5");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("2");
            row.Add("1010 0110");
            row.Add("DIV 6");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("3");
            row.Add("0110 1000");
            row.Add("STORE 8");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("4");
            row.Add("  ");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("5");
            row.Add("0010");
            row.Add("2");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("6");
            row.Add("0100");
            row.Add("4");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("7");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("8");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("9");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());
        }
        public void Storev()
        {

            MainMem.ColumnCount = 3;
            MainMem.Columns[0].Name = "ADDRESS";
            MainMem.Columns[1].Name = "DATA";
            MainMem.Columns[1].Name = "MNEMONIC";

            ArrayList row = new ArrayList();
            row.Add("1 ");
            row.Add("0001 0010");
            row.Add("LOAD 3");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("2");
            row.Add("0110 0100");
            row.Add("10");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("3");
            row.Add("0110");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("4");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());


        }

        public void add3no()
        {


            MainMem.ColumnCount = 3;
            MainMem.Columns[0].Name = "ADDRESS";
            MainMem.Columns[1].Name = "DATA";
            MainMem.Columns[2].Name = "MNEMONIC";


            ArrayList row = new ArrayList();
            row.Add("1");
            row.Add("000001 00101");
            row.Add("LOAD 5");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("2");
            row.Add("000001 00110");
            row.Add("LOAD 6");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("3");
            row.Add("000111 00111");
            row.Add("ADD 7");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("4");
            row.Add("0000100 01001");
            row.Add("STORE 9");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("5");
            row.Add("01100");
            row.Add("12");
            MainMem.Rows.Add(row.ToArray());
            row = new ArrayList();
            row.Add("6");
            row.Add("01000");
            row.Add("8");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("7");
            row.Add("01010");
            row.Add("10");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("8");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("9");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());
        }
        public void sub3no()
        {


            MainMem.ColumnCount = 3;
            MainMem.Columns[0].Name = "ADDRESS";
            MainMem.Columns[1].Name = "DATA";
            MainMem.Columns[2].Name = "MNEMONIC";


            ArrayList row = new ArrayList();
            row.Add("1");
            row.Add("000001 00101");
            row.Add("LOAD 5");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("2");
            row.Add("000001 00110");
            row.Add("LOAD 6");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("3");
            row.Add("000111 00111");
            row.Add("SUB 7");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("4");
            row.Add("000100 01001");
            row.Add("STORE 9");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("5");
            row.Add("01100");
            row.Add("12");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("6");
            row.Add("01000");
            row.Add("8");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("7");
            row.Add("01010");
            row.Add("10");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("8");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("9");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());
        }
        public void mul3no()
        {


            MainMem.ColumnCount = 3;
            MainMem.Columns[0].Name = "ADDRESS";
            MainMem.Columns[1].Name = "DATA";
            MainMem.Columns[2].Name = "MNEMONIC";


            ArrayList row = new ArrayList();
            row.Add("1");
            row.Add("000001 00101");
            row.Add("LOAD 5");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("2");
            row.Add("000001 00110");
            row.Add("LOAD 6");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("3");
            row.Add("000111 00111");
            row.Add("MUL 7");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("4");
            row.Add("000100 01001");
            row.Add("STORE 9");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("5");
            row.Add("01100");
            row.Add("12");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("6");
            row.Add("01000");
            row.Add("8");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("7");
            row.Add("01010");
            row.Add("10");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("8");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("9");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());
        }
        public void div3no()
        {


            MainMem.ColumnCount = 3;
            MainMem.Columns[0].Name = "ADDRESS";
            MainMem.Columns[1].Name = "DATA";
            MainMem.Columns[2].Name = "MNEMONIC";


            ArrayList row = new ArrayList();
            row.Add("1");
            row.Add("000001 00101");
            row.Add("LOAD 5");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("2");
            row.Add("000001 00110");
            row.Add("LOAD 6");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("3");
            row.Add("000111 00111");
            row.Add("DIV 7");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("4");
            row.Add("000100 01001");
            row.Add("STORE 9");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("5");
            row.Add("01100");
            row.Add("12");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("6");
            row.Add("01000");
            row.Add("8");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("7");
            row.Add("01010");
            row.Add("10");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("8");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("9");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());
        }
        public void addv16()
        {

            MainMem.ColumnCount = 3;
            MainMem.Columns[0].Name = "ADDRESS";
            MainMem.Columns[1].Name = "DATA";
            MainMem.Columns[2].Name = "MNEMONIC";

            ArrayList row = new ArrayList();
            row.Add("0");
            row.Add("000001 00100");
            row.Add("LOAD 4");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1");
            row.Add("000010 00101");
            row.Add("ADD 5");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("2");
            row.Add("000110 00110");
            row.Add("STORE 6");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("3");
            row.Add("  ");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("4");
            row.Add("00100");
            row.Add("4");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("5");
            row.Add("01000");
            row.Add("8");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("6");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("7");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("8");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());


        }
        public void Loadv16()
        {
            for (int i = 0; i < MainMem.Rows.Count; i++)
            {

                MainMem.Rows[i].Cells[1].Value = txtal.Text;
                txtal.Clear();
                decoder.Rows.Clear();
                txtALU.Clear();


            }
            MainMem.ColumnCount = 3;
            MainMem.Columns[0].Name = "ADDRESS";
            MainMem.Columns[1].Name = "DATA";
            MainMem.Columns[1].Name = "MNEMONIC";

            ArrayList row = new ArrayList();
            row.Add("1 ");
            row.Add("000001 00010");
            row.Add("LOAD 2");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("2");
            row.Add("01010");
            row.Add("10");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("3");
            row.Add(" ");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("4");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());


        }
        public void subv16()
        {

            MainMem.ColumnCount = 3;
            MainMem.Columns[0].Name = "ADDRESS";
            MainMem.Columns[1].Name = "DATA";
            MainMem.Columns[2].Name = "MNEMONIC";

            ArrayList row = new ArrayList();
            row.Add("0");
            row.Add("000001 00100");
            row.Add("LOAD 4");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1");
            row.Add("000101 00101");
            row.Add("SUB 5");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("2");
            row.Add("000110 00110");
            row.Add("STORE 6");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("3");
            row.Add("  ");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("4");
            row.Add("00100");
            row.Add("4");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("5");
            row.Add("00100");
            row.Add("4");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("6");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("7");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("8");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());


        }
        public void divv16()
        {

            MainMem.ColumnCount = 3;
            MainMem.Columns[0].Name = "ADDRESS";
            MainMem.Columns[1].Name = "DATA";
            MainMem.Columns[2].Name = "MNEMONIC";

            ArrayList row = new ArrayList();
            row.Add("0");
            row.Add("000001 00100");
            row.Add("LOAD 4");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1");
            row.Add("001001 00101");
            row.Add("DIV 5");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("2");
            row.Add("000110 00110");
            row.Add("STORE 6");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("3");
            row.Add("  ");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("4");
            row.Add("00010");
            row.Add("2");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("5");
            row.Add("00100");
            row.Add("4");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("6");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("7");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("8");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());


        }
        public void mulv16()
        {

            MainMem.ColumnCount = 3;
            MainMem.Columns[0].Name = "ADDRESS";
            MainMem.Columns[1].Name = "DATA";
            MainMem.Columns[2].Name = "MNEMONIC";

            ArrayList row = new ArrayList();
            row.Add("0");
            row.Add("000001 00100");
            row.Add("LOAD 4");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1");
            row.Add("001000 00101");
            row.Add("MUL 5");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("2");
            row.Add("000110 00110");
            row.Add("STORE 6");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("3");
            row.Add("  ");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("4");
            row.Add("00100");
            row.Add("4");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("5");
            row.Add("00011");
            row.Add("3");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("6");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("7");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("8");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());


        }
        public void Storev16()
        {

            MainMem.ColumnCount = 3;
            MainMem.Columns[0].Name = "ADDRESS";
            MainMem.Columns[1].Name = "DATA";
            MainMem.Columns[1].Name = "MNEMONIC";

            ArrayList row = new ArrayList();
            row.Add("1 ");
            row.Add("000001 00010");
            row.Add("LOAD 3");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("2");
            row.Add("001011 00100");
            row.Add("STORE 4");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("3");
            row.Add("00110");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("4");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());


        }
        public void addv32()
        {

            MainMem.ColumnCount = 3;
            MainMem.Columns[0].Name = "ADDRESS";
            MainMem.Columns[1].Name = "DATA";
            MainMem.Columns[2].Name = "MNEMONIC";

            ArrayList row = new ArrayList();
            row.Add("0");
            row.Add("0000000000000001 00000100");
            row.Add("LOAD 4");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1");
            row.Add("0000000000000010 00000101");
            row.Add("ADD 5");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("2");
            row.Add("0000000000000110 00110");
            row.Add("STORE 6");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("3");
            row.Add("  ");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("4");
            row.Add("00100");
            row.Add("4");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("5");
            row.Add("01000");
            row.Add("8");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("6");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("7");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("8");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());


        }
        public void Loadv32()
        {
            for (int i = 0; i < MainMem.Rows.Count; i++)
            {

                MainMem.Rows[i].Cells[1].Value = txtal.Text;
                txtal.Clear();
                decoder.Rows.Clear();
                txtALU.Clear();


            }
            MainMem.ColumnCount = 3;
            MainMem.Columns[0].Name = "ADDRESS";
            MainMem.Columns[1].Name = "DATA";
            MainMem.Columns[1].Name = "MNEMONIC";

            ArrayList row = new ArrayList();
            row.Add("1 ");
            row.Add("000001 00010");
            row.Add("LOAD 2");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("2");
            row.Add("01010");
            row.Add("10");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("3");
            row.Add(" ");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("4");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());


        }
        public void subv32()
        {

            MainMem.ColumnCount = 3;
            MainMem.Columns[0].Name = "ADDRESS";
            MainMem.Columns[1].Name = "DATA";
            MainMem.Columns[2].Name = "MNEMONIC";

            ArrayList row = new ArrayList();
            row.Add("0");
            row.Add("0000000000000001 00000100");
            row.Add("LOAD 4");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1");
            row.Add("0000000000001101 00000101");
            row.Add("SUB 5");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("2");
            row.Add("0000000000000110 00110");
            row.Add("STORE 6");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("3");
            row.Add("  ");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("4");
            row.Add("00100");
            row.Add("4");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("5");
            row.Add("00100");
            row.Add("4");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("6");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("7");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("8");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());


        }
        public void divv32()
        {

            MainMem.ColumnCount = 3;
            MainMem.Columns[0].Name = "ADDRESS";
            MainMem.Columns[1].Name = "DATA";
            MainMem.Columns[2].Name = "MNEMONIC";

            ArrayList row = new ArrayList();
            row.Add("0");
            row.Add("0000000000000001 00100");
            row.Add("LOAD 4");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1");
            row.Add("0000000000001001 00101");
            row.Add("DIV 5");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("2");
            row.Add("0000000000000110 00110");
            row.Add("STORE 6");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("3");
            row.Add("  ");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("4");
            row.Add("00000010");
            row.Add("2");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("5");
            row.Add("00000100");
            row.Add("4");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("6");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("7");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("8");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());


        }
        public void mulv32()
        {
            MainMem.ColumnCount = 3;
            MainMem.Columns[0].Name = "ADDRESS";
            MainMem.Columns[1].Name = "DATA";
            MainMem.Columns[2].Name = "MNEMONIC";

            ArrayList row = new ArrayList();
            row.Add("0");
            row.Add("0000000000000001 00000100");
            row.Add("LOAD 4");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("1");
            row.Add("0000000000001111 00000101");
            row.Add("MUL 5");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("2");
            row.Add("0000000000000110 00110");
            row.Add("STORE 6");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("3");
            row.Add("  ");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("4");
            row.Add("00000100");
            row.Add("4");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("5");
            row.Add("00000011");
            row.Add("3");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("6");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("7");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("8");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());


        }
        public void Storev32()
        {

            MainMem.ColumnCount = 3;
            MainMem.Columns[0].Name = "ADDRESS";
            MainMem.Columns[1].Name = "DATA";
            MainMem.Columns[1].Name = "MNEMONIC";

            ArrayList row = new ArrayList();
            row.Add("1 ");
            row.Add("0000000000000001 00010");
            row.Add("LOAD 3");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("2");
            row.Add("0000000000000110 00100");
            row.Add("STORE 4");

            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("3");
            row.Add("00000110");
            MainMem.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("4");
            row.Add("");
            MainMem.Rows.Add(row.ToArray());


        }
        public void Dec8()
        {

            decoder.ColumnCount = 8;
            decoder.AutoResizeRows();
            decoder.AutoResizeColumns();

        }
        public void Dec16()
        {
            decoder.ColumnCount = 16;
            decoder.AutoResizeRows();
            decoder.AutoResizeColumns();
        }
        public void Dec32()
        {

            decoder.ColumnCount = 32;
            decoder.AutoResizeRows();
            decoder.AutoResizeColumns();

        }
        public void Dec64()
        {

            decoder.ColumnCount = 64;
            decoder.AutoResizeRows();
            decoder.AutoResizeColumns();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbmp.SelectedIndex == null)
            {


            }
            if (cbmp.SelectedIndex == 0)
            {
                Dec8();

            }
            else if (cbmp.SelectedIndex == 1)
            {
                Dec16();

            }
            else if (cbmp.SelectedIndex == 2)
            {
                Dec32();

            }
            else if (cbmp.SelectedIndex == 3)
            {
                Dec64();

            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)

        {
            decoder.AutoResizeColumns();


        }

        public void wait(int t)
        {
            Thread.Sleep(5000);//will sleep for 5 sec
        }
        Boolean flag = true;
        private void EXECUTE_Click(object sender, EventArgs e)
        {
            //wait(2000); //wait 2 second
            decoder.Rows.Clear();
            if (cbmp.SelectedItem == null)
            {
                string message = "Select Microprocessor";
                string title = "Select MP";
                MessageBox.Show(message, title);
            }
            if (cbi.SelectedItem == null)
            {
                string message = "Select Program";
                string title = "Select Program";
                MessageBox.Show(message, title);

            }



            //if (MainMem.Row[row]!=0)
            //{ 
            pc.BackColor = Color.Yellow;

            if (row < MainMem.Rows.Count - 1)
            {
                pc.Text = MainMem.Rows[row].Cells[column].Value.ToString();

            }

            //}
            //txtmdr.Text = MainMem.Rows[prow].Cells[column + 1].Value.ToString();
            //txtmdr.BackColor = Color.LightGreen;


            if (row != 0 && row < MainMem.Rows.Count - 1)
            {

                txtmar.Text = MainMem.Rows[prow].Cells[column].Value.ToString();
                MainMem.Rows[prow].Cells[column].Style.BackColor = Color.LightBlue;
                //pc.BackColor = Color.White;
                txtmar.BackColor = Color.LightBlue;

            }
            if (row != 0 && row < MainMem.Rows.Count - 1)
            {

                txtmdr.Text = MainMem.Rows[prow].Cells[column + 1].Value.ToString();
                MainMem.Rows[prow].Cells[column + 1].Style.BackColor = Color.LightGreen;
                txtmdr.BackColor = Color.LightGreen;
                pc.BackColor = Color.White;
                //txtmar.BackColor = Color.White;
                if (txtmdr == null)
                {
                    decoder.Rows.Clear();
                }

            }



            prow = row;
            row++;

            //if (MainMem.Rows[row].Cells[column].Value.ToString() == null)
            //{
            //    decoder.Rows.Clear();
            //    lblOPCODE.Hide();
            //    lblOPERAND.Hide();
            //}
            //if (MainMem.Rows[row].Cells[column].Value.ToString() != null)
            //{
            //}




            string tok = txtmdr.Text;
            String[] tokens = tok.Split(' ');

            //if (tokens[0].Equals("")) //no op
            //{
            //    decoder.Rows[0].Cells[0].Value = "0";
            //    decoder.Rows[0].Cells[1].Value = "0";
            //    decoder.Rows[0].Cells[2].Value = "0";
            //    decoder.Rows[0].Cells[3].Value = "0";


            //String value = tokens[1].ToString();
            //char[] tkvalue = value.ToCharArray();
            //    decoder.Rows[0].Cells[4].Value = tkvalue[0].ToString();
            //    decoder.Rows[0].Cells[5].Value = tkvalue[1].ToString();
            //    decoder.Rows[0].Cells[6].Value = tkvalue[2].ToString();
            //    decoder.Rows[0].Cells[7].Value = tkvalue[3].ToString();

            //    lblOPCODE.Show();
            //    lblOPERAND.Show();

            //    decoder.Rows[0].Cells[0].Style.BackColor = Color.Gold;
            //    decoder.Rows[0].Cells[1].Style.BackColor = Color.Gold;
            //    decoder.Rows[0].Cells[2].Style.BackColor = Color.Gold;
            //    decoder.Rows[0].Cells[3].Style.BackColor = Color.Gold;

            //    decoder.Rows[0].Cells[4].Style.BackColor = Color.Pink;
            //    decoder.Rows[0].Cells[5].Style.BackColor = Color.Pink;
            //    decoder.Rows[0].Cells[6].Style.BackColor = Color.Pink;
            //    decoder.Rows[0].Cells[7].Style.BackColor = Color.Pink;
            //    string sequenceb_addresss_bit = null;

            //    lblOPCODE.Show();
            //    lblOPERAND.Show();

            //    for (int i = 0; i < MainMem.Rows.Count; i++)
            //    {

            //        if (MainMem.Rows[i].Cells[0].Value.ToString() != null)
            //        {
            //            int address = int.Parse((string)MainMem.Rows[i].Cells[0].Value);
            //            char[] sequenceb_addresss_bit_arry = binaryToConverter(address);


            //            if (sequenceb_addresss_bit_arry.Length == 3)
            //            {
            //                sequenceb_addresss_bit = "0";
            //            }

            //            for (int d = 0; d < sequenceb_addresss_bit_arry.Length; d++)
            //            {


            //                sequenceb_addresss_bit = sequenceb_addresss_bit + sequenceb_addresss_bit_arry[d];

            //            }


            //            if (tokens[1].Equals(sequenceb_addresss_bit))
            //            {
            //                int decno = binaryToDecimal(int.Parse((string)MainMem.Rows[i].Cells[1].Value));

            //                txtal.Text = decno.ToString();
            //            }
            //            else
            //            {
            //                sequenceb_addresss_bit = null;
            //            }
            //        }


            //    }

            //    if (txtal.Text != null)
            //    {
            //        ALUvalues.Add(txtal.Text);
            //    }


            //}

            if (cbmp.SelectedIndex == 0)
            {
                if (tokens[0].Equals("0001")) //load
                {
                    decoder.Rows[0].Cells[0].Value = "0";
                    decoder.Rows[0].Cells[1].Value = "0";
                    decoder.Rows[0].Cells[2].Value = "0";
                    decoder.Rows[0].Cells[3].Value = "1";

                    String value = tokens[1].ToString();
                    char[] tkvalue = value.ToCharArray();
                    decoder.Rows[0].Cells[4].Value = tkvalue[0].ToString();
                    decoder.Rows[0].Cells[5].Value = tkvalue[1].ToString();
                    decoder.Rows[0].Cells[6].Value = tkvalue[2].ToString();
                    decoder.Rows[0].Cells[7].Value = tkvalue[3].ToString();


                    lblOPCODE.Show();
                    lblOPERAND.Show();

                    decoder.Rows[0].Cells[0].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[1].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[2].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[3].Style.BackColor = Color.Gold;

                    decoder.Rows[0].Cells[4].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[5].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[6].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[7].Style.BackColor = Color.Pink;
                    string sequenceb_addresss_bit = null;


                    for (int i = 0; i < MainMem.Rows.Count - 1; i++)
                    {



                        if (MainMem.Rows[i].Cells[0].Value.ToString() != null)
                        {
                            int address = int.Parse((string)MainMem.Rows[i].Cells[0].Value);
                            char[] sequenceb_addresss_bit_arry = binaryToConverter(address);


                            if (sequenceb_addresss_bit_arry.Length == 3)
                            {
                                sequenceb_addresss_bit = "0";
                            }

                            if (sequenceb_addresss_bit_arry.Length == 2)
                            {
                                sequenceb_addresss_bit = "00";
                            }
                            if (sequenceb_addresss_bit_arry.Length == 1)
                            {
                                sequenceb_addresss_bit = "000";
                            }

                            //if (sequenceb_addresss_bit_arry.Length < 4 && cbmp.SelectedIndex == 0)
                            //{
                            //    string message = "Can't adjust Bits, Select Large Microprocessor";
                            //    string title = "BITS are exceeded";
                            //    MessageBox.Show(message, title);
                            //    flag = false;
                            //}
                            for (int d = 0; d < sequenceb_addresss_bit_arry.Length; d++)
                            {


                                sequenceb_addresss_bit = sequenceb_addresss_bit + sequenceb_addresss_bit_arry[d];

                            }


                            if (tokens[1].Equals(sequenceb_addresss_bit))
                            {
                                int decno = binaryToDecimal(int.Parse((string)MainMem.Rows[i].Cells[1].Value));

                                txtal.Text = decno.ToString();
                                break;
                            }
                            else
                            {
                                sequenceb_addresss_bit = null;
                            }

                        }
                        if (MainMem.Rows[i].Cells[0].Value.ToString() == null)
                        {
                            MessageBox.Show("Memory End");
                        }
                    }


                    if (txtal.Text != null)
                    {
                        ALUvalues.Add(txtal.Text);
                    }


                }
                else if (tokens[0].Equals("0010"))//add2no
                {
                    decoder.Rows.Clear();
                    decoder.Rows[0].Cells[0].Value = "0";
                    decoder.Rows[0].Cells[1].Value = "0";
                    decoder.Rows[0].Cells[2].Value = "1";
                    decoder.Rows[0].Cells[3].Value = "0";

                    String value = tokens[1].ToString();
                    char[] tkvalue = value.ToCharArray();

                    decoder.Rows[0].Cells[4].Value = tkvalue[0].ToString();
                    decoder.Rows[0].Cells[5].Value = tkvalue[1].ToString();
                    decoder.Rows[0].Cells[6].Value = tkvalue[2].ToString();
                    decoder.Rows[0].Cells[7].Value = tkvalue[3].ToString();


                    lblOPCODE.Show();
                    lblOPERAND.Show();

                    decoder.Rows[0].Cells[0].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[1].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[2].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[3].Style.BackColor = Color.Gold;

                    decoder.Rows[0].Cells[4].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[5].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[6].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[7].Style.BackColor = Color.Pink;
                    string sequenceb_addresss_bit = null;
                    for (int i = 0; i < MainMem.Rows.Count - 1; i++)
                    {

                        if (MainMem.Rows[i].Cells[0].Value.ToString() != null)
                        {
                            int address = int.Parse((string)MainMem.Rows[i].Cells[0].Value);
                            char[] sequenceb_addresss_bit_arry = binaryToConverter(address);


                            if (sequenceb_addresss_bit_arry.Length == 3)
                            {
                                sequenceb_addresss_bit = "0";
                            }
                            if (sequenceb_addresss_bit_arry.Length == 2)
                            {
                                sequenceb_addresss_bit = "00";
                            }
                            if (sequenceb_addresss_bit_arry.Length == 1)
                            {
                                sequenceb_addresss_bit = "000";
                            }

                            for (int d = 0; d < sequenceb_addresss_bit_arry.Length; d++)
                            {


                                sequenceb_addresss_bit = sequenceb_addresss_bit + sequenceb_addresss_bit_arry[d];

                            }


                            if (tokens[1].Equals(sequenceb_addresss_bit))
                            {
                                int decno = binaryToDecimal(int.Parse((string)MainMem.Rows[i].Cells[1].Value));

                                txtal.Text = decno.ToString();
                                break;
                            }
                            else
                            {
                                sequenceb_addresss_bit = null;
                            }
                        }


                    }

                    if (txtal.Text != null)
                    {
                        ALUvalues.Add(txtal.Text);
                    }


                    for (int i = 0; i < ALUvalues.Count; i++)
                    {
                        txtALU.Text = ALUvalues[i] + "\n" + txtALU.Text;

                    }
                    ALU add = new ALU();

                    String[] addvalue = txtALU.Text.Split("\n");

                    int cno = 0;

                    for (int c = 0; c < addvalue.Length; c++)
                    {
                        if (addvalue[c] != "")
                        {
                            cno++;
                        }
                    }

                    if (cno == 2)
                    {
                        int v = add.add2value(int.Parse(addvalue[0]), int.Parse(addvalue[1]));
                        txtal.Text = v.ToString();
                    }
                    if (txtal.Text == "0")
                    {
                        ZEROtxt.BackColor = Color.Green;
                        ZEROtxt.Text = "1";
                    }
                    if (txtal.Text == "0")
                    {
                        ZEROtxt.BackColor = Color.Green;
                        ZEROtxt.Text = "1";
                    }
                    if (txtal.Text != "0")
                    {

                        NEGATIVEtxt.Text = "0";
                        ZEROtxt.Text = "0";
                        CARRYtxt.Text = "0";
                        OVERFLOWtxt.Text = "0";

                        ZEROtxt.BackColor = Color.Red;
                        NEGATIVEtxt.BackColor = Color.Red;
                        CARRYtxt.BackColor = Color.Red;
                        OVERFLOWtxt.BackColor = Color.Red;
                    }


                }
                //----------------STORE VALUES---

                else if (tokens[0].Equals("0110"))
                {
                    decoder.Rows[0].Cells[0].Value = "0";
                    decoder.Rows[0].Cells[1].Value = "1";
                    decoder.Rows[0].Cells[2].Value = "1";
                    decoder.Rows[0].Cells[3].Value = "0";
                    String value = tokens[1].ToString();
                    char[] tkvalue = value.ToCharArray();
                    decoder.Rows[0].Cells[4].Value = tkvalue[0].ToString();
                    decoder.Rows[0].Cells[5].Value = tkvalue[1].ToString();
                    decoder.Rows[0].Cells[6].Value = tkvalue[2].ToString();
                    decoder.Rows[0].Cells[7].Value = tkvalue[3].ToString();


                    decoder.Rows[0].Cells[0].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[1].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[2].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[3].Style.BackColor = Color.Gold;

                    decoder.Rows[0].Cells[4].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[5].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[6].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[7].Style.BackColor = Color.Pink;
                    string sequenceb_addresss_bit = null;



                    for (int i = 0; i < MainMem.Rows.Count - 1; i++)

                    {

                        if (MainMem.Rows[i].Cells[0].Value.ToString() != null)
                        {
                            int address = int.Parse((string)MainMem.Rows[i].Cells[0].Value);
                            char[] sequenceb_addresss_bit_arry = binaryToConverter(address);


                            if (sequenceb_addresss_bit_arry.Length == 3)
                            {
                                sequenceb_addresss_bit = "0";
                            }

                            if (sequenceb_addresss_bit_arry.Length == 2)
                            {
                                sequenceb_addresss_bit = "00";
                            }
                            if (sequenceb_addresss_bit_arry.Length == 1)
                            {
                                sequenceb_addresss_bit = "000";


                            }




                            //if (sequenceb_addresss_bit_arry.Length < 4 && cbmp.SelectedIndex == 0)
                            //{
                            //    string message = "Can't adjust Bits, Select Large Microprocessor";
                            //    string title = "BITS are exceeded";
                            //    MessageBox.Show(message, title);
                            //    flag = false;
                            //}
                            for (int d = 0; d < sequenceb_addresss_bit_arry.Length; d++)
                            {


                                sequenceb_addresss_bit = sequenceb_addresss_bit + sequenceb_addresss_bit_arry[d];

                            }


                            if (tokens[1].Equals(sequenceb_addresss_bit))
                            {
                                //int decno = binaryToDecimal(int.Parse((string)MainMem.Rows[i].Cells[1].Value));

                                //int addmainmemory = binaryToDecimal(int.Parse(tokens[1]));
                                char[] bits_add = binaryToConverter(int.Parse(txtal.Text));
                                string bits_adds = null;


                                if (bits_add.Length == 3)
                                {
                                    bits_adds = "0";
                                }

                                if (bits_add.Length == 2)
                                {
                                    bits_adds = "00";
                                }
                                if (bits_add.Length == 1)
                                {
                                    bits_adds = "000";


                                }
                                for (int c = 0; c < bits_add.Length; c++)
                                {


                                    bits_adds = bits_adds + bits_add[c];

                                }


                                MainMem.Rows[i].Cells[1].Value = bits_adds;
                                MainMem.Rows[i].Cells[1].Style.BackColor = Color.Aqua;
                                //  MainMem.Rows[i].Cells[1].Value = txtal.Text;
                            }
                            else
                            {
                                sequenceb_addresss_bit = null;
                            }
                        }


                    }

                    if (txtal.Text != null)
                    {
                        ALUvalues.Add(txtal.Text);
                    }

                }

                //if (tokens[0].Equals("STORE"))
                //{
                //    decoder.Rows[0].Cells[0].Value = "1";
                //    decoder.Rows[0].Cells[1].Value = "0";
                //    decoder.Rows[0].Cells[2].Value = "1";
                //    decoder.Rows[0].Cells[3].Value = "1";
                //    int value = int.Parse(tokens[1].ToString());
                //    char[] tkvalue = binaryToConverter(value);
                //    decoder.Rows[0].Cells[4].Value = tkvalue[0].ToString();
                //    decoder.Rows[0].Cells[5].Value = tkvalue[1].ToString();
                //    decoder.Rows[0].Cells[6].Value = tkvalue[2].ToString();
                //    decoder.Rows[0].Cells[7].Value = tkvalue[3].ToString();


                //    for (int i = 0; i < MainMem.Rows.Count; i++)
                //    {
                //        if (tokens[1].Equals(MainMem.Rows[i].Cells[0].Value))
                //        {

                //            txtal.Text = MainMem.Rows[i].Cells[1].Value.ToString();
                //        }
                //    }
                //    ALUvalues.Add(txtal.Text);

                //}
                else if (tokens[0].Equals("0011")) //sub2no
                {
                    decoder.Rows.Clear();
                    decoder.Rows[0].Cells[0].Value = "0";
                    decoder.Rows[0].Cells[1].Value = "0";
                    decoder.Rows[0].Cells[2].Value = "1";
                    decoder.Rows[0].Cells[3].Value = "1";

                    String value = tokens[1].ToString();
                    char[] tkvalue = value.ToCharArray();
                    decoder.Rows[0].Cells[4].Value = tkvalue[0].ToString();
                    decoder.Rows[0].Cells[5].Value = tkvalue[1].ToString();
                    decoder.Rows[0].Cells[6].Value = tkvalue[2].ToString();
                    decoder.Rows[0].Cells[7].Value = tkvalue[3].ToString();


                    decoder.Rows[0].Cells[0].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[1].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[2].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[3].Style.BackColor = Color.Gold;

                    decoder.Rows[0].Cells[4].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[5].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[6].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[7].Style.BackColor = Color.Pink;
                    string sequenceb_addresss_bit = null;
                    for (int i = 0; i < MainMem.Rows.Count - 1; i++)
                    {

                        if (MainMem.Rows[i].Cells[0].Value.ToString() != null)
                        {
                            int address = int.Parse((string)MainMem.Rows[i].Cells[0].Value);
                            char[] sequenceb_addresss_bit_arry = binaryToConverter(address);


                            if (sequenceb_addresss_bit_arry.Length == 3)
                            {
                                sequenceb_addresss_bit = "0";
                            }
                            if (sequenceb_addresss_bit_arry.Length == 2)
                            {
                                sequenceb_addresss_bit = "00";
                            }
                            if (sequenceb_addresss_bit_arry.Length == 1)
                            {
                                sequenceb_addresss_bit = "000";
                            }

                            for (int d = 0; d < sequenceb_addresss_bit_arry.Length; d++)
                            {


                                sequenceb_addresss_bit = sequenceb_addresss_bit + sequenceb_addresss_bit_arry[d];

                            }


                            if (tokens[1].Equals(sequenceb_addresss_bit))
                            {
                                int decno = binaryToDecimal(int.Parse((string)MainMem.Rows[i].Cells[1].Value));

                                txtal.Text = decno.ToString();
                            }
                            else
                            {
                                sequenceb_addresss_bit = null;
                            }
                        }


                    }

                    if (txtal.Text != null)
                    {
                        ALUvalues.Add(txtal.Text);
                    }


                    for (int i = 0; i < ALUvalues.Count; i++)
                    {
                        txtALU.Text = ALUvalues[i] + "\n" + txtALU.Text;

                    }
                    ALU add = new ALU();

                    String[] addvalue = txtALU.Text.Split("\n");

                    int cno = 0;

                    for (int c = 0; c < addvalue.Length; c++)
                    {
                        if (addvalue[c] != "")
                        {
                            cno++;
                        }
                    }

                    if (cno == 2)
                    {
                        int v = add.sub2value(int.Parse(addvalue[0]), int.Parse(addvalue[1]));
                        txtal.Text = v.ToString();
                    }
                    if (txtal.Text == "0")
                    {
                        ZEROtxt.BackColor = Color.LightGreen;
                        ZEROtxt.Text = "1";


                        NEGATIVEtxt.Text = "0";
                        CARRYtxt.Text = "0";
                        OVERFLOWtxt.Text = "0";

                        NEGATIVEtxt.BackColor = Color.Red;
                        CARRYtxt.BackColor = Color.Red;
                        OVERFLOWtxt.BackColor = Color.Red;
                    }
                }

                else if (tokens[0].Equals("1001"))//mul
                {
                    decoder.Rows.Clear();
                    decoder.Rows[0].Cells[0].Value = "1";
                    decoder.Rows[0].Cells[1].Value = "0";
                    decoder.Rows[0].Cells[2].Value = "0";
                    decoder.Rows[0].Cells[3].Value = "1";

                    String value = tokens[1].ToString();
                    char[] tkvalue = value.ToCharArray();
                    decoder.Rows[0].Cells[4].Value = tkvalue[0].ToString();
                    decoder.Rows[0].Cells[5].Value = tkvalue[1].ToString();
                    decoder.Rows[0].Cells[6].Value = tkvalue[2].ToString();
                    decoder.Rows[0].Cells[7].Value = tkvalue[3].ToString();


                    decoder.Rows[0].Cells[0].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[1].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[2].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[3].Style.BackColor = Color.Gold;

                    decoder.Rows[0].Cells[4].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[5].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[6].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[7].Style.BackColor = Color.Pink;
                    string sequenceb_addresss_bit = null;
                    for (int i = 0; i < MainMem.Rows.Count - 1; i++)
                    {

                        if (MainMem.Rows[i].Cells[0].Value.ToString() != null)
                        {
                            int address = int.Parse((string)MainMem.Rows[i].Cells[0].Value);
                            char[] sequenceb_addresss_bit_arry = binaryToConverter(address);


                            if (sequenceb_addresss_bit_arry.Length == 3)
                            {
                                sequenceb_addresss_bit = "0";
                            }
                            if (sequenceb_addresss_bit_arry.Length == 2)
                            {
                                sequenceb_addresss_bit = "00";
                            }
                            if (sequenceb_addresss_bit_arry.Length == 1)
                            {
                                sequenceb_addresss_bit = "000";
                            }

                            for (int d = 0; d < sequenceb_addresss_bit_arry.Length; d++)
                            {


                                sequenceb_addresss_bit = sequenceb_addresss_bit + sequenceb_addresss_bit_arry[d];

                            }


                            if (tokens[1].Equals(sequenceb_addresss_bit))
                            {
                                int decno = binaryToDecimal(int.Parse((string)MainMem.Rows[i].Cells[1].Value));

                                txtal.Text = decno.ToString();
                            }
                            else
                            {
                                sequenceb_addresss_bit = null;
                            }
                        }


                    }

                    if (txtal.Text != null)
                    {
                        ALUvalues.Add(txtal.Text);
                    }


                    for (int i = 0; i < ALUvalues.Count; i++)
                    {
                        txtALU.Text = ALUvalues[i] + "\n" + txtALU.Text;

                    }
                    ALU add = new ALU();

                    String[] addvalue = txtALU.Text.Split("\n");

                    int cno = 0;

                    for (int c = 0; c < addvalue.Length; c++)
                    {
                        if (addvalue[c] != "")
                        {
                            cno++;
                        }
                    }

                    if (cno == 2)
                    {
                        int v = add.mul2value(int.Parse(addvalue[0]), int.Parse(addvalue[1]));
                        txtal.Text = v.ToString();
                    }
                    if (txtal.Text == "0")
                    {
                        ZEROtxt.BackColor = Color.Green;
                        ZEROtxt.Text = "1";
                        NEGATIVEtxt.Text = "0";
                        CARRYtxt.Text = "0";
                        OVERFLOWtxt.Text = "0";
                        NEGATIVEtxt.BackColor = Color.Red;
                        CARRYtxt.BackColor = Color.Red;
                        OVERFLOWtxt.BackColor = Color.Red;

                    }
                }
                else if (tokens[0].Equals("1010"))//div
                {
                    decoder.Rows.Clear();
                    decoder.Rows[0].Cells[0].Value = "1";
                    decoder.Rows[0].Cells[1].Value = "0";
                    decoder.Rows[0].Cells[2].Value = "1";
                    decoder.Rows[0].Cells[3].Value = "0";

                    String value = tokens[1].ToString();
                    char[] tkvalue = value.ToCharArray();
                    decoder.Rows[0].Cells[4].Value = tkvalue[0].ToString();
                    decoder.Rows[0].Cells[5].Value = tkvalue[1].ToString();
                    decoder.Rows[0].Cells[6].Value = tkvalue[2].ToString();
                    decoder.Rows[0].Cells[7].Value = tkvalue[3].ToString();


                    decoder.Rows[0].Cells[0].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[1].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[2].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[3].Style.BackColor = Color.Gold;

                    decoder.Rows[0].Cells[4].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[5].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[6].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[7].Style.BackColor = Color.Pink;

                    string sequenceb_addresss_bit = null;
                    for (int i = 0; i < MainMem.Rows.Count - 1; i++)
                    {

                        if (MainMem.Rows[i].Cells[0].Value.ToString() != null)
                        {
                            int address = int.Parse((string)MainMem.Rows[i].Cells[0].Value);
                            char[] sequenceb_addresss_bit_arry = binaryToConverter(address);


                            if (sequenceb_addresss_bit_arry.Length == 3)
                            {
                                sequenceb_addresss_bit = "0";
                            }
                            if (sequenceb_addresss_bit_arry.Length == 2)
                            {
                                sequenceb_addresss_bit = "00";
                            }
                            if (sequenceb_addresss_bit_arry.Length == 1)
                            {
                                sequenceb_addresss_bit = "000";
                            }

                            for (int d = 0; d < sequenceb_addresss_bit_arry.Length; d++)
                            {
                                sequenceb_addresss_bit = sequenceb_addresss_bit + sequenceb_addresss_bit_arry[d];
                            }


                            if (tokens[1].Equals(sequenceb_addresss_bit))
                            {
                                int decno = binaryToDecimal(int.Parse((string)MainMem.Rows[i].Cells[1].Value));

                                txtal.Text = decno.ToString();
                            }
                            else
                            {
                                sequenceb_addresss_bit = null;
                            }
                        }


                    }

                    if (txtal.Text != null)
                    {
                        ALUvalues.Add(txtal.Text);
                    }


                    for (int i = 0; i < ALUvalues.Count; i++)
                    {
                        txtALU.Text = ALUvalues[i] + "\n" + txtALU.Text;

                    }
                    ALU add = new ALU();

                    String[] addvalue = txtALU.Text.Split("\n");

                    int cno = 0;

                    for (int c = 0; c < addvalue.Length; c++)
                    {
                        if (addvalue[c] != "")
                        {
                            cno++;
                        }
                    }

                    if (cno == 2)
                    {
                        int v = add.div2value(int.Parse(addvalue[0]), int.Parse(addvalue[1]));
                        txtal.Text = v.ToString();
                    }
                    if (txtal.Text == "0")
                    {
                        ZEROtxt.BackColor = Color.Green;
                        ZEROtxt.Text = "1";
                    }
                    if (txtal.Text != "0")
                    {

                        NEGATIVEtxt.Text = "0";
                        ZEROtxt.Text = "0";
                        CARRYtxt.Text = "0";
                        OVERFLOWtxt.Text = "0";

                        ZEROtxt.BackColor = Color.Red;
                        NEGATIVEtxt.BackColor = Color.Red;
                        CARRYtxt.BackColor = Color.Red;
                        OVERFLOWtxt.BackColor = Color.Red;
                    }
                }
            }

            //----------------------------------------------------16 bit SAIII WALA--------------------------------------------------

            if (cbmp.SelectedIndex == 1)

            {
                string tok1 = txtmdr.Text;
                String[] tokens1 = tok.Split(' ');

                if (tokens[0].Equals("000001")) //load
                {
                    decoder.Rows[0].Cells[0].Value = "0";
                    decoder.Rows[0].Cells[1].Value = "0";
                    decoder.Rows[0].Cells[2].Value = "0";
                    decoder.Rows[0].Cells[3].Value = "0";
                    decoder.Rows[0].Cells[4].Value = "0";
                    decoder.Rows[0].Cells[5].Value = "1";

                    String value = tokens1[1].ToString();
                    char[] tkvalue = value.ToCharArray();
                    decoder.Rows[0].Cells[6].Value = tkvalue[0].ToString();
                    decoder.Rows[0].Cells[7].Value = tkvalue[1].ToString();
                    decoder.Rows[0].Cells[8].Value = tkvalue[2].ToString();
                    decoder.Rows[0].Cells[9].Value = tkvalue[3].ToString();
                    decoder.Rows[0].Cells[10].Value = tkvalue[4].ToString();

                    decoder.Rows[0].Cells[11].Value = "0";
                    decoder.Rows[0].Cells[12].Value = "0";
                    decoder.Rows[0].Cells[13].Value = "0";
                    decoder.Rows[0].Cells[14].Value = "0";
                    decoder.Rows[0].Cells[15].Value = "0";


                    lblOPCODE.Show();
                    lblOPERAND.Show();
                    LBLOP2.Show();

                    decoder.Rows[0].Cells[0].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[1].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[2].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[3].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[4].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[5].Style.BackColor = Color.Gold;

                    decoder.Rows[0].Cells[6].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[7].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[8].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[9].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[10].Style.BackColor = Color.Pink;


                    decoder.Rows[0].Cells[11].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[12].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[13].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[14].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[15].Style.BackColor = Color.Brown;
                    string sequenceb_addresss_bit = null;


                    for (int i = 0; i < MainMem.Rows.Count - 1; i++)
                    {



                        if (MainMem.Rows[i].Cells[0].Value.ToString() != null)
                        {
                            int address = int.Parse((string)MainMem.Rows[i].Cells[0].Value);
                            char[] sequenceb_addresss_bit_arry = binaryToConverter(address);



                            if (sequenceb_addresss_bit_arry.Length == 3)
                            {
                                sequenceb_addresss_bit = "00";
                            }

                            else if (sequenceb_addresss_bit_arry.Length == 2)
                            {
                                sequenceb_addresss_bit = "000";
                            }
                            if (sequenceb_addresss_bit_arry.Length == 1)
                            {
                                sequenceb_addresss_bit = "0000";
                            }

                            //if (sequenceb_addresss_bit_arry.Length < 4 && cbmp.SelectedIndex == 0)
                            //{
                            //    string message = "Can't adjust Bits, Select Large Microprocessor";
                            //    string title = "BITS are exceeded";
                            //    MessageBox.Show(message, title);
                            //    flag = false;
                            //}
                            for (int d = 0; d < sequenceb_addresss_bit_arry.Length; d++)
                            {


                                sequenceb_addresss_bit = sequenceb_addresss_bit + sequenceb_addresss_bit_arry[d];

                            }


                            if (tokens[1].Equals(sequenceb_addresss_bit))
                            {
                                int decno = binaryToDecimal(int.Parse((string)MainMem.Rows[i].Cells[1].Value));

                                txtal.Text = decno.ToString();
                                break;
                            }
                            else
                            {
                                sequenceb_addresss_bit = null;
                            }

                        }
                        if (MainMem.Rows[i].Cells[0].Value.ToString() == null)
                        {
                            MessageBox.Show("Memory End");
                        }
                    }


                    if (txtal.Text != null)
                    {
                        ALUvalues.Add(txtal.Text);
                    }


                }
                else if (tokens[0].Equals("000010"))//add2no
                {
                    decoder.Rows.Clear();
                    decoder.Rows[0].Cells[0].Value = "0";
                    decoder.Rows[0].Cells[1].Value = "0";
                    decoder.Rows[0].Cells[2].Value = "0";
                    decoder.Rows[0].Cells[3].Value = "0";
                    decoder.Rows[0].Cells[4].Value = "1";
                    decoder.Rows[0].Cells[5].Value = "0";
                    String value = tokens[1].ToString();
                    char[] tkvalue = value.ToCharArray();
                    decoder.Rows[0].Cells[6].Value = tkvalue[0].ToString();
                    decoder.Rows[0].Cells[7].Value = tkvalue[1].ToString();
                    decoder.Rows[0].Cells[8].Value = tkvalue[2].ToString();
                    decoder.Rows[0].Cells[9].Value = tkvalue[3].ToString();
                    decoder.Rows[0].Cells[10].Value = tkvalue[4].ToString();

                    //String value2 = tokens[2].ToString();
                    //char[] tkvalue2 = value.ToCharArray();
                    decoder.Rows[0].Cells[11].Value = "0";
                    decoder.Rows[0].Cells[12].Value = "0";
                    decoder.Rows[0].Cells[13].Value = "0";
                    decoder.Rows[0].Cells[14].Value = "0";
                    decoder.Rows[0].Cells[15].Value = "0";


                    lblOPCODE.Show();
                    lblOPERAND.Show();
                    LBLOP2.Show();

                    decoder.Rows[0].Cells[0].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[1].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[2].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[3].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[4].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[5].Style.BackColor = Color.Gold;

                    decoder.Rows[0].Cells[6].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[7].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[8].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[9].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[10].Style.BackColor = Color.Pink;


                    decoder.Rows[0].Cells[11].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[12].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[13].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[14].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[15].Style.BackColor = Color.Brown;
                    string sequenceb_addresss_bit = null;
                    for (int i = 0; i < MainMem.Rows.Count - 1; i++)
                    {

                        if (MainMem.Rows[i].Cells[0].Value.ToString() != null)
                        {
                            int address = int.Parse((string)MainMem.Rows[i].Cells[0].Value);
                            char[] sequenceb_addresss_bit_arry = binaryToConverter(address);



                            if (sequenceb_addresss_bit_arry.Length == 3)
                            {
                                sequenceb_addresss_bit = "00";
                            }

                            if (sequenceb_addresss_bit_arry.Length == 2)
                            {
                                sequenceb_addresss_bit = "000";
                            }
                            if (sequenceb_addresss_bit_arry.Length == 1)
                            {
                                sequenceb_addresss_bit = "0000";
                            }

                            for (int d = 0; d < sequenceb_addresss_bit_arry.Length; d++)
                            {


                                sequenceb_addresss_bit = sequenceb_addresss_bit + sequenceb_addresss_bit_arry[d];

                            }


                            if (tokens[1].Equals(sequenceb_addresss_bit))
                            {
                                int decno = binaryToDecimal(int.Parse((string)MainMem.Rows[i].Cells[1].Value));

                                txtal.Text = decno.ToString();
                                break;
                            }
                            else
                            {
                                sequenceb_addresss_bit = null;
                            }
                        }


                    }

                    if (txtal.Text != null)
                    {
                        ALUvalues.Add(txtal.Text);
                    }


                    for (int i = 0; i < ALUvalues.Count; i++)
                    {
                        txtALU.Text = ALUvalues[i] + "\n" + txtALU.Text;

                    }
                    ALU add = new ALU();

                    String[] addvalue = txtALU.Text.Split("\n");

                    int cno = 0;

                    for (int c = 0; c < addvalue.Length; c++)
                    {
                        if (addvalue[c] != "")
                        {
                            cno++;
                        }
                    }

                    if (cno == 2)
                    {
                        int v = add.add2value(int.Parse(addvalue[0]), int.Parse(addvalue[1]));
                        txtal.Text = v.ToString();
                    }
                    if (txtal.Text == "0")
                    {
                        ZEROtxt.BackColor = Color.Green;
                        ZEROtxt.Text = "1";
                    }
                    if (txtal.Text == "0")
                    {
                        ZEROtxt.BackColor = Color.Green;
                        ZEROtxt.Text = "1";
                    }
                    if (txtal.Text != "0")
                    {

                        NEGATIVEtxt.Text = "0";
                        ZEROtxt.Text = "0";
                        CARRYtxt.Text = "0";
                        OVERFLOWtxt.Text = "0";

                        ZEROtxt.BackColor = Color.Red;
                        NEGATIVEtxt.BackColor = Color.Red;
                        CARRYtxt.BackColor = Color.Red;
                        OVERFLOWtxt.BackColor = Color.Red;
                    }
                }

                else if (tokens[0].Equals("000110"))//store
                {
                    decoder.Rows[0].Cells[0].Value = "0";
                    decoder.Rows[0].Cells[1].Value = "0";
                    decoder.Rows[0].Cells[2].Value = "0";
                    decoder.Rows[0].Cells[3].Value = "1";
                    decoder.Rows[0].Cells[4].Value = "1";
                    decoder.Rows[0].Cells[5].Value = "0";
                    String value = tokens[1].ToString();
                    char[] tkvalue = value.ToCharArray();
                    decoder.Rows[0].Cells[6].Value = tkvalue[0].ToString();
                    decoder.Rows[0].Cells[7].Value = tkvalue[1].ToString();
                    decoder.Rows[0].Cells[8].Value = tkvalue[2].ToString();
                    decoder.Rows[0].Cells[9].Value = tkvalue[3].ToString();
                    decoder.Rows[0].Cells[10].Value = tkvalue[4].ToString();

                    decoder.Rows[0].Cells[11].Value = "0";
                    decoder.Rows[0].Cells[12].Value = "0";
                    decoder.Rows[0].Cells[13].Value = "0";
                    decoder.Rows[0].Cells[14].Value = "0";
                    decoder.Rows[0].Cells[15].Value = "0";


                    decoder.Rows[0].Cells[0].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[1].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[2].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[3].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[4].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[5].Style.BackColor = Color.Gold;

                    decoder.Rows[0].Cells[6].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[7].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[8].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[9].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[10].Style.BackColor = Color.Pink;

                    decoder.Rows[0].Cells[11].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[12].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[13].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[14].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[15].Style.BackColor = Color.Brown;
                    string sequenceb_addresss_bit = null;

                    for (int i = 0; i < MainMem.Rows.Count - 1; i++)

                    {

                        if (MainMem.Rows[i].Cells[0].Value.ToString() != null)
                        {
                            int address = int.Parse((string)MainMem.Rows[i].Cells[0].Value);
                            char[] sequenceb_addresss_bit_arry = binaryToConverter(address);


                            if (sequenceb_addresss_bit_arry.Length == 3)
                            {
                                sequenceb_addresss_bit = "00";
                            }

                            if (sequenceb_addresss_bit_arry.Length == 2)
                            {
                                sequenceb_addresss_bit = "000";
                            }
                            if (sequenceb_addresss_bit_arry.Length == 1)
                            {
                                sequenceb_addresss_bit = "0000";
                            }




                            //if (sequenceb_addresss_bit_arry.Length < 4 && cbmp.SelectedIndex == 0)
                            //{
                            //    string message = "Can't adjust Bits, Select Large Microprocessor";
                            //    string title = "BITS are exceeded";
                            //    MessageBox.Show(message, title);
                            //    flag = false;
                            //}
                            for (int d = 0; d < sequenceb_addresss_bit_arry.Length; d++)
                            {


                                sequenceb_addresss_bit = sequenceb_addresss_bit + sequenceb_addresss_bit_arry[d];

                            }


                            if (tokens[1].Equals(sequenceb_addresss_bit))
                            {
                                //int decno = binaryToDecimal(int.Parse((string)MainMem.Rows[i].Cells[1].Value));

                                //int addmainmemory = binaryToDecimal(int.Parse(tokens[1]));
#pragma warning disable CS8604 // Possible null reference argument.
                                char[] bits_add = binaryToConverter(int.Parse(txtal.Text));
#pragma warning restore CS8604 // Possible null reference argument.
                                string bits_adds = null;


                                if (bits_add.Length == 3)
                                {
                                    bits_adds = "0";
                                }

                                if (bits_add.Length == 2)
                                {
                                    bits_adds = "00";
                                }
                                if (bits_add.Length == 1)
                                {
                                    bits_adds = "000";


                                }
                                for (int c = 0; c < bits_add.Length; c++)
                                {


                                    bits_adds = bits_adds + bits_add[c];

                                }


                                MainMem.Rows[i].Cells[1].Value = bits_adds;
                                MainMem.Rows[i].Cells[1].Style.BackColor = Color.Aqua;
                                //  MainMem.Rows[i].Cells[1].Value = txtal.Text;
                            }
                            else
                            {
                                sequenceb_addresss_bit = null;
                            }
                        }


                    }

                    if (txtal.Text != null)
                    {
                        ALUvalues.Add(txtal.Text);
                    }

                }


                else if (tokens[0].Equals("000101"))//sub2no
                {
                    decoder.Rows.Clear();
                    decoder.Rows[0].Cells[0].Value = "0";
                    decoder.Rows[0].Cells[1].Value = "0";
                    decoder.Rows[0].Cells[2].Value = "0";
                    decoder.Rows[0].Cells[3].Value = "1";
                    decoder.Rows[0].Cells[4].Value = "0";
                    decoder.Rows[0].Cells[5].Value = "1";
                    String value = tokens[1].ToString();
                    char[] tkvalue = value.ToCharArray();
                    decoder.Rows[0].Cells[6].Value = tkvalue[0].ToString();
                    decoder.Rows[0].Cells[7].Value = tkvalue[1].ToString();
                    decoder.Rows[0].Cells[8].Value = tkvalue[2].ToString();
                    decoder.Rows[0].Cells[9].Value = tkvalue[3].ToString();
                    decoder.Rows[0].Cells[10].Value = tkvalue[4].ToString();

                    //String value2 = tokens[2].ToString();
                    //char[] tkvalue2 = value.ToCharArray();
                    decoder.Rows[0].Cells[11].Value = "0";
                    decoder.Rows[0].Cells[12].Value = "0";
                    decoder.Rows[0].Cells[13].Value = "0";
                    decoder.Rows[0].Cells[14].Value = "0";
                    decoder.Rows[0].Cells[15].Value = "0";


                    lblOPCODE.Show();
                    lblOPERAND.Show();
                    LBLOP2.Show();

                    decoder.Rows[0].Cells[0].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[1].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[2].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[3].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[4].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[5].Style.BackColor = Color.Gold;

                    decoder.Rows[0].Cells[6].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[7].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[8].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[9].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[10].Style.BackColor = Color.Pink;


                    decoder.Rows[0].Cells[11].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[12].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[13].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[14].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[15].Style.BackColor = Color.Brown;
                    string sequenceb_addresss_bit = null;
                    for (int i = 0; i < MainMem.Rows.Count - 1; i++)
                    {

                        if (MainMem.Rows[i].Cells[0].Value.ToString() != null)
                        {
                            int address = int.Parse((string)MainMem.Rows[i].Cells[0].Value);
                            char[] sequenceb_addresss_bit_arry = binaryToConverter(address);




                            if (sequenceb_addresss_bit_arry.Length == 3)
                            {
                                sequenceb_addresss_bit = "00";
                            }

                            if (sequenceb_addresss_bit_arry.Length == 2)
                            {
                                sequenceb_addresss_bit = "000";
                            }
                            if (sequenceb_addresss_bit_arry.Length == 1)
                            {
                                sequenceb_addresss_bit = "0000";
                            }

                            for (int d = 0; d < sequenceb_addresss_bit_arry.Length; d++)
                            {


                                sequenceb_addresss_bit = sequenceb_addresss_bit + sequenceb_addresss_bit_arry[d];

                            }


                            if (tokens[1].Equals(sequenceb_addresss_bit))
                            {
                                int decno = binaryToDecimal(int.Parse((string)MainMem.Rows[i].Cells[1].Value));

                                txtal.Text = decno.ToString();
                                break;
                            }
                            else
                            {
                                sequenceb_addresss_bit = null;
                            }
                        }


                    }

                    if (txtal.Text != null)
                    {
                        ALUvalues.Add(txtal.Text);
                    }


                    for (int i = 0; i < ALUvalues.Count; i++)
                    {
                        txtALU.Text = ALUvalues[i] + "\n" + txtALU.Text;

                    }
                    ALU add = new ALU();

                    String[] addvalue = txtALU.Text.Split("\n");

                    int cno = 0;

                    for (int c = 0; c < addvalue.Length; c++)
                    {
                        if (addvalue[c] != "")
                        {
                            cno++;
                        }
                    }

                    if (cno == 2)
                    {
                        int v = add.sub2value(int.Parse(addvalue[0]), int.Parse(addvalue[1]));
                        txtal.Text = v.ToString();
                    }
                    if (txtal.Text == "0")
                    {
                        ZEROtxt.BackColor = Color.Green;
                        ZEROtxt.Text = "1";
                    }
                    if (txtal.Text == "0")
                    {
                        ZEROtxt.BackColor = Color.Green;
                        ZEROtxt.Text = "1";
                    }
                    if (txtal.Text != "0")
                    {

                        NEGATIVEtxt.Text = "0";
                        ZEROtxt.Text = "0";
                        CARRYtxt.Text = "0";
                        OVERFLOWtxt.Text = "0";

                        ZEROtxt.BackColor = Color.Red;
                        NEGATIVEtxt.BackColor = Color.Red;
                        CARRYtxt.BackColor = Color.Red;
                        OVERFLOWtxt.BackColor = Color.Red;
                    }
                }
                else if (tokens[0].Equals("000111"))//mul2no
                {
                    decoder.Rows.Clear();
                    decoder.Rows[0].Cells[0].Value = "0";
                    decoder.Rows[0].Cells[1].Value = "0";
                    decoder.Rows[0].Cells[2].Value = "0";
                    decoder.Rows[0].Cells[3].Value = "1";
                    decoder.Rows[0].Cells[4].Value = "1";
                    decoder.Rows[0].Cells[5].Value = "1";
                    String value = tokens[1].ToString();
                    char[] tkvalue = value.ToCharArray();
                    decoder.Rows[0].Cells[6].Value = tkvalue[0].ToString();
                    decoder.Rows[0].Cells[7].Value = tkvalue[1].ToString();
                    decoder.Rows[0].Cells[8].Value = tkvalue[2].ToString();
                    decoder.Rows[0].Cells[9].Value = tkvalue[3].ToString();
                    decoder.Rows[0].Cells[10].Value = tkvalue[4].ToString();

                    //String value2 = tokens[2].ToString();
                    //char[] tkvalue2 = value.ToCharArray();
                    decoder.Rows[0].Cells[11].Value = "0";
                    decoder.Rows[0].Cells[12].Value = "0";
                    decoder.Rows[0].Cells[13].Value = "0";
                    decoder.Rows[0].Cells[14].Value = "0";
                    decoder.Rows[0].Cells[15].Value = "0";


                    lblOPCODE.Show();
                    lblOPERAND.Show();
                    LBLOP2.Show();

                    decoder.Rows[0].Cells[0].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[1].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[2].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[3].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[4].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[5].Style.BackColor = Color.Gold;

                    decoder.Rows[0].Cells[6].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[7].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[8].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[9].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[10].Style.BackColor = Color.Pink;


                    decoder.Rows[0].Cells[11].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[12].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[13].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[14].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[15].Style.BackColor = Color.Brown;
                    string sequenceb_addresss_bit = null;
                    for (int i = 0; i < MainMem.Rows.Count - 1; i++)
                    {

                        if (MainMem.Rows[i].Cells[0].Value.ToString() != null)
                        {
                            int address = int.Parse((string)MainMem.Rows[i].Cells[0].Value);
                            char[] sequenceb_addresss_bit_arry = binaryToConverter(address);




                            if (sequenceb_addresss_bit_arry.Length == 3)
                            {
                                sequenceb_addresss_bit = "00";
                            }

                            if (sequenceb_addresss_bit_arry.Length == 2)
                            {
                                sequenceb_addresss_bit = "000";
                            }
                            if (sequenceb_addresss_bit_arry.Length == 1)
                            {
                                sequenceb_addresss_bit = "0000";
                            }

                            for (int d = 0; d < sequenceb_addresss_bit_arry.Length; d++)
                            {


                                sequenceb_addresss_bit = sequenceb_addresss_bit + sequenceb_addresss_bit_arry[d];

                            }


                            if (tokens[1].Equals(sequenceb_addresss_bit))
                            {
                                int decno = binaryToDecimal(int.Parse((string)MainMem.Rows[i].Cells[1].Value));

                                txtal.Text = decno.ToString();
                                break;
                            }
                            else
                            {
                                sequenceb_addresss_bit = null;
                            }
                        }


                    }

                    if (txtal.Text != null)
                    {
                        ALUvalues.Add(txtal.Text);
                    }


                    for (int i = 0; i < ALUvalues.Count; i++)
                    {
                        txtALU.Text = ALUvalues[i] + "\n" + txtALU.Text;

                    }
                    ALU add = new ALU();

                    String[] addvalue = txtALU.Text.Split("\n");

                    int cno = 0;

                    for (int c = 0; c < addvalue.Length; c++)
                    {
                        if (addvalue[c] != "")
                        {
                            cno++;
                        }
                    }

                    if (cno == 2)
                    {
                        int v = add.mul2value(int.Parse(addvalue[0]), int.Parse(addvalue[1]));
                        txtal.Text = v.ToString();
                    }
                    if (txtal.Text == "0")
                    {
                        ZEROtxt.BackColor = Color.Green;
                        ZEROtxt.Text = "1";
                    }
                    if (txtal.Text == "0")
                    {
                        ZEROtxt.BackColor = Color.Green;
                        ZEROtxt.Text = "1";
                    }
                    if (txtal.Text != "0")
                    {

                        NEGATIVEtxt.Text = "0";
                        ZEROtxt.Text = "0";
                        CARRYtxt.Text = "0";
                        OVERFLOWtxt.Text = "0";

                        ZEROtxt.BackColor = Color.Red;
                        NEGATIVEtxt.BackColor = Color.Red;
                        CARRYtxt.BackColor = Color.Red;
                        OVERFLOWtxt.BackColor = Color.Red;
                    }
                }
                else if (tokens[0].Equals("001001"))//div2no
                {
                    decoder.Rows.Clear();
                    decoder.Rows[0].Cells[0].Value = "0";
                    decoder.Rows[0].Cells[1].Value = "0";
                    decoder.Rows[0].Cells[2].Value = "1";
                    decoder.Rows[0].Cells[3].Value = "0";
                    decoder.Rows[0].Cells[4].Value = "0";
                    decoder.Rows[0].Cells[5].Value = "1";
                    String value = tokens[1].ToString();
                    char[] tkvalue = value.ToCharArray();
                    decoder.Rows[0].Cells[6].Value = tkvalue[0].ToString();
                    decoder.Rows[0].Cells[7].Value = tkvalue[1].ToString();
                    decoder.Rows[0].Cells[8].Value = tkvalue[2].ToString();
                    decoder.Rows[0].Cells[9].Value = tkvalue[3].ToString();
                    decoder.Rows[0].Cells[10].Value = tkvalue[4].ToString();

                    //String value2 = tokens[2].ToString();
                    //char[] tkvalue2 = value.ToCharArray();
                    decoder.Rows[0].Cells[11].Value = "0";
                    decoder.Rows[0].Cells[12].Value = "0";
                    decoder.Rows[0].Cells[13].Value = "0";
                    decoder.Rows[0].Cells[14].Value = "0";
                    decoder.Rows[0].Cells[15].Value = "0";


                    lblOPCODE.Show();
                    lblOPERAND.Show();
                    LBLOP2.Show();

                    decoder.Rows[0].Cells[0].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[1].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[2].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[3].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[4].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[5].Style.BackColor = Color.Gold;

                    decoder.Rows[0].Cells[6].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[7].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[8].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[9].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[10].Style.BackColor = Color.Pink;


                    decoder.Rows[0].Cells[11].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[12].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[13].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[14].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[15].Style.BackColor = Color.Brown;
                    string sequenceb_addresss_bit = null;

                    for (int i = 0; i < MainMem.Rows.Count - 1; i++)
                    {

                        if (MainMem.Rows[i].Cells[0].Value.ToString() != null)
                        {
                            int address = int.Parse((string)MainMem.Rows[i].Cells[0].Value);
                            char[] sequenceb_addresss_bit_arry = binaryToConverter(address);


                            if (sequenceb_addresss_bit_arry.Length == 3)
                            {
                                sequenceb_addresss_bit = "00";
                            }

                            if (sequenceb_addresss_bit_arry.Length == 2)
                            {
                                sequenceb_addresss_bit = "000";
                            }
                            if (sequenceb_addresss_bit_arry.Length == 1)
                            {
                                sequenceb_addresss_bit = "0000";
                            }

                            for (int d = 0; d < sequenceb_addresss_bit_arry.Length; d++)
                            {
                                sequenceb_addresss_bit = sequenceb_addresss_bit + sequenceb_addresss_bit_arry[d];
                            }


                            if (tokens[1].Equals(sequenceb_addresss_bit))
                            {
                                int decno = binaryToDecimal(int.Parse((string)MainMem.Rows[i].Cells[1].Value));

                                txtal.Text = decno.ToString();
                            }
                            else
                            {
                                sequenceb_addresss_bit = null;
                            }
                        }


                    }

                    if (txtal.Text != null)
                    {
                        ALUvalues.Add(txtal.Text);
                    }


                    for (int i = 0; i < ALUvalues.Count; i++)
                    {
                        txtALU.Text = ALUvalues[i] + "\n" + txtALU.Text;

                    }
                    ALU add = new ALU();

                    String[] addvalue = txtALU.Text.Split("\n");

                    int cno = 0;

                    for (int c = 0; c < addvalue.Length; c++)
                    {
                        if (addvalue[c] != "")
                        {
                            cno++;
                        }
                    }

                    if (cno == 2)
                    {
                        int v = add.div2value(int.Parse(addvalue[0]), int.Parse(addvalue[1]));
                        txtal.Text = v.ToString();
                    }
                    if (txtal.Text == "0")
                    {
                        ZEROtxt.BackColor = Color.Green;
                        ZEROtxt.Text = "1";
                    }
                    else if (txtal.Text != "0")
                    {

                        NEGATIVEtxt.Text = "0";
                        ZEROtxt.Text = "0";
                        CARRYtxt.Text = "0";
                        OVERFLOWtxt.Text = "0";

                        ZEROtxt.BackColor = Color.Red;
                        NEGATIVEtxt.BackColor = Color.Red;
                        CARRYtxt.BackColor = Color.Red;
                        OVERFLOWtxt.BackColor = Color.Red;
                    }
                }
                else if (tokens[0].Equals("000010"))//add2no
                {
                    decoder.Rows.Clear();
                    decoder.Rows[0].Cells[0].Value = "0";
                    decoder.Rows[0].Cells[1].Value = "0";
                    decoder.Rows[0].Cells[2].Value = "0";
                    decoder.Rows[0].Cells[3].Value = "0";
                    decoder.Rows[0].Cells[4].Value = "1";
                    decoder.Rows[0].Cells[5].Value = "0";
                    String value = tokens[1].ToString();
                    char[] tkvalue = value.ToCharArray();
                    decoder.Rows[0].Cells[6].Value = tkvalue[0].ToString();
                    decoder.Rows[0].Cells[7].Value = tkvalue[1].ToString();
                    decoder.Rows[0].Cells[8].Value = tkvalue[2].ToString();
                    decoder.Rows[0].Cells[9].Value = tkvalue[3].ToString();
                    decoder.Rows[0].Cells[10].Value = tkvalue[4].ToString();

                    //String value2 = tokens[2].ToString();
                    //char[] tkvalue2 = value.ToCharArray();
                    decoder.Rows[0].Cells[11].Value = "0";
                    decoder.Rows[0].Cells[12].Value = "0";
                    decoder.Rows[0].Cells[13].Value = "0";
                    decoder.Rows[0].Cells[14].Value = "0";
                    decoder.Rows[0].Cells[15].Value = "0";


                    lblOPCODE.Show();
                    lblOPERAND.Show();
                    LBLOP2.Show();

                    decoder.Rows[0].Cells[0].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[1].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[2].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[3].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[4].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[5].Style.BackColor = Color.Gold;

                    decoder.Rows[0].Cells[6].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[7].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[8].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[9].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[10].Style.BackColor = Color.Pink;


                    decoder.Rows[0].Cells[11].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[12].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[13].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[14].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[15].Style.BackColor = Color.Brown;
                    string sequenceb_addresss_bit = null;
                    for (int i = 0; i < MainMem.Rows.Count - 1; i++)
                    {

                        if (MainMem.Rows[i].Cells[0].Value.ToString() != null)
                        {
                            int address = int.Parse((string)MainMem.Rows[i].Cells[0].Value);
                            char[] sequenceb_addresss_bit_arry = binaryToConverter(address);



                            if (sequenceb_addresss_bit_arry.Length == 3)
                            {
                                sequenceb_addresss_bit = "00";
                            }

                            if (sequenceb_addresss_bit_arry.Length == 2)
                            {
                                sequenceb_addresss_bit = "000";
                            }
                            if (sequenceb_addresss_bit_arry.Length == 1)
                            {
                                sequenceb_addresss_bit = "0000";
                            }

                            for (int d = 0; d < sequenceb_addresss_bit_arry.Length; d++)
                            {


                                sequenceb_addresss_bit = sequenceb_addresss_bit + sequenceb_addresss_bit_arry[d];

                            }


                            if (tokens[1].Equals(sequenceb_addresss_bit))
                            {
                                int decno = binaryToDecimal(int.Parse((string)MainMem.Rows[i].Cells[1].Value));

                                txtal.Text = decno.ToString();
                                break;
                            }
                            else
                            {
                                sequenceb_addresss_bit = null;
                            }
                        }


                    }

                    if (txtal.Text != null)
                    {
                        ALUvalues.Add(txtal.Text);
                    }


                    for (int i = 0; i < ALUvalues.Count; i++)
                    {
                        txtALU.Text = ALUvalues[i] + "\n" + txtALU.Text;

                    }
                    ALU add = new ALU();

                    String[] addvalue = txtALU.Text.Split("\n");

                    int cno = 0;

                    for (int c = 0; c < addvalue.Length; c++)
                    {
                        if (addvalue[c] != "")
                        {
                            cno++;
                        }
                    }

                    if (cno == 2)
                    {
                        int v = add.add3value(int.Parse(addvalue[0]), int.Parse(addvalue[1]));
                        txtal.Text = v.ToString();
                    }
                    if (txtal.Text == "0")
                    {
                        ZEROtxt.BackColor = Color.Green;
                        ZEROtxt.Text = "1";
                    }
                    if (txtal.Text == "0")
                    {
                        ZEROtxt.BackColor = Color.Green;
                        ZEROtxt.Text = "1";
                    }
                    if (txtal.Text != "0")
                    {

                        NEGATIVEtxt.Text = "0";
                        ZEROtxt.Text = "0";
                        CARRYtxt.Text = "0";
                        OVERFLOWtxt.Text = "0";

                        ZEROtxt.BackColor = Color.Red;
                        NEGATIVEtxt.BackColor = Color.Red;
                        CARRYtxt.BackColor = Color.Red;
                        OVERFLOWtxt.BackColor = Color.Red;
                    }
                }
            }

            //----------------------------------------------------32 bit SAIII WALA--------------------------------------------------

            if (cbmp.SelectedIndex == 2)

            {
                string tok1 = txtmdr.Text;
                String[] tokens1 = tok.Split(' ');

                if (tokens[0].Equals("0000000000000001")) //load
                {
                    decoder.Rows[0].Cells[0].Value = "0";
                    decoder.Rows[0].Cells[1].Value = "0";
                    decoder.Rows[0].Cells[2].Value = "0";
                    decoder.Rows[0].Cells[3].Value = "0";
                    decoder.Rows[0].Cells[4].Value = "0";
                    decoder.Rows[0].Cells[5].Value = "0";
                    decoder.Rows[0].Cells[6].Value = "0";
                    decoder.Rows[0].Cells[7].Value = "0";
                    decoder.Rows[0].Cells[8].Value = "0";
                    decoder.Rows[0].Cells[9].Value = "0";
                    decoder.Rows[0].Cells[10].Value = "0";
                    decoder.Rows[0].Cells[11].Value = "0";
                    decoder.Rows[0].Cells[12].Value = "0";
                    decoder.Rows[0].Cells[13].Value = "0";
                    decoder.Rows[0].Cells[14].Value = "0";
                    decoder.Rows[0].Cells[15].Value = "1";
 

                    String value = tokens1[1].ToString();
                    char[] tkvalue = value.ToCharArray();
                    decoder.Rows[0].Cells[16].Value = tkvalue[0].ToString();
                    decoder.Rows[0].Cells[17].Value = tkvalue[1].ToString();
                    decoder.Rows[0].Cells[18].Value = tkvalue[2].ToString();
                    decoder.Rows[0].Cells[19].Value = tkvalue[3].ToString();
                    decoder.Rows[0].Cells[20].Value = tkvalue[4].ToString();
                    decoder.Rows[0].Cells[21].Value = tkvalue[5].ToString();
                    decoder.Rows[0].Cells[22].Value = tkvalue[6].ToString();
                    decoder.Rows[0].Cells[23].Value = tkvalue[7].ToString();


                    decoder.Rows[0].Cells[24].Value = "0";
                    decoder.Rows[0].Cells[25].Value = "0";
                    decoder.Rows[0].Cells[26].Value = "0";
                    decoder.Rows[0].Cells[27].Value = "0";
                    decoder.Rows[0].Cells[28].Value = "0";
                    decoder.Rows[0].Cells[29].Value = "0";
                    decoder.Rows[0].Cells[30].Value = "0";
                    decoder.Rows[0].Cells[31].Value = "0";


                    lblOPCODE.Show();
                    lblOPERAND.Show();
                    LBLOP2.Show();

                    decoder.Rows[0].Cells[0].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[1].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[2].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[3].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[4].Style.BackColor = Color.Gold;
                    decoder.Rows[0].Cells[5].Style.BackColor = Color.Gold;

                    decoder.Rows[0].Cells[6].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[7].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[8].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[9].Style.BackColor = Color.Pink;
                    decoder.Rows[0].Cells[10].Style.BackColor = Color.Pink;


                    decoder.Rows[0].Cells[11].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[12].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[13].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[14].Style.BackColor = Color.Brown;
                    decoder.Rows[0].Cells[15].Style.BackColor = Color.Brown;
                    string sequenceb_addresss_bit = null;


                    for (int i = 0; i < MainMem.Rows.Count - 1; i++)
                    {



                        if (MainMem.Rows[i].Cells[0].Value.ToString() != null)
                        {
                            int address = int.Parse((string)MainMem.Rows[i].Cells[0].Value);
                            char[] sequenceb_addresss_bit_arry = binaryToConverter(address);



                            if (sequenceb_addresss_bit_arry.Length == 3)
                            {
                                sequenceb_addresss_bit = "00";
                            }

                            else if (sequenceb_addresss_bit_arry.Length == 2)
                            {
                                sequenceb_addresss_bit = "000";
                            }
                            if (sequenceb_addresss_bit_arry.Length == 1)
                            {
                                sequenceb_addresss_bit = "0000";
                            }

                            //if (sequenceb_addresss_bit_arry.Length < 4 && cbmp.SelectedIndex == 0)
                            //{
                            //    string message = "Can't adjust Bits, Select Large Microprocessor";
                            //    string title = "BITS are exceeded";
                            //    MessageBox.Show(message, title);
                            //    flag = false;
                            //}
                            for (int d = 0; d < sequenceb_addresss_bit_arry.Length; d++)
                            {


                                sequenceb_addresss_bit = sequenceb_addresss_bit + sequenceb_addresss_bit_arry[d];

                            }


                            if (tokens[1].Equals(sequenceb_addresss_bit))
                            {
                                int decno = binaryToDecimal(int.Parse((string)MainMem.Rows[i].Cells[1].Value));

                                txtal.Text = decno.ToString();
                                break;
                            }
                            else
                            {
                                sequenceb_addresss_bit = null;
                            }

                        }
                        if (MainMem.Rows[i].Cells[0].Value.ToString() == null)
                        {
                            MessageBox.Show("Memory End");
                        }
                    }


                    if (txtal.Text != null)
                    {
                        ALUvalues.Add(txtal.Text);
                    }


                }
            }
        }
            

        public char[] binaryToConverter(int n)
        {

            string binary = Convert.ToString(n, 2);
            Char[] binarytoken = new Char[binary.Length];
            binarytoken = binary.ToCharArray();

            return binarytoken;

        }

        public int binaryToDecimal(int n)
        {

            int decimalValue = Convert.ToInt32(n.ToString(), 2);


            return decimalValue;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
            Close();
        }

        private void visa_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();

        }

        private void label14_Click(object sender, EventArgs e)
        {
            if (cbmp.SelectedIndex == null)
            {
                label13.Text = " -- ";
            }
            else if (cbmp.SelectedIndex == 0)
            {
                label13.Text = " OPCODE  [4] ";
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MainMem.Rows.Clear();
            txtALU.Clear();
            txtal.Clear();
            txtmdr.Clear();
            txtmar.Clear();
            pc.Clear();
            decoder.Rows.Clear();

            if (cbi.SelectedIndex == null)
            {
                string message = "Select Program you want to execute";
                string title = "Select Program";

                MessageBox.Show(message, title);

            }
            else if (cbi.SelectedIndex == 0 && cbmp.SelectedIndex ==0)
            {
                Loadv();
                //detailtxtbox.Enabled = true;
                //lblDETAILS.Enabled = true;
            }
            else if (cbi.SelectedIndex == 1 && cbmp.SelectedIndex == 0)
            {
                pc.Text = 0.ToString();
                add2no();
                //detailtxtbox.Enabled = true;
                //lblDETAILS.Enabled = true;
            }
            else if (cbi.SelectedIndex == 2 && cbmp.SelectedIndex == 0)
            {
                sub2no();
                //detailtxtbox.Enabled = true;
                //lblDETAILS.Enabled = true;
            }
            else if (cbi.SelectedIndex == 3 && cbmp.SelectedIndex == 0)
            {
                mul2no(); 
                //detailtxtbox.Enabled = true;
                //lblDETAILS.Enabled = true;
            }
            else if (cbi.SelectedIndex == 4 && cbmp.SelectedIndex == 0)
            {
                div2no();
                //detailtxtbox.Enabled = true;
                //lblDETAILS.Enabled = true;
            }
            else if (cbi.SelectedIndex == 5 && cbmp.SelectedIndex == 0)
            {
                Storev();
                //detailtxtbox.Enabled = true;
                //lblDETAILS.Enabled = true;
            }
            else if (cbi.SelectedIndex == 6 && cbmp.SelectedIndex == 1 || cbmp.SelectedIndex == 2 || cbmp.SelectedIndex == 3)
            {
                add3no();
                //detailtxtbox.Enabled = true;
                //lblDETAILS.Enabled = true;
            }
            else if (cbi.SelectedIndex == 7 && cbmp.SelectedIndex == 1 || cbmp.SelectedIndex == 2 || cbmp.SelectedIndex == 3)
            {
                sub3no();
                //detailtxtbox.Enabled = true;
                //lblDETAILS.Enabled = true;
            }
            else if (cbi.SelectedIndex == 8 && cbmp.SelectedIndex == 1 || cbmp.SelectedIndex == 2 || cbmp.SelectedIndex == 3)
            {
                mul3no();
                //detailtxtbox.Enabled = true;
                //lblDETAILS.Enabled = true;
            }
            else if (cbi.SelectedIndex == 9 && cbmp.SelectedIndex == 1 || cbmp.SelectedIndex == 2 || cbmp.SelectedIndex == 3)
            {
                div3no();
                //detailtxtbox.Enabled = true;
                //lblDETAILS.Enabled = true;
            }
            else if (cbi.SelectedIndex == 0 && cbmp.SelectedIndex == 1)
            {
                Loadv16();
                //detailtxtbox.Enabled = true;
                //lblDETAILS.Enabled = true;
            }
            else if (cbi.SelectedIndex == 1 && cbmp.SelectedIndex == 1)
            {
                addv16();
                //detailtxtbox.Enabled = true;
                //lblDETAILS.Enabled = true;
            }
            else if (cbi.SelectedIndex == 2 && cbmp.SelectedIndex == 1)
            {
                subv16();
                //detailtxtbox.Enabled = true;
                //lblDETAILS.Enabled = true;
            }
            else if (cbi.SelectedIndex == 3 && cbmp.SelectedIndex == 1)
            {
                mulv16();
                //detailtxtbox.Enabled = true;
                //lblDETAILS.Enabled = true;
            }
            else if (cbi.SelectedIndex == 4 && cbmp.SelectedIndex == 1)
            {
                divv16();
                //detailtxtbox.Enabled = true;
                //lblDETAILS.Enabled = true;
            }
            else if (cbi.SelectedIndex == 5 && cbmp.SelectedIndex == 1)
            {
                Storev16();
                //detailtxtbox.Enabled = true;
                //lblDETAILS.Enabled = true;
            }
            else if (cbi.SelectedIndex == 1 && cbmp.SelectedIndex == 2)
            {
                addv32();
                //detailtxtbox.Enabled = true;
                //lblDETAILS.Enabled = true;
            }
            else if (cbi.SelectedIndex == 2 && cbmp.SelectedIndex == 2)
            {
                subv32();
                //detailtxtbox.Enabled = true;
                //lblDETAILS.Enabled = true;
            }
            else if (cbi.SelectedIndex == 3 && cbmp.SelectedIndex == 2)
            {
                mulv32();
                //detailtxtbox.Enabled = true;
                //lblDETAILS.Enabled = true;
            }
            else if (cbi.SelectedIndex == 4 && cbmp.SelectedIndex == 2)
            {
                divv32();
                //detailtxtbox.Enabled = true;
                //lblDETAILS.Enabled = true;
            }
            else if (cbi.SelectedIndex == 5 && cbmp.SelectedIndex == 2)
            {
                Storev32();
                //detailtxtbox.Enabled = true;
                //lblDETAILS.Enabled = true;
            }
            else
            {
                string message = "Select Large Microprocessor, Can't Perfom on 8 Bit Microporcessor";
                string title = "Select Program";

                MessageBox.Show(message, title);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMem.Rows.Clear();

            //pc.Text = MainMem.Rows[row].Cells[column].Value.ToString();

            txtal.Clear();
            txtALU.Clear();
            decoder.Rows.Clear();
            txtmar.Clear();
            txtmdr.Clear();
            pc.Clear();
            CARRYtxt.Clear();
            NEGATIVEtxt.Clear();
            OVERFLOWtxt.Clear();
            ZEROtxt.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                pc.Clear();
                pc.ResetText();
                //pc = res;
                txtmar.Clear();
                //txtmar = res; 
                txtmdr.Clear();
                MainMem.ColumnCount = 0;



            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cbmp.SelectedItem == null)
            {
                string message = "Select Microprocessor";
                string title = "Select MP";
                MessageBox.Show(message, title);

            }
            if (cbi.SelectedItem == null)
            {
                string message = "Select Program";
                string title = "Select Program";
                MessageBox.Show(message, title);

            }


            if (cbmp.SelectedIndex == 0)
            {

                //if (MainMem.Row[row]!=0)
                //{ 
                pc.Text = MainMem.Rows[row].Cells[column].Value.ToString();
                pc.BackColor = Color.Yellow;
                //}
                //txtmdr.Text = MainMem.Rows[prow].Cells[column + 1].Value.ToString();
                //txtmdr.BackColor = Color.LightGreen;

            }

        }

        private void e2_Click(object sender, EventArgs e)
        {
            bool flag = true;

            if (cbmp.SelectedItem == null)
            {
                string message = "Select Microprocessor";
                string title = "Select MP";
                MessageBox.Show(message, title);

            }
            if (cbi.SelectedItem == null)
            {
                string message = "Select Program";
                string title = "Select Program";
                MessageBox.Show(message, title);
            }


            if (cbmp.SelectedIndex == 0 && flag == true)
            {

                pc.Text = MainMem.Rows[row].Cells[column].Value.ToString();
                pc.BackColor = Color.Yellow;
                pc.ForeColor = Color.Green;


                if (row != 0 && flag == true)
                {

                    txtmar.Text = MainMem.Rows[prow].Cells[column].Value.ToString();
                    txtmar.BackColor = Color.LightBlue;
                    pc.BackColor = Color.White;
                    txtmdr.BackColor = Color.White;

                }
                if (row != 0 && flag == true)
                {

                    txtmdr.Text = MainMem.Rows[prow].Cells[column + 1].Value.ToString();
                    txtmdr.BackColor = Color.LightGreen;
                    pc.BackColor = Color.White;
                    txtmar.BackColor = Color.White;
                    flag = false;
                }



                prow = row;
                row++;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Boolean pause = true;
            //int pc= MainMem.Rows[];
            if (cbmp.SelectedItem == null)
            {
                string message = "Select Microprocessor";
                string title = "Select MP";
                MessageBox.Show(message, title);

            }
            else if (cbi.SelectedItem == null)
            {
                string message = "Select Program";
                string title = "Select Program";
                MessageBox.Show(message, title);

            }



            else if (cbmp.SelectedIndex == 0)
            {
                while (pause)
                {

                    //if (MainMem.Row[row]!=0)
                    //{ 
                    pc.Text = MainMem.Rows[row].Cells[column].Value.ToString();
                    pc.BackColor = Color.Yellow;
                    //}
                    txtmdr.Text = MainMem.Rows[prow].Cells[column + 1].Value.ToString();
                    txtmdr.BackColor = Color.LightGreen;


                    if (pause && row != 0)
                    {

                        txtmdr.Text = MainMem.Rows[prow].Cells[column + 1].Value.ToString();
                        txtmar.Text = MainMem.Rows[prow].Cells[column].Value.ToString();
                        txtmar.BackColor = Color.LightBlue;
                        pause = false;
                    }




                    prow = row;
                    row++;


                }
                string tok = txtmdr.Text;
                String[] tokens = tok.Split(' ');

                if (tokens[0].Equals("0001"))
                {
                    decoder.Rows[0].Cells[0].Value = "0";
                    decoder.Rows[0].Cells[1].Value = "0";
                    decoder.Rows[0].Cells[2].Value = "0";
                    decoder.Rows[0].Cells[3].Value = "1";
                    int value = int.Parse(tokens[1].ToString());
                    char[] tkvalue = binaryToConverter(value);
                    decoder.Rows[0].Cells[4].Value = tkvalue[0].ToString();
                    decoder.Rows[0].Cells[5].Value = tkvalue[1].ToString();
                    decoder.Rows[0].Cells[6].Value = tkvalue[2].ToString();
                    decoder.Rows[0].Cells[7].Value = tkvalue[3].ToString();


                    for (int i = 0; i < MainMem.Rows.Count; i++)
                    {
                        if (tokens[1].Equals(MainMem.Rows[i].Cells[0].Value))
                        {

                            txtal.Text = MainMem.Rows[i].Cells[1].Value.ToString();
                        }
                    }
#pragma warning disable CS8604 // Possible null reference argument.
                    ALUvalues.Add(txtal.Text);
#pragma warning restore CS8604 // Possible null reference argument.

                }
                else if (tokens[0].Equals("0010"))
                {
                    decoder.Rows.Clear();
                    decoder.Rows[0].Cells[0].Value = "0";
                    decoder.Rows[0].Cells[1].Value = "0";
                    decoder.Rows[0].Cells[2].Value = "1";
                    decoder.Rows[0].Cells[3].Value = "1";

                    int value = int.Parse(tokens[1].ToString());
                    char[] tkvalue = binaryToConverter(value);
                    decoder.Rows[0].Cells[4].Value = tkvalue[0].ToString();
                    decoder.Rows[0].Cells[5].Value = tkvalue[1].ToString();
                    decoder.Rows[0].Cells[6].Value = tkvalue[2].ToString();
                    decoder.Rows[0].Cells[7].Value = tkvalue[3].ToString();



                    for (int i = 0; i < MainMem.Rows.Count; i++)
                    {
                        if (tokens[1].Equals(MainMem.Rows[i].Cells[0].Value))
                        {

                            txtal.Text = MainMem.Rows[i].Cells[1].Value.ToString();
                        }
                    }


                    if (txtal.Text != null)
                    {
                        ALUvalues.Add(txtal.Text);
                    }


                    for (int i = 0; i < ALUvalues.Count; i++)
                    {
                        txtALU.Text = ALUvalues[i] + "\n" + txtALU.Text;

                    }
                    ALU add = new ALU();

                    String[] addvalue = txtALU.Text.Split("\n");

                    int cno = 0;

                    for (int c = 0; c < addvalue.Length; c++)
                    {
                        if (addvalue[c] != "")
                        {
                            cno++;
                        }
                    }

                    if (cno == 2)
                    {
                        int v = add.add2value(int.Parse(addvalue[0]), int.Parse(addvalue[1]));
                        txtal.Text = v.ToString();

                    }

                }
                else if (tokens[0].Equals("STORE"))
                {
                    decoder.Rows[0].Cells[0].Value = "1";
                    decoder.Rows[0].Cells[1].Value = "0";
                    decoder.Rows[0].Cells[2].Value = "1";
                    decoder.Rows[0].Cells[3].Value = "1";
                    int value = int.Parse(tokens[1].ToString());
                    char[] tkvalue = binaryToConverter(value);
                    decoder.Rows[0].Cells[4].Value = tkvalue[0].ToString();
                    decoder.Rows[0].Cells[5].Value = tkvalue[1].ToString();
                    decoder.Rows[0].Cells[6].Value = tkvalue[2].ToString();
                    decoder.Rows[0].Cells[7].Value = tkvalue[3].ToString();

                    for (int i = 0; i < MainMem.Rows.Count; i++)
                    {
                        if (tokens[1].Equals(MainMem.Rows[i].Cells[0].Value))
                        {

                            MainMem.Rows[i].Cells[1].Value = txtal.Text;
                            txtal.Clear();
                            decoder.Rows.Clear();
                            txtALU.Clear();


                        }
                    }

                }
                else if (tokens[0].Equals("SUB"))
                {
                    decoder.Rows.Clear();
                    decoder.Rows[0].Cells[0].Value = "0";
                    decoder.Rows[0].Cells[1].Value = "1";
                    decoder.Rows[0].Cells[2].Value = "0";
                    decoder.Rows[0].Cells[3].Value = "1";

                    int value = int.Parse(tokens[1].ToString());
                    char[] tkvalue = binaryToConverter(value);
                    decoder.Rows[0].Cells[4].Value = tkvalue[0].ToString();
                    decoder.Rows[0].Cells[5].Value = tkvalue[1].ToString();
                    decoder.Rows[0].Cells[6].Value = tkvalue[2].ToString();
                    decoder.Rows[0].Cells[7].Value = tkvalue[3].ToString();



                    for (int i = 0; i < MainMem.Rows.Count; i++)
                    {
                        if (tokens[1].Equals(MainMem.Rows[i].Cells[0].Value))
                        {

                            txtal.Text = MainMem.Rows[i].Cells[1].Value.ToString();
                        }
                    }


                    if (txtal.Text != null)
                    {
                        ALUvalues.Add(txtal.Text);
                    }


                    for (int i = 0; i < ALUvalues.Count; i++)
                    {
                        txtALU.Text = ALUvalues[i] + "\n" + txtALU.Text;

                    }
                    ALU add = new ALU();

                    String[] addvalue = txtALU.Text.Split("\n");

                    int cno = 0;

                    for (int c = 0; c < addvalue.Length; c++)
                    {
                        if (addvalue[c] != "")
                        {
                            cno++;
                        }
                    }

                    if (cno == 2)
                    {
                        int v = add.sub2value(int.Parse(addvalue[0]), int.Parse(addvalue[1]));
                        txtal.Text = v.ToString();

                    }

                }
                else if (tokens[0].Equals("MUL"))
                {
                    decoder.Rows.Clear();
                    decoder.Rows[0].Cells[0].Value = "0";
                    decoder.Rows[0].Cells[1].Value = "1";
                    decoder.Rows[0].Cells[2].Value = "1";
                    decoder.Rows[0].Cells[3].Value = "1";

                    int value = int.Parse(tokens[1].ToString());
                    char[] tkvalue = binaryToConverter(value);
                    decoder.Rows[0].Cells[4].Value = tkvalue[0].ToString();
                    decoder.Rows[0].Cells[5].Value = tkvalue[1].ToString();
                    decoder.Rows[0].Cells[6].Value = tkvalue[2].ToString();
                    decoder.Rows[0].Cells[7].Value = tkvalue[3].ToString();



                    for (int i = 0; i < MainMem.Rows.Count; i++)
                    {
                        if (tokens[1].Equals(MainMem.Rows[i].Cells[0].Value))
                        {

                            txtal.Text = MainMem.Rows[i].Cells[1].Value.ToString();
                        }
                    }


                    if (txtal.Text != null)
                    {
                        ALUvalues.Add(txtal.Text);
                    }


                    for (int i = 0; i < ALUvalues.Count; i++)
                    {
                        txtALU.Text = ALUvalues[i] + "\n" + txtALU.Text;

                    }
                    ALU add = new ALU();

                    String[] addvalue = txtALU.Text.Split("\n");

                    int cno = 0;

                    for (int c = 0; c < addvalue.Length; c++)
                    {
                        if (addvalue[c] != "")
                        {
                            cno++;
                        }
                    }

                    if (cno == 2)
                    {
                        int v = add.mul2value(int.Parse(addvalue[0]), int.Parse(addvalue[1]));
                        txtal.Text = v.ToString();

                    }

                }
                else if (tokens[0].Equals("DIV"))
                {
                    decoder.Rows.Clear();
                    decoder.Rows[0].Cells[0].Value = "1";
                    decoder.Rows[0].Cells[1].Value = "0";
                    decoder.Rows[0].Cells[2].Value = "0";
                    decoder.Rows[0].Cells[3].Value = "1";

                    int value = int.Parse(tokens[1].ToString());
                    char[] tkvalue = binaryToConverter(value);
                    decoder.Rows[0].Cells[4].Value = tkvalue[0].ToString();
                    decoder.Rows[0].Cells[5].Value = tkvalue[1].ToString();
                    decoder.Rows[0].Cells[6].Value = tkvalue[2].ToString();
                    decoder.Rows[0].Cells[7].Value = tkvalue[3].ToString();



                    for (int i = 0; i < MainMem.Rows.Count; i++)
                    {
                        if (tokens[1].Equals(MainMem.Rows[i].Cells[0].Value))
                        {

                            txtal.Text = MainMem.Rows[i].Cells[1].Value.ToString();
                        }
                    }


                    if (txtal.Text != null)
                    {
                        ALUvalues.Add(txtal.Text);
                    }


                    for (int i = 0; i < ALUvalues.Count; i++)
                    {
                        txtALU.Text = ALUvalues[i] + "\n" + txtALU.Text;

                    }
                    ALU add = new ALU();

                    String[] addvalue = txtALU.Text.Split("\n");

                    int cno = 0;

                    for (int c = 0; c < addvalue.Length; c++)
                    {
                        if (addvalue[c] != "")
                        {
                            cno++;
                        }
                    }

                    if (cno == 2)
                    {
                        int v = add.div2value(int.Parse(addvalue[0]), int.Parse(addvalue[1]));
                        txtal.Text = v.ToString();

                    }

                }

            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {
                this.Close();
            }
            Opacity -= .2;
            Close();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtALU_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton1.Checked == true)
            {
                //decodergroupbox.ForeColor = Color.White;
                //decodergroupbox.BackColor = Color.Gray;
                BackColor = Color.Black;
                flagsgroupbox.ForeColor = Color.White;
                registersgroupbox.ForeColor = Color.White;
                specialregistergroupbox.ForeColor = Color.White;
                //lblDETAILS.ForeColor = Color.White;
                //clearallbtn.ForeColor = Color.White;
                //clearmembtn.ForeColor = Color.White;
                //EXECUTE.ForeColor = Color.White;
                //stop.ForeColor = Color.White;
                //restart.ForeColor = Color.White;
                alulbl.ForeColor = Color.White;
                mainpanel.BackColor = Color.Gray;
                mainpanel.ForeColor = Color.White;
                microprocessorlbl.ForeColor = Color.Orange;
                decodergroupbox.BackColor = Color.Gray;
                //lblFORMAT.ForeColor = Color.White;
                //lblDETAILS.ForeColor = Color.White;


            }
            else
            {
                BackColor = Color.Lavender;
                //decodergroupbox.ForeColor = Color.Black;
                flagsgroupbox.ForeColor = Color.Black;
                registersgroupbox.ForeColor = Color.Black;
                specialregistergroupbox.ForeColor = Color.Black;
                //lblDETAILS.ForeColor = Color.Black;
                clearallbtn.ForeColor = Color.Black;
                clearmembtn.ForeColor = Color.Black;
                EXECUTE.ForeColor = Color.Black;
                stop.ForeColor = Color.Black;
                restart.ForeColor = Color.Black;
                alulbl.ForeColor = Color.Black;
                mainpanel.ForeColor = Color.Black;
                mainpanel.BackColor = Color.Orange;
                microprocessorlbl.ForeColor = Color.Black;
                decodergroupbox.BackColor = Color.WhiteSmoke;
                //lblFORMAT.ForeColor = Color.Black;
                //lblDETAILS.ForeColor = Color.Black;


            }


        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Label lblSize = new Label();
            lblSize.Size = new Size(150, 35);

        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            formatxtbox.Show();
            if (cbmp.SelectedIndex == 0)
            {
                formatxtbox.Text = "                            ****8 bit**** " +
        "\n #Format " +
        "\n" +
        "\n Opcode Operand " +
        "\n 0000   0000  " +
        "\n " +
        "\n " +
        "\n [OPCODE] [FUNCTION] " +
        "\n  " +
        "\n 0001	 LOAD A (ADDRESS) " +
        "\n 0010     LOAD X (VALUE)" +
        "\n 0011  	 ADD A (ADDRESS)" +
        "\n 0100     ADD X (VALUE) " +
        "\n 0101     SUB A (ADDRESS)" +
        "\n 0110     SUB X (VALUE)" +
        "\n 0111     MUL A (ADDRESS) " +
        "\n 1000     MUL X (VALUE) " +
        "\n 1001     DIV A (ADDRESS)" +
        "\n 1011     STORE A (ADDRESS)" +
        "\n 1100	 ---" +
        "\n 1101     ---" +
        "\n 1110     ---" +
        "\n 1111     ---";
            }

            if (cbmp.SelectedIndex == 1)
            {
                formatxtbox.Text = "                            ****16 bit**** " +
        "\n #Format " +
        "\n" +
        "\n Opcode  Operand-1  Operand-2 " +
        "\n 000000    00000  00000" +
        "\n " +
        "\n " +
        "\n [OPCODE] [FUNCTION] " +
        "\n  " +
        "\n 000001	 LOAD A (ADDRESS) " +
        "\n 000010     LOAD X (VALUE)" +
        "\n 000011  	 ADD A (ADDRESS)" +
        "\n 000100     ADD X (VALUE) " +
        "\n 000101     SUB A (ADDRESS)" +
        "\n 000110     SUB X (VALUE)" +
        "\n 000111     MUL A (VALUE) " +
        "\n 001000     MUL X (ADDRESS) " +
        "\n 001001     DIV A (ADDRESS)" +

        "\n 001110       ADD A(ADDRESS) [3 NUMBERS]" +
        "\n 001100     ADD X (VALUE) [3 NUMBERS]" +
        "\n 001101     SUB A (ADDRESS) [3 NUMBERS]" +
        "\n 001110     SUB X (VALUE) [3 NUMBERS]" +
        "\n 001111     MUL A (VALUE) [3 NUMBERS]" +
        "\n 011000     MUL X (ADDRESS) [3 NUMBERS]" +
        "\n 011001     DIV A (ADDRESS) [3 NUMBERS]" +

        "\n 011011     STORE A (ADDRESS)" +
        "\n 001100	 ---" +
        "\n 001101     ---" +
        "\n 001110     ---" +
        "\n 001111     ---";
            }

            if (cbmp.SelectedIndex == 2)
            {
                formatxtbox.Clear();
                formatxtbox.Text = "                            ****32 bit**** " +
        "\n #Format " +
        "\n" +
        "\n Opcode                    Operand-1      Operand-2" +
        "\n 0000000000000000         00000000        00000000 " +
        "\n " +
        "\n " +
        "\n [OPCODE] [FUNCTION] " +
        "\n  " +
        "\n 00000000000000000001	 LOAD A (ADDRESS) " +
        "\n 00000000000000000010     LOAD X (VALUE)" +
        "\n 00000000000000000011  	 ADD A (ADDRESS)" +
        "\n 00000000000000000100     ADD X (VALUE) " +
        "\n 00000000000000000101     SUB A (ADDRESS)" +
        "\n 00000000000000000110     SUB X (VALUE)" +
        "\n 00000000000000000111     MUL A (ADDRESS) " +
        "\n 00000000000000001000     MUL X (VALUE) " +
        "\n 00000000000000001001     DIV A (ADDRESS)" +

        "\n 00000000000000000111     ADD A(ADDRESS) [3 NUMBERS]" +
        "\n 00000000000000001100     ADD X (VALUE) [3 NUMBERS]" +
        "\n 00000000000000001101     SUB A (ADDRESS) [3 NUMBERS]" +
        "\n 00000000000000001110     SUB X (VALUE) [3 NUMBERS]" +
        "\n 00000000000000001111     MUL A (VALUE) [3 NUMBERS]" +
        "\n 00000000000000011000     MUL X (ADDRESS) [3 NUMBERS]" +
        "\n 00000000000000011001     DIV A (ADDRESS) [3 NUMBERS]" +

        "\n 00000000000000001011     STORE A (ADDRESS)" +
        "\n 00000000000000001100	 ---" +
        "\n 00000000000000001101     ---" +
        "\n 00000000000000001110     ---" +
        "\n 00000000000000001111     ---";
            }
            if (cbmp.SelectedIndex == 3)
            {
                formatxtbox.Text = "                            ****64 bit**** " +
        "\n #Format " +
        "\n" +
        "\n Opcode                                        Operand-1              Operand-2" +
        "\n 0000000000000000000000000000000000         000000000000000        000000000000000  " +
        "\n " +
        "\n " +
        "\n [OPCODE] [FUNCTION] " +
        "\n  " +
        "\n 00000000000000000000000000000000000001	 LOAD A (ADDRESS) " +
        "\n 00000000000000000000000000000000000010     LOAD X (VALUE)" +
        "\n 00000000000000000000000000000000000011  	 ADD A (ADDRESS)" +
        "\n 00000000000000000000000000000000000100     ADD X (VALUE) " +
        "\n 00000000000000000000000000000000000101     SUB A (ADDRESS)" +
        "\n 00000000000000000000000000000000000110     SUB X (VALUE)" +
        "\n 00000000000000000000000000000000000111     MUL A (ADDRESS) " +
        "\n 00000000000000000000000000000000001000     MUL X (VALUE) " +
        "\n 00000000000000000000000000000000001001     DIV A (ADDRESS)" +

        "\n 00000000000000000000000000000000000111       ADD A(ADDRESS) [3 NUMBERS]" +
        "\n 00000000000000000000000000000000001100     ADD X (VALUE) [3 NUMBERS]" +
        "\n 00000000000000000000000000000000001101     SUB A (ADDRESS) [3 NUMBERS]" +
        "\n 00000000000000000000000000000000001110     SUB X (VALUE) [3 NUMBERS]" +
        "\n 00000000000000000000000000000000001111     MUL A (VALUE) [3 NUMBERS]" +
        "\n 00000000000000000000000000000000011000     MUL X (ADDRESS) [3 NUMBERS]" +
        "\n 00000000000000000000000000000000011001     DIV A (ADDRESS) [3 NUMBERS]" +

        "\n 00000000000000000000000000000000001011     STORE A (ADDRESS)" +
        "\n 00000000000000000000000000000000001100	 ---" +
        "\n 00000000000000000000000000000000001101     ---" +
        "\n 00000000000000000000000000000000001110     ---" +
        "\n 00000000000000000000000000000000001111     ---";
            }
        }

        private void txtah_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void flagsgroupbox_Enter(object sender, EventArgs e)
        {

        }

        public void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op1 = new OpenFileDialog();
            op1.Multiselect = true;
            op1.ShowDialog();
            op1.Filter = "File|*.txt";
            AddAssemblyFilebtn.Text = op1.FileName;
            int count = 0;
            string[] FName;
            foreach (string s in op1.FileNames)
            {
                FName
                     = s.Split('\\');
                count++;
            }
            MessageBox.Show(Convert.ToString(count) + "File(s) Copied");


        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void formatxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


