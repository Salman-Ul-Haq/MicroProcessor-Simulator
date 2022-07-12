using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJ
{
    public class _8bit
    {
        //        if (cbmp.SelectedIndex == 0)
        //            {
        //                if (tokens[0].Equals("0001")) //load
        //                {
        //                    decoder.Rows[0].Cells[0].Value = "0";
        //                    decoder.Rows[0].Cells[1].Value = "0";
        //                    decoder.Rows[0].Cells[2].Value = "0";
        //                    decoder.Rows[0].Cells[3].Value = "1";

        //                    String value = tokens[1].ToString();
        //        char[] tkvalue = value.ToCharArray();
        //        decoder.Rows[0].Cells[4].Value = tkvalue[0].ToString();
        //        decoder.Rows[0].Cells[5].Value = tkvalue[1].ToString();
        //        decoder.Rows[0].Cells[6].Value = tkvalue[2].ToString();
        //        decoder.Rows[0].Cells[7].Value = tkvalue[3].ToString();


        //        lblOPCODE.Show();
        //                    lblOPERAND.Show();

        //                    decoder.Rows[0].Cells[0].Style.BackColor = Color.Gold;
        //                    decoder.Rows[0].Cells[1].Style.BackColor = Color.Gold;
        //                    decoder.Rows[0].Cells[2].Style.BackColor = Color.Gold;
        //                    decoder.Rows[0].Cells[3].Style.BackColor = Color.Gold;

        //                    decoder.Rows[0].Cells[4].Style.BackColor = Color.Pink;
        //                    decoder.Rows[0].Cells[5].Style.BackColor = Color.Pink;
        //                    decoder.Rows[0].Cells[6].Style.BackColor = Color.Pink;
        //                    decoder.Rows[0].Cells[7].Style.BackColor = Color.Pink;
        //                    string sequenceb_addresss_bit = null;


        //                    for (int i = 0; i<MainMem.Rows.Count - 1; i++)
        //                    {



        //                        if (MainMem.Rows[i].Cells[0].Value.ToString() != null)
        //                        {
        //                            int address = int.Parse((string)MainMem.Rows[i].Cells[0].Value);
        //        char[] sequenceb_addresss_bit_arry = binaryToConverter(address);


        //                            if (sequenceb_addresss_bit_arry.Length == 3)
        //                            {
        //                                sequenceb_addresss_bit = "0";
        //                            }

        //                            if (sequenceb_addresss_bit_arry.Length == 2)
        //                            {
        //                                sequenceb_addresss_bit = "00";
        //                            }
        //if (sequenceb_addresss_bit_arry.Length == 1)
        //{
        //    sequenceb_addresss_bit = "000";
        //}

        ////if (sequenceb_addresss_bit_arry.Length < 4 && cbmp.SelectedIndex == 0)
        ////{
        ////    string message = "Can't adjust Bits, Select Large Microprocessor";
        ////    string title = "BITS are exceeded";
        ////    MessageBox.Show(message, title);
        ////    flag = false;
        ////}
        //for (int d = 0; d < sequenceb_addresss_bit_arry.Length; d++)
        //{


        //    sequenceb_addresss_bit = sequenceb_addresss_bit + sequenceb_addresss_bit_arry[d];

        //}


        //if (tokens[1].Equals(sequenceb_addresss_bit))
        //{
        //    int decno = binaryToDecimal(int.Parse((string)MainMem.Rows[i].Cells[1].Value));

        //    txtal.Text = decno.ToString();
        //    break;
        //}
        //else
        //{
        //    sequenceb_addresss_bit = null;
        //}

        //                        }
        //                        if (MainMem.Rows[i].Cells[0].Value.ToString() == null)
        //{
        //    MessageBox.Show("Memory End");
        //}
        //                    }


        //                    if (txtal.Text != null)
        //{
        //    ALUvalues.Add(txtal.Text);
        //}


        //                }
        //                else if (tokens[0].Equals("0010"))//add2no
        //{
        //    decoder.Rows.Clear();
        //    decoder.Rows[0].Cells[0].Value = "0";
        //    decoder.Rows[0].Cells[1].Value = "0";
        //    decoder.Rows[0].Cells[2].Value = "1";
        //    decoder.Rows[0].Cells[3].Value = "0";

        //    String value = tokens[1].ToString();
        //    char[] tkvalue = value.ToCharArray();

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
        //    for (int i = 0; i < MainMem.Rows.Count - 1; i++)
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
        //                break;
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
        //        int v = add.add2value(int.Parse(addvalue[0]), int.Parse(addvalue[1]));
        //        txtal.Text = v.ToString();
        //    }
        //    if (txtal.Text == "0")
        //    {
        //        ZEROtxt.BackColor = Color.Green;
        //        ZEROtxt.Text = "1";
        //    }
        //    if (txtal.Text == "0")
        //    {
        //        ZEROtxt.BackColor = Color.Green;
        //        ZEROtxt.Text = "1";
        //    }
        //    if (txtal.Text != "0")
        //    {

        //        NEGATIVEtxt.Text = "0";
        //        ZEROtxt.Text = "0";
        //        CARRYtxt.Text = "0";
        //        OVERFLOWtxt.Text = "0";

        //        ZEROtxt.BackColor = Color.Red;
        //        NEGATIVEtxt.BackColor = Color.Red;
        //        CARRYtxt.BackColor = Color.Red;
        //        OVERFLOWtxt.BackColor = Color.Red;
        //    }


        //}
        ////----------------STORE VALUES---

        //else if (tokens[0].Equals("0110"))
        //{
        //    decoder.Rows[0].Cells[0].Value = "0";
        //    decoder.Rows[0].Cells[1].Value = "1";
        //    decoder.Rows[0].Cells[2].Value = "1";
        //    decoder.Rows[0].Cells[3].Value = "0";
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



        //    for (int i = 0; i < MainMem.Rows.Count - 1; i++)

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




        //            //if (sequenceb_addresss_bit_arry.Length < 4 && cbmp.SelectedIndex == 0)
        //            //{
        //            //    string message = "Can't adjust Bits, Select Large Microprocessor";
        //            //    string title = "BITS are exceeded";
        //            //    MessageBox.Show(message, title);
        //            //    flag = false;
        //            //}
        //            for (int d = 0; d < sequenceb_addresss_bit_arry.Length; d++)
        //            {


        //                sequenceb_addresss_bit = sequenceb_addresss_bit + sequenceb_addresss_bit_arry[d];

        //            }


        //            if (tokens[1].Equals(sequenceb_addresss_bit))
        //            {
        //                //int decno = binaryToDecimal(int.Parse((string)MainMem.Rows[i].Cells[1].Value));

        //                //int addmainmemory = binaryToDecimal(int.Parse(tokens[1]));
        //                char[] bits_add = binaryToConverter(int.Parse(txtal.Text));
        //                string bits_adds = null;


        //                if (bits_add.Length == 3)
        //                {
        //                    bits_adds = "0";
        //                }

        //                if (bits_add.Length == 2)
        //                {
        //                    bits_adds = "00";
        //                }
        //                if (bits_add.Length == 1)
        //                {
        //                    bits_adds = "000";


        //                }
        //                for (int c = 0; c < bits_add.Length; c++)
        //                {


        //                    bits_adds = bits_adds + bits_add[c];

        //                }


        //                MainMem.Rows[i].Cells[1].Value = bits_adds;
        //                MainMem.Rows[i].Cells[1].Style.BackColor = Color.Aqua;
        //                //  MainMem.Rows[i].Cells[1].Value = txtal.Text;
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

        ////if (tokens[0].Equals("STORE"))
        ////{
        ////    decoder.Rows[0].Cells[0].Value = "1";
        ////    decoder.Rows[0].Cells[1].Value = "0";
        ////    decoder.Rows[0].Cells[2].Value = "1";
        ////    decoder.Rows[0].Cells[3].Value = "1";
        ////    int value = int.Parse(tokens[1].ToString());
        ////    char[] tkvalue = binaryToConverter(value);
        ////    decoder.Rows[0].Cells[4].Value = tkvalue[0].ToString();
        ////    decoder.Rows[0].Cells[5].Value = tkvalue[1].ToString();
        ////    decoder.Rows[0].Cells[6].Value = tkvalue[2].ToString();
        ////    decoder.Rows[0].Cells[7].Value = tkvalue[3].ToString();


        ////    for (int i = 0; i < MainMem.Rows.Count; i++)
        ////    {
        ////        if (tokens[1].Equals(MainMem.Rows[i].Cells[0].Value))
        ////        {

        ////            txtal.Text = MainMem.Rows[i].Cells[1].Value.ToString();
        ////        }
        ////    }
        ////    ALUvalues.Add(txtal.Text);

        ////}
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
        //    for (int i = 0; i < MainMem.Rows.Count - 1; i++)
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

        //else if (tokens[0].Equals("1001"))//mul
        //{
        //    decoder.Rows.Clear();
        //    decoder.Rows[0].Cells[0].Value = "1";
        //    decoder.Rows[0].Cells[1].Value = "0";
        //    decoder.Rows[0].Cells[2].Value = "0";
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
        //    for (int i = 0; i < MainMem.Rows.Count - 1; i++)
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
        //        int v = add.mul2value(int.Parse(addvalue[0]), int.Parse(addvalue[1]));
        //        txtal.Text = v.ToString();
        //    }
        //    if (txtal.Text == "0")
        //    {
        //        ZEROtxt.BackColor = Color.Green;
        //        ZEROtxt.Text = "1";
        //        NEGATIVEtxt.Text = "0";
        //        CARRYtxt.Text = "0";
        //        OVERFLOWtxt.Text = "0";
        //        NEGATIVEtxt.BackColor = Color.Red;
        //        CARRYtxt.BackColor = Color.Red;
        //        OVERFLOWtxt.BackColor = Color.Red;

        //    }
        //}
        //else if (tokens[0].Equals("1010"))//div
        //{
        //    decoder.Rows.Clear();
        //    decoder.Rows[0].Cells[0].Value = "1";
        //    decoder.Rows[0].Cells[1].Value = "0";
        //    decoder.Rows[0].Cells[2].Value = "1";
        //    decoder.Rows[0].Cells[3].Value = "0";

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
        //    for (int i = 0; i < MainMem.Rows.Count - 1; i++)
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
        //        int v = add.div2value(int.Parse(addvalue[0]), int.Parse(addvalue[1]));
        //        txtal.Text = v.ToString();
        //    }
        //    if (txtal.Text == "0")
        //    {
        //        ZEROtxt.BackColor = Color.Green;
        //        ZEROtxt.Text = "1";
        //    }
        //    if (txtal.Text != "0")
        //    {

        //        NEGATIVEtxt.Text = "0";
        //        ZEROtxt.Text = "0";
        //        CARRYtxt.Text = "0";
        //        OVERFLOWtxt.Text = "0";

        //        ZEROtxt.BackColor = Color.Red;
        //        NEGATIVEtxt.BackColor = Color.Red;
        //        CARRYtxt.BackColor = Color.Red;
        //        OVERFLOWtxt.BackColor = Color.Red;
        //    }
        //}
        //            }
        //    
    }
}
