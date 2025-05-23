namespace WindowsFormsApp3
{
    partial class Form8
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
            this.pbWhenClicked = new System.Windows.Forms.PictureBox();
            this.tblCodeArea = new System.Windows.Forms.TableLayoutPanel();
            this.lblList = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbWhenClicked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWhenClicked
            // 
            this.pbWhenClicked.Image = global::WindowsFormsApp3.Properties.Resources.Capture;
            this.pbWhenClicked.Location = new System.Drawing.Point(452, 111);
            this.pbWhenClicked.Name = "pbWhenClicked";
            this.pbWhenClicked.Size = new System.Drawing.Size(166, 67);
            this.pbWhenClicked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWhenClicked.TabIndex = 1;
            this.pbWhenClicked.TabStop = false;
            this.pbWhenClicked.Tag = "When clicked";
            this.pbWhenClicked.MouseDown += new System.Windows.Forms.MouseEventHandler(this.codeBlock_MouseDown);
            // 
            // tblCodeArea
            // 
            this.tblCodeArea.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblCodeArea.ColumnCount = 1;
            this.tblCodeArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCodeArea.Location = new System.Drawing.Point(101, 74);
            this.tblCodeArea.Name = "tblCodeArea";
            this.tblCodeArea.RowCount = 4;
            this.tblCodeArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCodeArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCodeArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCodeArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCodeArea.Size = new System.Drawing.Size(156, 316);
            this.tblCodeArea.TabIndex = 2;
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(303, 83);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(35, 13);
            this.lblList.TabIndex = 3;
            this.lblList.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.capture1;
            this.pictureBox1.Location = new System.Drawing.Point(452, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "For Loop";
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.codeBlock_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(96, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to the drag and drop game! Please play around!";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.tblCodeArea);
            this.Controls.Add(this.pbWhenClicked);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWhenClicked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWhenClicked;
        private System.Windows.Forms.TableLayoutPanel tblCodeArea;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}