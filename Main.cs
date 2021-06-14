using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputDataApplication
{
    public partial class Main : Form
    {
        public static int index = 0;
        public Main()
        {
            InitializeComponent();
        }

        public void anotherFunc(object sender)
        {
            InputData s = new InputData();
            pn_Input.Controls.Add(s);
            if (sender is InputData)
            {
                pn_Input.Controls.SetChildIndex(s, pn_Input.Controls.GetChildIndex((sender as InputData)) + 1);
            }
            s.makeM += anotherFunc;
            s.deleteCtr += deleteAItem ;
            s.TabIndex = index;
            index++;
            s.tabToNew += checkTab;
            resetIndexAndTabIndex();

        }
        public void deleteAItem(int item)
        {
            pn_Input.Controls.RemoveAt(item);
        }
        public void resetIndexAndTabIndex()
        {

            for (int i = 0; i < pn_Input.Controls.Count; i++)
            {
                (pn_Input.Controls[i] as InputData).TabIndex = index = i;

            }
        }



        private void btn_Load_Click(object sender, EventArgs e)
        {
            uC_Image1.LoadImage("http://10.10.1.15:8888/DemoImage/663524651_2.jpeg", "663524651_2.jpeg");
        }

        private void Main_Load_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                this.anotherFunc(null);

            }
        }
        public void checkTab(object sender)
        {
            this.anotherFunc(null);
        }

        private void pn_Input_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
         
            }
        }
    }


