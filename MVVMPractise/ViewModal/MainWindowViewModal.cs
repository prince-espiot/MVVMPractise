
using MVVMPractise.Modal;
using MVVMPractise.MVVM;
using System.Collections.ObjectModel;
using System.Reflection.Metadata.Ecma335;
namespace MVVMPractise.ViewModal
{

    
    internal class MainWindowViewModal : ViewModalBase
    {
        public ObservableCollection<Item>? Items { get; set; }
        public RelayCommand AddCommand => new RelayCommand(execute => AddItem());
        public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteItem(),canExecute=>SelectedItem !=null);

        public RelayCommand SaveCommand => new RelayCommand(execute => Save(), canExecute => CanSave());

        

        public MainWindowViewModal()
        {
            Items = new ObservableCollection<Item>();
        }

        private Item? selectedItem = null;

        public Item? SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value;
                OnPropertyChanged();
            }
        }

        private void AddItem()
        {
            Items.Add(new Item
            {
                Name = "new name",
                SerialNumber = "ERERE",
                Quantity = 0
            });
        }

        private void DeleteItem()
        {
            Items.Remove(SelectedItem);
        }

        private bool CanSave()
        {
            return true;
        }

        private void Save()
        {//save to file or to database
            Items.Add(new Item
            {
                Name = "save name",
                SerialNumber = "hkeyuk",
                Quantity = 0
            });
        }
    }

	

}
