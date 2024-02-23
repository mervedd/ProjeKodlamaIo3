using Business.Abstracts;
using DAL.Abstracts;
using DAL.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorRepository _instructorRepository;

        public InstructorManager(IInstructorRepository instructorDal)
        {
            _instructorRepository = instructorDal;
        }
        public void TAdd(Instructor entity)
        {
            _instructorRepository.Add(entity);
        }

        public void TDelete(int id)
        {
            _instructorRepository.Delete(id);
        }

        public List<Instructor> TGetAll()
        {
            return _instructorRepository.GetAll();
        }

        public Instructor TGetById(int id)
        {
            return _instructorRepository.GetById(id);
        }

        public void TUpdate(Instructor entity)
        {
            _instructorRepository.Update(entity);
        }
    }
}
