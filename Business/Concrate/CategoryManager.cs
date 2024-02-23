using Business.Abstracts;
using DAL.Abstracts;
using DAL.Entities.Concrete;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{

    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void TAdd(Category entity)
        {
            _categoryRepository.Add(entity);
        }

        public void TDelete(int id)
        {
            _categoryRepository.Delete(id);
        }

        public List<Category> TGetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category TGetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public void TUpdate(Category entity)
        {
            _categoryRepository.Update(entity);
        }
    }
}

