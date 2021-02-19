namespace TriliumFolderGenerator
{
    partial class Form1
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
            this.textbox_job = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_generate = new System.Windows.Forms.Button();
            this.checkbox_openAfter = new System.Windows.Forms.CheckBox();
            this.foldersListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_delete_folder = new System.Windows.Forms.Button();
            this.lbl_new_folder = new System.Windows.Forms.Label();
            this.textbox_new_folder_name = new System.Windows.Forms.TextBox();
            this.button_add_new_folder = new System.Windows.Forms.Button();
            this.button_select_creation_directory = new System.Windows.Forms.Button();
            this.button_select_documents_directory = new System.Windows.Forms.Button();
            this.textbox_creation_directory = new System.Windows.Forms.TextBox();
            this.lbl_creationDirectory = new System.Windows.Forms.Label();
            this.textbox_documents_directory = new System.Windows.Forms.TextBox();
            this.lbl_documentsDirectory = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox_job
            // 
            this.textbox_job.Location = new System.Drawing.Point(3, 3);
            this.textbox_job.Name = "textbox_job";
            this.textbox_job.Size = new System.Drawing.Size(212, 20);
            this.textbox_job.TabIndex = 0;
            this.textbox_job.Text = "DPS-";
            this.textbox_job.TextChanged += new System.EventHandler(this.textbox_job_TextChanged);
            this.textbox_job.Enter += new System.EventHandler(this.textbox_job_Enter);
            this.textbox_job.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_job_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textbox_job, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_generate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkbox_openAfter, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(218, 289);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // button_generate
            // 
            this.button_generate.Enabled = false;
            this.button_generate.Location = new System.Drawing.Point(3, 125);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(212, 97);
            this.button_generate.TabIndex = 2;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // checkbox_openAfter
            // 
            this.checkbox_openAfter.AutoSize = true;
            this.checkbox_openAfter.Location = new System.Drawing.Point(3, 247);
            this.checkbox_openAfter.Name = "checkbox_openAfter";
            this.checkbox_openAfter.Size = new System.Drawing.Size(77, 17);
            this.checkbox_openAfter.TabIndex = 3;
            this.checkbox_openAfter.Text = "Open After";
            this.checkbox_openAfter.UseVisualStyleBackColor = true;
            // 
            // foldersListBox
            // 
            this.foldersListBox.FormattingEnabled = true;
            this.foldersListBox.Location = new System.Drawing.Point(10, 110);
            this.foldersListBox.Name = "foldersListBox";
            this.foldersListBox.Size = new System.Drawing.Size(214, 121);
            this.foldersListBox.TabIndex = 0;
            this.foldersListBox.SelectedIndexChanged += new System.EventHandler(this.foldersListBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 314);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_delete_folder);
            this.groupBox2.Controls.Add(this.lbl_new_folder);
            this.groupBox2.Controls.Add(this.textbox_new_folder_name);
            this.groupBox2.Controls.Add(this.button_add_new_folder);
            this.groupBox2.Controls.Add(this.button_select_creation_directory);
            this.groupBox2.Controls.Add(this.button_select_documents_directory);
            this.groupBox2.Controls.Add(this.textbox_creation_directory);
            this.groupBox2.Controls.Add(this.lbl_creationDirectory);
            this.groupBox2.Controls.Add(this.textbox_documents_directory);
            this.groupBox2.Controls.Add(this.lbl_documentsDirectory);
            this.groupBox2.Controls.Add(this.foldersListBox);
            this.groupBox2.Location = new System.Drawing.Point(260, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 308);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuration";
            // 
            // button_delete_folder
            // 
            this.button_delete_folder.Enabled = false;
            this.button_delete_folder.Location = new System.Drawing.Point(10, 238);
            this.button_delete_folder.Name = "button_delete_folder";
            this.button_delete_folder.Size = new System.Drawing.Size(214, 20);
            this.button_delete_folder.TabIndex = 9;
            this.button_delete_folder.Text = "Remove";
            this.button_delete_folder.UseVisualStyleBackColor = true;
            this.button_delete_folder.Click += new System.EventHandler(this.button_delete_folder_Click);
            // 
            // lbl_new_folder
            // 
            this.lbl_new_folder.AutoSize = true;
            this.lbl_new_folder.Location = new System.Drawing.Point(6, 266);
            this.lbl_new_folder.Name = "lbl_new_folder";
            this.lbl_new_folder.Size = new System.Drawing.Size(151, 13);
            this.lbl_new_folder.TabIndex = 8;
            this.lbl_new_folder.Text = "Add a New Folder to Generate";
            // 
            // textbox_new_folder_name
            // 
            this.textbox_new_folder_name.Location = new System.Drawing.Point(6, 282);
            this.textbox_new_folder_name.Name = "textbox_new_folder_name";
            this.textbox_new_folder_name.Size = new System.Drawing.Size(143, 20);
            this.textbox_new_folder_name.TabIndex = 7;
            this.textbox_new_folder_name.Text = "/";
            this.textbox_new_folder_name.TextChanged += new System.EventHandler(this.textbox_new_folder_name_TextChanged);
            this.textbox_new_folder_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_add_new_folder_KeyPress);
            // 
            // button_add_new_folder
            // 
            this.button_add_new_folder.Enabled = false;
            this.button_add_new_folder.Location = new System.Drawing.Point(160, 282);
            this.button_add_new_folder.Name = "button_add_new_folder";
            this.button_add_new_folder.Size = new System.Drawing.Size(64, 20);
            this.button_add_new_folder.TabIndex = 6;
            this.button_add_new_folder.Text = "Add";
            this.button_add_new_folder.UseVisualStyleBackColor = true;
            this.button_add_new_folder.Click += new System.EventHandler(this.button_add_new_folder_Click);
            // 
            // button_select_creation_directory
            // 
            this.button_select_creation_directory.Location = new System.Drawing.Point(13, 80);
            this.button_select_creation_directory.Name = "button_select_creation_directory";
            this.button_select_creation_directory.Size = new System.Drawing.Size(88, 19);
            this.button_select_creation_directory.TabIndex = 5;
            this.button_select_creation_directory.Text = "Select Folder...";
            this.button_select_creation_directory.UseVisualStyleBackColor = true;
            this.button_select_creation_directory.Click += new System.EventHandler(this.button_select_creation_directory_Click);
            // 
            // button_select_documents_directory
            // 
            this.button_select_documents_directory.Location = new System.Drawing.Point(10, 36);
            this.button_select_documents_directory.Name = "button_select_documents_directory";
            this.button_select_documents_directory.Size = new System.Drawing.Size(91, 20);
            this.button_select_documents_directory.TabIndex = 0;
            this.button_select_documents_directory.Text = "Select Folder...";
            this.button_select_documents_directory.UseVisualStyleBackColor = true;
            this.button_select_documents_directory.Click += new System.EventHandler(this.button_select_documents_directory_Click);
            // 
            // textbox_creation_directory
            // 
            this.textbox_creation_directory.Location = new System.Drawing.Point(120, 80);
            this.textbox_creation_directory.Name = "textbox_creation_directory";
            this.textbox_creation_directory.ReadOnly = true;
            this.textbox_creation_directory.Size = new System.Drawing.Size(104, 20);
            this.textbox_creation_directory.TabIndex = 4;
            // 
            // lbl_creationDirectory
            // 
            this.lbl_creationDirectory.AutoSize = true;
            this.lbl_creationDirectory.Location = new System.Drawing.Point(10, 63);
            this.lbl_creationDirectory.Name = "lbl_creationDirectory";
            this.lbl_creationDirectory.Size = new System.Drawing.Size(91, 13);
            this.lbl_creationDirectory.TabIndex = 3;
            this.lbl_creationDirectory.Text = "Creation Directory";
            // 
            // textbox_documents_directory
            // 
            this.textbox_documents_directory.Location = new System.Drawing.Point(120, 36);
            this.textbox_documents_directory.Name = "textbox_documents_directory";
            this.textbox_documents_directory.ReadOnly = true;
            this.textbox_documents_directory.Size = new System.Drawing.Size(104, 20);
            this.textbox_documents_directory.TabIndex = 2;
            // 
            // lbl_documentsDirectory
            // 
            this.lbl_documentsDirectory.AutoSize = true;
            this.lbl_documentsDirectory.Location = new System.Drawing.Point(7, 19);
            this.lbl_documentsDirectory.Name = "lbl_documentsDirectory";
            this.lbl_documentsDirectory.Size = new System.Drawing.Size(106, 13);
            this.lbl_documentsDirectory.TabIndex = 1;
            this.lbl_documentsDirectory.Text = "Documents Directory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 339);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Folder Generator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_job;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox checkbox_openAfter;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.ListBox foldersListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textbox_documents_directory;
        private System.Windows.Forms.Label lbl_documentsDirectory;
        private System.Windows.Forms.Label lbl_creationDirectory;
        private System.Windows.Forms.TextBox textbox_creation_directory;
        private System.Windows.Forms.Button button_select_documents_directory;
        private System.Windows.Forms.Button button_select_creation_directory;
        private System.Windows.Forms.TextBox textbox_new_folder_name;
        private System.Windows.Forms.Button button_add_new_folder;
        private System.Windows.Forms.Label lbl_new_folder;
        private System.Windows.Forms.Button button_delete_folder;
    }
}

