namespace A_simple_game
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
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mainTextBox = new System.Windows.Forms.RichTextBox();
            this.largePB = new System.Windows.Forms.PictureBox();
            this.leftPB = new System.Windows.Forms.PictureBox();
            this.rightPB = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CompThinking = new System.Windows.Forms.TextBox();
            this.scoreUser = new System.Windows.Forms.TextBox();
            this.scoreComp = new System.Windows.Forms.TextBox();
            this.street1 = new System.Windows.Forms.PictureBox();
            this.loc102 = new System.Windows.Forms.Button();
            this.loc101 = new System.Windows.Forms.Button();
            this.loc103 = new System.Windows.Forms.Button();
            this.street2 = new System.Windows.Forms.PictureBox();
            this.loc201 = new System.Windows.Forms.Button();
            this.loc202 = new System.Windows.Forms.Button();
            this.loc203 = new System.Windows.Forms.Button();
            this.loc204 = new System.Windows.Forms.Button();
            this.bobPB = new System.Windows.Forms.PictureBox();
            this.bobPB2 = new System.Windows.Forms.PictureBox();
            this.alicePB1 = new System.Windows.Forms.PictureBox();
            this.alicePB2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.largePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.street1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.street2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bobPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bobPB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alicePB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alicePB2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(783, 835);
            this.button1.Margin = new System.Windows.Forms.Padding(8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(393, 296);
            this.button1.TabIndex = 0;
            this.button1.Text = "yes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mainTextBox
            // 
            this.mainTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.mainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainTextBox.DetectUrls = false;
            this.mainTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15.85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTextBox.Location = new System.Drawing.Point(25, 21);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.ReadOnly = true;
            this.mainTextBox.Size = new System.Drawing.Size(679, 255);
            this.mainTextBox.TabIndex = 2;
            this.mainTextBox.TabStop = false;
            this.mainTextBox.Text = "Hello there! Today we are going to talk about the Game theory using a series of g" +
    "ame. ";
            this.mainTextBox.Click += new System.EventHandler(this.clicked);
            // 
            // largePB
            // 
            this.largePB.Location = new System.Drawing.Point(263, 296);
            this.largePB.Name = "largePB";
            this.largePB.Size = new System.Drawing.Size(184, 182);
            this.largePB.TabIndex = 3;
            this.largePB.TabStop = false;
            this.largePB.Visible = false;
            // 
            // leftPB
            // 
            this.leftPB.Location = new System.Drawing.Point(101, 296);
            this.leftPB.Name = "leftPB";
            this.leftPB.Size = new System.Drawing.Size(125, 63);
            this.leftPB.TabIndex = 4;
            this.leftPB.TabStop = false;
            this.leftPB.Visible = false;
            // 
            // rightPB
            // 
            this.rightPB.Location = new System.Drawing.Point(478, 296);
            this.rightPB.Name = "rightPB";
            this.rightPB.Size = new System.Drawing.Size(127, 59);
            this.rightPB.TabIndex = 5;
            this.rightPB.TabStop = false;
            this.rightPB.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(49, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "Insert the Coin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(49, 440);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 38);
            this.button3.TabIndex = 7;
            this.button3.Text = "Not insert the coin";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CompThinking
            // 
            this.CompThinking.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompThinking.Location = new System.Drawing.Point(453, 361);
            this.CompThinking.Name = "CompThinking";
            this.CompThinking.Size = new System.Drawing.Size(211, 47);
            this.CompThinking.TabIndex = 8;
            // 
            // scoreUser
            // 
            this.scoreUser.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreUser.Location = new System.Drawing.Point(14, 493);
            this.scoreUser.Name = "scoreUser";
            this.scoreUser.Size = new System.Drawing.Size(211, 47);
            this.scoreUser.TabIndex = 9;
            // 
            // scoreComp
            // 
            this.scoreComp.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreComp.Location = new System.Drawing.Point(453, 493);
            this.scoreComp.Name = "scoreComp";
            this.scoreComp.Size = new System.Drawing.Size(240, 47);
            this.scoreComp.TabIndex = 10;
            // 
            // street1
            // 
            this.street1.Location = new System.Drawing.Point(25, 282);
            this.street1.Name = "street1";
            this.street1.Size = new System.Drawing.Size(679, 241);
            this.street1.TabIndex = 11;
            this.street1.TabStop = false;
            // 
            // loc102
            // 
            this.loc102.Enabled = false;
            this.loc102.Location = new System.Drawing.Point(311, 313);
            this.loc102.Name = "loc102";
            this.loc102.Size = new System.Drawing.Size(102, 57);
            this.loc102.TabIndex = 12;
            this.loc102.Text = "Here!";
            this.loc102.UseVisualStyleBackColor = true;
            this.loc102.Visible = false;
            this.loc102.Click += new System.EventHandler(this.loc102_Click);
            // 
            // loc101
            // 
            this.loc101.Enabled = false;
            this.loc101.Location = new System.Drawing.Point(101, 313);
            this.loc101.Name = "loc101";
            this.loc101.Size = new System.Drawing.Size(96, 57);
            this.loc101.TabIndex = 13;
            this.loc101.Text = "Here!";
            this.loc101.UseVisualStyleBackColor = true;
            this.loc101.Visible = false;
            this.loc101.Click += new System.EventHandler(this.loc101_Click);
            // 
            // loc103
            // 
            this.loc103.Enabled = false;
            this.loc103.Location = new System.Drawing.Point(506, 313);
            this.loc103.Name = "loc103";
            this.loc103.Size = new System.Drawing.Size(99, 57);
            this.loc103.TabIndex = 14;
            this.loc103.Text = "Here!";
            this.loc103.UseVisualStyleBackColor = true;
            this.loc103.Visible = false;
            this.loc103.Click += new System.EventHandler(this.loc103_Click);
            // 
            // street2
            // 
            this.street2.Location = new System.Drawing.Point(25, 282);
            this.street2.Name = "street2";
            this.street2.Size = new System.Drawing.Size(679, 241);
            this.street2.TabIndex = 15;
            this.street2.TabStop = false;
            // 
            // loc201
            // 
            this.loc201.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loc201.Location = new System.Drawing.Point(141, 314);
            this.loc201.Name = "loc201";
            this.loc201.Size = new System.Drawing.Size(56, 55);
            this.loc201.TabIndex = 16;
            this.loc201.Text = "Here!";
            this.loc201.UseVisualStyleBackColor = true;
            this.loc201.Click += new System.EventHandler(this.loc201_Click);
            // 
            // loc202
            // 
            this.loc202.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loc202.Location = new System.Drawing.Point(263, 313);
            this.loc202.Name = "loc202";
            this.loc202.Size = new System.Drawing.Size(56, 55);
            this.loc202.TabIndex = 17;
            this.loc202.Text = "Here!";
            this.loc202.UseVisualStyleBackColor = true;
            this.loc202.Click += new System.EventHandler(this.loc202_Click);
            // 
            // loc203
            // 
            this.loc203.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loc203.Location = new System.Drawing.Point(378, 313);
            this.loc203.Name = "loc203";
            this.loc203.Size = new System.Drawing.Size(56, 55);
            this.loc203.TabIndex = 18;
            this.loc203.Text = "Here!";
            this.loc203.UseVisualStyleBackColor = true;
            this.loc203.Click += new System.EventHandler(this.loc203_Click);
            // 
            // loc204
            // 
            this.loc204.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loc204.Location = new System.Drawing.Point(506, 313);
            this.loc204.Name = "loc204";
            this.loc204.Size = new System.Drawing.Size(56, 55);
            this.loc204.TabIndex = 19;
            this.loc204.Text = "Here!";
            this.loc204.UseVisualStyleBackColor = true;
            this.loc204.Click += new System.EventHandler(this.loc204_Click);
            // 
            // bobPB
            // 
            this.bobPB.Location = new System.Drawing.Point(378, 313);
            this.bobPB.Name = "bobPB";
            this.bobPB.Size = new System.Drawing.Size(85, 54);
            this.bobPB.TabIndex = 20;
            this.bobPB.TabStop = false;
            // 
            // bobPB2
            // 
            this.bobPB2.Location = new System.Drawing.Point(506, 314);
            this.bobPB2.Name = "bobPB2";
            this.bobPB2.Size = new System.Drawing.Size(98, 52);
            this.bobPB2.TabIndex = 21;
            this.bobPB2.TabStop = false;
            // 
            // alicePB1
            // 
            this.alicePB1.Location = new System.Drawing.Point(107, 314);
            this.alicePB1.Name = "alicePB1";
            this.alicePB1.Size = new System.Drawing.Size(89, 55);
            this.alicePB1.TabIndex = 22;
            this.alicePB1.TabStop = false;
            // 
            // alicePB2
            // 
            this.alicePB2.Location = new System.Drawing.Point(232, 314);
            this.alicePB2.Name = "alicePB2";
            this.alicePB2.Size = new System.Drawing.Size(89, 55);
            this.alicePB2.TabIndex = 23;
            this.alicePB2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(29F, 67F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 553);
            this.Controls.Add(this.alicePB2);
            this.Controls.Add(this.alicePB1);
            this.Controls.Add(this.bobPB2);
            this.Controls.Add(this.bobPB);
            this.Controls.Add(this.loc204);
            this.Controls.Add(this.loc203);
            this.Controls.Add(this.loc202);
            this.Controls.Add(this.loc201);
            this.Controls.Add(this.street2);
            this.Controls.Add(this.loc103);
            this.Controls.Add(this.loc101);
            this.Controls.Add(this.loc102);
            this.Controls.Add(this.street1);
            this.Controls.Add(this.scoreComp);
            this.Controls.Add(this.scoreUser);
            this.Controls.Add(this.CompThinking);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rightPB);
            this.Controls.Add(this.leftPB);
            this.Controls.Add(this.largePB);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Form1";
            this.Text = "A game about the game theory";
            ((System.ComponentModel.ISupportInitialize)(this.largePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.street1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.street2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bobPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bobPB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alicePB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alicePB2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox mainTextBox;
        private System.Windows.Forms.PictureBox largePB;
        private System.Windows.Forms.PictureBox leftPB;
        private System.Windows.Forms.PictureBox rightPB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox CompThinking;
        private System.Windows.Forms.TextBox scoreUser;
        private System.Windows.Forms.TextBox scoreComp;
        private System.Windows.Forms.PictureBox street1;
        private System.Windows.Forms.Button loc102;
        private System.Windows.Forms.Button loc101;
        private System.Windows.Forms.Button loc103;
        private System.Windows.Forms.PictureBox street2;
        private System.Windows.Forms.Button loc201;
        private System.Windows.Forms.Button loc202;
        private System.Windows.Forms.Button loc203;
        private System.Windows.Forms.Button loc204;
        private System.Windows.Forms.PictureBox bobPB;
        private System.Windows.Forms.PictureBox bobPB2;
        private System.Windows.Forms.PictureBox alicePB1;
        private System.Windows.Forms.PictureBox alicePB2;
    }
}

