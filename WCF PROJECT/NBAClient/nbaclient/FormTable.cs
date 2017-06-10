using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WcfDuplexServiceClient
{
    public partial class FormTable : Form
    {
        public string RegionTable { get; set; }
        public FormTable()
        {
            InitializeComponent();
        }


        private void FormTable_Load(object sender, EventArgs e)
        {
            labelRegion.Text = RegionTable;
            UploadTable();
        }

        /// <summary>
        /// upload the table of specific region
        /// </summary>
        private void UploadTable()
        {
            foreach (var team in Program._proxy.UploadTableLeague(RegionTable))
            {
                
                dataGridViewTable.Rows.Add(team);
             
            }
            dataGridViewTable.Sort(dataGridViewTable.Columns[4], ListSortDirection.Descending);
        }
    }
}
