namespace WhiteCrow.Windows
{
    partial class StudentsView
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
            this.studentsDataView = new System.Windows.Forms.DataGridView();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsDataView
            // 
            this.studentsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataView.Location = new System.Drawing.Point(12, 38);
            this.studentsDataView.Name = "studentsDataView";
            this.studentsDataView.Size = new System.Drawing.Size(817, 405);
            this.studentsDataView.TabIndex = 0;
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(12, 12);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(100, 20);
            this.searchBar.TabIndex = 1;
            this.searchBar.Text = "Szukaj...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(721, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Statistics Placeholder";
            // 
            // StudentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.studentsDataView);
            this.Name = "StudentsView";
            this.Text = "StudentsView";
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentsDataView;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Label label1;
    }
}