using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class VetBusiness
    {
        private readonly VetRepository vetRepository;
        public VetBusiness()
        {
            this.vetRepository = new VetRepository();  
        }

        public List<Vet> GetAllVets()
        {
            return this.vetRepository.GetAllVets();
        }
        public bool InsertVets(Vet v)
        {
            if (this.vetRepository.InsertVets(v) > 0)
                return true;
            return false;
        }
        public bool UpdateVets(Vet v)
        {
            if (this.vetRepository.UpdateVets(v) > 0)
                return true;
            return false;
        }
        public bool DeleteVets(Vet v)
        {
            if (this.vetRepository.DeleteVets(v) > 0)
                return true;
            return false;
        }
        public List<Vet> GetVetsWithExperienceGreaterThan(int experienceThreshold)
        {
            // Dohvati sve veterinare
            List<Vet> allVets = this.vetRepository.GetAllVets();

            // Filtriraj veterinare prema iskustvu
            List<Vet> vetsWithMoreExperience = allVets
                .Where(vet => vet.YearsExperience > experienceThreshold)
                .ToList();

            return vetsWithMoreExperience;
        }

        public List<Vet> GetVetsWithExperienceLessThan(int experienceThreshold)
        {
            // Dohvati sve veterinare
            List<Vet> allVets = this.vetRepository.GetAllVets();

            // Filtriraj veterinare prema iskustvu
            List<Vet> vetsWithMoreExperience = allVets
                .Where(vet => vet.YearsExperience < experienceThreshold)
                .ToList();

            return vetsWithMoreExperience;
        }

        public List<Vet> GetVetsWithFullNameLengthGreaterThan(int lengthThreshold)
        {
            // Dohvati sve veterinare
            List<Vet> allVets = this.vetRepository.GetAllVets();

            // Filtriraj veterinare prema dužini FullName-a
            List<Vet> vetsWithLongerFullName = allVets
                .Where(vet => vet.FullName.Length > lengthThreshold)
                .ToList();

            return vetsWithLongerFullName;
        }

        // Random primer za min i max cenu

        /* public List<Restaurant> GetBetweenPrice(decimal min, decimal max)
         {
             return this.restaurantRepository.GetAllRestaurant()
        .Where(r => r.Price > min && r.Price < max)
        .ToList();
         }
        */

        // Random primer za datum koji je manji od zadatog

        /*
         public List<Product> GetProducts()
         {
             return productRepository.GetAllProducts()
        .Where(product => DateTime.Now < product.ExpiryDate)
        .ToList();
         }
        */
    }
}
