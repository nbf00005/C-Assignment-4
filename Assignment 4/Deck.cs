using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Assignment_4
{
    public class Deck
    {
        private List<Card> cards = new List<Card>();
        private ImageList imageList;
        private Random rng = new Random();

        public Deck(ImageList imageList)
        {
            this.imageList = imageList;
        }

        public int Count => cards.Count;

        public void Shuffle()
        {
            cards.Clear();

            for (int i = 0; i < imageList.Images.Count; i++)
            {
                string name = imageList.Images.Keys[i];
                Image image = imageList.Images[i];
                cards.Add(new Card(i, image, name));
            }

            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                (cards[k], cards[n]) = (cards[n], cards[k]);
            }
        }

        public Card DealCard()
        {
            if (cards.Count == 0)
                return Card.NoCard;

            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

        public Card GetCard(int index)
        {
            if (index < 0 || index >= cards.Count)
                return Card.NoCard;
            return cards[index];
        }

        public void SwapCards(int index1, int index2)
        {
            if (index1 >= 0 && index1 < cards.Count &&
                index2 >= 0 && index2 < cards.Count)
            {
                (cards[index1], cards[index2]) = (cards[index2], cards[index1]);
            }
        }


        public void SaveHand(string filename, Card[] hand)
        {
            using StreamWriter writer = new StreamWriter(filename);
            foreach (Card card in hand)
                writer.WriteLine(card.Id);
        }

        public void LoadHand(string filename, Card[] hand)
        {
            using StreamReader reader = new StreamReader(filename);

            for (int i = 0; i < hand.Length; i++)
            {
                string? line = reader.ReadLine();
                if (line == null)
                {
                    hand[i] = Card.NoCard;
                    continue;
                }

                if (int.TryParse(line, out int id) &&
                    id >= 0 && id < imageList.Images.Count)
                {
                    string name = imageList.Images.Keys[id];
                    Image image = imageList.Images[id];
                    hand[i] = new Card(id, image, name);
                }
                else
                {
                    hand[i] = Card.NoCard;
                }
            }
        }
    }
}
