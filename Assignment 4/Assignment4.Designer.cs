namespace Assignment_4
{
    partial class Assignment4
    {
        private System.ComponentModel.IContainer components = null!;
        private Button btnDeal;
        private Button btnSave;
        private Button btnLoad;
        private Button btnShowDeck;
        private CheckBox chkKeep1;
        private CheckBox chkKeep2;
        private CheckBox chkKeep3;
        private CheckBox chkKeep4;
        private CheckBox chkKeep5;
        private PictureBox picCard1;
        private PictureBox picCard2;
        private PictureBox picCard3;
        private PictureBox picCard4;
        private PictureBox picCard5;
        private ImageList imlCard;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assignment4));
            btnDeal = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            btnShowDeck = new Button();
            chkKeep1 = new CheckBox();
            chkKeep2 = new CheckBox();
            chkKeep3 = new CheckBox();
            chkKeep4 = new CheckBox();
            chkKeep5 = new CheckBox();
            picCard1 = new PictureBox();
            picCard2 = new PictureBox();
            picCard3 = new PictureBox();
            picCard4 = new PictureBox();
            picCard5 = new PictureBox();
            imlCard = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)picCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCard2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCard3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCard4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCard5).BeginInit();
            SuspendLayout();
            // 
            // btnDeal
            // 
            btnDeal.Location = new Point(12, 40);
            btnDeal.Name = "btnDeal";
            btnDeal.Size = new Size(120, 60);
            btnDeal.TabIndex = 0;
            btnDeal.Text = "&Deal";
            btnDeal.Click += btnDeal_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(500, 40);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 60);
            btnSave.TabIndex = 2;
            btnSave.Text = "&Save Hand";
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(630, 40);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(120, 60);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "&Load Hand";
            btnLoad.Click += btnLoad_Click;
            // 
            // btnShowDeck
            // 
            btnShowDeck.Location = new Point(150, 40);
            btnShowDeck.Name = "btnShowDeck";
            btnShowDeck.Size = new Size(120, 60);
            btnShowDeck.TabIndex = 1;
            btnShowDeck.Text = "S&how Deck";
            btnShowDeck.Click += btnShowDeck_Click;
            // 
            // chkKeep1
            // 
            chkKeep1.Location = new Point(12, 186);
            chkKeep1.Name = "chkKeep1";
            chkKeep1.Size = new Size(104, 24);
            chkKeep1.TabIndex = 4;
            chkKeep1.Text = "Keep &1";
            // 
            // chkKeep2
            // 
            chkKeep2.Location = new Point(174, 186);
            chkKeep2.Name = "chkKeep2";
            chkKeep2.Size = new Size(104, 24);
            chkKeep2.TabIndex = 5;
            chkKeep2.Text = "Keep &2";
            // 
            // chkKeep3
            // 
            chkKeep3.Location = new Point(336, 186);
            chkKeep3.Name = "chkKeep3";
            chkKeep3.Size = new Size(104, 24);
            chkKeep3.TabIndex = 6;
            chkKeep3.Text = "Keep &3";
            // 
            // chkKeep4
            // 
            chkKeep4.Location = new Point(506, 186);
            chkKeep4.Name = "chkKeep4";
            chkKeep4.Size = new Size(104, 24);
            chkKeep4.TabIndex = 7;
            chkKeep4.Text = "Keep &4";
            // 
            // chkKeep5
            // 
            chkKeep5.Location = new Point(663, 186);
            chkKeep5.Name = "chkKeep5";
            chkKeep5.Size = new Size(104, 24);
            chkKeep5.TabIndex = 8;
            chkKeep5.Text = "Keep &5";
            // 
            // picCard1
            // 
            picCard1.Location = new Point(12, 216);
            picCard1.Name = "picCard1";
            picCard1.Size = new Size(104, 179);
            picCard1.TabIndex = 9;
            picCard1.TabStop = false;
            // 
            // picCard2
            // 
            picCard2.Location = new Point(174, 216);
            picCard2.Name = "picCard2";
            picCard2.Size = new Size(104, 179);
            picCard2.TabIndex = 10;
            picCard2.TabStop = false;
            // 
            // picCard3
            // 
            picCard3.Location = new Point(336, 216);
            picCard3.Name = "picCard3";
            picCard3.Size = new Size(104, 179);
            picCard3.TabIndex = 11;
            picCard3.TabStop = false;
            // 
            // picCard4
            // 
            picCard4.Location = new Point(506, 216);
            picCard4.Name = "picCard4";
            picCard4.Size = new Size(104, 179);
            picCard4.TabIndex = 12;
            picCard4.TabStop = false;
            // 
            // picCard5
            // 
            picCard5.Location = new Point(663, 216);
            picCard5.Name = "picCard5";
            picCard5.Size = new Size(104, 179);
            picCard5.TabIndex = 13;
            picCard5.TabStop = false;
            // 
            // imlCard
            // 
            imlCard.ColorDepth = ColorDepth.Depth32Bit;
            imlCard.ImageStream = (ImageListStreamer)resources.GetObject("imlCard.ImageStream");
            imlCard.TransparentColor = Color.Transparent;
            imlCard.Images.SetKeyName(0, "2 of Clubs.png");
            imlCard.Images.SetKeyName(1, "2 of Diamonds.png");
            imlCard.Images.SetKeyName(2, "2 of Hearts.png");
            imlCard.Images.SetKeyName(3, "2 of Spades.png");
            imlCard.Images.SetKeyName(4, "3 of Clubs.png");
            imlCard.Images.SetKeyName(5, "3 of Diamonds.png");
            imlCard.Images.SetKeyName(6, "3 of Hearts.png");
            imlCard.Images.SetKeyName(7, "3 of Spades.png");
            imlCard.Images.SetKeyName(8, "4 of Clubs.png");
            imlCard.Images.SetKeyName(9, "4 of Diamonds.png");
            imlCard.Images.SetKeyName(10, "4 of Hearts.png");
            imlCard.Images.SetKeyName(11, "4 of Spades.png");
            imlCard.Images.SetKeyName(12, "5 of Clubs.png");
            imlCard.Images.SetKeyName(13, "5 of Diamonds.png");
            imlCard.Images.SetKeyName(14, "5 of Hearts.png");
            imlCard.Images.SetKeyName(15, "5 of Spades.png");
            imlCard.Images.SetKeyName(16, "6 of Clubs.png");
            imlCard.Images.SetKeyName(17, "6 of Diamonds.png");
            imlCard.Images.SetKeyName(18, "6 of Hearts.png");
            imlCard.Images.SetKeyName(19, "6 of Spades.png");
            imlCard.Images.SetKeyName(20, "7 of Clubs.png");
            imlCard.Images.SetKeyName(21, "7 of Diamonds.png");
            imlCard.Images.SetKeyName(22, "7 of Hearts.png");
            imlCard.Images.SetKeyName(23, "7 of Spades.png");
            imlCard.Images.SetKeyName(24, "8 of Clubs.png");
            imlCard.Images.SetKeyName(25, "8 of Diamonds.png");
            imlCard.Images.SetKeyName(26, "8 of Hearts.png");
            imlCard.Images.SetKeyName(27, "8 of Spades.png");
            imlCard.Images.SetKeyName(28, "9 of Clubs.png");
            imlCard.Images.SetKeyName(29, "9 of Diamonds.png");
            imlCard.Images.SetKeyName(30, "9 of Hearts.png");
            imlCard.Images.SetKeyName(31, "9 of Spades.png");
            imlCard.Images.SetKeyName(32, "10 of Clubs.png");
            imlCard.Images.SetKeyName(33, "10 of Diamonds.png");
            imlCard.Images.SetKeyName(34, "10 of Hearts.png");
            imlCard.Images.SetKeyName(35, "10 of Spades.png");
            imlCard.Images.SetKeyName(36, "Ace of Clubs.png");
            imlCard.Images.SetKeyName(37, "Ace of Diamonds.png");
            imlCard.Images.SetKeyName(38, "Ace of Hearts.png");
            imlCard.Images.SetKeyName(39, "Ace of Spades.png");
            imlCard.Images.SetKeyName(40, "Jack of Clubs.png");
            imlCard.Images.SetKeyName(41, "Jack of Diamonds.png");
            imlCard.Images.SetKeyName(42, "Jack of Hearts.png");
            imlCard.Images.SetKeyName(43, "Jack of Spades.png");
            imlCard.Images.SetKeyName(44, "King of Clubs.png");
            imlCard.Images.SetKeyName(45, "King of Diamonds.png");
            imlCard.Images.SetKeyName(46, "King of Hearts.png");
            imlCard.Images.SetKeyName(47, "King of Spades.png");
            imlCard.Images.SetKeyName(48, "Queen of Clubs.png");
            imlCard.Images.SetKeyName(49, "Queen of Diamonds.png");
            imlCard.Images.SetKeyName(50, "Queen of Hearts.png");
            imlCard.Images.SetKeyName(51, "Queen of Spades.png");
            // 
            // Assignment4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeal);
            Controls.Add(btnShowDeck);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(chkKeep1);
            Controls.Add(chkKeep2);
            Controls.Add(chkKeep3);
            Controls.Add(chkKeep4);
            Controls.Add(chkKeep5);
            Controls.Add(picCard1);
            Controls.Add(picCard2);
            Controls.Add(picCard3);
            Controls.Add(picCard4);
            Controls.Add(picCard5);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Assignment4";
            Text = "Poker Hand Simulator";
            ((System.ComponentModel.ISupportInitialize)picCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCard2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCard3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCard4).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCard5).EndInit();
            ResumeLayout(false);
        }
    }
}
