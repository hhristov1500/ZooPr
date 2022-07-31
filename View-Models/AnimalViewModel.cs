
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Zoo.Data;
using Zoo.Models;


namespace Zoo.View_Models
{
    public class AnimalViewModel : ViewModelBase
    {
        private ZooDbContext zooDbContext = new ZooDbContext();
        private List<AnimalToDisplay> _animals;
        private List<Category> _categories;
        private Category _sCategory;
        private AnimalToDisplay _sAnimal;
        private ICommand _searchAnimals;
        private  DelegateCommand loginCommand;
        public ICommand SearchAnimals
        {
            get
            {
                return  loginCommand ?? (loginCommand = new DelegateCommand(context =>
                {
                    SearchAnimalAction();
                }));
            }
        }
        

        public void SearchAnimalAction()
        {
            if (SCategory == null)
            {
                Animals = (from Animal in zooDbContext.Animal
                           join Category in zooDbContext.Category on Animal.IdCat equals Category.IdCat
                           select new AnimalToDisplay() { Name = Animal.Name, Description = Animal.Description, Image = Animal.Picture, Category = Category.Name }).ToList();

            }
            else
            {
                Animals = (from Animal in zooDbContext.Animal
                           join Category in zooDbContext.Category on Animal.IdCat equals Category.IdCat
                           where Animal.IdCat == SCategory.IdCat
                           select new AnimalToDisplay() { Name = Animal.Name, Description = Animal.Description, Image = Animal.Picture, Category = Category.Name }).ToList();

            }

        }
        public void FillCombobox()
        {
            Categories = zooDbContext.Category.Select(t => t).ToList();
        }
            //fills in information in the table (Animals) if empty
        public void FillDatabase()
        {
            if (zooDbContext.Animal.ToList().Count == 0)
            {
                Animal animal1 = new Animal("Лъв","Едър мъжки на 10 годишна възраст"
                    ,File.ReadAllBytes("D:/Microinvest/Zoo/Pictures/Lion_waiting_in_Namibia.jpg"),2);
                Animal animal2 = new Animal("Орел", "Едър мъжки на 3 годишна възраст"
                    , File.ReadAllBytes("D:/Microinvest/Zoo/Pictures/Orel.jpg"), 3);
                Animal animal3 = new Animal("Усойница", "Женска на 2 годишна възраст"
                    , File.ReadAllBytes("D:/Microinvest/Zoo/Pictures/Usoinica.jpg"), 1);
                zooDbContext.Animal.Add(animal1);
                zooDbContext.Animal.Add(animal2);
                zooDbContext.Animal.Add(animal3);
                zooDbContext.SaveChanges();
            }
        }
        public AnimalToDisplay SAnimal
        {
            get { return _sAnimal; }
            set { _sAnimal = value;
                OnPropertyChanged("SAnimal");
            }   
        }
        public List<AnimalToDisplay> Animals
        {
            get { return _animals; }
            set { _animals = value;
                OnPropertyChanged("Animals");
            }
        }
        public Category SCategory
        {
            get { return _sCategory; }
            set
            {
                _sCategory = value;
                OnPropertyChanged("SCategory");
            }
        }
        public List<Category> Categories
        {
            get { return _categories; }
            set
            {
                _categories = value;
                OnPropertyChanged("Category");
            }
        }
        public AnimalViewModel()
        {
            FillDatabase();
            FillCombobox();
        }
    }
}
