namespace Assignment_4
{
    public partial class Assignment4 : Form
    {
        private const int HAND_SIZE = 5;
        private const string FILE_EXTENSION = ".txt";

        private Deck deck;
        private Card[] hand = new Card[HAND_SIZE];
        private DeckForm? deckForm;
        private PictureBox[] pictureBoxes;
        private CheckBox[] keepCheckBoxes;

        public Assignment4()
        {
            InitializeComponent();
            deck = new Deck(imlCard);
            InitializeControls();
            deck.Shuffle();
            DealHand();
        }

        private void InitializeControls()
        {
            pictureBoxes = new[] { picCard1, picCard2, picCard3, picCard4, picCard5 };
            keepCheckBoxes = new[] { chkKeep1, chkKeep2, chkKeep3, chkKeep4, chkKeep5 };

            for (int i = 0; i < HAND_SIZE; i++)
            {
                int idx = i;
                pictureBoxes[i].Click += (s, e) => keepCheckBoxes[idx].Checked = !keepCheckBoxes[idx].Checked;
            }
        }

       private void DealHand()
{
    // If the deck is empty, reshuffle it
    if (deck.Count == 0)
        deck.Shuffle();

    for (int i = 0; i < hand.Length; i++)
    {
        if (!keepCheckBoxes[i].Checked)
            hand[i] = deck.DealCard();
    }

    picCard1.Image = hand[0].CardImage;
    picCard2.Image = hand[1].CardImage;
    picCard3.Image = hand[2].CardImage;
    picCard4.Image = hand[3].CardImage;
    picCard5.Image = hand[4].CardImage;

    // If the deck form is open, refresh it
    deckForm?.UpdateDeck();
}

        private void UpdateHandImages()
        {
            for (int i = 0; i < HAND_SIZE; i++)
                pictureBoxes[i].Image = hand[i]?.CardImage;
        }

        private void SaveHand()
        {
            using SaveFileDialog dlg = new()
            {
                Filter = "Text Files|*.txt|All Files|*.*",
                DefaultExt = FILE_EXTENSION,
                Title = "Save Poker Hand"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
                deck.SaveHand(dlg.FileName, hand);
        }

        private void LoadHand()
        {
            using OpenFileDialog dlg = new()
            {
                Filter = "Text Files|*.txt|All Files|*.*",
                DefaultExt = FILE_EXTENSION,
                Title = "Load Poker Hand"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                deck.LoadHand(dlg.FileName, hand);
                foreach (var chk in keepCheckBoxes)
                    chk.Checked = false;
                UpdateHandImages();
            }
        }

        private void btnDeal_Click(object sender, EventArgs e) => DealHand();
        private void btnSave_Click(object sender, EventArgs e) => SaveHand();
        private void btnLoad_Click(object sender, EventArgs e) => LoadHand();

        private void btnShowDeck_Click(object sender, EventArgs e)
        {
            if (deckForm == null || !deckForm.Visible)
            {
                deckForm = new DeckForm(deck);
                deckForm.Show();
            }
            else
            {
                deckForm.BringToFront();
            }
        }

        private void UpdateDeckView() => deckForm?.UpdateDeck();
    }
}
