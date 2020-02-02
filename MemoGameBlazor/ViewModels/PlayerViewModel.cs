using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MemoGameBlazor.ViewModels
{
    public class PlayerViewModel
    {
        public PlayerViewModel(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public int Moves { get; set; } = 0;

        public int MatchedPairs { get; set; } = 0;
    }
}
