using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DatabindingSampleWPF
{
    class ColorListDataContext:ObservableObject
    {
        private ColorDescriptor _selectedColor;
        private ColorDescriptor _selectedFavoriteColor;
        public List<ColorDescriptor> LotsOfColors { get; private set; }
        public ObservableCollection<ColorDescriptor> FavoriteColors { get; } = new ObservableCollection<ColorDescriptor>();
        public ColorDescriptor SelectedColor { get => _selectedColor; set => Set(ref _selectedColor, value); }
        public ColorDescriptor SelectedFavoriteColor { get => _selectedFavoriteColor; set  {Set(ref _selectedFavoriteColor, value);
                RaisePropertyChanged(nameof(IsRemoveFavoriteEnabled));
            } }

        public bool IsRemoveFavoriteEnabled => SelectedFavoriteColor != null;
        public ColorListDataContext()
        {
            LotsOfColors = new List<ColorDescriptor>
            {
               new ColorDescriptor(Colors.Red, "red"),
               new ColorDescriptor(Colors.White, "white"),
               new ColorDescriptor(Colors.Green, "green"),
               new ColorDescriptor(Colors.Yellow, "yellow"),
               new ColorDescriptor(Colors.Blue, "blue"),
               new ColorDescriptor(Colors.Black, "black")
            };
            SelectedColor = LotsOfColors[0];
        }


        public void AddSelectedColorToFavorites()
        {
            FavoriteColors.Add(SelectedColor);
        }

        public void RemoveFavoriteColor()
        {
            FavoriteColors.Remove(SelectedFavoriteColor);
        }
    }
}
