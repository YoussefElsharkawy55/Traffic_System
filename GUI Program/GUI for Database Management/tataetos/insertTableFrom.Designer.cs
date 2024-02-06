
namespace tataetos
{
    partial class insertTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(insertTableForm));
            this.insertData = new System.Windows.Forms.DataGridView();
            this.insertB = new System.Windows.Forms.Button();
            this.tableL = new System.Windows.Forms.Label();
            this.tableTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.insertData)).BeginInit();
            this.SuspendLayout();
            // 
            // insertData
            // 
            this.insertData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.insertData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.insertData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.insertData.Location = new System.Drawing.Point(12, 69);
            this.insertData.Name = "insertData";
            this.insertData.Size = new System.Drawing.Size(776, 326);
            this.insertData.TabIndex = 0;
            // 
            // insertB
            // 
            this.insertB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insertB.BackColor = System.Drawing.Color.Gold;
            this.insertB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertB.Location = new System.Drawing.Point(325, 421);
            this.insertB.Name = "insertB";
            this.insertB.Size = new System.Drawing.Size(114, 51);
            this.insertB.TabIndex = 9;
            this.insertB.Text = "Insert";
            this.insertB.UseVisualStyleBackColor = false;
            this.insertB.Click += new System.EventHandler(this.insertB_Click);
            // 
            // tableL
            // 
            this.tableL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableL.AutoSize = true;
            this.tableL.BackColor = System.Drawing.Color.Transparent;
            this.tableL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableL.ForeColor = System.Drawing.Color.Gold;
            this.tableL.Location = new System.Drawing.Point(24, 18);
            this.tableL.Name = "tableL";
            this.tableL.Size = new System.Drawing.Size(48, 20);
            this.tableL.TabIndex = 11;
            this.tableL.Text = "Table";
            // 
            // tableTB
            // 
            this.tableTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableTB.BackColor = System.Drawing.Color.Cornsilk;
            this.tableTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableTB.Location = new System.Drawing.Point(81, 18);
            this.tableTB.Name = "tableTB";
            this.tableTB.Size = new System.Drawing.Size(199, 26);
            this.tableTB.TabIndex = 10;
            // 
            // insertTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.tableL);
            this.Controls.Add(this.tableTB);
            this.Controls.Add(this.insertB);
            this.Controls.Add(this.insertData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "insertTableForm";
            this.Text = "insertTableFrom";
            ((System.ComponentModel.ISupportInitialize)(this.insertData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView insertData;
        private System.Windows.Forms.Button insertB;
        private System.Windows.Forms.Label tableL;
        private System.Windows.Forms.TextBox tableTB;
    }
}