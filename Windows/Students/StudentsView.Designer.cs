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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsView));
            this.studentsDataView = new System.Windows.Forms.DataGridView();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteStudentButton = new System.Windows.Forms.Button();
            this.deleteClassButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.repairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.jjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.jhjhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
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
            this.studentsDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.studentsDataView.Location = new System.Drawing.Point(12, 38);
            this.studentsDataView.MultiSelect = false;
            this.studentsDataView.Name = "studentsDataView";
            this.studentsDataView.ReadOnly = true;
            this.studentsDataView.RowHeadersWidth = 45;
            this.studentsDataView.RowTemplate.ReadOnly = true;
            this.studentsDataView.Size = new System.Drawing.Size(602, 405);
            this.studentsDataView.TabIndex = 0;
            this.studentsDataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsDataView_CellDoubleClick);
            this.studentsDataView.Sorted += new System.EventHandler(this.studentsDataView_Sorted);
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
            // deleteStudentButton
            // 
            this.deleteStudentButton.Location = new System.Drawing.Point(290, 10);
            this.deleteStudentButton.Name = "deleteStudentButton";
            this.deleteStudentButton.Size = new System.Drawing.Size(84, 23);
            this.deleteStudentButton.TabIndex = 5;
            this.deleteStudentButton.Text = "Skasuj ucznia";
            this.deleteStudentButton.UseVisualStyleBackColor = true;
            this.deleteStudentButton.Click += new System.EventHandler(this.deleteStudentButton_Click);
            // 
            // deleteClassButton
            // 
            this.deleteClassButton.Location = new System.Drawing.Point(380, 10);
            this.deleteClassButton.Name = "deleteClassButton";
            this.deleteClassButton.Size = new System.Drawing.Size(75, 23);
            this.deleteClassButton.TabIndex = 6;
            this.deleteClassButton.Text = "Skasuj klasę";
            this.deleteClassButton.UseVisualStyleBackColor = true;
            this.deleteClassButton.Click += new System.EventHandler(this.deleteClassButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repairToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 26);
            // 
            // repairToolStripMenuItem
            // 
            this.repairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switchStripMenu});
            this.repairToolStripMenuItem.Name = "repairToolStripMenuItem";
            this.repairToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.repairToolStripMenuItem.Text = "Akcje naprawcze";
            // 
            // switchStripMenu
            // 
            this.switchStripMenu.Name = "switchStripMenu";
            this.switchStripMenu.Size = new System.Drawing.Size(174, 22);
            this.switchStripMenu.Text = "Nazwisko <-> Imię";
            this.switchStripMenu.Click += new System.EventHandler(this.switchStripMenu_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jjToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(81, 26);
            // 
            // jjToolStripMenuItem
            // 
            this.jjToolStripMenuItem.Name = "jjToolStripMenuItem";
            this.jjToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.jjToolStripMenuItem.Text = "jj";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jhjhToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(95, 26);
            // 
            // jhjhToolStripMenuItem
            // 
            this.jhjhToolStripMenuItem.Name = "jhjhToolStripMenuItem";
            this.jhjhToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.jhjhToolStripMenuItem.Text = "jhjh";
            // 
            // StudentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 455);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.deleteClassButton);
            this.Controls.Add(this.deleteStudentButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.studentsDataView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentsView";
            this.Text = "Lista Uczniów";
            this.Activated += new System.EventHandler(this.StudentsView_Activated);
            this.Load += new System.EventHandler(this.StudentsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentsDataView;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deleteStudentButton;
        private System.Windows.Forms.Button deleteClassButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem repairToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem jjToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem jhjhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchStripMenu;
    }
}