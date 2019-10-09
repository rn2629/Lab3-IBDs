using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Lab3.Command;
using Lab3.Model;
using Lab3.View;

namespace Lab3.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        private Produit produit;
       


        public ICommand OpenWindowCommand
        {
            get;
            private set;
        }

        public bool CanUpdate
        {
            get
            {
                if (produit == null)
                    return false;
                else
                    return true;
            }            
        }

      

        public MainViewModel()
        {
            OpenWindowCommand = new OpenCommand(this);
            Produit = new Produit();        
        }

        public Produit Produit { get => produit; set => produit = value; }
      

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void SaveChanges()
        {
            Window fenetre2 = new ProductWindow();
            fenetre2.Show();
            fenetre2.DataContext = this;
        }
    }
}
