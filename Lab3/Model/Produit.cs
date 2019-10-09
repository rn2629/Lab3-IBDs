using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model
{
    class Produit : INotifyPropertyChanged
    {

        private string nom;
        private double prix;
        private double imageWidth;
        private double imageHeigth;
        private string couleur;
        private string imageSource;

        public Produit()
        {
            this.Nom = "";
            this.Prix = 0.00;
            this.ImageHeigth = 100.0;
            this.ImageWidth = 200.0;
            this.Couleur = "White";
            this.ImageSource = "pack://application:,,,/Image/Choco.jpg";
        }

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; OnPropertyChanged("Nom"); }
        }
        public double Prix
        {
            get { return this.prix; }
            set { this.prix = value; OnPropertyChanged(nameof(Prix)); }
        }
        public double ImageWidth
        {
            get { return this.imageWidth; }
            set { this.imageWidth = value; OnPropertyChanged(nameof(ImageWidth)); }
        }
        public double ImageHeigth
        {
            get { return imageHeigth; }
            set {imageHeigth = value; OnPropertyChanged(nameof(ImageHeigth)); }
        }
        public string Couleur
        {
            get { return couleur; }
            set { couleur = value; OnPropertyChanged(couleur); }
        }

        public string ImageSource
        {
            get { return imageSource; }
            set { imageSource = value; OnPropertyChanged(ImageSource); }
        }


        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
