using MemoGameBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemoGameBlazor.ViewModels
{
    public class GameCardViewModel
    {
        public string Text { get; }

        public string Image { get; }

        public bool IsOpen { get; set; }

        public bool IsMatched { get; set; }

        public GameCardViewModel(Card card)
        {
            this.Text = card.Text;
            this.Image = card.Image;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return this.Text == ((GameCardViewModel)obj).Text;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Text);
        }
    }
}
