using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FejlFinder
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }
        #region På begivenhed
        private void btnOpfriske_Click(object sender, EventArgs e)
        {
            Løb();
        }
        
        #endregion


        #region Hovedbegivenhed
        private void Løb()
        {

        }

        #endregion
    }
}
