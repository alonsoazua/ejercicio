using System;
using System.Collections.Generic;
using System.ComponentModel;
using Ejercicio.models;
using Xamarin.Forms;

namespace Ejercicio.viewmodel
{
    public class AddCarViewModel : INotifyPropertyChanged
    {
        public String marca { get; set; }
        public String modelo { get; set; }
        public String anio { get; set; }

		public Command GuardarCarroCommand { get; }
        public event PropertyChangedEventHandler PropertyChanged;

        private List<Car> _cars = new List<Car>();
        public List<Car> cars {
            get { return _cars; }
            set
            {
                _cars = value;
                OnPropertyChanged("cars");
            }
        }

        public AddCarViewModel()
        {
            cars = new List<Car>();

            cars.Add(new Car
            {
                marca = "test",
                modelo = "test",
                anio = "test"
            });

            cars.Add(new Car
            {
                marca = "test",
                modelo = "test",
                anio = "test"
            });

            GuardarCarroCommand = new Command(addCar);


        }

        public void OnPropertyChanged(String name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void addCar()
        {
            cars.Add(new Car
            {
                marca = this.marca,
                modelo = this.modelo,
                anio = this.modelo
            });


        }
    }
}
