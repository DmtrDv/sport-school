using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SportSchoolLib
{
    public class Inventory: INotifyPropertyChanged
    {
        private int Id_Inventory_;
        private string Name_Inventory_;
        private int Count_Inventory_;
        private DateTime DateDelivery_;

        [DisplayName("ИД")]
        public int Id_Inventory // id инвентаря 
        {
            get { return Id_Inventory_; }
            set
            {
                Id_Inventory_ = value;
                OnPropertyChanged();
            }
        }
        [DisplayName("Наименование")]
        public string Name_Inventory // наименование инвентаря 
        {
            get { return Name_Inventory_; }
            set
            {
                Name_Inventory_ = value;
                OnPropertyChanged();
            }
        }
        [DisplayName("Количество")]
        public int Count_Inventory // количество инвентаря
        {
            get { return Count_Inventory_; }
            set
            {
                Count_Inventory_ = value;
                OnPropertyChanged();
            }
        }
        [DisplayName("Дата поставки")]
        public DateTime DateDelivery // дата поставки инвентаря
        {
            get { return DateDelivery_; }
            set
            {
                DateDelivery_ = value;
                OnPropertyChanged();
            }
        }
        public Inventory() { }
        public Inventory(int Id)
        {
            Id_Inventory = Id;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //метод клонирования инвентаря
        public Inventory Clone()
        {
            return new Inventory
            {
                Id_Inventory = this.Id_Inventory,
                Name_Inventory = this.Name_Inventory,
                Count_Inventory = this.Count_Inventory,
                DateDelivery = this.DateDelivery
            };
        }
    }
}
