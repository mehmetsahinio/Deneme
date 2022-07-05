using System;
namespace SahinBankApp.Business.Abstract
{
	public interface IRepository<T> where T:class
	{
		List<T> GetAll();
		T GetById(int id);
		void Delete(T entity);
		void Update(T entity);
		void Create(T entity);
	}
}

