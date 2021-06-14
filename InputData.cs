using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputDataApplication
{
    public partial class InputData : UserControl
    {
        public InputData()
        {
            InitializeComponent();
        }
        public delegate void deleteCtro(int ctrl);
        public delegate void makeMore(object ctrl);
        public event makeMore makeM;
        public event makeMore tabToNew;
        public  event deleteCtro deleteCtr;



        private void txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtSubject_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (ch == 46 && txtSubject.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }


        public void txt_Name_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void txt_value_ValueChanged(object sender, EventArgs e)
        {
        

        }

        private void txtSubject_TextChanged(object sender, EventArgs e)
        {
        
        }

   
        private void lb_Add_Click(object sender, EventArgs e)
        {
            makeM?.Invoke(this);
        }

        private void txtSubject_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void txtSubject_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {


            FlowLayoutPanel flp = this.Parent as FlowLayoutPanel;
            switch (e.KeyCode)
            {

                case Keys.Tab:
                    int i = flp.Controls.GetChildIndex(this);
                    if (i == flp.Controls.Count - 1)
                        tabToNew?.Invoke(this);
                    foreach (var item in flp.Controls)
                    {
                        var itemCall = (item as InputData);
                        if(item is InputData)
                        {
                            if (flp.Controls.GetChildIndex(itemCall) == (i + 1))
                                (itemCall).txt_Name.SelectAll();
                        }
                    }            
                    break;
                case Keys.Down:

                   i = flp.Controls.GetChildIndex(this);
                    foreach (var item in flp.Controls)
                    {
                        var itemCall = (item as InputData);
                        if (item is InputData)
                            if (flp.Controls.GetChildIndex(itemCall) == (i + 1))
                                (itemCall).txtSubject.Focus();
                    }
                    break;
                case Keys.Right:
                    txt_Name.Focus();
                    break;
                case Keys.Up:
                    i = flp.Controls.GetChildIndex(this);
                    foreach (var item in flp.Controls)
                    {
                        var itemCall = (item as InputData);
                        if (item is InputData)
                            if (flp.Controls.GetChildIndex(itemCall) == (i - 1))
                                (itemCall).txtSubject.Focus();
                    }
                    break;
                case Keys.Left:
                    txt_value.Focus();
                    break;
            }
        }

        private void InputData_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void txt_Name_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            FlowLayoutPanel flp = this.Parent as FlowLayoutPanel;
            switch (e.KeyCode)
            {
                case Keys.Tab:
                    txt_value.SelectAll();
                    break;
                case Keys.Down:

                    int i = flp.Controls.GetChildIndex(this);
                    foreach (var item in flp.Controls)
                    {
                        var itemCall = (item as InputData);
                        if (item is InputData)
                            if (flp.Controls.GetChildIndex(itemCall) == (i + 1))
                                (itemCall).txt_Name.Focus();
                    }


                    break;
                case Keys.Right:
                    txt_value.Focus();
                    break;
                case Keys.Up:
                    i = flp.Controls.GetChildIndex(this);
                    foreach (var item in flp.Controls)
                    {
                        var itemCall = (item as InputData);
                        if (item is InputData)
                            if (flp.Controls.GetChildIndex(itemCall) == (i - 1))
                                (itemCall).txt_Name.Focus();
                    }
                    break;
                case Keys.Left:
                    txtSubject.Focus();
                    break;
            }
        }

        private void txt_value_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            FlowLayoutPanel flp = this.Parent as FlowLayoutPanel;
            switch (e.KeyCode)
            {
                case Keys.Tab:
                    txtSubject.SelectAll();
                    break;
                case Keys.Down:

                    int i = flp.Controls.GetChildIndex(this);
                    foreach (var item in flp.Controls)
                    {
                        var itemCall = (item as InputData);
                        if (item is InputData)
                            if (flp.Controls.GetChildIndex(itemCall) == (i + 1))
                                (itemCall).txt_value.Focus();
                    }


                    break;
                case Keys.Right:
                    txtSubject.Focus();
                    break;
                case Keys.Up:
                    i = flp.Controls.GetChildIndex(this);
                    foreach (var item in flp.Controls)
                    {
                        var itemCall = (item as InputData);
                        if (item is InputData)
                            if (flp.Controls.GetChildIndex(itemCall) == (i- 1))
                                (itemCall).txt_value.Focus();
                    }
                    break;
                case Keys.Left:
                    txt_Name.Focus();
                    break;
            }
        }

        private void lb_Delete_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flp = this.Parent as FlowLayoutPanel;
            int i = flp.Controls.GetChildIndex(this);
            deleteCtr?.Invoke(i);
        }

        private void InputData_Load(object sender, EventArgs e)
        {

        }
    }
}

//I can do that