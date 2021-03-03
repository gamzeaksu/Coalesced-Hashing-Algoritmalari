namespace CENG307_171180005_HW1
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
            this.button_LICH = new System.Windows.Forms.Button();
            this.button_EISCH = new System.Windows.Forms.Button();
            this.button_LICH_SEARCH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.button_EISCH_SEARCH = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_keys_size = new System.Windows.Forms.TextBox();
            this.dataGridView_eisch = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_pri = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView_reisch = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_BLISCH = new System.Windows.Forms.Button();
            this.button_REISCH = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button_BLISCH_SEARCH = new System.Windows.Forms.Button();
            this.button_REISCH_SEARCH = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button_table = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_lich_performance = new System.Windows.Forms.Label();
            this.lbl_blisch_performance = new System.Windows.Forms.Label();
            this.lbl_reisch_performance = new System.Windows.Forms.Label();
            this.lbl_eisch_performance = new System.Windows.Forms.Label();
            this.dataGridView_data = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_status = new System.Windows.Forms.ListBox();
            this.lbl_table = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_avg_lich = new System.Windows.Forms.Label();
            this.lbl_avg_eisch = new System.Windows.Forms.Label();
            this.lbl_avg_reisch = new System.Windows.Forms.Label();
            this.lbl_avg_blisch = new System.Windows.Forms.Label();
            this.rb_prime = new System.Windows.Forms.RadioButton();
            this.rb_notPrime = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_blisch = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_lich = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_eisch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_reisch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_blisch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lich)).BeginInit();
            this.SuspendLayout();
            // 
            // button_LICH
            // 
            this.button_LICH.BackColor = System.Drawing.Color.Aqua;
            this.button_LICH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_LICH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_LICH.ForeColor = System.Drawing.Color.Black;
            this.button_LICH.Location = new System.Drawing.Point(541, 21);
            this.button_LICH.Margin = new System.Windows.Forms.Padding(4);
            this.button_LICH.Name = "button_LICH";
            this.button_LICH.Size = new System.Drawing.Size(157, 139);
            this.button_LICH.TabIndex = 0;
            this.button_LICH.Text = "LATE INSERTION COALESCED HASHING";
            this.button_LICH.UseVisualStyleBackColor = false;
            this.button_LICH.Click += new System.EventHandler(this.button_LICH_Click);
            // 
            // button_EISCH
            // 
            this.button_EISCH.BackColor = System.Drawing.Color.Aqua;
            this.button_EISCH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_EISCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_EISCH.ForeColor = System.Drawing.Color.Black;
            this.button_EISCH.Location = new System.Drawing.Point(718, 21);
            this.button_EISCH.Margin = new System.Windows.Forms.Padding(4);
            this.button_EISCH.Name = "button_EISCH";
            this.button_EISCH.Size = new System.Drawing.Size(157, 139);
            this.button_EISCH.TabIndex = 8;
            this.button_EISCH.Text = "EARLY INSERTION STANDARD COALESCED HASHING";
            this.button_EISCH.UseVisualStyleBackColor = false;
            this.button_EISCH.Click += new System.EventHandler(this.button_EISCH_Click);
            // 
            // button_LICH_SEARCH
            // 
            this.button_LICH_SEARCH.BackColor = System.Drawing.Color.Aqua;
            this.button_LICH_SEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_LICH_SEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_LICH_SEARCH.ForeColor = System.Drawing.Color.Black;
            this.button_LICH_SEARCH.Location = new System.Drawing.Point(1349, 267);
            this.button_LICH_SEARCH.Margin = new System.Windows.Forms.Padding(4);
            this.button_LICH_SEARCH.Name = "button_LICH_SEARCH";
            this.button_LICH_SEARCH.Size = new System.Drawing.Size(171, 74);
            this.button_LICH_SEARCH.TabIndex = 9;
            this.button_LICH_SEARCH.Text = "LICH SEARCH";
            this.button_LICH_SEARCH.UseVisualStyleBackColor = false;
            this.button_LICH_SEARCH.Click += new System.EventHandler(this.button_LICH_SEARCH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1345, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter a number : ";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_search.Location = new System.Drawing.Point(1380, 225);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(113, 34);
            this.txt_search.TabIndex = 11;
            // 
            // button_EISCH_SEARCH
            // 
            this.button_EISCH_SEARCH.BackColor = System.Drawing.Color.Aqua;
            this.button_EISCH_SEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_EISCH_SEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_EISCH_SEARCH.ForeColor = System.Drawing.Color.Black;
            this.button_EISCH_SEARCH.Location = new System.Drawing.Point(1349, 358);
            this.button_EISCH_SEARCH.Margin = new System.Windows.Forms.Padding(4);
            this.button_EISCH_SEARCH.Name = "button_EISCH_SEARCH";
            this.button_EISCH_SEARCH.Size = new System.Drawing.Size(171, 74);
            this.button_EISCH_SEARCH.TabIndex = 12;
            this.button_EISCH_SEARCH.Text = "EISCH SEARCH";
            this.button_EISCH_SEARCH.UseVisualStyleBackColor = false;
            this.button_EISCH_SEARCH.Click += new System.EventHandler(this.button_EISCH_SEARCH_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(42, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Keys Size: ";
            // 
            // txt_keys_size
            // 
            this.txt_keys_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_keys_size.Location = new System.Drawing.Point(163, 118);
            this.txt_keys_size.Margin = new System.Windows.Forms.Padding(4);
            this.txt_keys_size.MaxLength = 3;
            this.txt_keys_size.Name = "txt_keys_size";
            this.txt_keys_size.Size = new System.Drawing.Size(76, 34);
            this.txt_keys_size.TabIndex = 19;
            this.txt_keys_size.TextChanged += new System.EventHandler(this.txt_keys_size_TextChanged);
            // 
            // dataGridView_eisch
            // 
            this.dataGridView_eisch.AllowUserToAddRows = false;
            this.dataGridView_eisch.AllowUserToDeleteRows = false;
            this.dataGridView_eisch.AllowUserToResizeRows = false;
            this.dataGridView_eisch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_eisch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView_eisch.Location = new System.Drawing.Point(448, 225);
            this.dataGridView_eisch.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_eisch.Name = "dataGridView_eisch";
            this.dataGridView_eisch.RowHeadersWidth = 51;
            this.dataGridView_eisch.RowTemplate.Height = 24;
            this.dataGridView_eisch.Size = new System.Drawing.Size(288, 342);
            this.dataGridView_eisch.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Index";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Data";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Link";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Probe";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(521, 571);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 32);
            this.label6.TabIndex = 25;
            this.label6.Text = "EISCH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(242, 571);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 32);
            this.label7.TabIndex = 26;
            this.label7.Text = "LICH";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(42, 153);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 29);
            this.label8.TabIndex = 28;
            this.label8.Text = "Primary Area Size:";
            // 
            // txt_pri
            // 
            this.txt_pri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_pri.Location = new System.Drawing.Point(232, 149);
            this.txt_pri.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pri.MaxLength = 3;
            this.txt_pri.Name = "txt_pri";
            this.txt_pri.Size = new System.Drawing.Size(62, 34);
            this.txt_pri.TabIndex = 27;
            this.toolTip1.SetToolTip(this.txt_pri, "Recommended Primary Area Size");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(28, 184);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(554, 29);
            this.label9.TabIndex = 29;
            this.label9.Text = "**The size of primary area is valid only for lich.";
            // 
            // dataGridView_reisch
            // 
            this.dataGridView_reisch.AllowUserToAddRows = false;
            this.dataGridView_reisch.AllowUserToDeleteRows = false;
            this.dataGridView_reisch.AllowUserToResizeRows = false;
            this.dataGridView_reisch.ColumnHeadersHeight = 29;
            this.dataGridView_reisch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView_reisch.Location = new System.Drawing.Point(744, 226);
            this.dataGridView_reisch.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_reisch.Name = "dataGridView_reisch";
            this.dataGridView_reisch.RowHeadersWidth = 51;
            this.dataGridView_reisch.RowTemplate.Height = 24;
            this.dataGridView_reisch.Size = new System.Drawing.Size(292, 342);
            this.dataGridView_reisch.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Index";
            this.dataGridViewTextBoxColumn5.MaxInputLength = 1000;
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Data";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Link";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 60;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Probe";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 60;
            // 
            // button_BLISCH
            // 
            this.button_BLISCH.BackColor = System.Drawing.Color.Aqua;
            this.button_BLISCH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_BLISCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_BLISCH.ForeColor = System.Drawing.Color.Black;
            this.button_BLISCH.Location = new System.Drawing.Point(1072, 21);
            this.button_BLISCH.Margin = new System.Windows.Forms.Padding(4);
            this.button_BLISCH.Name = "button_BLISCH";
            this.button_BLISCH.Size = new System.Drawing.Size(157, 139);
            this.button_BLISCH.TabIndex = 31;
            this.button_BLISCH.Text = "BIDIRECTIONAL LATE INSERTION STANDARD COALESCED HASHING";
            this.button_BLISCH.UseVisualStyleBackColor = false;
            this.button_BLISCH.Click += new System.EventHandler(this.button_BLISCH_Click);
            // 
            // button_REISCH
            // 
            this.button_REISCH.BackColor = System.Drawing.Color.Aqua;
            this.button_REISCH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_REISCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_REISCH.ForeColor = System.Drawing.Color.Black;
            this.button_REISCH.Location = new System.Drawing.Point(895, 21);
            this.button_REISCH.Margin = new System.Windows.Forms.Padding(4);
            this.button_REISCH.Name = "button_REISCH";
            this.button_REISCH.Size = new System.Drawing.Size(157, 139);
            this.button_REISCH.TabIndex = 32;
            this.button_REISCH.Text = "RANDOM INSERTION STANDARD COALESCED HASHING";
            this.button_REISCH.UseVisualStyleBackColor = false;
            this.button_REISCH.Click += new System.EventHandler(this.button_REISCH_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(830, 571);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 32);
            this.label10.TabIndex = 34;
            this.label10.Text = "REISCH";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(1146, 571);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 32);
            this.label11.TabIndex = 35;
            this.label11.Text = "BLlSCH";
            // 
            // button_BLISCH_SEARCH
            // 
            this.button_BLISCH_SEARCH.BackColor = System.Drawing.Color.Aqua;
            this.button_BLISCH_SEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_BLISCH_SEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_BLISCH_SEARCH.ForeColor = System.Drawing.Color.Black;
            this.button_BLISCH_SEARCH.Location = new System.Drawing.Point(1349, 540);
            this.button_BLISCH_SEARCH.Margin = new System.Windows.Forms.Padding(4);
            this.button_BLISCH_SEARCH.Name = "button_BLISCH_SEARCH";
            this.button_BLISCH_SEARCH.Size = new System.Drawing.Size(171, 74);
            this.button_BLISCH_SEARCH.TabIndex = 36;
            this.button_BLISCH_SEARCH.Text = "BLISCH SEARCH";
            this.button_BLISCH_SEARCH.UseVisualStyleBackColor = false;
            this.button_BLISCH_SEARCH.Click += new System.EventHandler(this.button_BLISCH_SEARCH_Click);
            // 
            // button_REISCH_SEARCH
            // 
            this.button_REISCH_SEARCH.BackColor = System.Drawing.Color.Aqua;
            this.button_REISCH_SEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_REISCH_SEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_REISCH_SEARCH.ForeColor = System.Drawing.Color.Black;
            this.button_REISCH_SEARCH.Location = new System.Drawing.Point(1349, 452);
            this.button_REISCH_SEARCH.Margin = new System.Windows.Forms.Padding(4);
            this.button_REISCH_SEARCH.Name = "button_REISCH_SEARCH";
            this.button_REISCH_SEARCH.Size = new System.Drawing.Size(171, 74);
            this.button_REISCH_SEARCH.TabIndex = 37;
            this.button_REISCH_SEARCH.Text = "REISCH SEARCH";
            this.button_REISCH_SEARCH.UseVisualStyleBackColor = false;
            this.button_REISCH_SEARCH.Click += new System.EventHandler(this.button_REISCH_SEARCH_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1300, 648);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 72);
            this.label2.TabIndex = 38;
            this.label2.Text = "GAMZE AKSU\r\n171180005";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(30, 664);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 32);
            this.label12.TabIndex = 39;
            this.label12.Text = "STATUS:";
            // 
            // button_table
            // 
            this.button_table.BackColor = System.Drawing.Color.Aqua;
            this.button_table.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_table.ForeColor = System.Drawing.Color.Black;
            this.button_table.Location = new System.Drawing.Point(376, 21);
            this.button_table.Margin = new System.Windows.Forms.Padding(4);
            this.button_table.Name = "button_table";
            this.button_table.Size = new System.Drawing.Size(157, 139);
            this.button_table.TabIndex = 40;
            this.button_table.Text = "CREATE TABLE";
            this.button_table.UseVisualStyleBackColor = false;
            this.button_table.Click += new System.EventHandler(this.button_table_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(42, 60);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(201, 29);
            this.label13.TabIndex = 41;
            this.label13.Text = "Packing Factor: ";
            // 
            // lbl_lich_performance
            // 
            this.lbl_lich_performance.AutoSize = true;
            this.lbl_lich_performance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_lich_performance.Location = new System.Drawing.Point(1258, 32);
            this.lbl_lich_performance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lich_performance.Name = "lbl_lich_performance";
            this.lbl_lich_performance.Size = new System.Drawing.Size(202, 25);
            this.lbl_lich_performance.TabIndex = 42;
            this.lbl_lich_performance.Text = "LICH Performance: ";
            // 
            // lbl_blisch_performance
            // 
            this.lbl_blisch_performance.AutoSize = true;
            this.lbl_blisch_performance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_blisch_performance.Location = new System.Drawing.Point(1231, 125);
            this.lbl_blisch_performance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_blisch_performance.Name = "lbl_blisch_performance";
            this.lbl_blisch_performance.Size = new System.Drawing.Size(237, 25);
            this.lbl_blisch_performance.TabIndex = 43;
            this.lbl_blisch_performance.Text = "BLISCH Performance:  ";
            // 
            // lbl_reisch_performance
            // 
            this.lbl_reisch_performance.AutoSize = true;
            this.lbl_reisch_performance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_reisch_performance.Location = new System.Drawing.Point(1231, 95);
            this.lbl_reisch_performance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_reisch_performance.Name = "lbl_reisch_performance";
            this.lbl_reisch_performance.Size = new System.Drawing.Size(233, 25);
            this.lbl_reisch_performance.TabIndex = 44;
            this.lbl_reisch_performance.Text = "REISCH Performance: ";
            // 
            // lbl_eisch_performance
            // 
            this.lbl_eisch_performance.AutoSize = true;
            this.lbl_eisch_performance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_eisch_performance.Location = new System.Drawing.Point(1245, 64);
            this.lbl_eisch_performance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_eisch_performance.Name = "lbl_eisch_performance";
            this.lbl_eisch_performance.Size = new System.Drawing.Size(219, 25);
            this.lbl_eisch_performance.TabIndex = 45;
            this.lbl_eisch_performance.Text = "EISCH Performance: ";
            // 
            // dataGridView_data
            // 
            this.dataGridView_data.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.dataGridView_data.AllowUserToAddRows = false;
            this.dataGridView_data.AllowUserToDeleteRows = false;
            this.dataGridView_data.AllowUserToResizeRows = false;
            this.dataGridView_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView_data.Location = new System.Drawing.Point(13, 226);
            this.dataGridView_data.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_data.Name = "dataGridView_data";
            this.dataGridView_data.RowHeadersWidth = 51;
            this.dataGridView_data.Size = new System.Drawing.Size(122, 342);
            this.dataGridView_data.TabIndex = 46;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Data";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 69;
            // 
            // lb_status
            // 
            this.lb_status.FormattingEnabled = true;
            this.lb_status.ItemHeight = 20;
            this.lb_status.Location = new System.Drawing.Point(174, 616);
            this.lb_status.Margin = new System.Windows.Forms.Padding(4);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(559, 104);
            this.lb_status.TabIndex = 47;
            // 
            // lbl_table
            // 
            this.lbl_table.AutoSize = true;
            this.lbl_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_table.Location = new System.Drawing.Point(42, 91);
            this.lbl_table.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_table.Name = "lbl_table";
            this.lbl_table.Size = new System.Drawing.Size(153, 29);
            this.lbl_table.TabIndex = 48;
            this.lbl_table.Text = "Table Size: ";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // lbl_avg_lich
            // 
            this.lbl_avg_lich.AutoSize = true;
            this.lbl_avg_lich.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_avg_lich.Location = new System.Drawing.Point(741, 616);
            this.lbl_avg_lich.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_avg_lich.Name = "lbl_avg_lich";
            this.lbl_avg_lich.Size = new System.Drawing.Size(323, 29);
            this.lbl_avg_lich.TabIndex = 49;
            this.lbl_avg_lich.Text = "Average Number of Probe:";
            // 
            // lbl_avg_eisch
            // 
            this.lbl_avg_eisch.AutoSize = true;
            this.lbl_avg_eisch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_avg_eisch.Location = new System.Drawing.Point(741, 654);
            this.lbl_avg_eisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_avg_eisch.Name = "lbl_avg_eisch";
            this.lbl_avg_eisch.Size = new System.Drawing.Size(323, 29);
            this.lbl_avg_eisch.TabIndex = 50;
            this.lbl_avg_eisch.Text = "Average Number of Probe:";
            // 
            // lbl_avg_reisch
            // 
            this.lbl_avg_reisch.AutoSize = true;
            this.lbl_avg_reisch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_avg_reisch.Location = new System.Drawing.Point(741, 692);
            this.lbl_avg_reisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_avg_reisch.Name = "lbl_avg_reisch";
            this.lbl_avg_reisch.Size = new System.Drawing.Size(323, 29);
            this.lbl_avg_reisch.TabIndex = 51;
            this.lbl_avg_reisch.Text = "Average Number of Probe:";
            // 
            // lbl_avg_blisch
            // 
            this.lbl_avg_blisch.AutoSize = true;
            this.lbl_avg_blisch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_avg_blisch.Location = new System.Drawing.Point(741, 730);
            this.lbl_avg_blisch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_avg_blisch.Name = "lbl_avg_blisch";
            this.lbl_avg_blisch.Size = new System.Drawing.Size(323, 29);
            this.lbl_avg_blisch.TabIndex = 52;
            this.lbl_avg_blisch.Text = "Average Number of Probe:";
            // 
            // rb_prime
            // 
            this.rb_prime.AutoSize = true;
            this.rb_prime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_prime.Location = new System.Drawing.Point(169, 31);
            this.rb_prime.Name = "rb_prime";
            this.rb_prime.Size = new System.Drawing.Size(85, 28);
            this.rb_prime.TabIndex = 53;
            this.rb_prime.Text = "Prime";
            this.rb_prime.UseVisualStyleBackColor = true;
            // 
            // rb_notPrime
            // 
            this.rb_notPrime.AutoSize = true;
            this.rb_notPrime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_notPrime.Location = new System.Drawing.Point(246, 31);
            this.rb_notPrime.Name = "rb_notPrime";
            this.rb_notPrime.Size = new System.Drawing.Size(123, 28);
            this.rb_notPrime.TabIndex = 54;
            this.rb_notPrime.Text = "Not Prime";
            this.rb_notPrime.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(41, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 29);
            this.label3.TabIndex = 55;
            this.label3.Text = "Table Size: ";
            // 
            // dataGridView_blisch
            // 
            this.dataGridView_blisch.AllowUserToAddRows = false;
            this.dataGridView_blisch.AllowUserToDeleteRows = false;
            this.dataGridView_blisch.AllowUserToResizeRows = false;
            this.dataGridView_blisch.ColumnHeadersHeight = 29;
            this.dataGridView_blisch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dataGridView_blisch.Location = new System.Drawing.Point(1049, 226);
            this.dataGridView_blisch.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_blisch.Name = "dataGridView_blisch";
            this.dataGridView_blisch.RowHeadersWidth = 51;
            this.dataGridView_blisch.RowTemplate.Height = 24;
            this.dataGridView_blisch.Size = new System.Drawing.Size(292, 342);
            this.dataGridView_blisch.TabIndex = 56;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Index";
            this.dataGridViewTextBoxColumn9.MaxInputLength = 1000;
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 60;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Data";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 60;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Link";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 60;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Probe";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 60;
            // 
            // dataGridView_lich
            // 
            this.dataGridView_lich.AllowUserToAddRows = false;
            this.dataGridView_lich.AllowUserToDeleteRows = false;
            this.dataGridView_lich.AllowUserToResizeRows = false;
            this.dataGridView_lich.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView_lich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_lich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.dataGridView_lich.Location = new System.Drawing.Point(148, 226);
            this.dataGridView_lich.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_lich.Name = "dataGridView_lich";
            this.dataGridView_lich.RowHeadersWidth = 51;
            this.dataGridView_lich.RowTemplate.Height = 24;
            this.dataGridView_lich.Size = new System.Drawing.Size(288, 342);
            this.dataGridView_lich.TabIndex = 57;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Index";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn13.Width = 60;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Data";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 60;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Link";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 60;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Probe";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 727);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 32);
            this.label4.TabIndex = 58;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1534, 761);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView_lich);
            this.Controls.Add(this.dataGridView_blisch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb_notPrime);
            this.Controls.Add(this.rb_prime);
            this.Controls.Add(this.lbl_avg_blisch);
            this.Controls.Add(this.lbl_avg_reisch);
            this.Controls.Add(this.lbl_avg_eisch);
            this.Controls.Add(this.lbl_avg_lich);
            this.Controls.Add(this.lbl_table);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.dataGridView_data);
            this.Controls.Add(this.lbl_eisch_performance);
            this.Controls.Add(this.lbl_reisch_performance);
            this.Controls.Add(this.lbl_blisch_performance);
            this.Controls.Add(this.lbl_lich_performance);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button_table);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_REISCH_SEARCH);
            this.Controls.Add(this.button_BLISCH_SEARCH);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button_REISCH);
            this.Controls.Add(this.button_BLISCH);
            this.Controls.Add(this.dataGridView_reisch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_pri);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView_eisch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_keys_size);
            this.Controls.Add(this.button_EISCH_SEARCH);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_LICH_SEARCH);
            this.Controls.Add(this.button_EISCH);
            this.Controls.Add(this.button_LICH);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAMZE_AKSU_171180005";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_eisch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_reisch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_blisch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_LICH;
        private System.Windows.Forms.Button button_EISCH;
        private System.Windows.Forms.Button button_LICH_SEARCH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button button_EISCH_SEARCH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_keys_size;
        private System.Windows.Forms.DataGridView dataGridView_eisch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_pri;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView_reisch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button_BLISCH;
        private System.Windows.Forms.Button button_REISCH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_BLISCH_SEARCH;
        private System.Windows.Forms.Button button_REISCH_SEARCH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_table;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_lich_performance;
        private System.Windows.Forms.Label lbl_blisch_performance;
        private System.Windows.Forms.Label lbl_reisch_performance;
        private System.Windows.Forms.Label lbl_eisch_performance;
        private System.Windows.Forms.DataGridView dataGridView_data;
        private System.Windows.Forms.ListBox lb_status;
        private System.Windows.Forms.Label lbl_table;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbl_avg_lich;
        private System.Windows.Forms.Label lbl_avg_eisch;
        private System.Windows.Forms.Label lbl_avg_reisch;
        private System.Windows.Forms.Label lbl_avg_blisch;
        private System.Windows.Forms.RadioButton rb_prime;
        private System.Windows.Forms.RadioButton rb_notPrime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_blisch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridView dataGridView_lich;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.Label label4;
    }
}

