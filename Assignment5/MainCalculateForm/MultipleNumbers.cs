using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainCalculateForm
{
    public partial class MultipleNumbers : UserControl
    {
        public MultipleNumbers()
        {
            InitializeComponent();
        }
        // Properties
        public string A
        {
            get { return txt_a.Text; }
        }
        public string B
        {
            get { return txt_b.Text; }
        }
        public string C
        {
            get { return txt_c.Text; }
        }
        private void btn_calculate_Click(object sender, EventArgs e)
        {
            decimal a, b, c, rel;
            a = ConvertToDecimal(A);
            b = ConvertToDecimal(B);
            c = ConvertToDecimal(C);
            rel = a * b * c;
            lbl_MultipleResult.Text = rel.ToString();
        }

        private decimal ConvertToDecimal(string num)
        {
            decimal rel;
            if (Decimal.TryParse(num, out rel))
            {
                return rel;
            }
            else
            {
                throw new Exception("please put only numbers");
            }
        }
    }
}
