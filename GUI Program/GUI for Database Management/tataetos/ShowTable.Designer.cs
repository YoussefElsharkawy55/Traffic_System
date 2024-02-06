
namespace tataetos
{
    partial class ShowTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowTable));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.queryL = new System.Windows.Forms.Label();
            this.queryTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 87);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(712, 284);
            this.dataGrid.TabIndex = 0;
            // 
            // queryL
            // 
            this.queryL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.queryL.AutoSize = true;
            this.queryL.BackColor = System.Drawing.Color.Transparent;
            this.queryL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryL.ForeColor = System.Drawing.Color.Gold;
            this.queryL.Location = new System.Drawing.Point(21, 21);
            this.queryL.Name = "queryL";
            this.queryL.Size = new System.Drawing.Size(51, 20);
            this.queryL.TabIndex = 2;
            this.queryL.Text = "Query";
            // 
            // queryTB
            // 
            this.queryTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.queryTB.BackColor = System.Drawing.Color.Cornsilk;
            this.queryTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryTB.Location = new System.Drawing.Point(25, 44);
            this.queryTB.Name = "queryTB";
            this.queryTB.Size = new System.Drawing.Size(688, 26);
            this.queryTB.TabIndex = 1;
            // 
            // ShowTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 383);
            this.Controls.Add(this.queryL);
            this.Controls.Add(this.queryTB);
            this.Controls.Add(this.dataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowTable";
            this.Text = "ShowTable";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label queryL;
        private System.Windows.Forms.TextBox queryTB;
    }
}