using PetShopLibrary.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PetShopLibrary.EF
{
    public class PetShopManager
    {
        private PetShopContext _context;
        
        
        public PetShopManager()
        {
            _context = new PetShopContext();
        }


        public void Save()
        {
            _context.SaveChanges();
        }

        public void Delete(Customer customer) 
        {
            var foundCustomer = _context.Customers.SingleOrDefault(cust => cust.ID == customer.ID);
            if (foundCustomer is null)
                return;
            foundCustomer.ObjectStatus = Status.Inactive;
        }

        public  void Delete(Employee employee)
        {
            var foundEmployee = _context.Employees.SingleOrDefault(emp => emp.ID == employee.ID);
            if (foundEmployee is null)
                return;
            foundEmployee.ObjectStatus = Status.Inactive;
        }

        public  void Delete(Pet pet)
        {
            var foundPet = _context.Pets.SingleOrDefault(p => p.ID == pet.ID);
            if (foundPet is null)
                return;
            foundPet.ObjectStatus = Status.Inactive;
        }


        public  void Delete(PetFood petFood)
        {
            var foundFood = _context.Customers.SingleOrDefault(food => food.ID == petFood.ID);
            if (foundFood is null)
                return;
            foundFood.ObjectStatus = Status.Inactive;
        }

        public void DeletePetFoodRange(string brand, int qty)
        {
            if(qty == 0) return;

            List<PetFood> petFoods = GetPetFoods().FindAll(x => x.Brand.Equals(brand) && x.ObjectStatus.Equals(Status.Active)).Take(qty).ToList();
            foreach(PetFood food in petFoods)
            {
                Delete(food);
            }
        }


        public List<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        public List<Transaction> GetTransactions()
        {
            return _context.Transactions.ToList();
        }

        public List<Pet> GetPets()
        {
            return _context.Pets.ToList();
        }

        public List<PetFood> GetPetFoods()
        {

            return _context.PetFoods.ToList();
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        public void Add(Customer customer)
        {
            var customerExists = _context.Customers.Where<Customer>(c => c.ID == customer.ID);
            if (customerExists.Any()) return;
            _context.Customers.Add(customer);
        }

        public void Add(Employee employee)
        {
            var employeeExists = _context.Employees.Where<Employee>(e => e.ID == employee.ID);
            if (employeeExists.Any()) return;
            _context.Employees.Add(employee);
        }

        public void Add(Pet pet)
        {
            var petExists = _context.Pets.Where<Pet>(p => p.ID == pet.ID);
            if (petExists.Any()) return;
            _context.Pets.Add(pet);
        }

        public void Add(Transaction transaction)
        {
            var transExists = _context.Transactions.Where<Transaction>(t => t.ID == transaction.ID);
            if (transExists.Any()) return;
            _context.Transactions.Add(transaction);
        }

        public void Add(PetFood petFood)
        {
            var petFoodExists = _context.PetFoods.Where<PetFood>(pf => pf.ID == petFood.ID);
            if (petFoodExists.Any()) return;
            _context.PetFoods.Add(petFood);
        }

        public PetFood? GetFood(AnimalType type, string brand)
        {
            PetFood? food = GetPetFoods().Find(x => x.Brand == brand && GetFoodType(type) == x.Type && x.ObjectStatus == Status.Active);
            return food;
        }

        public List<string> GetAvailableFoodBrands(AnimalType type)
        {
            var brands = GetFoodBrand(type);
            var available = brands.FindAll(x => GetFood(type, x) != null);
            return available;
        }


        public List<string> GetFoodBrand(AnimalType type)
        {
            FoodBrands brand = new FoodBrands();
            if(type == AnimalType.Dog)
            {
                return brand.DogFoodBrands;
            }
            else if(type == AnimalType.Bird)
            {
                return brand.BirdFoodBrands;
            }
            else if(type == AnimalType.Rat)
            {
                return brand.RatFoodBrands;
            }
            else if(type== AnimalType.Fish)
            {
                return brand.FishFoodBrands;
            }
            else if(type == AnimalType.Turtle)
            {
                return brand.TurtleFoodBrands;
            }
            else if(type == AnimalType.Snake)
            {
                return brand.SnakeFoodBrands;
            }
            else if(type == AnimalType.Cat)
            {
                return brand.CatFoodBrands;
            }
            else return null;
        }

        public FoodType GetFoodType(AnimalType type)
        {
            if (type == AnimalType.Dog)
            {
                return FoodType.DogFood;
            }
            else if (type == AnimalType.Bird)
            {
                return FoodType.BirdFood;
            }
            else if (type == AnimalType.Rat)
            {
                return FoodType.RatFood;
            }
            else if (type == AnimalType.Fish)
            {
                return FoodType.FishFood;
            }
            else if (type == AnimalType.Turtle)
            {
                return FoodType.TurtleFood;
            }
            else if (type == AnimalType.Snake)
            {
                return FoodType.SnakeFood;
            }
            else
            {
                return FoodType.CatFood;
            }
            
        }

        public int GetAvailableFoodQty(string brand)
        {
            return GetPetFoods().FindAll(x => x.Brand == brand).Count();
        }

        public decimal GetTotalPrice(Pet pet, int qty)
        {
            return GetFoodPrice(pet) * (qty-1 >= 0 ? qty-1 : 0 ) + pet.Price;
        }
        public decimal GetFoodPrice(Pet pet)
        {
            PetFood? petFood = GetPetFoods().Find(x => x.Type == pet.FoodType);
            if (petFood == null) return 0;

            return petFood.Price;
        }

    }
}
