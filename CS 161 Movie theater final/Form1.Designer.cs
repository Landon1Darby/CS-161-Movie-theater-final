﻿namespace CS_161_Movie_theater_final
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
            movieListbox = new ListBox();
            groupBox1 = new GroupBox();
            descriptionOutput = new Label();
            label10 = new Label();
            costOutput = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            moviePoster = new PictureBox();
            nameOutput = new Label();
            label3 = new Label();
            SearchGroupbox = new GroupBox();
            label2 = new Label();
            comedyCheck = new CheckBox();
            scaryCheck = new CheckBox();
            romanceCheck = new CheckBox();
            famliyCheck = new CheckBox();
            label1 = new Label();
            priceBox = new TextBox();
            searchButton = new Button();
            searchBox = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)moviePoster).BeginInit();
            SearchGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // movieListbox
            // 
            movieListbox.FormattingEnabled = true;
            movieListbox.Location = new Point(12, 12);
            movieListbox.Name = "movieListbox";
            movieListbox.Size = new Size(247, 164);
            movieListbox.TabIndex = 0;
            movieListbox.SelectedIndexChanged += movieListbox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(descriptionOutput);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(costOutput);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(moviePoster);
            groupBox1.Controls.Add(nameOutput);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(314, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 400);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Details";
            // 
            // descriptionOutput
            // 
            descriptionOutput.BackColor = SystemColors.Control;
            descriptionOutput.BorderStyle = BorderStyle.FixedSingle;
            descriptionOutput.Location = new Point(15, 294);
            descriptionOutput.Name = "descriptionOutput";
            descriptionOutput.Size = new Size(258, 89);
            descriptionOutput.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 165);
            label10.Name = "label10";
            label10.Size = new Size(55, 20);
            label10.TabIndex = 17;
            label10.Text = "Rating:";
            // 
            // costOutput
            // 
            costOutput.BackColor = SystemColors.Control;
            costOutput.BorderStyle = BorderStyle.FixedSingle;
            costOutput.Location = new Point(153, 91);
            costOutput.Name = "costOutput";
            costOutput.Size = new Size(131, 25);
            costOutput.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(151, 71);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 15;
            label8.Text = "Cost:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 274);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 14;
            label6.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(194, 139);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 13;
            // 
            // moviePoster
            // 
            moviePoster.Location = new Point(15, 26);
            moviePoster.Name = "moviePoster";
            moviePoster.Size = new Size(128, 133);
            moviePoster.SizeMode = PictureBoxSizeMode.Zoom;
            moviePoster.TabIndex = 12;
            moviePoster.TabStop = false;
            // 
            // nameOutput
            // 
            nameOutput.BackColor = SystemColors.Control;
            nameOutput.BorderStyle = BorderStyle.FixedSingle;
            nameOutput.Location = new Point(151, 46);
            nameOutput.Name = "nameOutput";
            nameOutput.Size = new Size(131, 25);
            nameOutput.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(149, 26);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 10;
            label3.Text = "Name:";
            // 
            // SearchGroupbox
            // 
            SearchGroupbox.Controls.Add(label2);
            SearchGroupbox.Controls.Add(comedyCheck);
            SearchGroupbox.Controls.Add(scaryCheck);
            SearchGroupbox.Controls.Add(romanceCheck);
            SearchGroupbox.Controls.Add(famliyCheck);
            SearchGroupbox.Controls.Add(label1);
            SearchGroupbox.Controls.Add(priceBox);
            SearchGroupbox.Controls.Add(searchButton);
            SearchGroupbox.Controls.Add(searchBox);
            SearchGroupbox.Location = new Point(12, 200);
            SearchGroupbox.Name = "SearchGroupbox";
            SearchGroupbox.Size = new Size(247, 209);
            SearchGroupbox.TabIndex = 2;
            SearchGroupbox.TabStop = false;
            SearchGroupbox.Text = "Search";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 29);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 9;
            label2.Text = "Name:";
            // 
            // comedyCheck
            // 
            comedyCheck.AutoSize = true;
            comedyCheck.Checked = true;
            comedyCheck.CheckState = CheckState.Checked;
            comedyCheck.Location = new Point(118, 133);
            comedyCheck.Name = "comedyCheck";
            comedyCheck.Size = new Size(86, 24);
            comedyCheck.TabIndex = 8;
            comedyCheck.Text = "Comedy";
            comedyCheck.UseVisualStyleBackColor = true;
            // 
            // scaryCheck
            // 
            scaryCheck.AutoSize = true;
            scaryCheck.Checked = true;
            scaryCheck.CheckState = CheckState.Checked;
            scaryCheck.Location = new Point(11, 133);
            scaryCheck.Name = "scaryCheck";
            scaryCheck.Size = new Size(75, 24);
            scaryCheck.TabIndex = 7;
            scaryCheck.Text = "Horror";
            scaryCheck.UseVisualStyleBackColor = true;
            // 
            // romanceCheck
            // 
            romanceCheck.AutoSize = true;
            romanceCheck.Checked = true;
            romanceCheck.CheckState = CheckState.Checked;
            romanceCheck.Location = new Point(118, 103);
            romanceCheck.Name = "romanceCheck";
            romanceCheck.Size = new Size(93, 24);
            romanceCheck.TabIndex = 6;
            romanceCheck.Text = "Romance";
            romanceCheck.UseVisualStyleBackColor = true;
            // 
            // famliyCheck
            // 
            famliyCheck.AutoSize = true;
            famliyCheck.Checked = true;
            famliyCheck.CheckState = CheckState.Checked;
            famliyCheck.Location = new Point(11, 103);
            famliyCheck.Name = "famliyCheck";
            famliyCheck.Size = new Size(73, 24);
            famliyCheck.TabIndex = 5;
            famliyCheck.Text = "Famliy";
            famliyCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 66);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 4;
            label1.Text = "Price:";
            // 
            // priceBox
            // 
            priceBox.Location = new Point(69, 59);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(158, 27);
            priceBox.TabIndex = 2;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(88, 174);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(70, 29);
            searchButton.TabIndex = 1;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(69, 26);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(158, 27);
            searchBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.star;
            pictureBox1.Location = new Point(15, 191);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.star;
            pictureBox2.Location = new Point(63, 191);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.star;
            pictureBox3.Location = new Point(111, 191);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(65, 65);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.star;
            pictureBox4.Location = new Point(155, 191);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(65, 65);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.star;
            pictureBox5.Location = new Point(207, 191);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(65, 65);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 23;
            pictureBox5.TabStop = false;
            pictureBox5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 423);
            Controls.Add(SearchGroupbox);
            Controls.Add(groupBox1);
            Controls.Add(movieListbox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)moviePoster).EndInit();
            SearchGroupbox.ResumeLayout(false);
            SearchGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox movieListbox;
        private GroupBox groupBox1;
        private GroupBox SearchGroupbox;
        private Label label1;
        private Button priceSearchbutton;
        private TextBox priceBox;
        private Button searchButton;
        private TextBox searchBox;
        private CheckBox comedyCheck;
        private CheckBox scaryCheck;
        private CheckBox romanceCheck;
        private CheckBox famliyCheck;
        private Label label2;
        private Label label6;
        private Label label5;
        private PictureBox moviePoster;
        private Label nameOutput;
        private Label label3;
        private Label descriptionOutput;
        private Label label10;
        private Label costOutput;
        private Label label8;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}
