using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarstwaUslugi;
using Prism.Mvvm;
using System.Windows;
using Prism.Commands;



namespace Zadanie4.ViewModel
{
    class MainViewModel : BindableBase
    {
        // Właściwość DodajOsobę jest odplana poprzez Binding
        private string noweImie;
        public string NoweImie
        {
            get => noweImie;
            set
            {
                noweImie = value;
                RaisePropertyChanged();
                MessageBox.Show(noweImie);

            }
            
        }
    }
}
