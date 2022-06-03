
namespace subventions
{
    partial class ChangeForm
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
            this.ChangeCloseButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.form_change_button = new System.Windows.Forms.Button();
            this.form_add_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ChangeMun = new System.Windows.Forms.ComboBox();
            this.ChangeTaker = new System.Windows.Forms.ComboBox();
            this.ChangeGiver = new System.Windows.Forms.ComboBox();
            this.ChangeYear = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangeCloseButton
            // 
            this.ChangeCloseButton.Location = new System.Drawing.Point(673, 367);
            this.ChangeCloseButton.Name = "ChangeCloseButton";
            this.ChangeCloseButton.Size = new System.Drawing.Size(101, 42);
            this.ChangeCloseButton.TabIndex = 40;
            this.ChangeCloseButton.Text = "Закрыть";
            this.ChangeCloseButton.UseVisualStyleBackColor = true;
            this.ChangeCloseButton.Click += new System.EventHandler(this.ChangeCloseButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(566, 367);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(101, 42);
            this.ChangeButton.TabIndex = 39;
            this.ChangeButton.Text = "Сохранить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(28, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Год, на который выдана субвенция";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(92, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Распределитель субвенции";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(133, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Получатель субвенции";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(81, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Муниципальноe образование";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(32, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(742, 118);
            this.dataGridView1.TabIndex = 41;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Объем выданных денежных средств";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дата получения денежных средств";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // form_change_button
            // 
            this.form_change_button.Location = new System.Drawing.Point(457, 367);
            this.form_change_button.Name = "form_change_button";
            this.form_change_button.Size = new System.Drawing.Size(103, 42);
            this.form_change_button.TabIndex = 42;
            this.form_change_button.Text = "Изменить платеж";
            this.form_change_button.UseVisualStyleBackColor = true;
            this.form_change_button.Click += new System.EventHandler(this.form_change_button_Click);
            // 
            // form_add_button
            // 
            this.form_add_button.Location = new System.Drawing.Point(348, 367);
            this.form_add_button.Name = "form_add_button";
            this.form_add_button.Size = new System.Drawing.Size(103, 42);
            this.form_add_button.TabIndex = 43;
            this.form_add_button.Text = "Добавить платеж";
            this.form_add_button.UseVisualStyleBackColor = true;
            this.form_add_button.Click += new System.EventHandler(this.form_add_button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 42);
            this.button3.TabIndex = 44;
            this.button3.Text = "Удалить платеж";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ChangeMun
            // 
            this.ChangeMun.FormattingEnabled = true;
            this.ChangeMun.Location = new System.Drawing.Point(372, 43);
            this.ChangeMun.Name = "ChangeMun";
            this.ChangeMun.Size = new System.Drawing.Size(369, 24);
            this.ChangeMun.TabIndex = 45;
            this.ChangeMun.SelectedIndexChanged += new System.EventHandler(this.ChangeMun_SelectedIndexChanged);
            // 
            // ChangeTaker
            // 
            this.ChangeTaker.FormattingEnabled = true;
            this.ChangeTaker.Location = new System.Drawing.Point(372, 84);
            this.ChangeTaker.Name = "ChangeTaker";
            this.ChangeTaker.Size = new System.Drawing.Size(369, 24);
            this.ChangeTaker.TabIndex = 46;
            // 
            // ChangeGiver
            // 
            this.ChangeGiver.FormattingEnabled = true;
            this.ChangeGiver.Location = new System.Drawing.Point(372, 127);
            this.ChangeGiver.Name = "ChangeGiver";
            this.ChangeGiver.Size = new System.Drawing.Size(369, 24);
            this.ChangeGiver.TabIndex = 47;
            // 
            // ChangeYear
            // 
            this.ChangeYear.CustomFormat = "yyyy";
            this.ChangeYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ChangeYear.Location = new System.Drawing.Point(372, 167);
            this.ChangeYear.Name = "ChangeYear";
            this.ChangeYear.Size = new System.Drawing.Size(200, 22);
            this.ChangeYear.TabIndex = 48;
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 434);
            this.Controls.Add(this.ChangeYear);
            this.Controls.Add(this.ChangeGiver);
            this.Controls.Add(this.ChangeTaker);
            this.Controls.Add(this.ChangeMun);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.form_add_button);
            this.Controls.Add(this.form_change_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ChangeCloseButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeForm";
            this.Text = "ChangeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeCloseButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button form_change_button;
        private System.Windows.Forms.Button form_add_button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox ChangeMun;
        private System.Windows.Forms.ComboBox ChangeTaker;
        private System.Windows.Forms.ComboBox ChangeGiver;
        private System.Windows.Forms.DateTimePicker ChangeYear;
    }
}