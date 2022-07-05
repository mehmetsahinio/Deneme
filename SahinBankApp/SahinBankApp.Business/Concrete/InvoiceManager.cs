using System;
using SahinBankApp.Business.Abstract;
using SahinBankApp.Data.Abstract;
using SahinBankApp.Entity;

namespace SahinBankApp.Business.Concrete
{
    public class InvoiceManager : IInvoiceService
    {
        private IInvoiceRepository _invoiceRepository;

        public InvoiceManager(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public void Create(Invoice entity)
        {
            _invoiceRepository.Create(entity);
        }

        public void Delete(Invoice entity)
        {
            _invoiceRepository.Delete(entity);
        }

        public List<Invoice> GetAll()
        {
            return _invoiceRepository.GetAll();
        }

        public Invoice GetById(int id)
        {
            return _invoiceRepository.GetById(id);
        }

        public void Update(Invoice entity)
        {
            _invoiceRepository.Update(entity);
        }
    }
}

