namespace Perceptron
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_input = new System.Windows.Forms.PictureBox();
            this.button_recognize = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_wrong = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.openFileDialog_weights = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox_indicator = new System.Windows.Forms.PictureBox();
            this.panel_learning = new System.Windows.Forms.Panel();
            this.saveFileDialog_weights = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_indicator)).BeginInit();
            this.panel_learning.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_input
            // 
            this.pictureBox_input.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_input.Name = "pictureBox_input";
            this.pictureBox_input.Size = new System.Drawing.Size(300, 300);
            this.pictureBox_input.TabIndex = 0;
            this.pictureBox_input.TabStop = false;
            this.pictureBox_input.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_input_MouseMove);
            // 
            // button_recognize
            // 
            this.button_recognize.Location = new System.Drawing.Point(330, 15);
            this.button_recognize.Name = "button_recognize";
            this.button_recognize.Size = new System.Drawing.Size(229, 32);
            this.button_recognize.TabIndex = 1;
            this.button_recognize.Text = "Распознать";
            this.button_recognize.UseVisualStyleBackColor = true;
            this.button_recognize.Click += new System.EventHandler(this.button_recognize_Click);
            // 
            // button_right
            // 
            this.button_right.Location = new System.Drawing.Point(0, 0);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(112, 29);
            this.button_right.TabIndex = 2;
            this.button_right.Text = "Верно!";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // button_wrong
            // 
            this.button_wrong.Location = new System.Drawing.Point(118, 0);
            this.button_wrong.Name = "button_wrong";
            this.button_wrong.Size = new System.Drawing.Size(111, 29);
            this.button_wrong.TabIndex = 3;
            this.button_wrong.Text = "Неверно!";
            this.button_wrong.UseVisualStyleBackColor = true;
            this.button_wrong.Click += new System.EventHandler(this.button_wrong_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(330, 281);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(229, 31);
            this.button_clear.TabIndex = 4;
            this.button_clear.Text = "Очистить";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(330, 242);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(112, 33);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(448, 242);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(111, 33);
            this.button_load.TabIndex = 6;
            this.button_load.Text = "Загрузить";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // openFileDialog_weights
            // 
            this.openFileDialog_weights.FileName = "openFileDialog1";
            // 
            // pictureBox_indicator
            // 
            this.pictureBox_indicator.Location = new System.Drawing.Point(330, 53);
            this.pictureBox_indicator.Name = "pictureBox_indicator";
            this.pictureBox_indicator.Size = new System.Drawing.Size(229, 58);
            this.pictureBox_indicator.TabIndex = 7;
            this.pictureBox_indicator.TabStop = false;
            // 
            // panel_learning
            // 
            this.panel_learning.Controls.Add(this.button_right);
            this.panel_learning.Controls.Add(this.button_wrong);
            this.panel_learning.Enabled = false;
            this.panel_learning.Location = new System.Drawing.Point(330, 117);
            this.panel_learning.Name = "panel_learning";
            this.panel_learning.Size = new System.Drawing.Size(229, 35);
            this.panel_learning.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(579, 326);
            this.Controls.Add(this.panel_learning);
            this.Controls.Add(this.pictureBox_indicator);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_recognize);
            this.Controls.Add(this.pictureBox_input);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_indicator)).EndInit();
            this.panel_learning.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_input;
        private System.Windows.Forms.Button button_recognize;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_wrong;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.OpenFileDialog openFileDialog_weights;
        private System.Windows.Forms.PictureBox pictureBox_indicator;
        private System.Windows.Forms.Panel panel_learning;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_weights;
    }
}

