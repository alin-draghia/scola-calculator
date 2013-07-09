namespace Calculator
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
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.screen = new System.Windows.Forms.TextBox();
            this.memClearBtn = new System.Windows.Forms.Button();
            this.memRecallBtn = new System.Windows.Forms.Button();
            this.memStoreBtn = new System.Windows.Forms.Button();
            this.memAddBtn = new System.Windows.Forms.Button();
            this.memSubBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.clearEntryBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.changeSignBtn = new System.Windows.Forms.Button();
            this.sqrtBtn = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.percentBtn = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.mulBtn = new System.Windows.Forms.Button();
            this.invBtn = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.subBtn = new System.Windows.Forms.Button();
            this.equalBtn = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.dotBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.digitGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.helpMenu});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(258, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(152, 22);
            this.exitMenu.Text = "Exit";
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyMenu,
            this.pasteMenu,
            this.toolStripMenuItem1,
            this.digitGroupToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "Edit";
            // 
            // copyMenu
            // 
            this.copyMenu.Name = "copyMenu";
            this.copyMenu.Size = new System.Drawing.Size(152, 22);
            this.copyMenu.Text = "Copy";
            // 
            // pasteMenu
            // 
            this.pasteMenu.Name = "pasteMenu";
            this.pasteMenu.Size = new System.Drawing.Size(152, 22);
            this.pasteMenu.Text = "Paste";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenu});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "Help";
            // 
            // aboutMenu
            // 
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(152, 22);
            this.aboutMenu.Text = "About";
            this.aboutMenu.Click += new System.EventHandler(this.aboutMenu_Click);
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.SystemColors.Control;
            this.screen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screen.Enabled = false;
            this.screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screen.Location = new System.Drawing.Point(12, 27);
            this.screen.MaxLength = 18;
            this.screen.Name = "screen";
            this.screen.ReadOnly = true;
            this.screen.Size = new System.Drawing.Size(234, 30);
            this.screen.TabIndex = 1;
            this.screen.TabStop = false;
            this.screen.Text = "1234.00568";
            this.screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // memClearBtn
            // 
            this.memClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memClearBtn.Location = new System.Drawing.Point(12, 63);
            this.memClearBtn.Name = "memClearBtn";
            this.memClearBtn.Size = new System.Drawing.Size(42, 23);
            this.memClearBtn.TabIndex = 2;
            this.memClearBtn.TabStop = false;
            this.memClearBtn.Text = "MC";
            this.memClearBtn.UseVisualStyleBackColor = true;
            this.memClearBtn.Click += new System.EventHandler(this.memClearBtn_Click);
            // 
            // memRecallBtn
            // 
            this.memRecallBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memRecallBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memRecallBtn.Location = new System.Drawing.Point(60, 63);
            this.memRecallBtn.Name = "memRecallBtn";
            this.memRecallBtn.Size = new System.Drawing.Size(42, 23);
            this.memRecallBtn.TabIndex = 2;
            this.memRecallBtn.TabStop = false;
            this.memRecallBtn.Text = "MR";
            this.memRecallBtn.UseVisualStyleBackColor = true;
            this.memRecallBtn.Click += new System.EventHandler(this.memRecallBtn_Click);
            // 
            // memStoreBtn
            // 
            this.memStoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memStoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memStoreBtn.Location = new System.Drawing.Point(108, 63);
            this.memStoreBtn.Name = "memStoreBtn";
            this.memStoreBtn.Size = new System.Drawing.Size(42, 23);
            this.memStoreBtn.TabIndex = 2;
            this.memStoreBtn.TabStop = false;
            this.memStoreBtn.Text = "MS";
            this.memStoreBtn.UseVisualStyleBackColor = true;
            this.memStoreBtn.Click += new System.EventHandler(this.memStoreBtn_Click);
            // 
            // memAddBtn
            // 
            this.memAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memAddBtn.Location = new System.Drawing.Point(156, 63);
            this.memAddBtn.Name = "memAddBtn";
            this.memAddBtn.Size = new System.Drawing.Size(42, 23);
            this.memAddBtn.TabIndex = 2;
            this.memAddBtn.TabStop = false;
            this.memAddBtn.Text = "M+";
            this.memAddBtn.UseVisualStyleBackColor = true;
            this.memAddBtn.Click += new System.EventHandler(this.memAddBtn_Click);
            // 
            // memSubBtn
            // 
            this.memSubBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memSubBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memSubBtn.Location = new System.Drawing.Point(204, 63);
            this.memSubBtn.Name = "memSubBtn";
            this.memSubBtn.Size = new System.Drawing.Size(42, 23);
            this.memSubBtn.TabIndex = 2;
            this.memSubBtn.TabStop = false;
            this.memSubBtn.Text = "M-";
            this.memSubBtn.UseVisualStyleBackColor = true;
            this.memSubBtn.Click += new System.EventHandler(this.memSubBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.Location = new System.Drawing.Point(12, 92);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(42, 23);
            this.delBtn.TabIndex = 2;
            this.delBtn.TabStop = false;
            this.delBtn.Text = "DEL";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // clearEntryBtn
            // 
            this.clearEntryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearEntryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearEntryBtn.Location = new System.Drawing.Point(60, 92);
            this.clearEntryBtn.Name = "clearEntryBtn";
            this.clearEntryBtn.Size = new System.Drawing.Size(42, 23);
            this.clearEntryBtn.TabIndex = 2;
            this.clearEntryBtn.TabStop = false;
            this.clearEntryBtn.Text = "CE";
            this.clearEntryBtn.UseVisualStyleBackColor = true;
            this.clearEntryBtn.Click += new System.EventHandler(this.clearEntryBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(108, 92);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(42, 23);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.TabStop = false;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // changeSignBtn
            // 
            this.changeSignBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeSignBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeSignBtn.Location = new System.Drawing.Point(156, 92);
            this.changeSignBtn.Name = "changeSignBtn";
            this.changeSignBtn.Size = new System.Drawing.Size(42, 23);
            this.changeSignBtn.TabIndex = 2;
            this.changeSignBtn.TabStop = false;
            this.changeSignBtn.Text = "+/-";
            this.changeSignBtn.UseVisualStyleBackColor = true;
            this.changeSignBtn.Click += new System.EventHandler(this.changeSignBtn_Click);
            // 
            // sqrtBtn
            // 
            this.sqrtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrtBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrtBtn.Location = new System.Drawing.Point(204, 92);
            this.sqrtBtn.Name = "sqrtBtn";
            this.sqrtBtn.Size = new System.Drawing.Size(42, 23);
            this.sqrtBtn.TabIndex = 2;
            this.sqrtBtn.TabStop = false;
            this.sqrtBtn.Text = "SQR";
            this.sqrtBtn.UseVisualStyleBackColor = true;
            this.sqrtBtn.Click += new System.EventHandler(this.sqrtBtn_Click);
            // 
            // num7
            // 
            this.num7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(12, 121);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(42, 23);
            this.num7.TabIndex = 2;
            this.num7.TabStop = false;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num_Click);
            // 
            // num8
            // 
            this.num8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(60, 121);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(42, 23);
            this.num8.TabIndex = 2;
            this.num8.TabStop = false;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num_Click);
            // 
            // num9
            // 
            this.num9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(108, 121);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(42, 23);
            this.num9.TabIndex = 2;
            this.num9.TabStop = false;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num_Click);
            // 
            // divBtn
            // 
            this.divBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divBtn.Location = new System.Drawing.Point(156, 121);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(42, 23);
            this.divBtn.TabIndex = 2;
            this.divBtn.TabStop = false;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // percentBtn
            // 
            this.percentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentBtn.Location = new System.Drawing.Point(204, 121);
            this.percentBtn.Name = "percentBtn";
            this.percentBtn.Size = new System.Drawing.Size(42, 23);
            this.percentBtn.TabIndex = 2;
            this.percentBtn.TabStop = false;
            this.percentBtn.Text = "%";
            this.percentBtn.UseVisualStyleBackColor = true;
            this.percentBtn.Click += new System.EventHandler(this.percentBtn_Click);
            // 
            // num4
            // 
            this.num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(12, 150);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(42, 23);
            this.num4.TabIndex = 2;
            this.num4.TabStop = false;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num_Click);
            // 
            // num5
            // 
            this.num5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(60, 150);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(42, 23);
            this.num5.TabIndex = 2;
            this.num5.TabStop = false;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num_Click);
            // 
            // num6
            // 
            this.num6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(108, 150);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(42, 23);
            this.num6.TabIndex = 2;
            this.num6.TabStop = false;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num_Click);
            // 
            // mulBtn
            // 
            this.mulBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mulBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulBtn.Location = new System.Drawing.Point(156, 150);
            this.mulBtn.Name = "mulBtn";
            this.mulBtn.Size = new System.Drawing.Size(42, 23);
            this.mulBtn.TabIndex = 2;
            this.mulBtn.TabStop = false;
            this.mulBtn.Text = "*";
            this.mulBtn.UseVisualStyleBackColor = true;
            this.mulBtn.Click += new System.EventHandler(this.mulBtn_Click);
            // 
            // invBtn
            // 
            this.invBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invBtn.Location = new System.Drawing.Point(204, 150);
            this.invBtn.Name = "invBtn";
            this.invBtn.Size = new System.Drawing.Size(42, 23);
            this.invBtn.TabIndex = 2;
            this.invBtn.TabStop = false;
            this.invBtn.Text = "1/x";
            this.invBtn.UseVisualStyleBackColor = true;
            this.invBtn.Click += new System.EventHandler(this.invBtn_Click);
            // 
            // num1
            // 
            this.num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(12, 179);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(42, 23);
            this.num1.TabIndex = 2;
            this.num1.TabStop = false;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num_Click);
            // 
            // num2
            // 
            this.num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(60, 179);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(42, 23);
            this.num2.TabIndex = 2;
            this.num2.TabStop = false;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num_Click);
            // 
            // num3
            // 
            this.num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(108, 179);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(42, 23);
            this.num3.TabIndex = 2;
            this.num3.TabStop = false;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num_Click);
            // 
            // subBtn
            // 
            this.subBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBtn.Location = new System.Drawing.Point(156, 179);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(42, 23);
            this.subBtn.TabIndex = 2;
            this.subBtn.TabStop = false;
            this.subBtn.Text = "-";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // equalBtn
            // 
            this.equalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalBtn.Location = new System.Drawing.Point(204, 179);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(42, 50);
            this.equalBtn.TabIndex = 2;
            this.equalBtn.TabStop = false;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = true;
            this.equalBtn.Click += new System.EventHandler(this.equalBtn_Click);
            // 
            // num0
            // 
            this.num0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.Location = new System.Drawing.Point(12, 208);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(90, 23);
            this.num0.TabIndex = 2;
            this.num0.TabStop = false;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num_Click);
            // 
            // dotBtn
            // 
            this.dotBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dotBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotBtn.Location = new System.Drawing.Point(108, 208);
            this.dotBtn.Name = "dotBtn";
            this.dotBtn.Size = new System.Drawing.Size(42, 23);
            this.dotBtn.TabIndex = 2;
            this.dotBtn.TabStop = false;
            this.dotBtn.Text = ".";
            this.dotBtn.UseVisualStyleBackColor = true;
            this.dotBtn.Click += new System.EventHandler(this.dotBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(156, 208);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(42, 23);
            this.addBtn.TabIndex = 2;
            this.addBtn.TabStop = false;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // digitGroupToolStripMenuItem
            // 
            this.digitGroupToolStripMenuItem.CheckOnClick = true;
            this.digitGroupToolStripMenuItem.Name = "digitGroupToolStripMenuItem";
            this.digitGroupToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.digitGroupToolStripMenuItem.Text = "Digit Group";
            this.digitGroupToolStripMenuItem.CheckedChanged += new System.EventHandler(this.digitGroupToolStripMenuItem_CheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Click to resore";
            this.notifyIcon1.BalloonTipTitle = "Calculator";
            this.notifyIcon1.Text = "Calculator";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 241);
            this.Controls.Add(this.equalBtn);
            this.Controls.Add(this.invBtn);
            this.Controls.Add(this.percentBtn);
            this.Controls.Add(this.sqrtBtn);
            this.Controls.Add(this.memSubBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.mulBtn);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.changeSignBtn);
            this.Controls.Add(this.memAddBtn);
            this.Controls.Add(this.dotBtn);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.memStoreBtn);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.clearEntryBtn);
            this.Controls.Add(this.memRecallBtn);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.memClearBtn);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem copyMenu;
        private System.Windows.Forms.ToolStripMenuItem pasteMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.TextBox screen;
        private System.Windows.Forms.Button memClearBtn;
        private System.Windows.Forms.Button memRecallBtn;
        private System.Windows.Forms.Button memStoreBtn;
        private System.Windows.Forms.Button memAddBtn;
        private System.Windows.Forms.Button memSubBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button clearEntryBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button changeSignBtn;
        private System.Windows.Forms.Button sqrtBtn;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button percentBtn;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button mulBtn;
        private System.Windows.Forms.Button invBtn;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Button equalBtn;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button dotBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem digitGroupToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

