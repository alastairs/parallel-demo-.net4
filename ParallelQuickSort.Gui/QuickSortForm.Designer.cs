namespace ParallelQuickSort.Gui
{
    partial class QuickSortForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numItemsLbl = new System.Windows.Forms.Label();
            this.numItems = new System.Windows.Forms.NumericUpDown();
            this.items = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.generateItems = new System.Windows.Forms.Button();
            this.sortItems = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numItems)).BeginInit();
            this.SuspendLayout();
            // 
            // numItemsLbl
            // 
            this.numItemsLbl.AutoSize = true;
            this.numItemsLbl.Location = new System.Drawing.Point(12, 14);
            this.numItemsLbl.Name = "numItemsLbl";
            this.numItemsLbl.Size = new System.Drawing.Size(143, 13);
            this.numItemsLbl.TabIndex = 0;
            this.numItemsLbl.Text = "Number of items to generate:";
            // 
            // numItems
            // 
            this.numItems.Location = new System.Drawing.Point(164, 12);
            this.numItems.Name = "numItems";
            this.numItems.Size = new System.Drawing.Size(51, 20);
            this.numItems.TabIndex = 1;
            this.numItems.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // items
            // 
            this.items.FormattingEnabled = true;
            this.items.Location = new System.Drawing.Point(12, 91);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(201, 95);
            this.items.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Items:";
            // 
            // generateItems
            // 
            this.generateItems.Location = new System.Drawing.Point(140, 38);
            this.generateItems.Name = "generateItems";
            this.generateItems.Size = new System.Drawing.Size(75, 23);
            this.generateItems.TabIndex = 4;
            this.generateItems.Text = "Generate";
            this.generateItems.UseVisualStyleBackColor = true;
            this.generateItems.Click += new System.EventHandler(this.button1_Click);
            // 
            // sortItems
            // 
            this.sortItems.Location = new System.Drawing.Point(12, 192);
            this.sortItems.Name = "sortItems";
            this.sortItems.Size = new System.Drawing.Size(75, 23);
            this.sortItems.TabIndex = 5;
            this.sortItems.Text = "Sort";
            this.sortItems.UseVisualStyleBackColor = true;
            this.sortItems.Click += new System.EventHandler(this.sortItems_Click);
            // 
            // QuickSortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 229);
            this.Controls.Add(this.sortItems);
            this.Controls.Add(this.generateItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.items);
            this.Controls.Add(this.numItems);
            this.Controls.Add(this.numItemsLbl);
            this.Name = "QuickSortForm";
            this.Text = "Parallel Quick Sort demo";
            ((System.ComponentModel.ISupportInitialize)(this.numItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numItemsLbl;
        private System.Windows.Forms.NumericUpDown numItems;
        private System.Windows.Forms.ListBox items;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generateItems;
        private System.Windows.Forms.Button sortItems;
    }
}

