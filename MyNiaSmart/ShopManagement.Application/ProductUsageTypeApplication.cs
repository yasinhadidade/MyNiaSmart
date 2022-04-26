﻿using _0_Framework.Utilities;
using ShopManagement.Application.Contract.ProductUsageType;
using ShopManagement.Domain.ProductUsageTypeAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Application
{
    public class ProductUsageTypeApplication : IProductUsageTypeApplication
    {
        private readonly IProductUsageTypeRepository _productUsageTypeRepository ;

        public ProductUsageTypeApplication(IProductUsageTypeRepository productUsageTypeRepository)
        {
            _productUsageTypeRepository = productUsageTypeRepository;
        }

        public OperationResult Create(CreateProductUsageType command)
        {
            var operation = new OperationResult();
            if (_productUsageTypeRepository.IsExist(x => x.Title == command.Title))
                return operation.Failed(ApplicationMessage.DuplicatedRecord);

            var productUsageType = new ProductUsageType(command.Title);
            _productUsageTypeRepository.Savechange();
            return operation.Succedded();

        }

        public OperationResult Edit(EditProductUsageType command)
        {
            var operation = new OperationResult();
            var productUsageType = _productUsageTypeRepository.GetById(command.Id);
            if (_productUsageTypeRepository.IsExist(x => x.Title == command.Title && x.Id != command.Id))
                return operation.Failed(ApplicationMessage.DuplicatedRecord);

            if (productUsageType == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            productUsageType.Edit(command.Title);
            _productUsageTypeRepository.Savechange();
            return operation.Succedded();
        }

        public EditProductUsageType GetDetails(int id)
        {
            return _productUsageTypeRepository.GetDetails(id);
        }

        public List<ProductUsageTypeViewModel> GetList()
        {
            return _productUsageTypeRepository.GetList();
        }
    }
}
