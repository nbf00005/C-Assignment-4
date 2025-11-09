namespace Assignment_4
{
    partial class DeckForm
    {
        private System.ComponentModel.IContainer components = null!;
        private Label lblCards;
        private ListBox lstCards;
        private PictureBox picCard;
        private Button btnUp;
        private Button btnDown;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblCards = new Label();
            lstCards = new ListBox();
            picCard = new PictureBox();
            btnUp = new Button();
            btnDown = new Button();
            ((System.ComponentModel.ISupportInitialize)picCard).BeginInit();
            SuspendLayout();
            // 
            // lblCards
            // 
            lblCards.Location = new Point(10, 10);
            lblCards.Name = "lblCards";
            lblCards.Size = new Size(100, 23);
            lblCards.TabIndex = 0;
            lblCards.Text = "&Cards:";
            // 
            // lstCards
            // 
            lstCards.Location = new Point(10, 35);
            lstCards.Name = "lstCards";
            lstCards.Size = new Size(200, 284);
            lstCards.TabIndex = 1;
            lstCards.SelectedIndexChanged += lstCards_SelectedIndexChanged;
            // 
            // picCard
            // 
            picCard.Location = new Point(238, 103);
            picCard.Name = "picCard";
            picCard.Size = new Size(100, 145);
            picCard.SizeMode = PictureBoxSizeMode.StretchImage;
            picCard.TabIndex = 2;
            picCard.TabStop = false;
            // 
            // btnUp
            // 
            btnUp.Location = new Point(10, 350);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(75, 38);
            btnUp.TabIndex = 3;
            btnUp.Text = "&Up";
            btnUp.Click += btnUp_Click;
            // 
            // btnDown
            // 
            btnDown.Location = new Point(90, 350);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(75, 38);
            btnDown.TabIndex = 4;
            btnDown.Text = "&Down";
            btnDown.Click += btnDown_Click;
            // 
            // DeckForm
            // 
            ClientSize = new Size(350, 400);
            Controls.Add(lblCards);
            Controls.Add(lstCards);
            Controls.Add(picCard);
            Controls.Add(btnUp);
            Controls.Add(btnDown);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeckForm";
            Text = "Deck";
            ((System.ComponentModel.ISupportInitialize)picCard).EndInit();
            ResumeLayout(false);
        }
    }
}