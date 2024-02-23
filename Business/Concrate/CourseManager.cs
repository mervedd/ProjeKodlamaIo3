using Business.Abstracts;
using DAL.Abstracts;
using DAL.Entities.Concrete;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICourseRepository = DAL.Abstracts.ICourseRepository;

namespace Business.Services
{
    public class CourseManager : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseManager(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public void TAdd(Course entity)
        {
            _courseRepository.Add(entity);
        }

        public void TDelete(int id)
        {
            _courseRepository.Delete(id);
        }

        public List<Course> TGetAll()
        {
            return _courseRepository.GetAll();
        }

        public Course TGetById(int id)
        {
            return _courseRepository.GetById(id);
        }

        public void TUpdate(Course entity)
        {
            _courseRepository.Update(entity);
        }
    }

}
