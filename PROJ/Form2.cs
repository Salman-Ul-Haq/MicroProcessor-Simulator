using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJ
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtIns.Text = "****8 bit**** " +
                "\n #Format " +
                "\n"+
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
                "\n 1011     STORE A (ADDRESS)"+
                "\n 1100	 ---" +
                "\n 1101     ---" +
                "\n 1110     ---" +
                "\n 1111     ---" ;

        }

        private void btn16bit_Click(object sender, EventArgs e)
        {
            txtIns.Text = "****16 bit**** " +
    "\n #Format " +
    "\n" +
    "\n Opcode 	      Operand-1   Operand-2 " +
    "\n 000000     00000            00000" +
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
    "\n 000111     MUL A (ADDRESS) " +
    "\n 001000     MUL X (VALUE) " +
    "\n 001001     DIV A (ADDRESS)" +
    "\n 001011     STORE A (ADDRESS)" +
    "\n 001100	 ---" +
    "\n 001101     ---" +
    "\n 001110     ---" +
    "\n 001111     ---";
        }

        private void txtIns_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
