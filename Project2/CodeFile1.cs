using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

// the program is made by writing a number,
// then coming out again and again until you write a zero value (0)
// and it stops and calculates the total value of all numbers entered before zero.
// If you do not enter a number, an error occurs.

class Beginer
{
    static void Main()
    {
        double anumb = 0; 
        double a = 1;
        try
        {
            while (a > 0)
            {
                a = Convert.ToDouble(Interaction.InputBox("Type a number \n If you want to stop type 0", "Изчислител"));
                anumb += a;
                if (a == 0)
                {
                    MessageBox.Show(anumb.ToString(), "Result");
                    
                }
            }
        }
        catch
        {
            MessageBox.Show("You didnt enter a number", "Error");
            
        }


    }
}
   
    