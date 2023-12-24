namespace SportsTeam
{
    partial class SezonEkle
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.seasonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportsTeamDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportsTeamDataSet = new SportsTeam.SportsTeamDataSet();
            this.seasonsTableAdapter = new SportsTeam.SportsTeamDataSetTableAdapters.SeasonsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.seasonsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seasonsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsTeamDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsTeamDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eklemek İstediğiniz Sezonu Yazınız : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(369, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seasonsIDDataGridViewTextBoxColumn,
            this.seasonsNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.seasonsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(125, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(537, 187);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // seasonsBindingSource
            // 
            this.seasonsBindingSource.DataMember = "Seasons";
            this.seasonsBindingSource.DataSource = this.sportsTeamDataSetBindingSource;
            // 
            // sportsTeamDataSetBindingSource
            // 
            this.sportsTeamDataSetBindingSource.DataSource = this.sportsTeamDataSet;
            this.sportsTeamDataSetBindingSource.Position = 0;
            // 
            // sportsTeamDataSet
            // 
            this.sportsTeamDataSet.DataSetName = "SportsTeamDataSet";
            this.sportsTeamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seasonsTableAdapter
            // 
            this.seasonsTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mevcut Sezonlar :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // seasonsIDDataGridViewTextBoxColumn
            // 
            this.seasonsIDDataGridViewTextBoxColumn.DataPropertyName = "SeasonsID";
            this.seasonsIDDataGridViewTextBoxColumn.HeaderText = "SeasonsID";
            this.seasonsIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seasonsIDDataGridViewTextBoxColumn.Name = "seasonsIDDataGridViewTextBoxColumn";
            this.seasonsIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.seasonsIDDataGridViewTextBoxColumn.Visible = false;
            this.seasonsIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // seasonsNameDataGridViewTextBoxColumn
            // 
            this.seasonsNameDataGridViewTextBoxColumn.DataPropertyName = "SeasonsName";
            this.seasonsNameDataGridViewTextBoxColumn.HeaderText = "Seasons Name";
            this.seasonsNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seasonsNameDataGridViewTextBoxColumn.Name = "seasonsNameDataGridViewTextBoxColumn";
            this.seasonsNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.seasonsNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // SezonEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "SezonEkle";
            this.Text = "SezonEkle";
            this.Load += new System.EventHandler(this.SezonEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsTeamDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsTeamDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sportsTeamDataSetBindingSource;
        private SportsTeamDataSet sportsTeamDataSet;
        private System.Windows.Forms.BindingSource seasonsBindingSource;
        private SportsTeamDataSetTableAdapters.SeasonsTableAdapter seasonsTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn seasonsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seasonsNameDataGridViewTextBoxColumn;
    }
}