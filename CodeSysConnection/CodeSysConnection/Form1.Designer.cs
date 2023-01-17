namespace CodeSysConnection
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timerConnection = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inputW10 = new System.Windows.Forms.TextBox();
            this.inputW8 = new System.Windows.Forms.TextBox();
            this.inputW4 = new System.Windows.Forms.TextBox();
            this.inputW9 = new System.Windows.Forms.TextBox();
            this.inputW7 = new System.Windows.Forms.TextBox();
            this.inputW3 = new System.Windows.Forms.TextBox();
            this.inputW6 = new System.Windows.Forms.TextBox();
            this.inputW2 = new System.Windows.Forms.TextBox();
            this.inputW5 = new System.Windows.Forms.TextBox();
            this.inputW1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.holdingW10 = new System.Windows.Forms.TextBox();
            this.holdingW9 = new System.Windows.Forms.TextBox();
            this.holdingW8 = new System.Windows.Forms.TextBox();
            this.holdingW7 = new System.Windows.Forms.TextBox();
            this.holdingW6 = new System.Windows.Forms.TextBox();
            this.holdingW5 = new System.Windows.Forms.TextBox();
            this.holdingW4 = new System.Windows.Forms.TextBox();
            this.holdingW3 = new System.Windows.Forms.TextBox();
            this.holdingW2 = new System.Windows.Forms.TextBox();
            this.holdingW1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(97, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP ADRESS";
            // 
            // txtIp
            // 
            this.txtIp.BackColor = System.Drawing.Color.DarkGray;
            this.txtIp.Location = new System.Drawing.Point(17, 35);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(249, 20);
            this.txtIp.TabIndex = 1;
            this.txtIp.Text = "192.168.88.100";
            this.txtIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.DarkGray;
            this.txtPort.Location = new System.Drawing.Point(296, 35);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(249, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "502";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConnect
            // 
            this.btnConnect.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConnect.ForeColor = System.Drawing.Color.Yellow;
            this.btnConnect.Location = new System.Drawing.Point(372, 65);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(70, 22);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDisconnect.ForeColor = System.Drawing.Color.Yellow;
            this.btnDisconnect.Location = new System.Drawing.Point(451, 65);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(94, 22);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "DISCONNECT";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.Gray;
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatus.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStatus.ForeColor = System.Drawing.Color.Yellow;
            this.txtStatus.Location = new System.Drawing.Point(-1, 482);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(0);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(563, 12);
            this.txtStatus.TabIndex = 1;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStatus.TextChanged += new System.EventHandler(this.txtStatus_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(403, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "PORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Connection Status :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.ForeColor = System.Drawing.Color.Lime;
            this.lblStatus.Location = new System.Drawing.Point(168, 67);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 21);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.txtIp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(5, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 99);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Parameters";
            // 
            // timerConnection
            // 
            this.timerConnection.Interval = 50;
            this.timerConnection.Tick += new System.EventHandler(this.timerConnection_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inputW10);
            this.groupBox2.Controls.Add(this.inputW8);
            this.groupBox2.Controls.Add(this.inputW4);
            this.groupBox2.Controls.Add(this.inputW9);
            this.groupBox2.Controls.Add(this.inputW7);
            this.groupBox2.Controls.Add(this.inputW3);
            this.groupBox2.Controls.Add(this.inputW6);
            this.groupBox2.Controls.Add(this.inputW2);
            this.groupBox2.Controls.Add(this.inputW5);
            this.groupBox2.Controls.Add(this.inputW1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(13, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 325);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MODBUS INPUT REGISTERS";
            // 
            // inputW10
            // 
            this.inputW10.BackColor = System.Drawing.Color.Gray;
            this.inputW10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inputW10.ForeColor = System.Drawing.Color.White;
            this.inputW10.Location = new System.Drawing.Point(88, 284);
            this.inputW10.Name = "inputW10";
            this.inputW10.ReadOnly = true;
            this.inputW10.Size = new System.Drawing.Size(166, 20);
            this.inputW10.TabIndex = 1;
            this.inputW10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputW8
            // 
            this.inputW8.BackColor = System.Drawing.Color.Gray;
            this.inputW8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inputW8.ForeColor = System.Drawing.Color.White;
            this.inputW8.Location = new System.Drawing.Point(88, 230);
            this.inputW8.Name = "inputW8";
            this.inputW8.ReadOnly = true;
            this.inputW8.Size = new System.Drawing.Size(166, 20);
            this.inputW8.TabIndex = 1;
            this.inputW8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputW4
            // 
            this.inputW4.BackColor = System.Drawing.Color.Gray;
            this.inputW4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inputW4.ForeColor = System.Drawing.Color.White;
            this.inputW4.Location = new System.Drawing.Point(88, 120);
            this.inputW4.Name = "inputW4";
            this.inputW4.ReadOnly = true;
            this.inputW4.Size = new System.Drawing.Size(166, 20);
            this.inputW4.TabIndex = 1;
            this.inputW4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputW9
            // 
            this.inputW9.BackColor = System.Drawing.Color.Gray;
            this.inputW9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inputW9.ForeColor = System.Drawing.Color.White;
            this.inputW9.Location = new System.Drawing.Point(88, 257);
            this.inputW9.Name = "inputW9";
            this.inputW9.ReadOnly = true;
            this.inputW9.Size = new System.Drawing.Size(166, 20);
            this.inputW9.TabIndex = 1;
            this.inputW9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputW7
            // 
            this.inputW7.BackColor = System.Drawing.Color.Gray;
            this.inputW7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inputW7.ForeColor = System.Drawing.Color.White;
            this.inputW7.Location = new System.Drawing.Point(88, 202);
            this.inputW7.Name = "inputW7";
            this.inputW7.ReadOnly = true;
            this.inputW7.Size = new System.Drawing.Size(166, 20);
            this.inputW7.TabIndex = 1;
            this.inputW7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputW3
            // 
            this.inputW3.BackColor = System.Drawing.Color.Gray;
            this.inputW3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inputW3.ForeColor = System.Drawing.Color.White;
            this.inputW3.Location = new System.Drawing.Point(88, 91);
            this.inputW3.Name = "inputW3";
            this.inputW3.ReadOnly = true;
            this.inputW3.Size = new System.Drawing.Size(166, 20);
            this.inputW3.TabIndex = 1;
            this.inputW3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputW6
            // 
            this.inputW6.BackColor = System.Drawing.Color.Gray;
            this.inputW6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inputW6.ForeColor = System.Drawing.Color.White;
            this.inputW6.Location = new System.Drawing.Point(88, 174);
            this.inputW6.Name = "inputW6";
            this.inputW6.ReadOnly = true;
            this.inputW6.Size = new System.Drawing.Size(166, 20);
            this.inputW6.TabIndex = 1;
            this.inputW6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputW2
            // 
            this.inputW2.BackColor = System.Drawing.Color.Gray;
            this.inputW2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inputW2.ForeColor = System.Drawing.Color.White;
            this.inputW2.Location = new System.Drawing.Point(88, 63);
            this.inputW2.Name = "inputW2";
            this.inputW2.ReadOnly = true;
            this.inputW2.Size = new System.Drawing.Size(166, 20);
            this.inputW2.TabIndex = 1;
            this.inputW2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputW5
            // 
            this.inputW5.BackColor = System.Drawing.Color.Gray;
            this.inputW5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inputW5.ForeColor = System.Drawing.Color.White;
            this.inputW5.Location = new System.Drawing.Point(88, 147);
            this.inputW5.Name = "inputW5";
            this.inputW5.ReadOnly = true;
            this.inputW5.Size = new System.Drawing.Size(166, 20);
            this.inputW5.TabIndex = 1;
            this.inputW5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputW1
            // 
            this.inputW1.BackColor = System.Drawing.Color.Gray;
            this.inputW1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inputW1.ForeColor = System.Drawing.Color.White;
            this.inputW1.Location = new System.Drawing.Point(88, 33);
            this.inputW1.Name = "inputW1";
            this.inputW1.ReadOnly = true;
            this.inputW1.Size = new System.Drawing.Size(166, 20);
            this.inputW1.TabIndex = 1;
            this.inputW1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label13.Location = new System.Drawing.Point(9, 288);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "WORD 10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label12.Location = new System.Drawing.Point(16, 260);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "WORD 9";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label11.Location = new System.Drawing.Point(16, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "WORD 8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(16, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "WORD 7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(16, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "WORD 6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(16, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "WORD 5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(16, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "WORD 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(16, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "WORD 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(16, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "WORD 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(16, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "WORD 1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.holdingW10);
            this.groupBox3.Controls.Add(this.holdingW9);
            this.groupBox3.Controls.Add(this.holdingW8);
            this.groupBox3.Controls.Add(this.holdingW7);
            this.groupBox3.Controls.Add(this.holdingW6);
            this.groupBox3.Controls.Add(this.holdingW5);
            this.groupBox3.Controls.Add(this.holdingW4);
            this.groupBox3.Controls.Add(this.holdingW3);
            this.groupBox3.Controls.Add(this.holdingW2);
            this.groupBox3.Controls.Add(this.holdingW1);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox3.Location = new System.Drawing.Point(292, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 325);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MODBUS HOLDİNG REGISTERS";
            // 
            // holdingW10
            // 
            this.holdingW10.Location = new System.Drawing.Point(85, 282);
            this.holdingW10.Name = "holdingW10";
            this.holdingW10.Size = new System.Drawing.Size(166, 20);
            this.holdingW10.TabIndex = 12;
            this.holdingW10.Text = "0";
            // 
            // holdingW9
            // 
            this.holdingW9.Location = new System.Drawing.Point(85, 255);
            this.holdingW9.Name = "holdingW9";
            this.holdingW9.Size = new System.Drawing.Size(166, 20);
            this.holdingW9.TabIndex = 12;
            this.holdingW9.Text = "0";
            // 
            // holdingW8
            // 
            this.holdingW8.Location = new System.Drawing.Point(85, 227);
            this.holdingW8.Name = "holdingW8";
            this.holdingW8.Size = new System.Drawing.Size(166, 20);
            this.holdingW8.TabIndex = 12;
            this.holdingW8.Text = "0";
            // 
            // holdingW7
            // 
            this.holdingW7.Location = new System.Drawing.Point(85, 200);
            this.holdingW7.Name = "holdingW7";
            this.holdingW7.Size = new System.Drawing.Size(166, 20);
            this.holdingW7.TabIndex = 12;
            this.holdingW7.Text = "0";
            // 
            // holdingW6
            // 
            this.holdingW6.Location = new System.Drawing.Point(85, 172);
            this.holdingW6.Name = "holdingW6";
            this.holdingW6.Size = new System.Drawing.Size(166, 20);
            this.holdingW6.TabIndex = 12;
            this.holdingW6.Text = "0";
            // 
            // holdingW5
            // 
            this.holdingW5.Location = new System.Drawing.Point(85, 144);
            this.holdingW5.Name = "holdingW5";
            this.holdingW5.Size = new System.Drawing.Size(166, 20);
            this.holdingW5.TabIndex = 12;
            this.holdingW5.Text = "0";
            // 
            // holdingW4
            // 
            this.holdingW4.Location = new System.Drawing.Point(85, 116);
            this.holdingW4.Name = "holdingW4";
            this.holdingW4.Size = new System.Drawing.Size(166, 20);
            this.holdingW4.TabIndex = 12;
            this.holdingW4.Text = "0";
            // 
            // holdingW3
            // 
            this.holdingW3.Location = new System.Drawing.Point(85, 87);
            this.holdingW3.Name = "holdingW3";
            this.holdingW3.Size = new System.Drawing.Size(166, 20);
            this.holdingW3.TabIndex = 12;
            this.holdingW3.Text = "0";
            // 
            // holdingW2
            // 
            this.holdingW2.Location = new System.Drawing.Point(85, 59);
            this.holdingW2.Name = "holdingW2";
            this.holdingW2.Size = new System.Drawing.Size(166, 20);
            this.holdingW2.TabIndex = 12;
            this.holdingW2.Text = "0";
            // 
            // holdingW1
            // 
            this.holdingW1.Location = new System.Drawing.Point(85, 31);
            this.holdingW1.Name = "holdingW1";
            this.holdingW1.Size = new System.Drawing.Size(166, 20);
            this.holdingW1.TabIndex = 12;
            this.holdingW1.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label14.Location = new System.Drawing.Point(6, 285);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "WORD 10";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label15.Location = new System.Drawing.Point(13, 257);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "WORD 9";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label16.Location = new System.Drawing.Point(13, 229);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 16);
            this.label16.TabIndex = 3;
            this.label16.Text = "WORD 8";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label17.Location = new System.Drawing.Point(13, 201);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 16);
            this.label17.TabIndex = 4;
            this.label17.Text = "WORD 7";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label18.Location = new System.Drawing.Point(13, 173);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 16);
            this.label18.TabIndex = 5;
            this.label18.Text = "WORD 6";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label19.Location = new System.Drawing.Point(13, 145);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 16);
            this.label19.TabIndex = 6;
            this.label19.Text = "WORD 5";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label20.Location = new System.Drawing.Point(13, 117);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 16);
            this.label20.TabIndex = 7;
            this.label20.Text = "WORD 4";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label21.Location = new System.Drawing.Point(13, 89);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 16);
            this.label21.TabIndex = 8;
            this.label21.Text = "WORD 3";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label22.Location = new System.Drawing.Point(13, 61);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 16);
            this.label22.TabIndex = 9;
            this.label22.Text = "WORD 2";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label23.Location = new System.Drawing.Point(13, 33);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 16);
            this.label23.TabIndex = 10;
            this.label23.Text = "WORD 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(563, 500);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtStatus);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " TCP/IP Communication  @zeytEymen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timerConnection;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox inputW10;
        private System.Windows.Forms.TextBox inputW8;
        private System.Windows.Forms.TextBox inputW4;
        private System.Windows.Forms.TextBox inputW9;
        private System.Windows.Forms.TextBox inputW7;
        private System.Windows.Forms.TextBox inputW3;
        private System.Windows.Forms.TextBox inputW6;
        private System.Windows.Forms.TextBox inputW2;
        private System.Windows.Forms.TextBox inputW5;
        private System.Windows.Forms.TextBox inputW1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox holdingW10;
        private System.Windows.Forms.TextBox holdingW9;
        private System.Windows.Forms.TextBox holdingW8;
        private System.Windows.Forms.TextBox holdingW7;
        private System.Windows.Forms.TextBox holdingW6;
        private System.Windows.Forms.TextBox holdingW5;
        private System.Windows.Forms.TextBox holdingW4;
        private System.Windows.Forms.TextBox holdingW3;
        private System.Windows.Forms.TextBox holdingW2;
        private System.Windows.Forms.TextBox holdingW1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
    }
}

