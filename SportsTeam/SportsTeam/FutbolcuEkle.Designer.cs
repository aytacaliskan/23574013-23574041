namespace SportsTeam
{
    partial class FutbolcuEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.sportsTeamDataSet = new SportsTeam.SportsTeamDataSet();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter = new SportsTeam.SportsTeamDataSetTableAdapters.PlayersTableAdapter();
            this.playersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sportsTeamDataSet1 = new SportsTeam.SportsTeamDataSet1();
            this.playersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter1 = new SportsTeam.SportsTeamDataSet1TableAdapters.PlayersTableAdapter();
            this.playersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.playersBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sportsTeamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsTeamDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Futbolcu bilgilerini giriniz : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mevki :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adı :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 230);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(127, 22);
            this.textBox3.TabIndex = 6;
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(137, 291);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(127, 23);
            this.ekleBtn.TabIndex = 7;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // sportsTeamDataSet
            // 
            this.sportsTeamDataSet.DataSetName = "SportsTeamDataSet";
            this.sportsTeamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.sportsTeamDataSet;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // playersBindingSource1
            // 
            this.playersBindingSource1.DataMember = "Players";
            this.playersBindingSource1.DataSource = this.sportsTeamDataSet;
            // 
            // sportsTeamDataSet1
            // 
            this.sportsTeamDataSet1.DataSetName = "SportsTeamDataSet1";
            this.sportsTeamDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersBindingSource2
            // 
            this.playersBindingSource2.DataMember = "Players";
            this.playersBindingSource2.DataSource = this.sportsTeamDataSet1;
            // 
            // playersTableAdapter1
            // 
            this.playersTableAdapter1.ClearBeforeFill = true;
            // 
            // playersBindingSource3
            // 
            this.playersBindingSource3.DataMember = "Players";
            this.playersBindingSource3.DataSource = this.sportsTeamDataSet;
            // 
            // playersBindingSource4
            // 
            this.playersBindingSource4.DataMember = "Players";
            this.playersBindingSource4.DataSource = this.sportsTeamDataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(355, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(559, 219);
            this.dataGridView1.TabIndex = 8;
            // 
            // FutbolcuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 448);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FutbolcuEkle";
            this.Text = "FutbolcuEkle";
            this.Load += new System.EventHandler(this.FutbolcuEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sportsTeamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsTeamDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button ekleBtn;
        private SportsTeamDataSet sportsTeamDataSet;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private SportsTeamDataSetTableAdapters.PlayersTableAdapter playersTableAdapter;
        private System.Windows.Forms.BindingSource playersBindingSource1;
        private SportsTeamDataSet1 sportsTeamDataSet1;
        private System.Windows.Forms.BindingSource playersBindingSource2;
        private SportsTeamDataSet1TableAdapters.PlayersTableAdapter playersTableAdapter1;
        private System.Windows.Forms.BindingSource playersBindingSource4;
        private System.Windows.Forms.BindingSource playersBindingSource3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}