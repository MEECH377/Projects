
namespace Library_System
{
    partial class FrmBookManager
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
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxAvailable = new System.Windows.Forms.CheckBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbxEdit = new System.Windows.Forms.GroupBox();
            this.txtGenreEdit = new System.Windows.Forms.TextBox();
            this.lblGenreEdit = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxAvailableEdit = new System.Windows.Forms.CheckBox();
            this.txtAuthorEdit = new System.Windows.Forms.TextBox();
            this.txtTitleEdit = new System.Windows.Forms.TextBox();
            this.lblAuthorEdit = new System.Windows.Forms.Label();
            this.lblTitleEdit = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.lblBokId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.gbxEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(12, 36);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(873, 221);
            this.dgvBooks.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(23, 13);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(54, 13);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "SEARCH:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(91, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.cbxAvailable);
            this.gbxAdd.Controls.Add(this.txtGenre);
            this.gbxAdd.Controls.Add(this.txtAuthor);
            this.gbxAdd.Controls.Add(this.lblGenre);
            this.gbxAdd.Controls.Add(this.lblAuthor);
            this.gbxAdd.Controls.Add(this.txtTitle);
            this.gbxAdd.Controls.Add(this.lblTitle);
            this.gbxAdd.Location = new System.Drawing.Point(12, 263);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(331, 238);
            this.gbxAdd.TabIndex = 3;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "ADD";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(104, 201);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxAvailable
            // 
            this.cbxAvailable.AutoSize = true;
            this.cbxAvailable.Location = new System.Drawing.Point(25, 137);
            this.cbxAvailable.Name = "cbxAvailable";
            this.cbxAvailable.Size = new System.Drawing.Size(69, 17);
            this.cbxAvailable.TabIndex = 9;
            this.cbxAvailable.Text = "Available";
            this.cbxAvailable.UseVisualStyleBackColor = true;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(104, 98);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 20);
            this.txtGenre.TabIndex = 7;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(104, 64);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 6;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(22, 101);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(48, 13);
            this.lblGenre.TabIndex = 5;
            this.lblGenre.Text = "GENRE:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(22, 67);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(56, 13);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "AUTHOR:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(104, 31);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(22, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(40, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "TITLE:";
            // 
            // gbxEdit
            // 
            this.gbxEdit.Controls.Add(this.txtGenreEdit);
            this.gbxEdit.Controls.Add(this.lblGenreEdit);
            this.gbxEdit.Controls.Add(this.btnDelete);
            this.gbxEdit.Controls.Add(this.btnUpdate);
            this.gbxEdit.Controls.Add(this.cbxAvailableEdit);
            this.gbxEdit.Controls.Add(this.txtAuthorEdit);
            this.gbxEdit.Controls.Add(this.txtTitleEdit);
            this.gbxEdit.Controls.Add(this.lblAuthorEdit);
            this.gbxEdit.Controls.Add(this.lblTitleEdit);
            this.gbxEdit.Controls.Add(this.txtBookId);
            this.gbxEdit.Controls.Add(this.lblBokId);
            this.gbxEdit.Location = new System.Drawing.Point(349, 263);
            this.gbxEdit.Name = "gbxEdit";
            this.gbxEdit.Size = new System.Drawing.Size(331, 238);
            this.gbxEdit.TabIndex = 4;
            this.gbxEdit.TabStop = false;
            this.gbxEdit.Text = "EDIT";
            // 
            // txtGenreEdit
            // 
            this.txtGenreEdit.Location = new System.Drawing.Point(104, 124);
            this.txtGenreEdit.Name = "txtGenreEdit";
            this.txtGenreEdit.Size = new System.Drawing.Size(100, 20);
            this.txtGenreEdit.TabIndex = 13;
            // 
            // lblGenreEdit
            // 
            this.lblGenreEdit.AutoSize = true;
            this.lblGenreEdit.Location = new System.Drawing.Point(22, 127);
            this.lblGenreEdit.Name = "lblGenreEdit";
            this.lblGenreEdit.Size = new System.Drawing.Size(48, 13);
            this.lblGenreEdit.TabIndex = 12;
            this.lblGenreEdit.Text = "GENRE:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(194, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(38, 201);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // cbxAvailableEdit
            // 
            this.cbxAvailableEdit.AutoSize = true;
            this.cbxAvailableEdit.Location = new System.Drawing.Point(25, 159);
            this.cbxAvailableEdit.Name = "cbxAvailableEdit";
            this.cbxAvailableEdit.Size = new System.Drawing.Size(69, 17);
            this.cbxAvailableEdit.TabIndex = 9;
            this.cbxAvailableEdit.Text = "Available";
            this.cbxAvailableEdit.UseVisualStyleBackColor = true;
            // 
            // txtAuthorEdit
            // 
            this.txtAuthorEdit.Location = new System.Drawing.Point(104, 95);
            this.txtAuthorEdit.Name = "txtAuthorEdit";
            this.txtAuthorEdit.Size = new System.Drawing.Size(100, 20);
            this.txtAuthorEdit.TabIndex = 7;
            // 
            // txtTitleEdit
            // 
            this.txtTitleEdit.Location = new System.Drawing.Point(104, 64);
            this.txtTitleEdit.Name = "txtTitleEdit";
            this.txtTitleEdit.Size = new System.Drawing.Size(100, 20);
            this.txtTitleEdit.TabIndex = 6;
            // 
            // lblAuthorEdit
            // 
            this.lblAuthorEdit.AutoSize = true;
            this.lblAuthorEdit.Location = new System.Drawing.Point(22, 98);
            this.lblAuthorEdit.Name = "lblAuthorEdit";
            this.lblAuthorEdit.Size = new System.Drawing.Size(59, 13);
            this.lblAuthorEdit.TabIndex = 5;
            this.lblAuthorEdit.Text = "AUTHOR: ";
            // 
            // lblTitleEdit
            // 
            this.lblTitleEdit.AutoSize = true;
            this.lblTitleEdit.Location = new System.Drawing.Point(22, 67);
            this.lblTitleEdit.Name = "lblTitleEdit";
            this.lblTitleEdit.Size = new System.Drawing.Size(40, 13);
            this.lblTitleEdit.TabIndex = 4;
            this.lblTitleEdit.Text = "TITLE:";
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(104, 31);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(100, 20);
            this.txtBookId.TabIndex = 3;
            // 
            // lblBokId
            // 
            this.lblBokId.AutoSize = true;
            this.lblBokId.Location = new System.Drawing.Point(22, 34);
            this.lblBokId.Name = "lblBokId";
            this.lblBokId.Size = new System.Drawing.Size(54, 13);
            this.lblBokId.TabIndex = 2;
            this.lblBokId.Text = "BOOK ID:";
            // 
            // FrmBookManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 506);
            this.Controls.Add(this.gbxEdit);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvBooks);
            this.Name = "FrmBookManager";
            this.Text = "FrmBookManager";
            this.Load += new System.EventHandler(this.FrmBookManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxEdit.ResumeLayout(false);
            this.gbxEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox cbxAvailable;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbxEdit;
        private System.Windows.Forms.TextBox txtGenreEdit;
        private System.Windows.Forms.Label lblGenreEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox cbxAvailableEdit;
        private System.Windows.Forms.TextBox txtAuthorEdit;
        private System.Windows.Forms.TextBox txtTitleEdit;
        private System.Windows.Forms.Label lblAuthorEdit;
        private System.Windows.Forms.Label lblTitleEdit;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label lblBokId;
    }
}