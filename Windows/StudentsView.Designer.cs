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
            this.addButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsDataView
            // 
            this.studentsDataView.AllowUserToAddRows = false;
            this.studentsDataView.AllowUserToDeleteRows = false;
            this.studentsDataView.AllowUserToResizeRows = false;
            this.studentsDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataView.Location = new System.Drawing.Point(12, 38);
            this.studentsDataView.Name = "studentsDataView";
            this.studentsDataView.Size = new System.Drawing.Size(817, 405);
            this.studentsDataView.TabIndex = 0;
            this.studentsDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsDataView_CellContentClick);
            this.studentsDataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsDataView_CellDoubleClick);
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(12, 12);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(100, 20);
            this.searchBar.TabIndex = 1;
            this.searchBar.Text = "Szukaj...";
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
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
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(128, 10);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Odśwież";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 455);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.studentsDataView);
            this.Name = "StudentsView";
            this.Text = "StudentsView";
            this.Load += new System.EventHandler(this.StudentsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentsDataView;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button1;
    }
}