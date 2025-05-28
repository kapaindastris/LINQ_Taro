using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using LINQ_Taro.Models; 

namespace LINQ_Taro.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Card> _cards;
        private ObservableCollection<Card> _originalCards;
        private string _searchText;

        public ObservableCollection<Card> Cards
        {
            get => _cards;
            set
            {
                _cards = value;
                OnPropertyChanged(nameof(Cards));
            }
        }

        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;
                OnPropertyChanged(nameof(SearchText));
            }
        }

        public ICommand ShuffleCommand { get; }
        public ICommand SortCommand { get; }
        public ICommand ResetCommand { get; }
        public ICommand SearchCommand { get; }

        public MainViewModel()
        {
            _originalCards = new ObservableCollection<Card>(GenerateCards());
            Cards = new ObservableCollection<Card>(_originalCards);

            ShuffleCommand = new RelayCommand(_ => Shuffle());
            SortCommand = new RelayCommand(_ => SortByName());
            ResetCommand = new RelayCommand(_ => Reset());
            SearchCommand = new RelayCommand(_ => Search());
        }

        private List<Card> GenerateCards()
        {
            return new List<Card>
            {
                new Card { Key = 1, Name = "Туз" },
                new Card { Key = 2, Name = "Двойка" },
                new Card { Key = 3, Name = "Тройка" },
                new Card { Key = 4, Name = "Четвёрка" },
                new Card { Key = 5, Name = "Пятёрка" },
                new Card { Key = 6, Name = "Шестёрка" },
                new Card { Key = 7, Name = "Семёрка" },
                new Card { Key = 8, Name = "Восьмёрка" },
                new Card { Key = 9, Name = "Девятка" },
                new Card { Key = 10, Name = "Десятка" }
            };
        }

        private void Shuffle()
        {
            var rnd = new Random();
            Cards = new ObservableCollection<Card>(Cards.OrderBy(c => rnd.Next()));
        }

        private void SortByName()
        {
            Cards = new ObservableCollection<Card>(Cards.OrderBy(c => c.Name));
        }

        private void Reset()
        {
            Cards = new ObservableCollection<Card>(_originalCards);
        }

        private void Search()
        {
            if (!string.IsNullOrWhiteSpace(SearchText))
            {
                var result = _originalCards
                    .Where(c => c.Name.Contains(SearchText, StringComparison.OrdinalIgnoreCase));
                Cards = new ObservableCollection<Card>(result);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
