using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ParallelQuickSort.Gui
{
    public partial class QuickSortForm : Form
    {
        public QuickSortForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numItemsValue = (int)numItems.Value;
            
            for (int i = 0; i < numItemsValue; i++)
            {
                items.Items.Add(new Random((int)DateTime.Now.Ticks).Next());
                Thread.Sleep(1);
            }
        }

        private void sortItems_Click(object sender, EventArgs e)
        {
            var quickSortClass = new ParallelQuickSort();
            quickSortClass.Numbers = items.Items.Cast<int>().ToList<int>();
            quickSortClass.Sort();
        }
    }
}
