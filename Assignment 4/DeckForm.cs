using System;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_4
{
    public partial class DeckForm : Form
    {
        private readonly Deck _deck;

        public DeckForm(Deck deck)
        {
            InitializeComponent();
            _deck = deck;
            Load += (s, e) => UpdateDeck();
        }

        public void UpdateDeck()
        {
            lstCards.Items.Clear();
            for (int i = 0; i < _deck.Count; i++)
                lstCards.Items.Add(_deck.GetCard(i));
        }

        private void lstCards_SelectedIndexChanged(object? sender, EventArgs e)
        {
            Card? card = (Card?)lstCards.SelectedItem;
            picCard.Image = card?.CardImage;
        }

        private void btnUp_Click(object? sender, EventArgs e)
        {
            int index = lstCards.SelectedIndex;
            if (index <= 0) return;
            _deck.SwapCards(index, index - 1);
            UpdateDeck();
            lstCards.SelectedIndex = index - 1;
        }

        private void btnDown_Click(object? sender, EventArgs e)
        {
            int index = lstCards.SelectedIndex;
            if (index < 0 || index >= _deck.Count - 1) return;
            _deck.SwapCards(index, index + 1);
            UpdateDeck();
            lstCards.SelectedIndex = index + 1;
        }
    }
}