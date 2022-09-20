namespace CardManager
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TAB = new System.Windows.Forms.TabControl();
            this.SYS = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CardDataPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CAR = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.TAB1 = new System.Windows.Forms.TabControl();
            this.CARD1 = new System.Windows.Forms.TabPage();
            this.CARD1AC = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.CARD1NICK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CARD1BT2 = new System.Windows.Forms.Button();
            this.CARD1BT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CARD2 = new System.Windows.Forms.TabPage();
            this.CARD2AC = new System.Windows.Forms.Label();
            this.CARD2NICK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CARD2BT2 = new System.Windows.Forms.Button();
            this.CARD2BT = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CARD3 = new System.Windows.Forms.TabPage();
            this.CARD3AC = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CARD3NICK = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CARD3BT2 = new System.Windows.Forms.Button();
            this.CARD3BT = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.NEWKC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NEWAC = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TAB.SuspendLayout();
            this.SYS.SuspendLayout();
            this.CAR.SuspendLayout();
            this.TAB1.SuspendLayout();
            this.CARD1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.CARD2.SuspendLayout();
            this.CARD3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TAB
            // 
            this.TAB.Controls.Add(this.SYS);
            this.TAB.Controls.Add(this.CAR);
            this.TAB.Location = new System.Drawing.Point(-3, -22);
            this.TAB.Name = "TAB";
            this.TAB.SelectedIndex = 0;
            this.TAB.Size = new System.Drawing.Size(497, 317);
            this.TAB.TabIndex = 0;
            // 
            // SYS
            // 
            this.SYS.Controls.Add(this.button2);
            this.SYS.Controls.Add(this.label3);
            this.SYS.Controls.Add(this.CardDataPath);
            this.SYS.Controls.Add(this.button1);
            this.SYS.Controls.Add(this.label1);
            this.SYS.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SYS.Location = new System.Drawing.Point(4, 22);
            this.SYS.Name = "SYS";
            this.SYS.Padding = new System.Windows.Forms.Padding(3);
            this.SYS.Size = new System.Drawing.Size(489, 279);
            this.SYS.TabIndex = 0;
            this.SYS.Text = "初期設定";
            this.SYS.UseVisualStyleBackColor = true;
            this.SYS.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(251, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 19);
            this.button2.TabIndex = 6;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Card.iniの保存ディレクトリ";
            // 
            // CardDataPath
            // 
            this.CardDataPath.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CardDataPath.Location = new System.Drawing.Point(18, 59);
            this.CardDataPath.Name = "CardDataPath";
            this.CardDataPath.Size = new System.Drawing.Size(227, 19);
            this.CardDataPath.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepPink;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(11, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(459, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "設定完了";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(-5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "設定　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　";
            // 
            // CAR
            // 
            this.CAR.BackColor = System.Drawing.Color.Transparent;
            this.CAR.Controls.Add(this.label12);
            this.CAR.Controls.Add(this.button12);
            this.CAR.Controls.Add(this.label13);
            this.CAR.Location = new System.Drawing.Point(4, 22);
            this.CAR.Name = "CAR";
            this.CAR.Padding = new System.Windows.Forms.Padding(3);
            this.CAR.Size = new System.Drawing.Size(489, 291);
            this.CAR.TabIndex = 1;
            this.CAR.Text = "カードセレクター";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Gold;
            this.label12.Location = new System.Drawing.Point(301, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "Create By Kinako";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Gold;
            this.button12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button12.Location = new System.Drawing.Point(402, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(87, 23);
            this.button12.TabIndex = 3;
            this.button12.Text = "設定";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // TAB1
            // 
            this.TAB1.Controls.Add(this.CARD1);
            this.TAB1.Controls.Add(this.CARD2);
            this.TAB1.Controls.Add(this.CARD3);
            this.TAB1.Controls.Add(this.tabPage1);
            this.TAB1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAB1.Location = new System.Drawing.Point(-3, 29);
            this.TAB1.Multiline = true;
            this.TAB1.Name = "TAB1";
            this.TAB1.SelectedIndex = 0;
            this.TAB1.Size = new System.Drawing.Size(497, 266);
            this.TAB1.TabIndex = 1;
            this.TAB1.Visible = false;
            // 
            // CARD1
            // 
            this.CARD1.BackColor = System.Drawing.Color.White;
            this.CARD1.Controls.Add(this.CARD1NICK);
            this.CARD1.Controls.Add(this.CARD1AC);
            this.CARD1.Controls.Add(this.pictureBox4);
            this.CARD1.Controls.Add(this.label6);
            this.CARD1.Controls.Add(this.CARD1BT2);
            this.CARD1.Controls.Add(this.CARD1BT);
            this.CARD1.Controls.Add(this.label4);
            this.CARD1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CARD1.Location = new System.Drawing.Point(4, 26);
            this.CARD1.Name = "CARD1";
            this.CARD1.Padding = new System.Windows.Forms.Padding(3);
            this.CARD1.Size = new System.Drawing.Size(489, 236);
            this.CARD1.TabIndex = 0;
            this.CARD1.Text = "カード1";
            // 
            // CARD1AC
            // 
            this.CARD1AC.AutoSize = true;
            this.CARD1AC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CARD1AC.Location = new System.Drawing.Point(11, 33);
            this.CARD1AC.Name = "CARD1AC";
            this.CARD1AC.Size = new System.Drawing.Size(135, 17);
            this.CARD1AC.TabIndex = 1;
            this.CARD1AC.Text = "0000-0000-0000-0000";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(256, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(246, 148);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // CARD1NICK
            // 
            this.CARD1NICK.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CARD1NICK.Location = new System.Drawing.Point(15, 89);
            this.CARD1NICK.Name = "CARD1NICK";
            this.CARD1NICK.Size = new System.Drawing.Size(248, 39);
            this.CARD1NICK.TabIndex = 5;
            this.CARD1NICK.TextChanged += new System.EventHandler(this.CARD1NICK_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "カード名";
            // 
            // CARD1BT2
            // 
            this.CARD1BT2.BackColor = System.Drawing.Color.Red;
            this.CARD1BT2.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.CARD1BT2.ForeColor = System.Drawing.Color.White;
            this.CARD1BT2.Location = new System.Drawing.Point(434, 188);
            this.CARD1BT2.Name = "CARD1BT2";
            this.CARD1BT2.Size = new System.Drawing.Size(49, 42);
            this.CARD1BT2.TabIndex = 3;
            this.CARD1BT2.Text = "登録解除";
            this.CARD1BT2.UseVisualStyleBackColor = false;
            this.CARD1BT2.Click += new System.EventHandler(this.button4_Click);
            // 
            // CARD1BT
            // 
            this.CARD1BT.BackColor = System.Drawing.Color.DeepPink;
            this.CARD1BT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CARD1BT.ForeColor = System.Drawing.Color.White;
            this.CARD1BT.Location = new System.Drawing.Point(6, 188);
            this.CARD1BT.Name = "CARD1BT";
            this.CARD1BT.Size = new System.Drawing.Size(422, 42);
            this.CARD1BT.TabIndex = 2;
            this.CARD1BT.Text = "このカードを使用する";
            this.CARD1BT.UseVisualStyleBackColor = false;
            this.CARD1BT.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "アクセスコード";
            // 
            // CARD2
            // 
            this.CARD2.BackColor = System.Drawing.Color.White;
            this.CARD2.Controls.Add(this.CARD2NICK);
            this.CARD2.Controls.Add(this.CARD2AC);
            this.CARD2.Controls.Add(this.pictureBox3);
            this.CARD2.Controls.Add(this.label5);
            this.CARD2.Controls.Add(this.CARD2BT2);
            this.CARD2.Controls.Add(this.CARD2BT);
            this.CARD2.Controls.Add(this.label8);
            this.CARD2.Location = new System.Drawing.Point(4, 26);
            this.CARD2.Name = "CARD2";
            this.CARD2.Padding = new System.Windows.Forms.Padding(3);
            this.CARD2.Size = new System.Drawing.Size(489, 236);
            this.CARD2.TabIndex = 1;
            this.CARD2.Text = "カード2";
            // 
            // CARD2AC
            // 
            this.CARD2AC.AutoSize = true;
            this.CARD2AC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CARD2AC.Location = new System.Drawing.Point(11, 33);
            this.CARD2AC.Name = "CARD2AC";
            this.CARD2AC.Size = new System.Drawing.Size(135, 17);
            this.CARD2AC.TabIndex = 7;
            this.CARD2AC.Text = "0000-0000-0000-0000";
            // 
            // CARD2NICK
            // 
            this.CARD2NICK.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CARD2NICK.Location = new System.Drawing.Point(15, 89);
            this.CARD2NICK.Name = "CARD2NICK";
            this.CARD2NICK.Size = new System.Drawing.Size(248, 39);
            this.CARD2NICK.TabIndex = 11;
            this.CARD2NICK.TextChanged += new System.EventHandler(this.CARD2NICK_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "カード名";
            // 
            // CARD2BT2
            // 
            this.CARD2BT2.BackColor = System.Drawing.Color.Red;
            this.CARD2BT2.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold);
            this.CARD2BT2.ForeColor = System.Drawing.Color.White;
            this.CARD2BT2.Location = new System.Drawing.Point(434, 188);
            this.CARD2BT2.Name = "CARD2BT2";
            this.CARD2BT2.Size = new System.Drawing.Size(49, 42);
            this.CARD2BT2.TabIndex = 9;
            this.CARD2BT2.Text = "登録解除";
            this.CARD2BT2.UseVisualStyleBackColor = false;
            this.CARD2BT2.Click += new System.EventHandler(this.button5_Click);
            // 
            // CARD2BT
            // 
            this.CARD2BT.BackColor = System.Drawing.Color.DeepPink;
            this.CARD2BT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.CARD2BT.ForeColor = System.Drawing.Color.White;
            this.CARD2BT.Location = new System.Drawing.Point(6, 188);
            this.CARD2BT.Name = "CARD2BT";
            this.CARD2BT.Size = new System.Drawing.Size(422, 42);
            this.CARD2BT.TabIndex = 8;
            this.CARD2BT.Text = "このカードを使用する";
            this.CARD2BT.UseVisualStyleBackColor = false;
            this.CARD2BT.Click += new System.EventHandler(this.button6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "アクセスコード";
            // 
            // CARD3
            // 
            this.CARD3.BackColor = System.Drawing.Color.White;
            this.CARD3.Controls.Add(this.CARD3NICK);
            this.CARD3.Controls.Add(this.CARD3AC);
            this.CARD3.Controls.Add(this.pictureBox1);
            this.CARD3.Controls.Add(this.label9);
            this.CARD3.Controls.Add(this.CARD3BT2);
            this.CARD3.Controls.Add(this.CARD3BT);
            this.CARD3.Controls.Add(this.label11);
            this.CARD3.Location = new System.Drawing.Point(4, 26);
            this.CARD3.Name = "CARD3";
            this.CARD3.Padding = new System.Windows.Forms.Padding(3);
            this.CARD3.Size = new System.Drawing.Size(489, 236);
            this.CARD3.TabIndex = 2;
            this.CARD3.Text = "カード3";
            // 
            // CARD3AC
            // 
            this.CARD3AC.AutoSize = true;
            this.CARD3AC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CARD3AC.Location = new System.Drawing.Point(11, 33);
            this.CARD3AC.Name = "CARD3AC";
            this.CARD3AC.Size = new System.Drawing.Size(135, 17);
            this.CARD3AC.TabIndex = 7;
            this.CARD3AC.Text = "0000-0000-0000-0000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(256, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // CARD3NICK
            // 
            this.CARD3NICK.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CARD3NICK.Location = new System.Drawing.Point(15, 89);
            this.CARD3NICK.Name = "CARD3NICK";
            this.CARD3NICK.Size = new System.Drawing.Size(248, 39);
            this.CARD3NICK.TabIndex = 11;
            this.CARD3NICK.Click += new System.EventHandler(this.CARD3NICK_Click);
            this.CARD3NICK.TextChanged += new System.EventHandler(this.CARD3NICK_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 21);
            this.label9.TabIndex = 10;
            this.label9.Text = "カード名";
            // 
            // CARD3BT2
            // 
            this.CARD3BT2.BackColor = System.Drawing.Color.Red;
            this.CARD3BT2.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CARD3BT2.ForeColor = System.Drawing.Color.White;
            this.CARD3BT2.Location = new System.Drawing.Point(434, 188);
            this.CARD3BT2.Name = "CARD3BT2";
            this.CARD3BT2.Size = new System.Drawing.Size(49, 42);
            this.CARD3BT2.TabIndex = 9;
            this.CARD3BT2.Text = "登録解除";
            this.CARD3BT2.UseVisualStyleBackColor = false;
            this.CARD3BT2.Click += new System.EventHandler(this.button7_Click);
            // 
            // CARD3BT
            // 
            this.CARD3BT.BackColor = System.Drawing.Color.DeepPink;
            this.CARD3BT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.CARD3BT.ForeColor = System.Drawing.Color.White;
            this.CARD3BT.Location = new System.Drawing.Point(6, 188);
            this.CARD3BT.Name = "CARD3BT";
            this.CARD3BT.Size = new System.Drawing.Size(422, 42);
            this.CARD3BT.TabIndex = 8;
            this.CARD3BT.Text = "このカードを使用する";
            this.CARD3BT.UseVisualStyleBackColor = false;
            this.CARD3BT.Click += new System.EventHandler(this.button8_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 21);
            this.label11.TabIndex = 6;
            this.label11.Text = "アクセスコード";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.NEWKC);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.NEWAC);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(489, 236);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "カード新規登録";
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(11, 199);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(465, 24);
            this.button11.TabIndex = 12;
            this.button11.Text = "スロット3へ登録";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(11, 169);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(465, 24);
            this.button10.TabIndex = 11;
            this.button10.Text = "スロット2へ登録";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(11, 139);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(465, 24);
            this.button9.TabIndex = 10;
            this.button9.Text = "スロット1へ登録";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // NEWKC
            // 
            this.NEWKC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEWKC.Location = new System.Drawing.Point(11, 92);
            this.NEWKC.Name = "NEWKC";
            this.NEWKC.Size = new System.Drawing.Size(465, 29);
            this.NEWKC.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "チップID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "アクセスコード";
            // 
            // NEWAC
            // 
            this.NEWAC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEWAC.Location = new System.Drawing.Point(11, 36);
            this.NEWAC.Name = "NEWAC";
            this.NEWAC.Size = new System.Drawing.Size(465, 29);
            this.NEWAC.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Gold;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(-5, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(694, 25);
            this.label13.TabIndex = 5;
            this.label13.Text = "カード情報　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(256, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(246, 148);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 292);
            this.Controls.Add(this.TAB1);
            this.Controls.Add(this.TAB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Card Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TAB.ResumeLayout(false);
            this.SYS.ResumeLayout(false);
            this.SYS.PerformLayout();
            this.CAR.ResumeLayout(false);
            this.CAR.PerformLayout();
            this.TAB1.ResumeLayout(false);
            this.CARD1.ResumeLayout(false);
            this.CARD1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.CARD2.ResumeLayout(false);
            this.CARD2.PerformLayout();
            this.CARD3.ResumeLayout(false);
            this.CARD3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TAB;
        private System.Windows.Forms.TabPage SYS;
        private System.Windows.Forms.TabPage CAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CardDataPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl TAB1;
        private System.Windows.Forms.TabPage CARD1;
        private System.Windows.Forms.TextBox CARD1NICK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CARD1BT2;
        private System.Windows.Forms.Button CARD1BT;
        private System.Windows.Forms.Label CARD1AC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage CARD2;
        private System.Windows.Forms.TabPage CARD3;
        private System.Windows.Forms.TextBox CARD2NICK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CARD2BT2;
        private System.Windows.Forms.Button CARD2BT;
        private System.Windows.Forms.Label CARD2AC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CARD3NICK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button CARD3BT2;
        private System.Windows.Forms.Button CARD3BT;
        private System.Windows.Forms.Label CARD3AC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox NEWKC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NEWAC;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

