namespace CardPassApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnSave = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btnUpdate = new Button();
            btnDelete = new Button();
            txtName = new TextBox();
            menuStrip1 = new MenuStrip();
            mainMenuToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            procesToolStripMenuItem = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            cardReaderToolStripMenuItem = new ToolStripMenuItem();
            tblPnl = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            dgList = new DataGridView();
            pnlRegister = new Panel();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            btnBrowse = new Button();
            label5 = new Label();
            txtCardId = new TextBox();
            txtStudentNo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtLastname = new TextBox();
            pnlNavi = new Panel();
            label6 = new Label();
            button2 = new Button();
            btnClose = new Button();
            panel3 = new Panel();
            btnAccessColor = new Button();
            lbCardStatus = new Label();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            tblPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgList).BeginInit();
            pnlRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            pnlNavi.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackgroundImage = (Image)resources.GetObject("btnSave.BackgroundImage");
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(210, 22);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(32, 32);
            btnSave.TabIndex = 2;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnUpdate
            // 
            btnUpdate.BackgroundImage = (Image)resources.GetObject("btnUpdate.BackgroundImage");
            btnUpdate.BackgroundImageLayout = ImageLayout.Stretch;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(248, 22);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(32, 32);
            btnUpdate.TabIndex = 6;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnRefresh_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(286, 22);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(32, 32);
            btnDelete.TabIndex = 7;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(93, 22);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 8;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainMenuToolStripMenuItem, procesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 36);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(630, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            mainMenuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            mainMenuToolStripMenuItem.Size = new Size(52, 20);
            mainMenuToolStripMenuItem.Text = "Folder";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // procesToolStripMenuItem
            // 
            procesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registerToolStripMenuItem, cardReaderToolStripMenuItem });
            procesToolStripMenuItem.Name = "procesToolStripMenuItem";
            procesToolStripMenuItem.Size = new Size(54, 20);
            procesToolStripMenuItem.Text = "Proces";
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(138, 22);
            registerToolStripMenuItem.Text = "Register";
            registerToolStripMenuItem.Click += registerToolStripMenuItem_Click;
            // 
            // cardReaderToolStripMenuItem
            // 
            cardReaderToolStripMenuItem.Name = "cardReaderToolStripMenuItem";
            cardReaderToolStripMenuItem.Size = new Size(138, 22);
            cardReaderToolStripMenuItem.Text = "Card Reader";
            cardReaderToolStripMenuItem.Click += cardReaderToolStripMenuItem_Click;
            // 
            // tblPnl
            // 
            tblPnl.ColumnCount = 2;
            tblPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.73163F));
            tblPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.26837F));
            tblPnl.Controls.Add(pictureBox1, 1, 0);
            tblPnl.Controls.Add(dgList, 0, 0);
            tblPnl.Dock = DockStyle.Top;
            tblPnl.Location = new Point(0, 92);
            tblPnl.Name = "tblPnl";
            tblPnl.RowCount = 1;
            tblPnl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblPnl.Size = new Size(630, 206);
            tblPnl.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(429, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dgList
            // 
            dgList.AllowUserToAddRows = false;
            dgList.BackgroundColor = Color.FromArgb(35, 59, 119);
            dgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgList.Dock = DockStyle.Fill;
            dgList.Location = new Point(3, 3);
            dgList.Name = "dgList";
            dgList.RowTemplate.Height = 25;
            dgList.Size = new Size(420, 200);
            dgList.TabIndex = 2;
            // 
            // pnlRegister
            // 
            pnlRegister.Controls.Add(pictureBox2);
            pnlRegister.Controls.Add(groupBox1);
            pnlRegister.Dock = DockStyle.Top;
            pnlRegister.Location = new Point(0, 298);
            pnlRegister.Name = "pnlRegister";
            pnlRegister.Size = new Size(630, 150);
            pnlRegister.TabIndex = 13;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(356, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(161, 141);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBrowse);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(txtCardId);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(txtStudentNo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtLastname);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 150);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Register";
            // 
            // btnBrowse
            // 
            btnBrowse.BackgroundImage = (Image)resources.GetObject("btnBrowse.BackgroundImage");
            btnBrowse.BackgroundImageLayout = ImageLayout.Stretch;
            btnBrowse.FlatAppearance.BorderSize = 0;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Location = new Point(286, 60);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(32, 32);
            btnBrowse.TabIndex = 11;
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(11, 112);
            label5.Name = "label5";
            label5.Size = new Size(60, 19);
            label5.TabIndex = 16;
            label5.Text = "Card Id:";
            // 
            // txtCardId
            // 
            txtCardId.Location = new Point(93, 109);
            txtCardId.Name = "txtCardId";
            txtCardId.Size = new Size(100, 23);
            txtCardId.TabIndex = 15;
            txtCardId.TextChanged += txtCardId_TextChanged;
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(93, 80);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(100, 23);
            txtStudentNo.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(11, 83);
            label3.Name = "label3";
            label3.Size = new Size(82, 19);
            label3.TabIndex = 12;
            label3.Text = "Student No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 54);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 11;
            label2.Text = "Lastname:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 25);
            label1.Name = "label1";
            label1.Size = new Size(49, 19);
            label1.TabIndex = 10;
            label1.Text = "Name:";
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(93, 51);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(100, 23);
            txtLastname.TabIndex = 9;
            // 
            // pnlNavi
            // 
            pnlNavi.Controls.Add(label6);
            pnlNavi.Controls.Add(button2);
            pnlNavi.Controls.Add(btnClose);
            pnlNavi.Dock = DockStyle.Top;
            pnlNavi.Location = new Point(0, 0);
            pnlNavi.Name = "pnlNavi";
            pnlNavi.Size = new Size(630, 36);
            pnlNavi.TabIndex = 14;
            pnlNavi.MouseDown += pnlNavi_MouseDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 6);
            label6.Name = "label6";
            label6.Size = new Size(189, 22);
            label6.TabIndex = 2;
            label6.Text = "University Access App";
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(555, 3);
            button2.Name = "button2";
            button2.Size = new Size(32, 32);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(593, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAccessColor);
            panel3.Controls.Add(lbCardStatus);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(630, 32);
            panel3.TabIndex = 15;
            // 
            // btnAccessColor
            // 
            btnAccessColor.BackColor = Color.DarkRed;
            btnAccessColor.FlatAppearance.BorderSize = 0;
            btnAccessColor.FlatStyle = FlatStyle.Flat;
            btnAccessColor.Location = new Point(248, 5);
            btnAccessColor.Name = "btnAccessColor";
            btnAccessColor.Size = new Size(205, 23);
            btnAccessColor.TabIndex = 2;
            btnAccessColor.UseVisualStyleBackColor = false;
            // 
            // lbCardStatus
            // 
            lbCardStatus.AutoSize = true;
            lbCardStatus.Font = new Font("Times New Roman", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            lbCardStatus.ForeColor = Color.White;
            lbCardStatus.Location = new Point(475, 5);
            lbCardStatus.Name = "lbCardStatus";
            lbCardStatus.Size = new Size(124, 23);
            lbCardStatus.TabIndex = 1;
            lbCardStatus.Text = "Card Waiting";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 5);
            label4.Name = "label4";
            label4.Size = new Size(207, 24);
            label4.TabIndex = 0;
            label4.Text = "Campus Entry System";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 59, 119);
            ClientSize = new Size(630, 480);
            Controls.Add(pnlRegister);
            Controls.Add(tblPnl);
            Controls.Add(panel3);
            Controls.Add(menuStrip1);
            Controls.Add(pnlNavi);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tblPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgList).EndInit();
            pnlRegister.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlNavi.ResumeLayout(false);
            pnlNavi.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private System.Windows.Forms.Timer timer1;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtName;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainMenuToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem procesToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem;
        private TableLayoutPanel tblPnl;
        private Panel pnlRegister;
        private GroupBox groupBox1;
        private TextBox txtStudentNo;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtLastname;
        private PictureBox pictureBox1;
        private Panel pnlNavi;
        private Button button2;
        private Button btnClose;
        private Panel panel3;
        private Label label4;
        private Label lbCardStatus;
        private DataGridView dgList;
        private ToolStripMenuItem cardReaderToolStripMenuItem;
        private Label label6;
        private Label label5;
        private TextBox txtCardId;
        private Button btnAccessColor;
        private Button btnBrowse;
        private PictureBox pictureBox2;
    }
}