using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJ
{
    public class Instructions
    {
        //public void add2no()
        //{

        //    MainMem.ColumnCount = 3;
        //    MainMem.Columns[0].Name = "ADDRESS";
        //    MainMem.Columns[1].Name = "DATA";
        //    MainMem.Columns[2].Name = "MNEMONIC";

        //    ArrayList row = new ArrayList();
        //    row.Add("0");
        //    row.Add("0001 0100");
        //    row.Add("LOAD 4");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("1");
        //    row.Add("0010 0101");
        //    row.Add("ADD 5");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("2");
        //    row.Add("0110 0110");
        //    row.Add("STORE 6");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("3");
        //    row.Add("  ");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("4");
        //    row.Add("0100");
        //    row.Add("4");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("5");
        //    row.Add("1000");
        //    row.Add("8");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("6");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("7");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("8");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());


        //}
        //public void Loadv()
        //{
        //    for (int i = 0; i < MainMem.Rows.Count; i++)
        //    {

        //        MainMem.Rows[i].Cells[1].Value = txtal.Text;
        //        txtal.Clear();
        //        decoder.Rows.Clear();
        //        txtALU.Clear();


        //    }
        //    MainMem.ColumnCount = 3;
        //    MainMem.Columns[0].Name = "ADDRESS";
        //    MainMem.Columns[1].Name = "DATA";
        //    MainMem.Columns[1].Name = "MNEMONIC";

        //    ArrayList row = new ArrayList();
        //    row.Add("1 ");
        //    row.Add("0001 0010");
        //    row.Add("LOAD 2");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("2");
        //    row.Add("1010");
        //    row.Add("10");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("3");
        //    row.Add(" ");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("4");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());


        //}
        //public void sub2no()
        //{


        //    MainMem.ColumnCount = 3;
        //    MainMem.Columns[0].Name = "ADDRESS";
        //    MainMem.Columns[1].Name = "DATA";
        //    MainMem.Columns[2].Name = "MNEMONIC";


        //    ArrayList row = new ArrayList();
        //    row.Add("1");
        //    row.Add("0001 0101");
        //    row.Add("LOAD 5");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("2");
        //    row.Add("0011 0110");
        //    row.Add("SUB 6");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("3");
        //    row.Add("0110 1000");
        //    row.Add("STORE 8");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("4");
        //    row.Add("  ");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("5");
        //    row.Add("0101");
        //    row.Add("5");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("6");
        //    row.Add("0101");
        //    row.Add("5");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("7");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("8");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("9");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());


        //}
        //public void mul2no()
        //{


        //    MainMem.ColumnCount = 3;
        //    MainMem.Columns[0].Name = "ADDRESS";
        //    MainMem.Columns[1].Name = "DATA";
        //    MainMem.Columns[2].Name = "MNEMONIC";


        //    ArrayList row = new ArrayList();
        //    row.Add("1");
        //    row.Add("0001 0100");
        //    row.Add("LOAD 5");


        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("2");
        //    row.Add("0001 0101");
        //    row.Add("MUL 6");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("3");
        //    row.Add("0001 0101");
        //    row.Add("STORE 1003");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("4");
        //    row.Add("  ");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("5");
        //    row.Add("0011");
        //    row.Add("3");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("6");
        //    row.Add("0010");
        //    row.Add("2");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("7");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("8");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("9");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());


        //}
        //public void div2no()
        //{


        //    MainMem.ColumnCount = 3;
        //    MainMem.Columns[0].Name = "ADDRESS";
        //    MainMem.Columns[1].Name = "DATA";
        //    MainMem.Columns[2].Name = "MNEMONIC";


        //    ArrayList row = new ArrayList();
        //    row.Add("1");
        //    row.Add("0001 0101");
        //    row.Add("LOAD 5");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("2");
        //    row.Add("1010 0110");
        //    row.Add("DIV 6");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("3");
        //    row.Add("0110 1000");
        //    row.Add("STORE 8");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("4");
        //    row.Add("  ");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("5");
        //    row.Add("0010");
        //    row.Add("2");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("6");
        //    row.Add("0100");
        //    row.Add("4");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("7");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("8");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("9");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());
        //}
        //public void Storev()
        //{

        //    MainMem.ColumnCount = 3;
        //    MainMem.Columns[0].Name = "ADDRESS";
        //    MainMem.Columns[1].Name = "DATA";
        //    MainMem.Columns[1].Name = "MNEMONIC";

        //    ArrayList row = new ArrayList();
        //    row.Add("1 ");
        //    row.Add("0001 0010");
        //    row.Add("LOAD 3");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("2");
        //    row.Add("0110 0100");
        //    row.Add("10");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("3");
        //    row.Add("0110");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("4");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());


        //}

        //public void add3no()
        //{


        //    MainMem.ColumnCount = 3;
        //    MainMem.Columns[0].Name = "ADDRESS";
        //    MainMem.Columns[1].Name = "DATA";
        //    MainMem.Columns[2].Name = "MNEMONIC";


        //    ArrayList row = new ArrayList();
        //    row.Add("1");
        //    row.Add("000001 00101");
        //    row.Add("LOAD 5");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("2");
        //    row.Add("000001 00110");
        //    row.Add("LOAD 6");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("3");
        //    row.Add("000111 00111");
        //    row.Add("ADD 7");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("4");
        //    row.Add("0000100 01001");
        //    row.Add("STORE 9");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("5");
        //    row.Add("01100");
        //    row.Add("12");
        //    MainMem.Rows.Add(row.ToArray());
        //    row = new ArrayList();
        //    row.Add("6");
        //    row.Add("01000");
        //    row.Add("8");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("7");
        //    row.Add("01010");
        //    row.Add("10");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("8");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("9");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());
        //}
        //public void sub3no()
        //{


        //    MainMem.ColumnCount = 3;
        //    MainMem.Columns[0].Name = "ADDRESS";
        //    MainMem.Columns[1].Name = "DATA";
        //    MainMem.Columns[2].Name = "MNEMONIC";


        //    ArrayList row = new ArrayList();
        //    row.Add("1");
        //    row.Add("000001 00101");
        //    row.Add("LOAD 5");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("2");
        //    row.Add("000001 00110");
        //    row.Add("LOAD 6");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("3");
        //    row.Add("000111 00111");
        //    row.Add("SUB 7");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("4");
        //    row.Add("000100 01001");
        //    row.Add("STORE 9");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("5");
        //    row.Add("01100");
        //    row.Add("12");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("6");
        //    row.Add("01000");
        //    row.Add("8");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("7");
        //    row.Add("01010");
        //    row.Add("10");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("8");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("9");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());
        //}
        //public void mul3no()
        //{


        //    MainMem.ColumnCount = 3;
        //    MainMem.Columns[0].Name = "ADDRESS";
        //    MainMem.Columns[1].Name = "DATA";
        //    MainMem.Columns[2].Name = "MNEMONIC";


        //    ArrayList row = new ArrayList();
        //    row.Add("1");
        //    row.Add("000001 00101");
        //    row.Add("LOAD 5");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("2");
        //    row.Add("000001 00110");
        //    row.Add("LOAD 6");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("3");
        //    row.Add("000111 00111");
        //    row.Add("MUL 7");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("4");
        //    row.Add("000100 01001");
        //    row.Add("STORE 9");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("5");
        //    row.Add("01100");
        //    row.Add("12");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("6");
        //    row.Add("01000");
        //    row.Add("8");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("7");
        //    row.Add("01010");
        //    row.Add("10");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("8");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("9");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());
        //}
        //public void div3no()
        //{


        //    MainMem.ColumnCount = 3;
        //    MainMem.Columns[0].Name = "ADDRESS";
        //    MainMem.Columns[1].Name = "DATA";
        //    MainMem.Columns[2].Name = "MNEMONIC";


        //    ArrayList row = new ArrayList();
        //    row.Add("1");
        //    row.Add("000001 00101");
        //    row.Add("LOAD 5");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("2");
        //    row.Add("000001 00110");
        //    row.Add("LOAD 6");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("3");
        //    row.Add("000111 00111");
        //    row.Add("DIV 7");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("4");
        //    row.Add("000100 01001");
        //    row.Add("STORE 9");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("5");
        //    row.Add("01100");
        //    row.Add("12");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("6");
        //    row.Add("01000");
        //    row.Add("8");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("7");
        //    row.Add("01010");
        //    row.Add("10");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("8");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("9");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());
        //}
        //public void addv16()
        //{

        //    MainMem.ColumnCount = 3;
        //    MainMem.Columns[0].Name = "ADDRESS";
        //    MainMem.Columns[1].Name = "DATA";
        //    MainMem.Columns[2].Name = "MNEMONIC";

        //    ArrayList row = new ArrayList();
        //    row.Add("0");
        //    row.Add("000001 00100");
        //    row.Add("LOAD 4");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("1");
        //    row.Add("000010 00101");
        //    row.Add("ADD 5");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("2");
        //    row.Add("000110 00110");
        //    row.Add("STORE 6");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("3");
        //    row.Add("  ");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("4");
        //    row.Add("00100");
        //    row.Add("4");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("5");
        //    row.Add("01000");
        //    row.Add("8");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("6");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("7");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("8");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());


        //}
        //public void Loadv16()
        //{
        //    for (int i = 0; i < MainMem.Rows.Count; i++)
        //    {

        //        MainMem.Rows[i].Cells[1].Value = txtal.Text;
        //        txtal.Clear();
        //        decoder.Rows.Clear();
        //        txtALU.Clear();


        //    }
        //    MainMem.ColumnCount = 3;
        //    MainMem.Columns[0].Name = "ADDRESS";
        //    MainMem.Columns[1].Name = "DATA";
        //    MainMem.Columns[1].Name = "MNEMONIC";

        //    ArrayList row = new ArrayList();
        //    row.Add("1 ");
        //    row.Add("000001 00010");
        //    row.Add("LOAD 2");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("2");
        //    row.Add("01010");
        //    row.Add("10");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("3");
        //    row.Add(" ");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("4");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());


        //}
        //public void subv16()
        //{

        //    MainMem.ColumnCount = 3;
        //    MainMem.Columns[0].Name = "ADDRESS";
        //    MainMem.Columns[1].Name = "DATA";
        //    MainMem.Columns[2].Name = "MNEMONIC";

        //    ArrayList row = new ArrayList();
        //    row.Add("0");
        //    row.Add("000001 00100");
        //    row.Add("LOAD 4");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("1");
        //    row.Add("000010 00101");
        //    row.Add("ADD 5");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("2");
        //    row.Add("000110 00110");
        //    row.Add("STORE 6");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("3");
        //    row.Add("  ");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("4");
        //    row.Add("00100");
        //    row.Add("4");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("5");
        //    row.Add("00100");
        //    row.Add("4");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("6");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("7");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("8");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());


        //}
        //public void divv16()
        //{

        //    MainMem.ColumnCount = 3;
        //    MainMem.Columns[0].Name = "ADDRESS";
        //    MainMem.Columns[1].Name = "DATA";
        //    MainMem.Columns[2].Name = "MNEMONIC";

        //    ArrayList row = new ArrayList();
        //    row.Add("0");
        //    row.Add("000001 00100");
        //    row.Add("LOAD 4");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("1");
        //    row.Add("000010 00101");
        //    row.Add("ADD 5");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("2");
        //    row.Add("000110 00110");
        //    row.Add("STORE 6");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("3");
        //    row.Add("  ");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("4");
        //    row.Add("00100");
        //    row.Add("4");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("5");
        //    row.Add("00010");
        //    row.Add("2");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("6");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("7");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("8");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());


        //}
        //public void mulv16()
        //{

        //    MainMem.ColumnCount = 3;
        //    MainMem.Columns[0].Name = "ADDRESS";
        //    MainMem.Columns[1].Name = "DATA";
        //    MainMem.Columns[2].Name = "MNEMONIC";

        //    ArrayList row = new ArrayList();
        //    row.Add("0");
        //    row.Add("000001 00100");
        //    row.Add("LOAD 4");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("1");
        //    row.Add("000010 00101");
        //    row.Add("ADD 5");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("2");
        //    row.Add("000110 00110");
        //    row.Add("STORE 6");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("3");
        //    row.Add("  ");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("4");
        //    row.Add("00100");
        //    row.Add("4");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("5");
        //    row.Add("00011");
        //    row.Add("3");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("6");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("7");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("8");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());


        //}
        //public void Storev16()
        //{

        //    MainMem.ColumnCount = 3;
        //    MainMem.Columns[0].Name = "ADDRESS";
        //    MainMem.Columns[1].Name = "DATA";
        //    MainMem.Columns[1].Name = "MNEMONIC";

        //    ArrayList row = new ArrayList();
        //    row.Add("1 ");
        //    row.Add("000001 00010");
        //    row.Add("LOAD 3");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("2");
        //    row.Add("000110 00100");
        //    row.Add("STORE 4");

        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("3");
        //    row.Add("00110");
        //    MainMem.Rows.Add(row.ToArray());

        //    row = new ArrayList();
        //    row.Add("4");
        //    row.Add("");
        //    MainMem.Rows.Add(row.ToArray());


        //}
    }
}
