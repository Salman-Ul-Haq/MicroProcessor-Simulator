using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJ
{
    internal class _16bit
    {
        //----------------------------------------------------16 bit--------------------------------------------------



        //    else if (cbmp.SelectedIndex == 1)
        //    {
        //        while (pause)
        //        {

        //            //if (MainMem.Row[row]!=0)
        //            //{ 
        //            pc.Text = MainMem.Rows[row].Cells[column].Value.ToString();
        //            pc.BackColor = Color.Yellow;
        //            //}
        //            txtmdr.Text = MainMem.Rows[prow].Cells[column + 1].Value.ToString();
        //            txtmdr.BackColor = Color.LightGreen;


        //            if (pause && row != 0)
        //            {

        //                txtmdr.Text = MainMem.Rows[prow].Cells[column + 1].Value.ToString();
        //                txtmar.Text = MainMem.Rows[prow].Cells[column].Value.ToString();
        //                txtmar.BackColor = Color.LightBlue;
        //                pause = false;
        //            }



        //            prow = row;
        //            row++;


        //        }
        //        string tok = txtmdr.Text;
        //        String[] tokens = tok.Split(' ');

        //        if (tokens[0].Equals("LOAD"))
        //        {
        //            decoder.Rows[0].Cells[0].Value = "0";
        //            decoder.Rows[0].Cells[1].Value = "0";
        //            decoder.Rows[0].Cells[2].Value = "0";
        //            decoder.Rows[0].Cells[3].Value = "0";
        //            decoder.Rows[0].Cells[4].Value = "0";
        //            decoder.Rows[0].Cells[5].Value = "0";
        //            decoder.Rows[0].Cells[6].Value = "1"; 
        //            int op1 = int.Parse(tokens[1].ToString());
        //            char[] tkvalue1 = binaryToConverter(op1);


        //            if (tkvalue1.Length == 4)
        //            {

        //                decoder.Rows[0].Cells[7].Value = "0";
        //                decoder.Rows[0].Cells[8].Value = "0";
        //                decoder.Rows[0].Cells[9].Value = "0";
        //                decoder.Rows[0].Cells[10].Value = "0";
        //                decoder.Rows[0].Cells[11].Value = "0";
        //                decoder.Rows[0].Cells[12].Value = tkvalue1[0].ToString();
        //                decoder.Rows[0].Cells[13].Value = tkvalue1[1].ToString();
        //                decoder.Rows[0].Cells[14].Value = tkvalue1[2].ToString();
        //                decoder.Rows[0].Cells[15].Value = tkvalue1[3].ToString();
        //            }
        //            else if (tkvalue1.Length == 5)
        //            {

        //                decoder.Rows[0].Cells[7].Value = "0";
        //                decoder.Rows[0].Cells[8].Value = "0";
        //                decoder.Rows[0].Cells[9].Value = "0";
        //                decoder.Rows[0].Cells[10].Value = "0";
        //                decoder.Rows[0].Cells[11].Value = tkvalue1[0].ToString();
        //                decoder.Rows[0].Cells[12].Value = tkvalue1[1].ToString();
        //                decoder.Rows[0].Cells[13].Value = tkvalue1[2].ToString();
        //                decoder.Rows[0].Cells[14].Value = tkvalue1[3].ToString();
        //                decoder.Rows[0].Cells[15].Value = tkvalue1[4].ToString();
        //            }
        //            else if (tkvalue1.Length == 6)
        //            {

        //                decoder.Rows[0].Cells[7].Value = "0";
        //                decoder.Rows[0].Cells[8].Value = "0";
        //                decoder.Rows[0].Cells[9].Value = "0";
        //                decoder.Rows[0].Cells[10].Value = tkvalue1[0].ToString();
        //                decoder.Rows[0].Cells[11].Value = tkvalue1[1].ToString();
        //                decoder.Rows[0].Cells[12].Value = tkvalue1[2].ToString();
        //                decoder.Rows[0].Cells[13].Value = tkvalue1[3].ToString();
        //                decoder.Rows[0].Cells[14].Value = tkvalue1[4].ToString();
        //                decoder.Rows[0].Cells[15].Value = tkvalue1[5].ToString();
        //            }
        //            else if (tkvalue1.Length == 7)
        //            {

        //                decoder.Rows[0].Cells[7].Value = "0";
        //                decoder.Rows[0].Cells[8].Value = "0";
        //                decoder.Rows[0].Cells[9].Value = tkvalue1[0].ToString();
        //                decoder.Rows[0].Cells[10].Value = tkvalue1[1].ToString();
        //                decoder.Rows[0].Cells[11].Value = tkvalue1[2].ToString();
        //                decoder.Rows[0].Cells[12].Value = tkvalue1[3].ToString();
        //                decoder.Rows[0].Cells[13].Value = tkvalue1[4].ToString();
        //                decoder.Rows[0].Cells[14].Value = tkvalue1[5].ToString();
        //                decoder.Rows[0].Cells[15].Value = tkvalue1[6].ToString();
        //            }
        //            else if (tkvalue1.Length == 8)
        //            {

        //                decoder.Rows[0].Cells[7].Value = "0";
        //                decoder.Rows[0].Cells[8].Value = tkvalue1[0].ToString();
        //                decoder.Rows[0].Cells[9].Value = tkvalue1[1].ToString();
        //                decoder.Rows[0].Cells[10].Value = tkvalue1[2].ToString();
        //                decoder.Rows[0].Cells[11].Value = tkvalue1[3].ToString();
        //                decoder.Rows[0].Cells[12].Value = tkvalue1[4].ToString();
        //                decoder.Rows[0].Cells[13].Value = tkvalue1[5].ToString();
        //                decoder.Rows[0].Cells[14].Value = tkvalue1[6].ToString();
        //                decoder.Rows[0].Cells[15].Value = tkvalue1[7].ToString();
        //            }
        //            else if (tkvalue1.Length == 9)
        //            {

        //                decoder.Rows[0].Cells[7].Value = tkvalue1[0].ToString();
        //                decoder.Rows[0].Cells[8].Value = tkvalue1[1].ToString();
        //                decoder.Rows[0].Cells[9].Value = tkvalue1[2].ToString();
        //                decoder.Rows[0].Cells[10].Value = tkvalue1[3].ToString();
        //                decoder.Rows[0].Cells[11].Value = tkvalue1[4].ToString();
        //                decoder.Rows[0].Cells[12].Value = tkvalue1[5].ToString();
        //                decoder.Rows[0].Cells[13].Value = tkvalue1[6].ToString();
        //                decoder.Rows[0].Cells[14].Value = tkvalue1[7].ToString();
        //                decoder.Rows[0].Cells[15].Value = tkvalue1[8].ToString();
        //            }
        //            else if (tkvalue1.Length == 10)
        //            {

        //                decoder.Rows[0].Cells[7].Value = tkvalue1[0].ToString();
        //                decoder.Rows[0].Cells[8].Value = tkvalue1[1].ToString();
        //                decoder.Rows[0].Cells[9].Value = tkvalue1[2].ToString();
        //                decoder.Rows[0].Cells[10].Value = tkvalue1[3].ToString();
        //                decoder.Rows[0].Cells[11].Value = tkvalue1[4].ToString();
        //                decoder.Rows[0].Cells[12].Value = tkvalue1[5].ToString();
        //                decoder.Rows[0].Cells[13].Value = tkvalue1[6].ToString();
        //                decoder.Rows[0].Cells[14].Value = tkvalue1[7].ToString();
        //                decoder.Rows[0].Cells[15].Value = tkvalue1[8].ToString();
        //            }


        //            for (int i = 0; i < MainMem.Rows.Count; i++)
        //            {
        //                if (tokens[1].Equals(MainMem.Rows[i].Cells[0].Value))
        //                {

        //                    txtal.Text = MainMem.Rows[i].Cells[1].Value.ToString();
        //                }
        //            }
        //            ALUvalues.Add(txtal.Text);

        //        }
        //        else if (tokens[0].Equals("ADD"))
        //        {
        //            decoder.Rows.Clear();
        //            decoder.Rows[0].Cells[0].Value = "0";
        //            decoder.Rows[0].Cells[1].Value = "0";
        //            decoder.Rows[0].Cells[2].Value = "0";
        //            decoder.Rows[0].Cells[3].Value = "0";
        //            decoder.Rows[0].Cells[4].Value = "1";
        //            decoder.Rows[0].Cells[5].Value = "1";



        //            int value = int.Parse(tokens[1].ToString());
        //            char[] tkvalue = binaryToConverter(value);
        //            if (tkvalue.Length == 5)
        //            {
        //                decoder.Rows[0].Cells[6].Value = tkvalue[0].ToString();
        //                decoder.Rows[0].Cells[7].Value = tkvalue[1].ToString();
        //                decoder.Rows[0].Cells[8].Value = tkvalue[2].ToString();
        //                decoder.Rows[0].Cells[9].Value = tkvalue[3].ToString();
        //                decoder.Rows[0].Cells[10].Value = tkvalue[4].ToString();
        //            }
        //            else if (tkvalue.Length == 4)
        //            {
        //                decoder.Rows[0].Cells[6].Value = "0";
        //                decoder.Rows[0].Cells[7].Value = tkvalue[0].ToString();
        //                decoder.Rows[0].Cells[8].Value = tkvalue[1].ToString();
        //                decoder.Rows[0].Cells[9].Value = tkvalue[2].ToString();
        //                decoder.Rows[0].Cells[10].Value = tkvalue[3].ToString();

        //            }
        //            if (tokens.Length == 3)
        //            {
        //                int value1 = int.Parse(tokens[2].ToString());

        //                char[] tkvalue1 = binaryToConverter(value1);
        //                if (tkvalue.Length == 5)
        //                {
        //                    decoder.Rows[0].Cells[11].Value = tkvalue[0].ToString();
        //                    decoder.Rows[0].Cells[12].Value = tkvalue[1].ToString();
        //                    decoder.Rows[0].Cells[13].Value = tkvalue[2].ToString();
        //                    decoder.Rows[0].Cells[14].Value = tkvalue[3].ToString();
        //                    decoder.Rows[0].Cells[15].Value = tkvalue[4].ToString();
        //                }
        //                else if (tkvalue.Length == 4)
        //                {
        //                    decoder.Rows[0].Cells[11].Value = "0";
        //                    decoder.Rows[0].Cells[12].Value = tkvalue[0].ToString();
        //                    decoder.Rows[0].Cells[13].Value = tkvalue[1].ToString();
        //                    decoder.Rows[0].Cells[14].Value = tkvalue[2].ToString();
        //                    decoder.Rows[0].Cells[15].Value = tkvalue[3].ToString();
        //                }
        //            }
        //            else
        //            {
        //                decoder.Rows[0].Cells[11].Value = "0";
        //                decoder.Rows[0].Cells[12].Value = "0";
        //                decoder.Rows[0].Cells[13].Value = "0";
        //                decoder.Rows[0].Cells[14].Value = "0";
        //                decoder.Rows[0].Cells[15].Value = "0";
        //            }

        //            for (int i = 0; i < MainMem.Rows.Count; i++)
        //            {
        //                if (tokens[1].Equals(MainMem.Rows[i].Cells[0].Value))
        //                {

        //                    txtal.Text = MainMem.Rows[i].Cells[1].Value.ToString();
        //                }
        //            }


        //            ALUvalues.Add(txtal.Text);

        //            for (int i = 0; i < ALUvalues.Count; i++)
        //            {
        //                txtALU.Text = ALUvalues[i] + "\n" + txtALU.Text;

        //            }
        //            ALU add = new ALU();

        //            String[] addvalue = txtALU.Text.Split("\n");

        //            int cno = 0;

        //            for (int c = 0; c < addvalue.Length; c++)
        //            {
        //                if (addvalue[c] != "")
        //                {
        //                    cno++;
        //                }
        //            }

        //            if (cno == 2)
        //            {
        //                int v = add.add2value(int.Parse(addvalue[0]), int.Parse(addvalue[1]));
        //                txtal.Text = v.ToString();

        //            }

        //        }
        //    }

        //jumpdend:;
        //else if (tokens[0].Equals("0011")) //sub2no
        //{
        //    decoder.Rows.Clear();
        //    decoder.Rows[0].Cells[0].Value = "0";
        //    decoder.Rows[0].Cells[1].Value = "0";
        //    decoder.Rows[0].Cells[2].Value = "1";
        //    decoder.Rows[0].Cells[3].Value = "1";

        //    String value = tokens[1].ToString();
        //    char[] tkvalue = value.ToCharArray();
        //    decoder.Rows[0].Cells[4].Value = tkvalue[0].ToString();
        //    decoder.Rows[0].Cells[5].Value = tkvalue[1].ToString();
        //    decoder.Rows[0].Cells[6].Value = tkvalue[2].ToString();
        //    decoder.Rows[0].Cells[7].Value = tkvalue[3].ToString();


        //    decoder.Rows[0].Cells[0].Style.BackColor = Color.Gold;
        //    decoder.Rows[0].Cells[1].Style.BackColor = Color.Gold;
        //    decoder.Rows[0].Cells[2].Style.BackColor = Color.Gold;
        //    decoder.Rows[0].Cells[3].Style.BackColor = Color.Gold;

        //    decoder.Rows[0].Cells[4].Style.BackColor = Color.Pink;
        //    decoder.Rows[0].Cells[5].Style.BackColor = Color.Pink;
        //    decoder.Rows[0].Cells[6].Style.BackColor = Color.Pink;
        //    decoder.Rows[0].Cells[7].Style.BackColor = Color.Pink;
        //    string sequenceb_addresss_bit = null;
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
        //            if (sequenceb_addresss_bit_arry.Length == 2)
        //            {
        //                sequenceb_addresss_bit = "00";
        //            }
        //            if (sequenceb_addresss_bit_arry.Length == 1)
        //            {
        //                sequenceb_addresss_bit = "000";
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


        //    for (int i = 0; i < ALUvalues.Count; i++)
        //    {
        //        txtALU.Text = ALUvalues[i] + "\n" + txtALU.Text;

        //    }
        //    ALU add = new ALU();

        //    String[] addvalue = txtALU.Text.Split("\n");

        //    int cno = 0;

        //    for (int c = 0; c < addvalue.Length; c++)
        //    {
        //        if (addvalue[c] != "")
        //        {
        //            cno++;
        //        }
        //    }

        //    if (cno == 2)
        //    {
        //        int v = add.sub2value(int.Parse(addvalue[0]), int.Parse(addvalue[1]));
        //        txtal.Text = v.ToString();
        //    }
        //    if (txtal.Text == "0")
        //    {
        //        ZEROtxt.BackColor = Color.LightGreen;
        //        ZEROtxt.Text = "1";
        //        NEGATIVEtxt.Text = "0";
        //        CARRYtxt.Text = "0";
        //        OVERFLOWtxt.Text = "0";

        //        NEGATIVEtxt.BackColor = Color.Red;
        //        CARRYtxt.BackColor = Color.Red;
        //        OVERFLOWtxt.BackColor = Color.Red;
        //    }
        //}
        //else if (tokens[0].Equals("0010"))//add2no
        //{
        //    decoder.Rows.Clear();
        //    decoder.Rows[0].Cells[0].Value = "0";
        //    decoder.Rows[0].Cells[1].Value = "0";
        //    decoder.Rows[0].Cells[2].Value = "0";
        //    decoder.Rows[0].Cells[3].Value = "0";
        //    decoder.Rows[0].Cells[4].Value = "1";
        //    decoder.Rows[0].Cells[5].Value = "0";

        //    decoder.Rows[0].Cells[6].Value = "0";
        //    decoder.Rows[0].Cells[7].Value = "0";
        //    decoder.Rows[0].Cells[8].Value = "1";
        //    decoder.Rows[0].Cells[9].Value = "0";
        //    decoder.Rows[0].Cells[10].Value = "0";

        //    decoder.Rows[0].Cells[11].Value = "0";
        //    decoder.Rows[0].Cells[12].Value = "1";
        //    decoder.Rows[0].Cells[13].Value = "0";
        //    decoder.Rows[0].Cells[14].Value = "0";
        //    decoder.Rows[0].Cells[15].Value = "0";

        //    //String value1 = tokens[1].ToString(); //OPERAND 1
        //    //char[] tkvalue1 = value1.ToCharArray();

        //    //decoder.Rows[0].Cells[6].Value = tkvalue1[6].ToString();
        //    //decoder.Rows[0].Cells[7].Value = tkvalue1[7].ToString();
        //    //decoder.Rows[0].Cells[8].Value = tkvalue1[8].ToString();
        //    //decoder.Rows[0].Cells[9].Value = tkvalue1[9].ToString();
        //    //decoder.Rows[0].Cells[10].Value = tkvalue1[10].ToString();
        //    //decoder.Rows[0].Cells[11].Value = tkvalue1[11 ].ToString();

        //    ////String value2 = tokens[1].ToString(); //OPERAND 2
        //    ////char[] tkvalue2 = value2.ToCharArray();

        //    //decoder.Rows[0].Cells[6].Value = tkvalue2[0].ToString();
        //    //decoder.Rows[0].Cells[7].Value = tkvalue2[1].ToString();
        //    //decoder.Rows[0].Cells[8].Value = tkvalue2[2].ToString();
        //    //decoder.Rows[0].Cells[9].Value = tkvalue2[3].ToString();
        //    //decoder.Rows[0].Cells[10].Value = tkvalue2[2].ToString();
        //    //decoder.Rows[0].Cells[11].Value = tkvalue2[3].ToString();




        //    lblOPCODE.Show();
        //    lblOPERAND.Show();

        //    decoder.Rows[0].Cells[0].Style.BackColor = Color.Gold;
        //    decoder.Rows[0].Cells[1].Style.BackColor = Color.Gold;
        //    decoder.Rows[0].Cells[2].Style.BackColor = Color.Gold;
        //    decoder.Rows[0].Cells[3].Style.BackColor = Color.Gold;
        //    decoder.Rows[0].Cells[4].Style.BackColor = Color.Gold;
        //    decoder.Rows[0].Cells[5].Style.BackColor = Color.Gold;

        //    decoder.Rows[0].Cells[6].Style.BackColor = Color.Pink;
        //    decoder.Rows[0].Cells[7].Style.BackColor = Color.Pink;
        //    decoder.Rows[0].Cells[8].Style.BackColor = Color.Pink;
        //    decoder.Rows[0].Cells[9].Style.BackColor = Color.Pink;
        //    decoder.Rows[0].Cells[10].Style.BackColor = Color.Pink;

        //    decoder.Rows[0].Cells[11].Style.BackColor = Color.Brown;
        //    decoder.Rows[0].Cells[12].Style.BackColor = Color.Brown;
        //    decoder.Rows[0].Cells[13].Style.BackColor = Color.Brown;
        //    decoder.Rows[0].Cells[14].Style.BackColor = Color.Brown;
        //    decoder.Rows[0].Cells[15].Style.BackColor = Color.Brown;
        //    //string sequenceb_addresss_bit = null;
        //for (int i = 0; i < MainMem.Rows.Count; i++)
        //{

        //    if (MainMem.Rows[i].Cells[0].Value.ToString() != null)
        //    {
        //        int address = int.Parse((string)MainMem.Rows[i].Cells[0].Value);
        //        char[] sequenceb_addresss_bit_arry = binaryToConverter(address);


        //        if (sequenceb_addresss_bit_arry.Length == 5)
        //        {
        //            sequenceb_addresss_bit = "0";
        //        }

        //        if (sequenceb_addresss_bit_arry.Length == 5)
        //        {
        //            sequenceb_addresss_bit = "00";
        //        }

        //        if (sequenceb_addresss_bit_arry.Length == 3)
        //        {
        //            sequenceb_addresss_bit = "000";
        //        }
        //        if (sequenceb_addresss_bit_arry.Length == 2)
        //        {
        //            sequenceb_addresss_bit = "0000";
        //        }
        //        if (sequenceb_addresss_bit_arry.Length == 1)
        //        {
        //            sequenceb_addresss_bit = "00000";
        //        }

        //        for (int d = 0; d < sequenceb_addresss_bit_arry.Length; d++)
        //        {


        //            sequenceb_addresss_bit = sequenceb_addresss_bit + sequenceb_addresss_bit_arry[d];

        //        }


        //        if (tokens[1].Equals(sequenceb_addresss_bit))
        //        {
        //            int decno = binaryToDecimal(int.Parse((string)MainMem.Rows[i].Cells[1].Value));

        //            txtal.Text = decno.ToString();
        //        }
        //        else
        //        {
        //            sequenceb_addresss_bit = null;
        //        }
        //    }


        //}

        //        if (txtal.Text != null)
        //        {
        //            ALUvalues.Add(txtal.Text);
        //        }


        //        for (int i = 0; i < ALUvalues.Count; i++)
        //        {
        //            txtALU.Text = ALUvalues[i] + "\n" + txtALU.Text;

        //        }
        //        ALU add = new ALU();

        //        String[] addvalue = txtALU.Text.Split("\n");

        //        int cno = 0;

        //        for (int c = 0; c < addvalue.Length; c++)
        //        {
        //            if (addvalue[c] != "")
        //            {
        //                cno++;
        //            }
        //        }

        //        if (cno == 2)
        //        {
        //            int v = add.add2value(int.Parse(addvalue[0]), int.Parse(addvalue[1]));
        //            txtal.Text = v.ToString();
        //        }
        //        if (txtal.Text == "0")
        //        {
        //            ZEROtxt.BackColor = Color.Green;
        //            ZEROtxt.Text = "1";
        //        }
        //        if (txtal.Text == "0")
        //        {
        //            ZEROtxt.BackColor = Color.Green;
        //            ZEROtxt.Text = "1";
        //        }
        //        if (txtal.Text != "0")
        //        {

        //            NEGATIVEtxt.Text = "0";
        //            ZEROtxt.Text = "0";
        //            CARRYtxt.Text = "0";
        //            OVERFLOWtxt.Text = "0";

        //            ZEROtxt.BackColor = Color.Red;
        //            NEGATIVEtxt.BackColor = Color.Red;
        //            CARRYtxt.BackColor = Color.Red;
        //            OVERFLOWtxt.BackColor = Color.Red;
        //        }

        //    }

        //}
    }
}
