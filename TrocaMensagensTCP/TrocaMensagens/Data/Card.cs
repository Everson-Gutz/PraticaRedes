using System;

namespace TrocaMensagens.Data
{
    public class Card
    {
        public Card(string response)
        {
            ParseResponse(response);
        }

        private void ParseResponse(string response)
        {
            if (response.StartsWith(".") ||
                response.StartsWith(":\r\n"))
            {
                IsValid = false;
                return;
            }

            var tokens = response.Split(':');
            Symbol = tokens[0];
            Value = GetNumericValue(Symbol);
            Suit = ConvertSuit(tokens[1]);
            IsValid = true;
        }

        public bool IsValid { get; private set; }
        public string Symbol { get; private set; }
        public int Value { get; private set; }
        public string Suit { get; private set; }

        private int GetNumericValue(string symbol)
        {
            switch (symbol)
            {
                case "A":
                    return 1;
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                    return Convert.ToInt32(symbol);
                case "J":
                case "Q":
                case "K":
                    return 10;
                default:
                    return 0;
            }
        }

        private string ConvertSuit(string suit)
        {
            switch (suit.Substring(0, suit.IndexOf("\r\n")))
            {
                case "CLUB":
                    return "Paus";
                case "HEART":
                    return "Copas";
                case "DIAMOND":
                    return "Ouro";
                case "SPADE":
                    return "Espadas";
                default:
                    return "Desconhecido";
            }
        }
    }
}
