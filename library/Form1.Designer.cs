namespace library
{
    partial class FrnPrincipal
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
            this.tabControlEditores = new System.Windows.Forms.TabControl();
            this.tabPagePrincipal = new System.Windows.Forms.TabPage();
            this.tabPageAuthor = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblAuthorNationaliotySearch = new System.Windows.Forms.Label();
            this.LblAuthorNameSearch = new System.Windows.Forms.Label();
            this.tabPageEditores = new System.Windows.Forms.TabPage();
            this.tabPageTema = new System.Windows.Forms.TabPage();
            this.tabPageBook = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pnlautor = new System.Windows.Forms.Panel();
            this.btnewautor = new System.Windows.Forms.Button();
            this.btneditautor = new System.Windows.Forms.Button();
            this.btnDeleteautor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabControlEditores.SuspendLayout();
            this.tabPagePrincipal.SuspendLayout();
            this.tabPageAuthor.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlautor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlEditores
            // 
            this.tabControlEditores.Controls.Add(this.tabPagePrincipal);
            this.tabControlEditores.Controls.Add(this.tabPageAuthor);
            this.tabControlEditores.Controls.Add(this.tabPage1);
            this.tabControlEditores.Controls.Add(this.tabPageEditores);
            this.tabControlEditores.Controls.Add(this.tabPageTema);
            this.tabControlEditores.Controls.Add(this.tabPageBook);
            this.tabControlEditores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEditores.Location = new System.Drawing.Point(0, 0);
            this.tabControlEditores.Name = "tabControlEditores";
            this.tabControlEditores.SelectedIndex = 0;
            this.tabControlEditores.Size = new System.Drawing.Size(1257, 668);
            this.tabControlEditores.TabIndex = 0;
            this.tabControlEditores.Tag = "";
            this.tabControlEditores.SelectedIndexChanged += new System.EventHandler(this.tabControlEditores_SelectedIndexChanged);
            // 
            // tabPagePrincipal
            // 
            this.tabPagePrincipal.Controls.Add(this.dataGridView2);
            this.tabPagePrincipal.Controls.Add(this.panel1);
            this.tabPagePrincipal.Controls.Add(this.groupBox2);
            this.tabPagePrincipal.Location = new System.Drawing.Point(4, 24);
            this.tabPagePrincipal.Name = "tabPagePrincipal";
            this.tabPagePrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrincipal.Size = new System.Drawing.Size(1249, 640);
            this.tabPagePrincipal.TabIndex = 0;
            this.tabPagePrincipal.Text = "Principal";
            this.tabPagePrincipal.UseVisualStyleBackColor = true;
            this.tabPagePrincipal.Click += new System.EventHandler(this.tabPagePrincipal_Click);
            // 
            // tabPageAuthor
            // 
            this.tabPageAuthor.Controls.Add(this.panel2);
            this.tabPageAuthor.Controls.Add(this.groupBox4);
            this.tabPageAuthor.Location = new System.Drawing.Point(4, 24);
            this.tabPageAuthor.Name = "tabPageAuthor";
            this.tabPageAuthor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuthor.Size = new System.Drawing.Size(1249, 640);
            this.tabPageAuthor.TabIndex = 1;
            this.tabPageAuthor.Text = "Clientes";
            this.tabPageAuthor.UseVisualStyleBackColor = true;
            this.tabPageAuthor.Click += new System.EventHandler(this.tabPageAuthor_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlautor);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.LblAuthorNameSearch);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1249, 640);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Autores";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SlateGray;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LblAuthorNationaliotySearch);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1238, 133);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "consulta";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.DimGray;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(249, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 29);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(28, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 29);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.BackgroundImage = global::library.Properties.Resources.Search;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(409, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(41, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "nome do autor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblAuthorNationaliotySearch
            // 
            this.LblAuthorNationaliotySearch.AutoSize = true;
            this.LblAuthorNationaliotySearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblAuthorNationaliotySearch.Location = new System.Drawing.Point(262, 42);
            this.LblAuthorNationaliotySearch.Name = "LblAuthorNationaliotySearch";
            this.LblAuthorNationaliotySearch.Size = new System.Drawing.Size(94, 21);
            this.LblAuthorNationaliotySearch.TabIndex = 2;
            this.LblAuthorNationaliotySearch.Text = "nationality";
            this.LblAuthorNationaliotySearch.Click += new System.EventHandler(this.LblAuthorNationaliotySearch_Click);
            // 
            // LblAuthorNameSearch
            // 
            this.LblAuthorNameSearch.AutoSize = true;
            this.LblAuthorNameSearch.Location = new System.Drawing.Point(8, 3);
            this.LblAuthorNameSearch.Name = "LblAuthorNameSearch";
            this.LblAuthorNameSearch.Size = new System.Drawing.Size(0, 15);
            this.LblAuthorNameSearch.TabIndex = 0;
            this.LblAuthorNameSearch.Click += new System.EventHandler(this.LblAuthorNameSearch_Click);
            // 
            // tabPageEditores
            // 
            this.tabPageEditores.Location = new System.Drawing.Point(4, 24);
            this.tabPageEditores.Name = "tabPageEditores";
            this.tabPageEditores.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditores.Size = new System.Drawing.Size(1249, 683);
            this.tabPageEditores.TabIndex = 3;
            this.tabPageEditores.Text = "Editores";
            this.tabPageEditores.UseVisualStyleBackColor = true;
            this.tabPageEditores.Click += new System.EventHandler(this.tabPageEditores_Click);
            // 
            // tabPageTema
            // 
            this.tabPageTema.Location = new System.Drawing.Point(4, 24);
            this.tabPageTema.Name = "tabPageTema";
            this.tabPageTema.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTema.Size = new System.Drawing.Size(1249, 683);
            this.tabPageTema.TabIndex = 4;
            this.tabPageTema.Text = "Temas";
            this.tabPageTema.UseVisualStyleBackColor = true;
            this.tabPageTema.Click += new System.EventHandler(this.tabPageTema_Click);
            // 
            // tabPageBook
            // 
            this.tabPageBook.Location = new System.Drawing.Point(4, 24);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBook.Size = new System.Drawing.Size(1249, 683);
            this.tabPageBook.TabIndex = 5;
            this.tabPageBook.Text = "Livro";
            this.tabPageBook.UseVisualStyleBackColor = true;
            this.tabPageBook.Click += new System.EventHandler(this.tabPageBook_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 646);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1257, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // pnlautor
            // 
            this.pnlautor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlautor.Controls.Add(this.dataGridView1);
            this.pnlautor.Controls.Add(this.btnDeleteautor);
            this.pnlautor.Controls.Add(this.btneditautor);
            this.pnlautor.Controls.Add(this.btnewautor);
            this.pnlautor.ForeColor = System.Drawing.SystemColors.Highlight;
            this.pnlautor.Location = new System.Drawing.Point(9, 139);
            this.pnlautor.Name = "pnlautor";
            this.pnlautor.Size = new System.Drawing.Size(1237, 524);
            this.pnlautor.TabIndex = 9;
            this.pnlautor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlautor_Paint);
            // 
            // btnewautor
            // 
            this.btnewautor.BackgroundImage = global::library.Properties.Resources.Add;
            this.btnewautor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnewautor.Location = new System.Drawing.Point(125, 67);
            this.btnewautor.Name = "btnewautor";
            this.btnewautor.Size = new System.Drawing.Size(75, 68);
            this.btnewautor.TabIndex = 0;
            this.btnewautor.UseVisualStyleBackColor = true;
            this.btnewautor.Click += new System.EventHandler(this.btnewautor_Click);
            // 
            // btneditautor
            // 
            this.btneditautor.BackgroundImage = global::library.Properties.Resources.Edit;
            this.btneditautor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneditautor.Location = new System.Drawing.Point(44, 67);
            this.btneditautor.Name = "btneditautor";
            this.btneditautor.Size = new System.Drawing.Size(75, 68);
            this.btneditautor.TabIndex = 1;
            this.btneditautor.UseVisualStyleBackColor = true;
            this.btneditautor.Click += new System.EventHandler(this.btneditautor_Click);
            // 
            // btnDeleteautor
            // 
            this.btnDeleteautor.BackgroundImage = global::library.Properties.Resources.Delete;
            this.btnDeleteautor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteautor.Location = new System.Drawing.Point(206, 67);
            this.btnDeleteautor.Name = "btnDeleteautor";
            this.btnDeleteautor.Size = new System.Drawing.Size(75, 68);
            this.btnDeleteautor.TabIndex = 2;
            this.btnDeleteautor.UseVisualStyleBackColor = true;
            this.btnDeleteautor.Click += new System.EventHandler(this.btnDeleteautor_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1238, 390);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(5, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1238, 212);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "consulta";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.DeepPink;
            this.comboBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(592, 65);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(124, 29);
            this.comboBox2.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.HotPink;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(144, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 29);
            this.textBox2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.BackgroundImage = global::library.Properties.Resources.Search;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(408, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 70);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(164, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "nome do autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(604, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "nationality";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::library.Properties.Resources.Delete;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(1071, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 134);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::library.Properties.Resources.Edit;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(34, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 134);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::library.Properties.Resources.Add;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(510, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 134);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(0, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 165);
            this.panel1.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(2, 392);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(1238, 211);
            this.dataGridView2.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox4.Controls.Add(this.comboBox4);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox4.Location = new System.Drawing.Point(5, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1238, 117);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "consulta";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboBox4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(249, 66);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(124, 29);
            this.comboBox4.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(28, 66);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(155, 29);
            this.textBox4.TabIndex = 7;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button7.BackgroundImage = global::library.Properties.Resources.Search;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(411, 25);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 70);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(40, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "nome do autor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(265, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "nationality";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Location = new System.Drawing.Point(3, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1238, 123);
            this.panel2.TabIndex = 10;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::library.Properties.Resources.Add;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(88, 28);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 68);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::library.Properties.Resources.Delete;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Location = new System.Drawing.Point(169, 28);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 68);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::library.Properties.Resources.Edit;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Location = new System.Drawing.Point(7, 28);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 68);
            this.button9.TabIndex = 6;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(57, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(85, 26);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(1096, 139);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(85, 26);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(540, 136);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(85, 26);
            this.panel5.TabIndex = 9;
            // 
            // FrnPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 668);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControlEditores);
            this.Name = "FrnPrincipal";
            this.Text = "biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlEditores.ResumeLayout(false);
            this.tabPagePrincipal.ResumeLayout(false);
            this.tabPageAuthor.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlautor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControlEditores;
        private TabPage tabPagePrincipal;
        private TabPage tabPageAuthor;
        private TabPage tabPage1;
        private TabPage tabPageEditores;
        private TabPage tabPageTema;
        private TabPage tabPageBook;
        private StatusStrip statusStrip1;
        private Label LblAuthorNameSearch;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label LblAuthorNationaliotySearch;
        private Panel pnlautor;
        private DataGridView dataGridView1;
        private Button btnDeleteautor;
        private Button btneditautor;
        private Button btnewautor;
        private DataGridView dataGridView2;
        private Panel panel1;
        private Button button5;
        private Button button3;
        private Button button4;
        private GroupBox groupBox2;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private Button button2;
        private Label label2;
        private Label label3;
        private GroupBox groupBox4;
        private ComboBox comboBox4;
        private TextBox textBox4;
        private Button button7;
        private Label label6;
        private Label label7;
        private Panel panel4;
        private Panel panel5;
        private Panel panel3;
        private Panel panel2;
        private Button button6;
        private Button button8;
        private Button button9;
    }
}