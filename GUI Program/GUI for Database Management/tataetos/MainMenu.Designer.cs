
namespace tataetos
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.showB = new System.Windows.Forms.Button();
            this.tableList = new System.Windows.Forms.ComboBox();
            this.tableL = new System.Windows.Forms.Label();
            this.queryB = new System.Windows.Forms.Button();
            this.queryTB = new System.Windows.Forms.RichTextBox();
            this.queryL = new System.Windows.Forms.Label();
            this.insertB = new System.Windows.Forms.Button();
            this.tableListInsert = new System.Windows.Forms.ComboBox();
            this.selectTableL2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showB
            // 
            this.showB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showB.BackColor = System.Drawing.Color.Gold;
            this.showB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showB.Location = new System.Drawing.Point(151, 343);
            this.showB.Name = "showB";
            this.showB.Size = new System.Drawing.Size(114, 51);
            this.showB.TabIndex = 2;
            this.showB.Text = "Show";
            this.showB.UseVisualStyleBackColor = false;
            this.showB.Click += new System.EventHandler(this.showB_Click);
            // 
            // tableList
            // 
            this.tableList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tableList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tableList.BackColor = System.Drawing.Color.Cornsilk;
            this.tableList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableList.FormattingEnabled = true;
            this.tableList.Location = new System.Drawing.Point(50, 294);
            this.tableList.Name = "tableList";
            this.tableList.Size = new System.Drawing.Size(215, 32);
            this.tableList.TabIndex = 3;
            // 
            // tableL
            // 
            this.tableL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableL.AutoSize = true;
            this.tableL.BackColor = System.Drawing.Color.Transparent;
            this.tableL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableL.ForeColor = System.Drawing.Color.Gold;
            this.tableL.Location = new System.Drawing.Point(45, 257);
            this.tableL.Name = "tableL";
            this.tableL.Size = new System.Drawing.Size(122, 25);
            this.tableL.TabIndex = 4;
            this.tableL.Text = "Select Table";
            // 
            // queryB
            // 
            this.queryB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.queryB.BackColor = System.Drawing.Color.Gold;
            this.queryB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryB.Location = new System.Drawing.Point(532, 190);
            this.queryB.Name = "queryB";
            this.queryB.Size = new System.Drawing.Size(114, 51);
            this.queryB.TabIndex = 5;
            this.queryB.Text = "Run Query";
            this.queryB.UseVisualStyleBackColor = false;
            this.queryB.Click += new System.EventHandler(this.queryB_Click);
            // 
            // queryTB
            // 
            this.queryTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.queryTB.BackColor = System.Drawing.Color.Cornsilk;
            this.queryTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryTB.Location = new System.Drawing.Point(21, 51);
            this.queryTB.Name = "queryTB";
            this.queryTB.Size = new System.Drawing.Size(625, 121);
            this.queryTB.TabIndex = 6;
            this.queryTB.Text = "";
            // 
            // queryL
            // 
            this.queryL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.queryL.AutoSize = true;
            this.queryL.BackColor = System.Drawing.Color.Transparent;
            this.queryL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryL.ForeColor = System.Drawing.Color.Gold;
            this.queryL.Location = new System.Drawing.Point(25, 23);
            this.queryL.Name = "queryL";
            this.queryL.Size = new System.Drawing.Size(139, 25);
            this.queryL.TabIndex = 7;
            this.queryL.Text = "Custom Query";
            // 
            // insertB
            // 
            this.insertB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insertB.BackColor = System.Drawing.Color.Gold;
            this.insertB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertB.Location = new System.Drawing.Point(494, 343);
            this.insertB.Name = "insertB";
            this.insertB.Size = new System.Drawing.Size(114, 51);
            this.insertB.TabIndex = 8;
            this.insertB.Text = "Insert";
            this.insertB.UseVisualStyleBackColor = false;
            this.insertB.Click += new System.EventHandler(this.insertB_Click);
            // 
            // tableListInsert
            // 
            this.tableListInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableListInsert.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tableListInsert.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tableListInsert.BackColor = System.Drawing.Color.Cornsilk;
            this.tableListInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableListInsert.FormattingEnabled = true;
            this.tableListInsert.Location = new System.Drawing.Point(393, 294);
            this.tableListInsert.Name = "tableListInsert";
            this.tableListInsert.Size = new System.Drawing.Size(215, 32);
            this.tableListInsert.TabIndex = 9;
            // 
            // selectTableL2
            // 
            this.selectTableL2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectTableL2.AutoSize = true;
            this.selectTableL2.BackColor = System.Drawing.Color.Transparent;
            this.selectTableL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTableL2.ForeColor = System.Drawing.Color.Gold;
            this.selectTableL2.Location = new System.Drawing.Point(388, 257);
            this.selectTableL2.Name = "selectTableL2";
            this.selectTableL2.Size = new System.Drawing.Size(122, 25);
            this.selectTableL2.TabIndex = 10;
            this.selectTableL2.Text = "Select Table";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(675, 464);
            this.Controls.Add(this.selectTableL2);
            this.Controls.Add(this.tableListInsert);
            this.Controls.Add(this.insertB);
            this.Controls.Add(this.queryL);
            this.Controls.Add(this.queryTB);
            this.Controls.Add(this.queryB);
            this.Controls.Add(this.tableL);
            this.Controls.Add(this.tableList);
            this.Controls.Add(this.showB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button showB;
        private System.Windows.Forms.ComboBox tableList;
        private System.Windows.Forms.Label tableL;
        private System.Windows.Forms.Button queryB;
        private System.Windows.Forms.RichTextBox queryTB;
        private System.Windows.Forms.Label queryL;
        private System.Windows.Forms.Button insertB;
        private System.Windows.Forms.ComboBox tableListInsert;
        private System.Windows.Forms.Label selectTableL2;
    }
}